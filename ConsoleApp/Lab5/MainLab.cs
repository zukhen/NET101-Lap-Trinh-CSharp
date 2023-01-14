using System.Text;
using ConsoleApp.Lab5.model.bai2;

namespace ConsoleApp.Lab5;

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
        ChuNhat cn = new ChuNhat(9, 8);
        Vuong vu = new Vuong(8);
        cn.Xuat();
        vu.Xuat();
    }

    static void bai4()
    {
        int chon;
        SinhVienService sinhVienService = new SinhVienService();
        while (true)
        {
            Console.Out.WriteLine("1: Nhập danh sách sinh viên.");
            Console.Out.WriteLine("2: Xuất danh sách sinh viên.");
            Console.Out.WriteLine("3: Xuất danh sách sinh viên có học lực giỏi");
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
                            sinhVienService.Nhap();
                            break;

                        case 2:
                            sinhVienService.Xuat();
                            break;

                        case 3:
                            sinhVienService.XuatHocLucGioi();
                            break;
                        case 4:
                            sinhVienService.Sapxep();
                            break;
                        case 5:
                            Environment.Exit(0);
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
}