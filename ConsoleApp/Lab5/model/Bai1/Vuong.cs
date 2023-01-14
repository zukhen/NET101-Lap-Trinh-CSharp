namespace ConsoleApp.Lab5;

public class Vuong : ChuNhat
{
   private float canh;
   public new void Xuat()
   {
      Console.Out.WriteLine("Thong tin hinh vuong la:");
      base.Xuat();
   }


   public Vuong(float c) : base(c, c)
   {
      canh = c;
   }
}