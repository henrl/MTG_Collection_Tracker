# Glee_Max Collection Database
A little side project I did to keep track of cards in my MTG collection.

## Backstory
One day, I was casually sorting through my collection, looking for yet another cardboard box to store the cards gradually filling up my room (yes, I may have a problem). Then it hit me: I have a lot of useless cardboard in my room, and I should probably get rid of some of it. But to do this, I needed a way to keep track of which cards I have in my collection and also to easily update my records if I have traded stuff away.

Enter Glee_Max. It's basically just another CRUD app, but it will be useful for keeping track of my collection, as well as showing interviewers that I can code (if that means you, hi :) ).

## How to set up your database locally
1. Go to https://scryfall.com/docs/api/bulk-data, and download the Default Cards JSON. This contains the name of every MTG card ever printed.
2. Make a new database in SQL Server Management Studio.
3. Run the R script (script.R) to clean up the Scryfall Default Cards JSON data (you won't need most of the columns).
4. Run the SQL migration scripts in ascending numeric order.

## How to set up the CRUD app
coming soon...