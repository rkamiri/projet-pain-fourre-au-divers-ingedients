public class OrderParsingAttempt{
    public bool isValid { get; }
    public Order? order { get; }
    public string error { get; }
    public OrderParsingAttempt(bool isValid,Order? order,string error){
        this.isValid = isValid;
        this.order = order;
        this.error = error;
    }
}