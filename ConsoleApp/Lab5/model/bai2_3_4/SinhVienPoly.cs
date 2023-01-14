namespace ConsoleApp.Lab5.model.bai2;

public abstract class SinhVienPoly 
{
    private String hoTen;
    private String nganh;



    public SinhVienPoly(string hoTen, string nganh)
    {
        this.hoTen = hoTen;
        this.nganh = nganh;
    }

    public string HoTen
    {
        get => hoTen;
        set => hoTen = value ?? throw new ArgumentNullException(nameof(value));
    }

    public abstract double  Diem{get;}
   
    public string Nganh
    {
        get => nganh;
        set => nganh = value ?? throw new ArgumentNullException(nameof(value));
    }

   
    public String getHocLuc()
    {
        double diem = Diem;
        switch (diem)
        {
            case >= 9:
                return "Xuat sac";
            case >= 7.5:
                return "Gioi";
            case >= 6.5:
                return "Kha";
            case >= 5:
                return "Trung binh";
            default:
                return "Yeu";
        }
    }

    
}