internal class Program
{
    private static void Main(string[] args)
    {
        //右側對齊星形三角形
        for (int i = 5; i >= 0; i--)
        {
            int countOfEmpty = i;
            int countOfStar = 5 - i;
            string row = new string(' ', countOfEmpty) + new string('*', countOfStar);
            Console.WriteLine(row);
        }
    }
}