using Xunit;
public class OrderingMachine{
    private USerInterface userInterface;
    private OrderInterpretor orderInterpretor;
    public OrderingMachine(){
        this.userInterface = new USerInterface();
        this.orderInterpretor = new OrderInterpretor();
    }
    private string? askUserCommand(){
        this.userInterface.printTextToUser("Please make your choice !\n");
        return this.userInterface.askUser();
    }
    private void printTextToUser(string response){
        this.userInterface.printTextToUser(response);
    }
    private OrderParsingAttempt parseTextualOrder(string? command){
        return this.orderInterpretor.parseTextualOrder(command);
    }
    // [Fact]
    public void startOrderingMachinService(){
        string response = "";
        this.printStartingMessage();
        do {
            string? command = this.askUserCommand();
            OrderParsingAttempt parsedOrder = this.parseTextualOrder(command);
            if(parsedOrder.isValid){
                Order? order = parsedOrder.order;
                if (order is Order valueOforder){
                    InvoiceGenerator invoiceGenerator = InvoiceGenerator.of();
                    Invoice invoice = invoiceGenerator.withOrder(valueOforder).build();
                    response = invoice.invoice;
                }
            }else {
               response = parsedOrder.error;
            }
            this.printTextToUser(response);
        } while(true);
    }
    private void printStartingMessage(){
        this.printTextToUser(
            "Salut !\n" +
            "Choisit tes sandwiches parmis ceux proposer dans la liste qui va suivre.\n" +
            "La syntax pour commander est:\n" +
            "-> pour un type de sandwich : 'nbSandwich IdSandwich' ex: '2 JambonBeurre'\n" +
            "-> pour plusieurs type de sandwich: 'nbSandwich1 IdSandwich1, nbSandwich2 IdSandwich2, etc...' ex: '5 JambonBeurre, 2 Dieppois'\n"
            );
        this.printTextToUser(this.getAvailableSandwichesList());
    }
    private string getAvailableSandwichesList(){
        string sandwichList = "";
        foreach (var sandwich in AvailableSandwiches.sandwiches){
          sandwichList += "Id: " + sandwich.Key + " <- Sandwich" + sandwich.Value.name + "\n";
        }
        return sandwichList;
    }



     [Fact]
       public void sandwiches_list_should_be_available_test()
       {
           
           String sandwichesRequested = "Id: JambonBeurre <- SandwichJambon beurre\n"+
                        "Id: PouletCrudites <- SandwichPoulet crudités\n"+
                        "Id: Dieppois <- SandwichDieppois\n";
           String sandwichList = getAvailableSandwichesList();

        // Here is all the sandwiches that our store is selling.
           Assert.Equal(sandwichesRequested, sandwichList);
       }

    [Fact]
       public void sandwiches_list_should_not_be_available_test()
       {
           String sandwichesRequested = "Id: JambonBeurre <- SandwichJambon beurre\n"+
                        "Id: PouletCrudites <- SandwichPoulet crudités\n"+
                        "Id: Dieppois <- SandwichDieppois\n"+
                        "Id: Montagnard <- SandwichMontagnard\n";
           String sandwichList = getAvailableSandwichesList();

        // Our store doesn't sell Montagnard Sandwich
           Assert.NotEqual(sandwichesRequested, sandwichList);
       }
    
    [Fact]
       public void Parse_textual_null_order()
       {
        OrderParsingAttempt parsedOrderRequested = new OrderParsingAttempt(false,null," is not a valid format !");
        OrderParsingAttempt parsedOrder = this.parseTextualOrder("");
        Assert.Equal(parsedOrderRequested,parsedOrder);  
       }

           [Fact]
       public void Parse_textual_order_for_jambonBeurre_sandwich()
       {
        Dictionary<string,int> dict = new Dictionary<string,int>();
        dict.Add("JambonBeurre",1);
        Order orderRequested = new Order(dict);
        OrderParsingAttempt parsedOrderRequested = new OrderParsingAttempt(true,orderRequested,"");
        OrderParsingAttempt parsedOrder = this.parseTextualOrder("1 JambonBeurre");
        
        Assert.Equal(parsedOrderRequested,parsedOrder);  
       }

           [Fact]
       public void Parse_textual_order_fail_for_sandwich_without_quantity()
       {
        Dictionary<string,int> dict = new Dictionary<string,int>();
        dict.Add("JambonBeurre",1);
        Order orderRequested = new Order(dict);
        OrderParsingAttempt parsedOrderRequested = new OrderParsingAttempt(true,orderRequested,"");
        OrderParsingAttempt parsedOrder = this.parseTextualOrder("JambonBeurre");
        
        Assert.NotEqual(parsedOrderRequested,parsedOrder);  
       }

    //    [Fact]
    //    public void Q02_Creer_une_classe_Car_heritant_de_Vehicle()
    //    {
    //        Car car = new Car();

    //        Assert.True(car is Vehicle);
    //    }
    
    //    [Fact]
    //    public void Q03_Verifier_la_valeur_du_champs_Type_d_un_objet_Car()
    //    {
    //        Vehicle car = new Car();

    //        Assert.Equal("Car", car.Type);
    //    }
}