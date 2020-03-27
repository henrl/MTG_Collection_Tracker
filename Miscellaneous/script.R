library(jsonlite)

isCommanderLegal <- function(str) {
  if (str == "legal") {
    return(TRUE)
  }
  return(FALSE)
}

mtg_data <- fromJSON("scryfall-default-cards.json")

mtg_flat <- flatten(mtg_data)
colnames(mtg_flat)

headings <- c("oracle_id",
              "name",
              "lang",
              "uri",
              "scryfall_uri",
              "mana_cost",
              "cmc",
              "type_line",
              "oracle_text",
              "colors",
              "color_identity",
              "set_name",
              "power",
              "toughness",
              "flavor_text",
              "legalities.commander")
cards <- mtg_flat[,headings]
cards[,"commanderlegal"] <- sapply(cards$legalities.commander, isCommanderLegal)

filter_headings <- c("oracle_id",
                     "name",
                     "lang",
                     "uri",
                     "scryfall_uri",
                     "mana_cost",
                     "cmc",
                     "type_line",
                     "oracle_text",
                     "colors",
                     "color_identity",
                     "set_name",
                     "power",
                     "toughness",
                     "flavor_text",
                     "commanderlegal")
write_json(cards[,filter_headings], "mtg.json")
