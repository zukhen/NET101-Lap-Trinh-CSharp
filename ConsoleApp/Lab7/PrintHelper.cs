namespace ConsoleApp.Lab7;

public class PrintHelper
{
    public delegate void BeforePrint();
    public event BeforePrint beforePrintEvent;
    public delegate int DelegateB1(int a,int b);
    public int Tong(int a, int b)
    {
        return a + b;
    }
    public int Hieu(int a, int b)
    {
        return a - b;
    }
    public int Tich(int a, int b)
    {
        return a * b;
    }
    public int Thuong(int a, int b)
    {
        return a / b;
    }
    public PrintHelper()
    {
    }

    public void PrintNumber(int num)
    {
        if (beforePrintEvent != null)
        {
            beforePrintEvent();
            Console.Out.WriteLine("Number: {0,-12:N0}", num);
        }
    }

    public void PrintDemical(int dec)
    {
        if (beforePrintEvent != null)
        {
            beforePrintEvent();
            Console.Out.WriteLine("Number: {0:G}", dec);
        }


    }
    public void PrintMoney(int money)
    {
        if (beforePrintEvent != null)
        {
            beforePrintEvent();
            Console.Out.WriteLine("Number: {0:C}", money);
        }
    }
    public void PrintTemperature(int num)
    {
        if (beforePrintEvent != null)
        {
            beforePrintEvent();
            Console.Out.WriteLine("Number: {0,4:N1}", num);
        }
    }
    public void PrintHex(int dec)
    {
        if (beforePrintEvent != null)
        {
            beforePrintEvent();
            Console.Out.WriteLine("Number: {0:X}", dec);
        }
    }
    //b3
}