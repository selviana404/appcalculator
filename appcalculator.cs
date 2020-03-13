

using system;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Aplikasi kalkulator");
    Console.WriteLine("...................");
    Console.WriteLine("1.penambahan");
    Console.WriteLine("2.pengurangan");
    Console.WriteLine("3.perkalian");
    Console.WriteLine("4.pembagian");
    Console.WriteLine("pilih menu antara [1..4]");
    int ch = int.Parse(Console.ReadLine());
    int x, y, z;
    if (ch==1)
    {
      Console.Write("Masukan nilai x :");
      x = int.Parse(Console.ReadLine());
      Console.Write("Masukan nilai y :");
      y = int.Parse(Console.ReadLine());
      z = x + y;
      Console.WriteLine("penambahan = {0}", z);
    }
    else if (ch==2)
    {
       Console.Write("Masukan nilai x :");
       x = int.Parse(Console.ReadLine());
       Console.Write("Masukan nilai y :");
       y = int.Parse(Console.ReadLine());
       z = x - y;
       Console.WriteLine("pengurangan = {0}", z);
    }
    else if (ch==3)
    {
       Console.Write("Masukan nilai x :");
       x = int.Parse(Console.ReadLine());
       Console.Write("Masukan nilai y :");
       y = int.Parse(Console.ReadLine());
       z = x * y;
       Console.WriteLine("perkalian = {0}", z);
    }
    else if (ch==4)
    {
        Console.Write("Masukan nilai x :");
        x = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai y :");
        y = int.Parse(Console.ReadLine());
        z = x / y;
        Console.WriteLine("pembagian = {0}", z);
    }
    else
    {
        Console.WriteLine("Maaf, menu yang Anda pilih tidak tesedia");
    }
    Console.WriteLine("\nTekan sembarang key untuk keluar");
    Console.ReadKey();
  }
}