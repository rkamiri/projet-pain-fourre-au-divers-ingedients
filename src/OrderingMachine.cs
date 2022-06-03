public class OrderingMachine{
    private USerInterface userInterface;
    private OrderInterpretor orderInterpretor;
    private InvoiceGenerator invoiceGenerator;
    public OrderingMachine(){
        this.userInterface = new USerInterface();
        this.orderInterpretor = new OrderInterpretor();
        this.invoiceGenerator = new InvoiceGenerator();
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
    public void startOrderingMachinService(){
        string response = "";
        this.printStartingMessage();
        do {
            string? command = this.askUserCommand();
            OrderParsingAttempt parsedOrder = this.parseTextualOrder(command);
            if(parsedOrder.isValid){
                Order? order = parsedOrder.order;
                if (order is Order valueOforder){
                    response = this.invoiceGenerator.generateStringifiedFacture(valueOforder);
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
}