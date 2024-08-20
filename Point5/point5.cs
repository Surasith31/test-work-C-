//ข้อ 5
class Point5
{
    static void Main()
    {
        // input 1-4
        int number = 4;
        Console.WriteLine("------------------");
        DrawTriangle(number);
        Console.WriteLine("------------------");

        int number2 = 3;
        DrawTriangle(number2);
        Console.WriteLine("------------------");

    }
    //ข้อ5
    static void DrawTriangle(int size)
    {
        int currentNumber = 1; // เลขเริ่มต้น
        for (int i = 1; i <= size; i++)
        {
            // พิมพ์ช่องว่างเพื่อจัดตำแหน่ง
            for (int j = size - i; j > 0; j--)
            {
                Console.Write(" ");
            }
            // พิมพ์ตัวเลข
            for (int k = 0; k < i; k++)
            {
                Console.Write(currentNumber + " ");
                currentNumber++;
                if (currentNumber > 9) // รีเซ็ตตัวเลขหลังจาก 9
                {
                    currentNumber = 0;
                }
            }
            // ขึ้นบรรทัดใหม่
            Console.WriteLine();
        }
    }
}