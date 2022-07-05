public class Unity{
    public string unity { get; }
    private Unity(string unity){
        this.unity = unity;
    }

    public static Unity of(string unity){
        return new Unity(unity);
    }
}