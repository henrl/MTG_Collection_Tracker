# Glee_Max Collection Database
A little side project I did to keep track of cards in my MTG collection.

## How to set up your database locally
1. Go to https://scryfall.com/docs/api/bulk-data, and download the Default Cards JSON. This contains the name of every MTG card ever printed.
2. Make a new database in SQL Server Management Studio.
3. Run the R script (script.R) to clean up the Scryfall Default Cards JSON data (you won't need most of the columns).
4. In .NET Core CLI, type `dotnet ef database update` to run the code-first migrations.

## How to set up the CRUD app
1. Navigate to the Glee_Max.Web folder.
2. Run `dotnet watch run`.

## How to set up the Vue app
1. Navigate to the Glee_Max.Client folder, then the client folder.
2. Run `npm run serve`.

## How to periodically update the data
coming soon...