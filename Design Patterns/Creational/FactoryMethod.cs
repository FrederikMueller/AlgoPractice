namespace Design_Patterns_Practice_2022.Creational;
public interface IDiscountService
{
    int DiscountPercentage { get; }
    string ToString();
}

public class CountryDiscountService : IDiscountService
{
    private readonly string countryIdentifier;

    public CountryDiscountService(string countryIdentifier) => this.countryIdentifier = countryIdentifier;
    public int DiscountPercentage
    {
        get
        {
            switch (countryIdentifier)
            {
                case "de":
                    return 20;

                default:
                    return 10;
            }
        }
    }

    public override string ToString() => $"{GetType().Name} with the country identifier '{countryIdentifier}'";
}
public class CodeDiscountService : IDiscountService
{
    private readonly Guid codeId;
    public CodeDiscountService(Guid code) => this.codeId = code;

    public int DiscountPercentage
    {
        get => 15;
    }
    public override string ToString() => $"{GetType().Name} with code: '{codeId}'";
}
public class FlatDiscountService : IDiscountService
{
    private readonly int discountValue;
    public FlatDiscountService(int discountValue) => this.discountValue = discountValue;

    public int DiscountPercentage { get => discountValue; }
    string IDiscountService.ToString() => $"{GetType().Name}";
}

// Factories
public abstract class DiscountFactory
{
    public abstract IDiscountService CreateDiscountService();
}

public class CountryDiscountFactory : DiscountFactory
{
    private readonly string countryIdentifier;

    public CountryDiscountFactory(string countryIdentifier) => this.countryIdentifier = countryIdentifier;

    public override IDiscountService CreateDiscountService()
    {
        return new CountryDiscountService(countryIdentifier);
    }
}
public class CodeDiscountFactory : DiscountFactory
{
    private readonly Guid guid;

    public CodeDiscountFactory(Guid code) => guid = code;

    public override IDiscountService CreateDiscountService()
    {
        return new CodeDiscountService(guid);
    }
}
public class FlatDiscountFactory : DiscountFactory
{
    private readonly int flatDiscountValue;

    public FlatDiscountFactory(int flatDiscountValue) => this.flatDiscountValue = flatDiscountValue;

    public override IDiscountService CreateDiscountService()
    {
        return new FlatDiscountService(flatDiscountValue);
    }
}