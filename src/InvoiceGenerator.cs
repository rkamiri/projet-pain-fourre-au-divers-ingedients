public class InvoiceGenerator{

    private Order Order { get; set; }

    private string generateStringifiedFacture(Order order){
        string stringifiedInvoice = "";
        double price = 0.0;
        foreach(var sandwich in order.orderedSandwiches)
        {
            Sandwich sandwichData = AvailableSandwiches.sandwiches[sandwich.Key];
            price += (sandwichData.price * sandwich.Value);
            stringifiedInvoice += "X" + sandwich.Value + " " + sandwichData.name+ "\n";
            IngredientPortion[] IngredientPortion = sandwichData.ingredientsPortions;
            foreach(var ingredient in IngredientPortion){
                stringifiedInvoice += "     " + getIngredientInvoiceRow(ingredient) + "\n"; 
            }
            stringifiedInvoice += "\n";
        }
        stringifiedInvoice += "\n";
        stringifiedInvoice += "Prix total : " + price + "€";
        return stringifiedInvoice;
    }

    public InvoiceGenerator withOrder(Order order){
        this.Order = order;
        return this;
    }

    public Invoice build(){
        return Invoice.of(this.generateStringifiedFacture(this.Order));
    }

    private string getIngredientInvoiceRow(IngredientPortion ingredientPortion){
        return ingredientPortion.ingredient.name + " : " + ingredientPortion.quantity + " " + ingredientPortion.ingredient.unity.unity;
    }

    public static InvoiceGenerator of(){
        return new InvoiceGenerator();
    }
}