namespace ConsoleApp.Lab4;

public class SanPham
{
    private String tenSanPham;

    public SanPham()
    {
    }

    public SanPham(string tenSanPham, double donGia, double giamGia)
    {
        this.tenSanPham = tenSanPham;
        this.DonGia = donGia;
        this.GiamGia = giamGia;
    }

    public SanPham(string tenSanPham, double donGia)
    {
        this.tenSanPham = tenSanPham;
        DonGia = donGia;
    }

    private string TenSanPham
    {
        get => tenSanPham;
        set => tenSanPham = value ?? throw new ArgumentNullException(nameof(value));
    }

    private double DonGia { get; set; }

    private double GiamGia { get; set; }

    public double GetThueNhapKhau()
    {
        return DonGia*0.1;
    }

    public void Xuat()
    {
        Console.Out.WriteLine("Ten san pham: "+TenSanPham);
        Console.Out.WriteLine("Gia san pham: "+DonGia);
        Console.Out.WriteLine("Giam gia san pham: "+GiamGia);
        Console.Out.WriteLine("Thue nhap khau san pham: "+GetThueNhapKhau());
    }

    public void Nhap()
    {
        //dung getter/setter tang tinh bao mat
        Console.Out.Write("Nhap vao ten san pham: ");
        TenSanPham = Console.ReadLine();
        Console.Out.Write("Nhap vao gia san pham: ");
        DonGia = Convert.ToDouble(Console.ReadLine());
        Console.Out.Write("Nhap vao giam gia san pham: ");
        GiamGia = Convert.ToDouble(Console.ReadLine());

    }
}