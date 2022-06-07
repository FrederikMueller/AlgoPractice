namespace Design_Patterns_Practice_2022.Creational;

public class GermanShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountNewService CreateDiscountService() => new GermanDiscountService();
    public IShippingCostsService CreateShippingCostsService() => new GermanShippingCostService();
}
public class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
{
    public IDiscountNewService CreateDiscountService() => new BelgiumDiscountService();
    public IShippingCostsService CreateShippingCostsService() => new BelgiumShippingCostService();
}
public interface IShoppingCartPurchaseFactory
{
    IDiscountNewService CreateDiscountService();
    IShippingCostsService CreateShippingCostsService();
}

public interface IShippingCostsService
{
    decimal ShippingCosts { get; }
}
public interface IDiscountNewService
{
    int DiscountPercentage { get; }
}

public class BelgiumDiscountService : IDiscountNewService
{
    public int DiscountPercentage => 25;
}
public class GermanDiscountService : IDiscountNewService
{
    public int DiscountPercentage => 35;
}

public class BelgiumShippingCostService : IShippingCostsService
{
    public decimal ShippingCosts => 3.40m;
}
public class GermanShippingCostService : IShippingCostsService
{
    public decimal ShippingCosts => 1.40m;
}

public class ShoppingCart
{
    private readonly IDiscountNewService discountService;
    private readonly IShippingCostsService shippingCostsService;
    private int orderCosts;

    public ShoppingCart(IShoppingCartPurchaseFactory factory)
    {
        shippingCostsService = factory.CreateShippingCostsService();
        discountService = factory.CreateDiscountService();
        orderCosts = 200;
    }

    public void CalculateCosts()
    {
        var postDiscountPrice = orderCosts * (100 - discountService.DiscountPercentage) / 100;

        Console.WriteLine($"Total costs are {postDiscountPrice + shippingCostsService.ShippingCosts}. Base price was {orderCosts}. A {discountService.DiscountPercentage}% discount was applied. {shippingCostsService.ShippingCosts}$ shipping.");
    }
}