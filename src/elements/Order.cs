public class Order{
    public Dictionary<string, int> orderedSandwiches { get; }
    public Order(Dictionary<string, int> orderedSandwiches){
        this.orderedSandwiches = orderedSandwiches;
    }

    public override bool Equals(Object obj)
   {
      //Check for null and compare run-time types.
      if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
      {
         return false;
      }
      else {
         Order test = (Order) obj;
         return (orderedSandwiches == test.orderedSandwiches);
      }
   }

    public override string ToString()
    {
        return String.Format(" sandwich : "+this.orderedSandwiches.TryGetValue);
    }
}