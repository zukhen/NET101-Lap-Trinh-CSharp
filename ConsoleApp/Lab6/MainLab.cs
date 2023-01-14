using System.Text;
using ConsoleApp.Lab6.model;

namespace ConsoleApp.Lab6;

public class MainLab
{
    /*
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

    }
*/
    static void bai1()
    {
        IBook service = new Book();
        int chon, amountBook;
        while (true)
        {
            Console.Out.WriteLine("1:Cho nhập vào một mảng chứa những cuốn sách");
            Console.Out.WriteLine("2: Xuất danh sách thông tin những cuốn sách");
            Console.Out.WriteLine(
                "3: Lần lượt xuất danh sách ra theo thứ tự được sắp theo tên tác giả,tên sách, năm xuất bản");
            Console.Out.WriteLine("4: Kết thúc.");
            while (true)
            {
                Console.Out.Write("Mời chọn: ");
                try
                {
                    chon = Convert.ToInt32(Console.ReadLine());
                    switch (chon)
                    {
                        case 1:
                            Console.Out.Write("Nhập vào số lượng cuốn sách: ");
                            amountBook = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < amountBook; i++)
                            {
                                service.Nhap();
                            }

                            break;
                        case 2:
                            service.Xuat();
                            break;
                        case 3:
                            service.Sapxep();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vui lòng nhập số");
                }
            }
        }
    }

    static void bai2()
    {
        DbAction db1 = new Order();
        DbAction db2 = new Product();
        db1.insert();
        db2.insert();
    }
}