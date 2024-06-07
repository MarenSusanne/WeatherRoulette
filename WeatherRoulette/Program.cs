using WeatherRoulette;
Game game = new Game();
Weather weather = new Weather();
Outfit outfit = new Outfit();

/*Denne appen skal være et slags spill hvor man skal “gjette” hva slags klær som matcher til hva slags vær.
Konsollen skal vise en tilfeldig værtype (eksempelvis sterk sol, regnvær, snøstorm) og gi spilleren et valg mellom 3 outfits. 
En av disse stemmer til værtypen, de andre to ikke. Spilleren skal få feedback på om valget var riktig eller ikke
Eks: “Dagens vær: Sterk sol”  Valg options: Shorts og T skjorte gir feedbacken “Deilig vær med korte klær!”  
Vinterjakke og skibukse gir feedbacken “Oi, dette ble for varmt - jeg tror jeg kovner!” og valget Regnjakke og 
sydvest kan f.eks gi feedbacken “Dette ble…klamt. Skulle valgt en annen outfit”
 
Game - 
Weather - Sun, Rain, Snow
Outfit - 
 */

game.runGame();