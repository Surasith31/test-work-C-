//ข้อ 8
class Point8
{
    static void Main()
    {
        Point8 obj = new Point8();
        // รับค่าจำนวนเงิน
        int amount = 32;

        int change = 1000 - amount;

        // แสดงผลลัพธ์
        Console.WriteLine($"\nเงืนทอน {change} บาท\n");
        obj.Change(change);
    }
    public void Change(int change)
    {
        // กำหนดจำนวน ธนบัตร และ เหรียญ
        int[] billsAndCoins = { 500, 100, 50, 10, 5, 1 };
        foreach (int value in billsAndCoins)
        {
            // หาจำนวนธนบัตรหรือเหรียญที่ต้องใช้
            int count = change / value;
            if (count > 0)
            {
                // หักจำนวนเงินทอนที่ได้ใช้ ธนบัตรหรือเหรียญ นั้นออกจากจำนวนเงินทอนทั้งหมด
                change -= count * value;
                if (value > 10)
                {
                    Console.WriteLine($"{value} {count} ใบ");
                }
                else
                {
                    Console.WriteLine($"{value} {count} เหรียญ");
                }
            }
        }
        Console.WriteLine("");
    }
}