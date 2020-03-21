INSERT INTO Card(oracle_id,
                     name,
                     lang,
                     uri,
                     scryfall_uri,
                     mana_cost,
                     cmc,
                     type_line,
                     oracle_text,
                     colors,
                     color_identity,
                     set_name,
                     power,
                     toughness,
                     flavor_text,
                     commanderlegal)
SELECT Cards.*
from OPENROWSET (BULK 'D:\Personal\MTG\mtg.json', SINGLE_CLOB) as j
CROSS APPLY OPENJSON(BulkColumn)
WITH (
	oracle_id nvarchar(255),
	name nvarchar(255),
	lang nvarchar(50),
	uri nvarchar(255),
	scryfall_uri nvarchar(255),
	mana_cost nvarchar(255),
	cmc decimal(10,2),
	type_line nvarchar(255),
	oracle_text nvarchar(4000),
	colors nvarchar(MAX) as JSON,
	color_identity nvarchar(MAX) as JSON,
	set_name nvarchar(255),
	power nvarchar(50),
	toughness nvarchar(50),
	flavor_text nvarchar(4000),
	commanderlegal bit) as Cards;

