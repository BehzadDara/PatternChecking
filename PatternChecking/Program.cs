using PatternChecking;

var testCases = new List<Order>
{
    new Order
    {
        Customer = new Customer
        {
            Name = "x1",
            IsPremium = true,
            Age = 18
        },
        TotalCost = 50
    },
    new Order
    {
        Customer = new Customer
        {
            Name = "x2",
            IsPremium = true,
            Age = 18
        },
        TotalCost = 150
    },
    new Order
    {
        Customer = new Customer
        {
            Name = "x3",
            IsPremium = true,
            Age = 22
        },
        TotalCost = 50
    },
    new Order
    {
        Customer = new Customer
        {
            Name = "x4",
            IsPremium = true,
            Age = 22
        },
        TotalCost = 150
    },
    new Order
    {
        Customer = new Customer
        {
            Name = "x5",
            IsPremium = false,
            Age = 18
        },
        TotalCost = 50
    },
    new Order
    {
        Customer = new Customer
        {
            Name = "x6",
            IsPremium = false,
            Age = 18
        },
        TotalCost = 150
    },
    new Order
    {
        Customer = new Customer
        {
            Name = "x7",
            IsPremium = false,
            Age = 22
        },
        TotalCost = 50
    },
    new Order
    {
        Customer = new Customer
        {
            Name = "x8",
            IsPremium = false,
            Age = 22
        },
        TotalCost = 150
    },
};

foreach (var testCase in testCases)
{
    Console.Write($"IsPremium: {testCase.Customer.IsPremium}, Age: {testCase.Customer.Age}, TotalCost: {testCase.TotalCost}, ");
    var tax1 = testCase.Tax1();
    var tax2 = testCase.Tax2();
    if (tax1 == tax2)
    {
        Console.WriteLine($"tax: {tax1}");
    }
    else
    {
        Console.WriteLine($"tax1: {tax1}, tax2 is {tax2}");
    }
}