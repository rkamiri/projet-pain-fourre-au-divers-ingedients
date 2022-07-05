public class Sandwich{
    public string name { get; }
    public IngredientPortion[] ingredientsPortions { get; }
    public double price { get; }
    private Sandwich(string name, IngredientPortion[] ingredientsPortions,double price){
        this.name = name;
        this.ingredientsPortions = ingredientsPortions;
        this.price = price;
    }

    public static Sandwich of(string name, IngredientPortion[] ingredientsPortions,double price){
        return new Sandwich(name, ingredientsPortions, price);
    }
}