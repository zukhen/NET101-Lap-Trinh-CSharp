namespace ConsoleApp.Lab2;

public class MainLab
{
/*
    public static void Main(string[] args)
    {
        
    }
*/
    static void bai1(float a, float b)
    {
        if (a == 0)
        {
            Console.Out.WriteLine("a phai khac 0");
        }
        else
        {
            double kq = -b / a;
            Console.Out.WriteLine("Phuong trinh co nghiem la x= " + kq);
        }
    }

    static void bai2(float a, float b, float c)
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

    static void bai3()
    {
        int ngay, thang, nam;
        do
        {
            Console.Out.Write("Nhap vao ngay: ");
            ngay = int.Parse(Console.ReadLine());
        } while (ngay > 31 || ngay <= 0);

        do
        {
            Console.Out.Write("Nhap vao thang: ");
            thang = int.Parse(Console.ReadLine());
        } while (thang > 12 || thang <= 0);

        Console.Out.Write("Nhap vao nam: ");
        nam = int.Parse(Console.ReadLine());
        //2
        CheckDayOfMonth(ngay, nam);
        //3
        CheckDayBeforeAndAfter(ngay, thang, nam);
    }

    static void CheckDayBeforeAndAfter(int ngay, int thang, int nam)
    {
        if (ngay - 1 == 0) Console.WriteLine("Ngay hôm truoc la ngay: 31 ");
        if (thang == 2)
        {
            if (nam % 400 == 0 || nam % 4 == 0 && nam % 100 != 0)
            {
                Console.WriteLine("ngay hom truoc la ngay 28");
            }

            Console.WriteLine("ngay hom truoc la ngay 27");
        }

        Console.WriteLine("Ngay hom sau la ngay  " + (ngay + 1));
    }

    static void CheckDayOfMonth(int thang, int nam)
    {
        switch (thang)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("thang " + thang + " co 31 ngay");
                break;
            case 2:
                if (nam % 400 == 0 || nam % 4 == 0 && nam % 100 != 0)
                {
                    Console.WriteLine("nam nhuan co 29 ngay");
                }
                else
                {
                    Console.WriteLine("co 28 ngay");
                }

                break;
        }
    }

    static void bai4()
    {
        int n;
        bool check =true;
        Console.Out.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n%i==0)
            {
                check=false;
                break;
            }
            i++;
        }

        if (check)
        {
            Console.Out.WriteLine(n+" la so nguyen to");
        }
        else
        {  Console.Out.WriteLine(n+" khong phai so nguyen to");
            
        }
    }

    static void bai5()
    {
        for (int i = 0; i <=10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Console.Out.WriteLine(+i+"x"+j+"= "+(i*j));
            }
        }
    }
}