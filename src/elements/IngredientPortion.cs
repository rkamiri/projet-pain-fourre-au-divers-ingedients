public class IngredientPortion{
    public Ingredient ingredient { get; }
    public double quantity { get; }
    public IngredientPortion(Ingredient ingredient,double quantity){
        this.ingredient = ingredient;
        this.quantity = quantity;
    }
}