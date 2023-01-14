namespace ConsoleApp.Lab5.model.bai2;

public class SinhVienIT : SinhVienPoly
{
    private double diemCss;
    private double diemJava;
    private double diemHtml;


    public SinhVienIT(string hoTen, string nganh, double diemCss, double diemJava, double diemHtml) : base(hoTen, nganh)
    {
        this.diemCss = diemCss;
        this.diemJava = diemJava;
        this.diemHtml = diemHtml;
    }

    public override double Diem
    {
        get
        {
            return (diemJava * 2 + diemHtml+diemCss) / 4;
        }
    }
}