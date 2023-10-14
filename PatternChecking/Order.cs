namespace PatternChecking
{
    public class Order
    {
        public Customer Customer { get; set; } = new Customer();
        public decimal TotalCost { get; set; }

        public decimal Tax1()
        {
            if (Customer.IsPremium && Customer.Age < 20)
            {
                if (TotalCost < 100)
                    return 0;
                else
                    return 5;
            }
            else if (Customer.IsPremium)
            {
                if (TotalCost < 100)
                    return 10;
                else
                    return 15;
            }
            else if (Customer.Age < 20)
            {
                if (TotalCost < 100)
                    return 20;
                else
                    return 25;
            }
            else
            {
                if (TotalCost > 100)
                    return 30;
                else
                    return 35;
            }
        }

        public decimal Tax2() => this switch
        {
            { Customer: { IsPremium: true, Age: < 20 }, TotalCost: var cost } when cost < 100 => 0 ,
            { Customer: { IsPremium: true, Age: < 20 } } => 5 ,
            { Customer.IsPremium: true, TotalCost: var cost } when cost < 100 => 10,
            { Customer.IsPremium: true } => 15,
            { Customer.Age: < 20, TotalCost: var cost } when cost < 100 => 20,
            { Customer.Age: < 20 } => 25,
            { TotalCost: > 100 } => 30,
            _ => 35
        };

    }

    public class Customer
    {
        public string Name { get; set; } = string.Empty;
        public bool IsPremium { get; set; }
        public int Age { get; set; }
    }
}
