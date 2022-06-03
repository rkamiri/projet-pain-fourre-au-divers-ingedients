public class Sandwich{
    public string name { get; }
    public IngredientPortion[] ingredientsPortions { get; }
    public double price { get; }
    public Sandwich(string name, IngredientPortion[] ingredientsPortions,double price){
        this.name = name;
        this.ingredientsPortions = ingredientsPortions;
        this.price = price;
    }
}