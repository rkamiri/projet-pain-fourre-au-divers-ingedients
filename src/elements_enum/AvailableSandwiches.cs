public static class AvailableSandwiches {

public static Sandwich JambonBeurre = Sandwich.of(
    "Jambon beurre",
    new IngredientPortion[] {
        IngredientPortionBuilder.of(availableIngredients.Pain).Build(),
        IngredientPortionBuilder.of(availableIngredients.Tranche_de_jambon).Build(),
        IngredientPortionBuilder.of(availableIngredients.Beurre).WithQuantity(10).Build()
    }
    , 
    3.50
);
public static Sandwich PouletCrudites = Sandwich.of(
    "Poulet crudités",
    new IngredientPortion[] {
        IngredientPortionBuilder.of(availableIngredients.Pain).Build(),
        IngredientPortionBuilder.of(availableIngredients.Oeuf).Build(),
        IngredientPortionBuilder.of(availableIngredients.Tomate).WithQuantity(0.5).Build(),
        IngredientPortionBuilder.of(availableIngredients.Tranche_de_poulet).Build(),
        IngredientPortionBuilder.of(availableIngredients.Mayonnaise).WithQuantity(10).Build(),
        IngredientPortionBuilder.of(availableIngredients.Salade).WithQuantity(10).Build()
    }
    ,
    5.00
);
public static Sandwich Dieppois = Sandwich.of(
    "Dieppois",
    new IngredientPortion[] {
        IngredientPortionBuilder.of(availableIngredients.Pain).Build(),
        IngredientPortionBuilder.of(availableIngredients.Thon).WithQuantity(50).Build(),
        IngredientPortionBuilder.of(availableIngredients.Tomate).WithQuantity(0.5).Build(),
        IngredientPortionBuilder.of(availableIngredients.Mayonnaise).WithQuantity(10).Build(),
        IngredientPortionBuilder.of(availableIngredients.Salade).WithQuantity(10).Build()
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