public static class AvailableSandwiches {

public static Sandwich JambonBeurre = Sandwich.of(
    "Jambon beurre",
    new IngredientPortion[] {
        IngredientPortion.of(availableIngredients.Pain,1),
        IngredientPortion.of(availableIngredients.Tranche_de_jambon,1),
        IngredientPortion.of(availableIngredients.Beurre,10)
    }
    , 
    3.50
);
public static Sandwich PouletCrudites = Sandwich.of(
    "Poulet crudités",
    new IngredientPortion[] {
        IngredientPortion.of(availableIngredients.Pain,1),
        IngredientPortion.of(availableIngredients.Oeuf,1),
        IngredientPortion.of(availableIngredients.Tomate,0.5),
        IngredientPortion.of(availableIngredients.Tranche_de_poulet,1),
        IngredientPortion.of(availableIngredients.Mayonnaise,10),
        IngredientPortion.of(availableIngredients.Salade,10)
    }
    ,
    5.00
);
public static Sandwich Dieppois = Sandwich.of(
    "Dieppois",
    new IngredientPortion[] {
        IngredientPortion.of(availableIngredients.Pain,1),
        IngredientPortion.of(availableIngredients.Thon,50),
        IngredientPortion.of(availableIngredients.Tomate,0.5),
        IngredientPortion.of(availableIngredients.Mayonnaise,10),
        IngredientPortion.of(availableIngredients.Salade,10)
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