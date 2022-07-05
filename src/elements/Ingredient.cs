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