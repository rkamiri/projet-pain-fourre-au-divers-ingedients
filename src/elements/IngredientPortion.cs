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

public class IngredientPortionBuilder{
    private Ingredient ingredient;
    private double quantity = 1;
    private IngredientPortionBuilder(Ingredient ingredient){
        this.ingredient = ingredient;
    }
    public IngredientPortionBuilder WithQuantity(double quantity){
        this.quantity = quantity;
        return this;
    }
    public IngredientPortion Build(){
        return IngredientPortion.of(this.ingredient,this.quantity);
    }
    public static IngredientPortionBuilder of(Ingredient ingredient){
        return new IngredientPortionBuilder(ingredient);
    }
}