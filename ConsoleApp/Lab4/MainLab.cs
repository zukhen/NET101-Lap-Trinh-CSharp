namespace ConsoleApp.Lab4;

public class MainLab
{
    /*
    public static void Main(string[] args)
    {
    }
    */
    static void bai1()
    {
        SanPham sp = new SanPham("Hoa hong", 10000, 10);
        sp.Xuat();
    }

    static void bai2()
    {
        SanPham sp = new SanPham();
        SanPham sp2 = new SanPham();
        sp.Nhap();
        sp2.Nhap();
        sp.Xuat();
        sp2.Xuat();
    }

    static void bai3()
    {
        SanPham sp3 = new SanPham("hoa hong", 100000, 10);
        SanPham sp33 = new SanPham("SP2", 1000000);
        sp3.Xuat();
        sp33.Xuat();
    }
}