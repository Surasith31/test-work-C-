//ข้อ 4 เเละ ข้อ 10 
class Point4and10
{
    static void Main()
    {
        Point4and10 obj = new Point4and10();

        int input = 5;
        Console.WriteLine("-------------------------------------------\nข้อ4\n");
        obj.triangle(input);
        Console.WriteLine("-------------------------------------------\nข้อ10\n");
        obj.triangle2(input);
        Console.WriteLine("-------------------------------------------");
    }
    //ข้อ4
    public void triangle(int input)
    {
        for (int i = input; i > 0; i--)
        {
            // เพิ่มช่องว่าง
            for (int j = input - i; j > 0; j--)
            {
                Console.Write(" ");
            }
            // เพิ่ม *
            for (int k = 0; k < (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            // ขึ้นบรรทัดใหม่
            Console.WriteLine();
        }
    }
    //ข้อ10
    public void triangle2(int input)
    {
        for (int i = 1; i <= input; i++)
        {
            // วาดช่องว่าง
            for (int j = 1; j <= input - i; j++)
            {
                Console.Write(" ");
            }

            // วาด *
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}