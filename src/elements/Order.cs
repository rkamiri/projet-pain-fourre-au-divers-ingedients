public class Order{
    public Dictionary<string, int> orderedSandwiches { get; }
    public Order(Dictionary<string, int> orderedSandwiches){
        this.orderedSandwiches = orderedSandwiches;
    }
}