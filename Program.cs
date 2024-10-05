internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap thang ban muon xem bao nhieu ngay");
        int thang = int.Parse(Console.ReadLine());
        switch (thang){
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Thang {0} co 31 ngay", thang);
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Thang {0} co 30 ngay", thang);
                break;
            case 2:
                Console.WriteLine("Thang 2 co 28 hoac 29 ngay (nam nhuan co 29 ngay)");
                break;
            default:
                Console.WriteLine("Nhap sai thang! Vui long nhap so tu 1 den 12.");
                break;
        }
    }
}