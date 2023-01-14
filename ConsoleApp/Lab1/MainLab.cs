namespace ConsoleApp.Lab1;

public class MainLab
{/*
    public static void Main(string[] args)
    {
                


      }
*/
    static void bai2(float cDai, float cRong)
    {
        Console.WriteLine("Chu vi: " + (cRong + cDai) * 2);
        Console.WriteLine("Dien tich: " + cRong * cDai);
        Console.WriteLine("Canh nho nhat: " + Math.Min(cDai, cRong));
    }

    static double bai3(float canh)
    {
        return Math.Pow(canh, 3);
    }

    static void bai4(float a, float b, float c)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.Out.WriteLine("Phuong trinh co vo so nghiem");
                }
            }
            else
            {
                double kq = -c / b;
                Console.Out.WriteLine("Phuong trinh co nghiem la x= " + kq);
            }
        }
        else
        {
            var delta = Math.Pow(b, 2) - 4 * a * c;
            switch (Math.Sqrt(delta))
            {
                case > 0:
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.Out.WriteLine("Phuong trinh co 2 nghiem");
                    Console.Out.WriteLine("x1= " + x1);
                    Console.Out.WriteLine("x2= " + x2);
                    break;
                }
                case 0:
                {
                    double nghiemKep = -b / (2 * a);
                    Console.Out.WriteLine("Phuong trinh co nghiem kep la x=: " + nghiemKep);
                    break;
                }
                default:
                    Console.Out.WriteLine("Phuong trinh vo nghiem");
                    break;
            }
        }
    }
}