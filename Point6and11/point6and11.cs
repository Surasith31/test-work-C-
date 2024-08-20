//ข้อ 6 เเละ ข้อ 11
class Point6and11
{
    static void Main()
    {
        //จากโจทย์
        int[] numbers = { 1, 2, 9, 4, 5, 8, 7, 6, 3, 10 };

        // เรียงลำดับจากมากไปน้อย
        Descending(numbers);

        Console.WriteLine("-----------------------------------------------------");
        Console.Write("ข้อ 6 จากมากไปน้อย : ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        
        // เรียงลำดับจากน้อยไปมาก
        Fromleasttogreatest(numbers);

        Console.Write("\nข้อ 11 จากน้อยไปมาก : ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("\n-----------------------------------------------------");
    }
    //ข้อ 6
    static void Descending(int[] array)
    {
        int n = array.Length;
        // การจัดเรียงแบบ (Selection Sort)
        for (int i = 0; i < n - 1; i++)
        {
            // หาตำแหน่งของค่ามากที่สุด
            int maxIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] > array[maxIndex])
                {
                    maxIndex = j;
                }
            }
            // สลับค่าที่ตำแหน่ง i กับตำแหน่ง maxIndex
            int temp = array[i];
            array[i] = array[maxIndex];
            array[maxIndex] = temp;
        }
    }
    //ข้อ 11
    static void Fromleasttogreatest(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            // หาตำแหน่งของค่าต่ำที่สุด
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // สลับค่าที่ตำแหน่ง i กับตำแหน่ง minIndex
            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }
}