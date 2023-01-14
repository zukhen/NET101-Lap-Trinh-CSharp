namespace ConsoleApp.Lab5;

public class ChuNhat
{
    private double rong;
    private double dai;

    public ChuNhat()
    {
    }

    public ChuNhat( double dai,double rong)
    {
        this.rong = rong;
        this.dai = dai;
    }

    public double Rong
    {
        get => rong;
        set => rong = value;
    }

    public double Dai
    {
        get => dai;
        set => dai = value;
    }

    public void Xuat()
    {
        Console.Out.WriteLine("Chieu dai: "+dai);
        Console.Out.WriteLine("Chieu rong: "+rong);
        Console.Out.WriteLine("Chu vi: "+(dai+rong)*2);
        Console.Out.WriteLine("Dien tich: "+(dai*rong));
    }
}