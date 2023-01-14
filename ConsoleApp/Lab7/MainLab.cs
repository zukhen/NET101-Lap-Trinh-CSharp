using System.Collections;
using System.Text;

namespace ConsoleApp.Lab7;

public class MainLab
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;
        bai1();
    }
    static void bai1()
    {
        PrintHelper printHelper = new PrintHelper();
        PrintHelper.DelegateB1 dl = printHelper.Tong;

        Console.Out.WriteLine("Tong: " + dl(8, 4));
        dl = printHelper.Hieu;

        Console.Out.WriteLine("Hieu: " + dl(8, 4));
        dl = printHelper.Tich;
        Console.Out.WriteLine("Tich: " + dl(8, 4));
        dl = printHelper.Thuong;
        Console.Out.WriteLine("Thuong: " + dl(8, 4));
    }
}