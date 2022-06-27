public class OrderInterpretor{
    public OrderParsingAttempt parseTextualOrder(string? textualOrder){
        Dictionary<string, int> sandwichesOrdered = AvailableSandwiches.sandwiches.Keys.ToDictionary(keySelector: m => m, elementSelector: m => 0);

        if(textualOrder == null){
            return new OrderParsingAttempt(false,null,"Your order cannot be null");
        }

        string[] commandElements = textualOrder.Split(",");
        foreach (var item in commandElements){
            string[] splitedOrderSandwich = this.filterSpace(item.Split(" "));

            int amount = 0;
            string sandwichId = "";
            try{
                amount = int.Parse(splitedOrderSandwich[0]);
                sandwichId = splitedOrderSandwich[1];
            } 
            catch (ArgumentNullException)
            {
                return new OrderParsingAttempt(false,null,"Ordered quantity not found !");
            }
            catch(FormatException){
                return new OrderParsingAttempt(false,null,splitedOrderSandwich[0] + " is not a valid number !");
            }
            catch(OverflowException){
                return new OrderParsingAttempt(false,null,"An overflow occured !");
            }
            catch(IndexOutOfRangeException){
                return new OrderParsingAttempt(false,null,item + " is not a valid format !");
            }
            if(sandwichesOrdered.ContainsKey(sandwichId)){
                sandwichesOrdered[sandwichId] += amount;
            }else{
                return new OrderParsingAttempt(false,null,"Sandwich Id not found !");
            }
        }
        Dictionary<string, int> filtered = sandwichesOrdered.Where(d => d.Value > 0).ToDictionary(x => x.Key, x => x.Value);
        return new OrderParsingAttempt(true,new Order(filtered),"");
    }
    private string[] filterSpace(string[] array){
        return array.Where(c => (c != " " && c != "")).ToArray();
    }
}