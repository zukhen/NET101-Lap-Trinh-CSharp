using System.Collections;

namespace ConsoleApp.Lab5.model.bai2;

public class SinhVienService
{
    private List<SinhVienPoly> _list = new List<SinhVienPoly>();
    private String hoTen, chuyenNganh;
    private SinhVienPoly sv;
    private double diemJava, diemCss, diemHtml, diemMarketing, diemSales;

    private String getInputValue(String msg)
    {
        Console.Out.Write("Nhập vào " + msg);
        return Console.ReadLine();
    }

    public void Nhap()
    {
        while (true)
        {
            Console.Out.Write("Nhập vào tên sinh viên: ");
            hoTen = Console.ReadLine();
            if (hoTen.Trim().Length == 0) break;
            Console.Out.Write("Nhập vào chuyên ngành: ");
            chuyenNganh = Console.ReadLine();
            switch (chuyenNganh)
            {
                case "IT":
                case "it":

                    _list.Add(new SinhVienIT(hoTen, chuyenNganh, Convert.ToDouble(getInputValue("điểm Css: ")),
                        Convert.ToDouble(getInputValue("điểm Java: ")),
                        Convert.ToDouble(getInputValue("điểm Html: "))));
                    break;
                case "BIZ":
                case "biz":
                    _list.Add(new SinhVienBiz(hoTen, chuyenNganh, Convert.ToDouble(getInputValue("điểm Marketing: ")),
                        Convert.ToDouble(getInputValue("điểm Sales: "))));
                    break;
            }
        }
    }

    public void Xuat()
    {
        foreach (SinhVienPoly sv in _list)
        {
            Console.Write("Ho ten: {0} | Nganh: {1} | Diem TB: {2:F2} | Hoc luc: {3}\n", sv.HoTen.ToUpper(), sv.Nganh, sv.Diem, sv.getHocLuc());
        }
    }

    public void XuatHocLucGioi()
    {
        foreach (SinhVienPoly x in _list)
        {
            if (x.getHocLuc().Equals("Giỏi"))
            {
                Xuat();
            }
            else
            {
                Console.Out.WriteLine("Không có học sinh giỏi");
                break;
            }
        }
    }


    public virtual void Sapxep()
    {
        IComparer<SinhVienPoly> comp = new ComparatorAnonymousInnerClass(this);
        _list.Sort(comp);
        _list.Reverse();
        Xuat();
    }

    private class ComparatorAnonymousInnerClass : IComparer<SinhVienPoly>
    {
        private  SinhVienService outerInstances;

        public ComparatorAnonymousInnerClass(SinhVienService outerInstance)
        {
            this.outerInstances = outerInstance;
        }

        public int Compare(SinhVienPoly o1, SinhVienPoly o2)
        {
            return o1.Diem.CompareTo(o2.Diem);
        }
    }
}