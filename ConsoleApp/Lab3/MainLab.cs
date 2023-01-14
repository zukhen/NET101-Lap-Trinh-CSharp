using System.Collections;

namespace ConsoleApp.Lab3;

public class MainLab
{
    /*
    public static void Main(string[] args)
    {
    }
*/
    static void b1_1(int n)
    {
        int Sum = 0;
        var array1 = new int[n];
        //nhap
        for (int i = 0; i < n; i++)
        {
            Console.Out.Write("Phan thu thu " + (i + 1) + ": ");
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }

        //sap xep
        Array.Sort(array1);
        Console.Out.WriteLine("Sap xep: ");
        foreach (int x in array1)
        {
            Console.Out.Write(x + " ");
            if (x % 3 == 0)
            {
                Sum += x;
            }
        }

        Console.Out.WriteLine("\nPhan tu nho nhat la: " + array1[0]);
        Console.Out.WriteLine("Trung binh cong la: " + (float)Sum / n);
    }

    static void b1_2(int n)
    {
        int Sum = 0;
        ArrayList arrayList = new ArrayList();
        for (int i = 0; i < n; i++)
        {
            Console.Out.Write("Phan thu thu " + (i + 1) + ": ");
            arrayList.Add(i);
        }

        foreach (int el in arrayList)
        {
            if (el % 3 == 0)
            {
                Sum += el;
            }
        }

        Console.Out.WriteLine("\nPhan tu nho nhat la: " + arrayList[0]);
        Console.Out.WriteLine("Trung binh cong la: " + (Sum / n));
    }

    static void bai2(int n)
    {
        String[] ten = new string[n];
        double[] diem = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Out.Write("Ten sinh vien thu " + (i + 1) + ": ");
            ten[i] = Console.ReadLine();
            Console.Out.Write("Diem sinh vien thu " + (i + 1) + ": ");
            diem[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < ten.Length - 1; i++) {
            for (int j = 0; j < ten.Length - 1; j++) {
                if (diem[i] > diem[j]) {
                    double temp = diem[i];
                    diem[i] = diem[j];
                    diem[j] = temp;
                    //sinh vien
                    String tempSV = ten[i];
                    ten[i] = ten[j];
                    ten[j] = tempSV;
                }
            }
        }
        for (int i = 0; i < n; i++) {
            Console.Out.WriteLine("Ho ten: " + ten[i]);
            Console.Out.WriteLine("Diem: " + diem[i]);
            if (diem[i] >= 9) {
                Console.Out.WriteLine("Hoc luc: Xuat Sac");
            } else if (diem[i] >= 7.5 && diem[i] < 9) {
                Console.Out.WriteLine("Hoc luc: Gioi");
            } else if (diem[i] >= 6.5 && diem[i] < 7.5) {
                Console.Out.WriteLine("Hoc luc: Kha");
            } else if (diem[i] >= 5 && diem[i] < 6.5) {
                Console.Out.WriteLine("Hoc luc: Trung Binh");
            } else {
                Console.Out.WriteLine("Hoc luc: Yeu");
            }
        }
    }
}