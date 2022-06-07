using Design_Patterns_Practice_2022.Creational;

Singleton.Instance.Log("Hallo");
Console.WriteLine();

var factories = new List<DiscountFactory>
{
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("br"),
    new FlatDiscountFactory(50)
};

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine($"A discount of {discountService.DiscountPercentage} from {discountService.ToString()} has been applied.");
}
Console.WriteLine();

var cart = new ShoppingCart(new GermanShoppingCartPurchaseFactory());
var cart2 = new ShoppingCart(new BelgiumShoppingCartPurchaseFactory());
cart.CalculateCosts();
cart2.CalculateCosts();

Console.WriteLine();

var director = new Garage();
var bmwBuilder = new BMWBuilder();
var miniBuilder = new MiniBuilder();

director.Construct(bmwBuilder);
director.Show();
director.Construct(miniBuilder);
director.Show();

Console.WriteLine();

var manager = new Manager("Fmax");

var managerClone = (Manager)manager.Clone();

managerClone.Name = "fmax2";

Console.WriteLine($"{managerClone.Name} and the real {manager.Name}");

Console.ReadLine();