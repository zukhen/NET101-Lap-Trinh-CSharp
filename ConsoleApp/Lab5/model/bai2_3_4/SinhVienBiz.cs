namespace ConsoleApp.Lab5.model.bai2;

public class SinhVienBiz : SinhVienPoly
{
    private double diemMarketing;
    private double diemSales;
    public SinhVienBiz(string hoTen, string nganh,double diemMarketing,double diemSales) : base(hoTen, nganh)
    {
        this.diemSales =diemSales ;
        this.diemMarketing = diemMarketing;
    }

    public override double Diem
    {
        get
        {
            return (2 * diemMarketing + diemSales) / 3;
        }
    }
}