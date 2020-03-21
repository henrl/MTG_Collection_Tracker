CREATE TABLE Card (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	oracle_id nvarchar(255),
	name nvarchar(255),
	lang nvarchar(50),
	uri nvarchar(255),
	scryfall_uri nvarchar(255),
	mana_cost nvarchar(255),
	cmc decimal(10,2) not null,
	type_line nvarchar(255),
	oracle_text nvarchar(4000),
	colors nvarchar(MAX),
	color_identity nvarchar(MAX),
	set_name nvarchar(255),
	power nvarchar(50),
	toughness nvarchar(50),
	flavor_text nvarchar(4000),
	commanderlegal bit not null
);
