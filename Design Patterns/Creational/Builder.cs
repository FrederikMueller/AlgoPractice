using System;
using System.Text;

namespace Design_Patterns_Practice_2022.Creational;
public class Car
{
    List<string> parts = new List<string>();
    string carType;

    public Car(string carType) => this.carType = carType;

    public void AddPart(string part)
    {
        parts.Add(part);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (string part in parts)
        {
            sb.Append($"Car of type {carType} has part {part}.");
        }
        return sb.ToString();
    }
}

public abstract class Carbuilder
{
    public Car Car { get; private set; }

    public Carbuilder(string carType) => Car = new Car(carType);

    public abstract void BuildEngine();
    public abstract void BuildFrame();
}

public class MiniBuilder : Carbuilder
{
    public MiniBuilder() : base("Mini")
    {
    }
    public override void BuildEngine()
    {
        Car.AddPart("schmutz engine");
    }

    public override void BuildFrame() => Car.AddPart("klein und zerbrechlich");
}
public class BMWBuilder : Carbuilder
{
    public BMWBuilder() : base("BMW")
    {
    }
    public override void BuildEngine()
    {
        Car.AddPart("big dick engine");
    }

    public override void BuildFrame() => Car.AddPart("gigachad frame");
}

public class Garage
{
    private Carbuilder? carbuilder;

    public void Construct(Carbuilder builder)
    {
        carbuilder = builder;

        builder.BuildEngine();
        builder.BuildFrame();
    }

    public void Show()
    {
        Console.WriteLine(carbuilder?.Car.ToString());
    }
}