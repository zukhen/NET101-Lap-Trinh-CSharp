namespace ConsoleApp.Lab6.model;

public class Product : DbAction
{
    public void insert()
    {
        Console.Out.WriteLine("insert Product");
    }

    public void update()
    {
        Console.Out.WriteLine("update Product");


    }

    public void delete()
    {
        Console.Out.WriteLine("delete Product");

    }

    public void select()
    {
        Console.Out.WriteLine("select Product");

    }
}