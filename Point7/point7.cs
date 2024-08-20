//ข้อ 7
class Point7
{
    static void Main()
    {
        Point7 obj = new Point7();

        int seconds = 59;
        int seconds2 = 90;

        Console.WriteLine("---------------------------------------");
        obj.time(seconds);
        obj.time(seconds2);
        Console.WriteLine("---------------------------------------");
    }
    //ข้อ7
    public void time(int seconds)
    {
        int hours = seconds / 3600; // 1 ชั่วโมง = 3600 วินาที
        seconds %= 3600; // เหลือเศษของวินาทีหลังจากหักชั่วโมง
        int minutes = seconds / 60; // 1 นาที = 60 วินาที
        seconds %= 60; // เหลือเศษของวินาทีหลังจากหักนาที

        // hh:mm:ss
        string time = (hours < 10 ? "0" : "") + hours + ":"
                    + (minutes < 10 ? "0" : "") + minutes + ":"
                    + (seconds < 10 ? "0" : "") + seconds;

        Console.WriteLine(time);
    }
}