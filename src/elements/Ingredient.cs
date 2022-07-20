public class Ingredient{
    public String name { get; }
    public Unity unity { get; }
    private Ingredient(String name,Unity unity){
        this.name = name;
        this.unity = unity;
    }
    public static Ingredient of(String name,Unity unity){
        return new Ingredient(name, unity);
    }
}

public class IngredientBuilder{
    private String name;
    private Unity unity = AvailableUnity.Piece;
    private IngredientBuilder(String name){
        this.name = name;
    }
    public IngredientBuilder WithUnity(Unity unity){
        this.unity = unity;
        return this;
    }
    public Ingredient Build(){
        return Ingredient.of(this.name,this.unity);
    }
    public static IngredientBuilder of(String name){
        return new IngredientBuilder(name);
    }
}