public class Invoice {
    public string invoice { get; set; }

    private Invoice(){}
    private Invoice(string invoice){
        this.invoice = invoice;
    }

    public static Invoice of(string invoice){
        return new Invoice(invoice);
    }
}
