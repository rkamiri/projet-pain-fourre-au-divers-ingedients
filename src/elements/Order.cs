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
         return (orderedSandwiches.Count() == test.orderedSandwiches.Count() && !orderedSandwiches.Except(test.orderedSandwiches).Any());
      }
   }

    public override int GetHashCode()
    {
        return HashCode.Combine(orderedSandwiches);
    }
}