public class IngredientPortion{
    public Ingredient ingredient { get; }
    public double quantity { get; }
    private IngredientPortion(Ingredient ingredient,double quantity){
        this.ingredient = ingredient;
        this.quantity = quantity;
    }

    public static IngredientPortion of(Ingredient ingredient,double quantity){
        return new IngredientPortion(ingredient, quantity);
    }
}