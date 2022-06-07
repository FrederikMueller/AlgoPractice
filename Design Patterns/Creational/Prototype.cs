using Newtonsoft.Json;

namespace Design_Patterns_Practice_2022.Creational;
public abstract class Person
{
    public abstract string Name { get; set; }
    public abstract Person Clone(bool deepClone);
}

class Manager : Person
{
    public override string Name { get; set; }

    public List<int> ints { get; set; } = new List<int>();

    public Manager(string name) => Name = name;

    public override Person Clone(bool deepClone = false)
    {
        if (deepClone)
        {
            var objAsJson = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<Manager>(objAsJson);
        }
        else
            return (Person)MemberwiseClone();
    }
}
class Employee : Person
{
    public override string Name { get; set; }
    public Manager Manager { get; set; }

    public Employee(string name, Manager manager)
    {
        Name = name;
        Manager = manager;
    }

    public override Person Clone(bool deepClone = false)
    {
        if (deepClone)
        {
            var objAsJson = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<Employee>(objAsJson);
        }
        else
            return (Person)MemberwiseClone();
    }
}