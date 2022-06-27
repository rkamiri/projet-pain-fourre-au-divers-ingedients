public class OrderParsingAttempt{
    public bool isValid { get; }
    public Order? order { get; }
    public string error { get; }
    public OrderParsingAttempt(bool isValid,Order? order,string error){
        this.isValid = isValid;
        this.order = order;
        this.error = error;
    }

    public override bool Equals(Object obj)
   {
      //Check for null and compare run-time types.
      if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
      {
         return false;
      }
      else {
         OrderParsingAttempt test = (OrderParsingAttempt) obj;
         return (isValid == test.isValid) && (order == test.order) && (error == test.error);
      }
   }
}