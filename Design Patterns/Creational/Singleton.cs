namespace Design_Patterns_Practice_2022.Creational;
public class Singleton
{
    // private static Singleton? instance;
    private static readonly Lazy<Singleton> lazySingleton = new Lazy<Singleton>(() => new Singleton());

    public static Singleton Instance
    {
        get
        {
            return lazySingleton.Value;

            //if (instance == null)
            //    instance = new Singleton();

            //return instance;
        }
    }

    // cant be instantiated, but subclassed
    protected Singleton()
    {
    }

    public void Log(string message)
    {
        Console.WriteLine($"Logged message: {message}.");
    }
}