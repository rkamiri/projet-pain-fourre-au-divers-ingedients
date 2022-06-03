public static class AvailableSandwiches {

public static Sandwich JambonBeurre = new Sandwich(
    "Jambon beurre",
    new IngredientPortion[] {
        new IngredientPortion(availableIngredients.Pain,1),
        new IngredientPortion(availableIngredients.Tranche_de_jambon,1),
        new IngredientPortion(availableIngredients.Beurre,10)
    }
    , 
    3.50
);
public static Sandwich PouletCrudites = new Sandwich(
    "Poulet crudités",
    new IngredientPortion[] {
        new IngredientPortion(availableIngredients.Pain,1),
        new IngredientPortion(availableIngredients.Oeuf,1),
        new IngredientPortion(availableIngredients.Tomate,0.5),
        new IngredientPortion(availableIngredients.Tranche_de_poulet,1),
        new IngredientPortion(availableIngredients.Mayonnaise,10),
        new IngredientPortion(availableIngredients.Salade,10)
    }
    ,
    5.00
);
public static Sandwich Dieppois = new Sandwich(
    "Dieppois",
    new IngredientPortion[] {
        new IngredientPortion(availableIngredients.Pain,1),
        new IngredientPortion(availableIngredients.Thon,50),
        new IngredientPortion(availableIngredients.Tomate,0.5),
        new IngredientPortion(availableIngredients.Mayonnaise,10),
        new IngredientPortion(availableIngredients.Salade,10)
    }
    ,
    4.50
);
public static Dictionary<string, Sandwich> sandwiches = new Dictionary<string, Sandwich>(){
    {"JambonBeurre", JambonBeurre},
    {"PouletCrudites", PouletCrudites},
    {"Dieppois", Dieppois}
};

}