namespace ConsoleApp.Lab6.model;

public class Order : DbAction
{
    public void insert()
    {
        Console.Out.WriteLine("insert Order");
    }

    public void update()
    {
        Console.Out.WriteLine("update Order");

    }

    public void delete()
    {
        Console.Out.WriteLine("delete Order");

    }

    public void select()
    {
        Console.Out.WriteLine("select Order");

    }
}