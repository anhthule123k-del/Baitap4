using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhập họ tên không theo chuẩn. Chỉnh lại theo chuẩn và xuất ra.");
        Console.WriteLine();

        Console.Write("Nhập họ tên (không cần theo chuẩn): ");
        string fullname = Console.ReadLine();

        string SEPERATOR = " ";

        // Tách từ dựa vào khoảng trắng, bỏ các giá trị rỗng
        string[] parts = fullname.Split(new string[] { SEPERATOR }, StringSplitOptions.RemoveEmptyEntries);

        // Hàm chuẩn hóa một từ: chữ cái đầu viết hoa, phần còn lại viết thường
        string Normalize(string s)
        {
            return s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
        }

        string ho = Normalize(parts[0]);
        string ten = Normalize(parts[parts.Length - 1]);
        string tenlot = "";

        // Nếu có tên lót thì ghép lại tất cả phần giữa họ và tên
        if (parts.Length > 2)
        {
            for (int i = 1; i < parts.Length - 1; i++)
            {
                tenlot += Normalize(parts[i]) + " ";
            }
            tenlot = tenlot.Trim();
        }

        if (tenlot == "")
            Console.WriteLine("Tên theo đúng chuẩn là: {0} {1}", ho, ten);
        else
            Console.WriteLine("Tên theo đúng chuẩn là: {0} {1} {2}", ho, tenlot, ten);

        Console.ReadKey(true);
    }
}

