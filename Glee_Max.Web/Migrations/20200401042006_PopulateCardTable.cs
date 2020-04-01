using Microsoft.EntityFrameworkCore.Migrations;

namespace Glee_Max.Migrations
{
    public partial class PopulateCardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // TODO: figure out a way to not hardcode the file path
            // Replace this file path with the location of the JSON file generated from script.R
            var filePath = "D:\\Personal\\MTG\\mtg.json";
            var sqlQuery = "INSERT INTO Cards" +
                "(OracleId," +
                "Name," +
                "Language," +
                "Uri," +
                "ScryfallUri," +
                "ManaCost," +
                "Cmc," +
                "TypeLine," +
                "OracleText," +
                "Colors," +
                "ColorIdentity," +
                "SetName," +
                "Power," +
                "Toughness," +
                "FlavorText," +
                "CommanderLegal)" +
                " " +
                "SELECT oracle_id,name,lang,uri,scryfall_uri,mana_cost,cmc,type_line,oracle_text,colors,color_identity,set_name,power,toughness,flavor_text,commanderlegal" +
                " " +
                $"FROM OPENROWSET (BULK '{filePath}', SINGLE_CLOB) as j" +
                " " +
                "CROSS APPLY OPENJSON (BulkColumn)"+
                " " +
                "WITH (" +
                "oracle_id nvarchar(255),"+
                "name nvarchar(255),"+
                "lang nvarchar(50),"+
                "uri nvarchar(255),"+
                "scryfall_uri nvarchar(255),"+
                "mana_cost nvarchar(255),"+
                "cmc decimal(10, 2),"+
                "type_line nvarchar(255),"+
                "oracle_text nvarchar(400),"+
                "colors nvarchar(MAX) as JSON,"+
                "color_identity nvarchar(MAX) as JSON,"+
                "set_name nvarchar(255),"+
                "power nvarchar(50),"+
                "toughness nvarchar(50),"+
                "flavor_text nvarchar(4000),"+
                "commanderlegal bit)";

            migrationBuilder.Sql(sqlQuery);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE from Cards", true);
        }
    }
}
