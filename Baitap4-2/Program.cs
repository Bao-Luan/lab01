namespace Baitap4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ho ten day du. Xuat ra tung phan.");
            Console.WriteLine();

            Console.Write("Nhap ho ten: ");
            string fullname = Console.ReadLine();

            string SPACE = " ";
            string[] parts = fullname.Split(new string[] { SPACE }, StringSplitOptions.None);

            if (parts.Length >= 3)
            {
                Console.WriteLine("Ho: {0}, ten lot: {1}, ten: {2}", parts[0], parts[1], parts[2]);
            }
            else
            {
                Console.WriteLine("Chuoi nhap vao khong du 3 phan.");
            }

            Console.ReadKey(true);
        }
    }
}