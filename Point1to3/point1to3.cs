//ข้อ 1 - 3
class Point1to3
{
    static void Main()
    {
        Point1to3 obj = new Point1to3();
        //ข้อที่ 1
        int[] array = { 1, 2, 3, 4, 5 };
        int sum = 5;
        int sum2 = 4;
        Console.WriteLine("\n--------------------------------- \nข้อที่ 1 \nsum = " + sum);
        obj.sumNumber(array, sum);
        Console.WriteLine("\nsum = " + sum2);
        obj.sumNumber(array, sum2);

        //ข้อที่ 2
        string str1 = "Mary";
        string str2 = "Army";
        string str3 = "Arm";

        bool result = checkString(str1, str2);
        Console.WriteLine("\n--------------------------------- \nข้อที่ 2 \nstr = " + str1 + "\nstr2 = " + str2);
        Console.WriteLine(result);

        bool result2 = checkString(str1, str3);
        Console.WriteLine("\nstr = " + str1 + "\nstr3 = " + str3);
        Console.WriteLine(result2);

        //ข้อ3
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] array2 = { 1, 4, 6, 9, 10, 14, 16, 17 };

        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("ข้อ3 \n" + ConvertArrayToRanges(array1));
        Console.WriteLine(ConvertArrayToRanges(array2));
        Console.WriteLine("---------------------------------");

    }
    //--------------------------------------------------------------------------------------------------------------
    //ข้อ 1
    public void sumNumber(int[] array, int sum)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                // เช็คว่าผลรวมของตัวเลขในตำแหน่ง i และ j เท่ากับ sum หรือไม่
                if (array[i] + array[j] == sum)
                {
                    Console.WriteLine($"{array[i]},{array[j]}");
                }
            }
        }
    }
    //--------------------------------------------------------------------------------------------------------------
    //ข้อ 2
    static bool checkString(string str1, string str2)
    {
        // เช็คความยาวของทั้งสองเท่ากันไหม
        if (str1.Length != str2.Length)
        {
            return false;
        }

        // แปลงสตริงทั้งสองเป็นตัวพิมพ์เล็กเอง
        char[] array1 = new char[str1.Length];
        char[] array2 = new char[str2.Length];

        // แปลงเป็นตัวพิมพ์เล็ก
        for (int i = 0; i < str1.Length; i++)
        {
            array1[i] = (str1[i] >= 'A' && str1[i] <= 'Z') ? (char)(str1[i] + 32) : str1[i];
            array2[i] = (str2[i] >= 'A' && str2[i] <= 'Z') ? (char)(str2[i] + 32) : str2[i];
        }

        // เปรียบเทียบความถี่ของตัวอักษรในแต่ละstring
        int[] charCount1 = new int[26];
        int[] charCount2 = new int[26];

        for (int i = 0; i < array1.Length; i++)
        {
            charCount1[array1[i] - 'a']++;
            charCount2[array2[i] - 'a']++;
        }

        // เปรียบเทียบความถี่ของตัวอักษร
        for (int i = 0; i < 26; i++)
        {
            if (charCount1[i] != charCount2[i])
            {
                return false;
            }
        }

        return true;
    }
    //--------------------------------------------------------------------------------------------------------------
    //ข้อ 3
    static string ConvertArrayToRanges(int[] array)
    {
        string result = "";

        int start = array[0];//เริ่ม
        int end = array[0]; //สุดท้าย

        for (int i = 1; i < array.Length; i++)
        {
            // หากตัวเลขถัดไปเป็นค่าต่อเนื่องจากตัวเลขปัจจุบัน
            if (array[i] == end + 1)
            {
                // ปรับค่าตัวสุดท้าย
                end = array[i];
            }
            else
            {
                if (start == end)
                {
                    result += start + ", ";
                }
                else
                {
                    result += start + "-" + end + ", ";
                }
                // เริ่มใหม่
                start = array[i];
                end = array[i];
            }
        }
        // ส่วนสุดท้ายของอาเรย์ที่เหลืออยู่
        if (start == end)
        {
            result += start;
        }
        else
        {
            result += start + "-" + end;
        }

        return result;
    }
}