using System.Threading.Tasks.Dataflow;

namespace ConsoleApp.Lab6.model;

public class Book  : IBook
{
    private String tenSach;
    private String tenTacGia;
    private String nhaXuatBan;
    private int namXuatBan;
    private int soHieuISBN;
    private int danhMuc;
    private List<Book> _list = new List<Book>();
    public Book()
    {
    }

    public Book(string tenSach, string tenTacGia, string nhaXuatBan, int namXuatBan, int soHieuIsbn, int danhMuc)
    {
        this.tenSach = tenSach;
        this.tenTacGia = tenTacGia;
        this.nhaXuatBan = nhaXuatBan;
        this.namXuatBan = namXuatBan;
        soHieuISBN = soHieuIsbn;
        this.danhMuc = danhMuc;
    }

    public string TenSach
    {
        get => tenSach;
        set => tenSach = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string TenTacGia
    {
        get => tenTacGia;
        set => tenTacGia = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string NhaXuatBan
    {
        get => nhaXuatBan;
        set => nhaXuatBan = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int NamXuatBan
    {
        get => namXuatBan;
        set => namXuatBan = value;
    }

    public int SoHieuIsbn
    {
        get => soHieuISBN;
        set => soHieuISBN = value;
    }

    public int DanhMuc
    {
        get => danhMuc;
        set => danhMuc = value;
    }
    private String getInputValue(String msg)
    {
        Console.Out.Write("Nhập vào " + msg);
        return Console.ReadLine();
    }
    public void Nhap()
    {
       _list.Add(new Book(getInputValue("tên sách: "),
           getInputValue("tên tác giả: "),
           getInputValue("tên nhà xuất bản: "),
           Convert.ToInt32(getInputValue("năm xuất bản: ")),
           Convert.ToInt32(getInputValue("số hiệu ISBN: ")),
           Convert.ToInt32(getInputValue("danh mục chương sách: "))
           ));

    }

    public void Xuat()
    {
        foreach (Book b in _list)
        {
            Console.Write("Tên sách: {0} | Tên tác giả: {1} | Tên nhà xuất bản: {2:F2} | Năm xuất bản: {3} | Số hiệu ISBN: {4} | Danh mục chương sách: {5}\n ",
                b.TenSach,b.TenTacGia,b.nhaXuatBan,b.NamXuatBan,b.SoHieuIsbn,b.DanhMuc);
        }
        
    }
    public virtual void Sapxep()
    {
        IComparer<Book> comp = new ComparatorAnonymousInnerClass(this);
        _list.Sort(comp);
        _list.Reverse();
        Xuat();
    }

    private class ComparatorAnonymousInnerClass : IComparer<Book>
    {
        private  Book outerInstances;

        public ComparatorAnonymousInnerClass(Book outerInstance)
        {
            this.outerInstances = outerInstance;
        }

        public int Compare(Book o1, Book o2)
        {
            return o1.NamXuatBan.CompareTo(o2.NamXuatBan);
        }
    }
}
