//ข้อ 9
class Point9
{
    static void Main()
    {
        string sentence = "Welcome to clicknext";

        //  ReverseWords เพื่อทำการเปลี่ยนแปลง
        string reversedSentence = ReverseWords(sentence);

        // แสดงผลลัพธ์
        Console.WriteLine("----------------------------------------------\nข้อ 9");
        Console.Write("\n input : " + sentence);
        Console.WriteLine("\n output : " + reversedSentence + "\n");
        Console.Write("----------------------------------------------");
    }

    // ฟังก์ชันเพื่อทำการรีเวิร์สคำในประโยค
    static string ReverseWords(string sentence)
    {
        // แบ่งประโยคออกเป็นคำ
        string[] words = SplitSentence(sentence);
        string[] reversedWords = new string[words.Length];

        // รีเวิร์สแต่ละคำ
        for (int i = 0; i < words.Length; i++)
        {
            reversedWords[i] = ReverseWord(words[i]);
        }
        // รวมคำที่รีเวิร์สแล้วกลับเป็นประโยค
        return JoinWords(reversedWords);
    }

    // ฟังก์ชันเพื่อแบ่งประโยคเป็นคำ
    static string[] SplitSentence(string sentence)
    {
        // นับจำนวนช่องว่างเพื่อคำนวณขนาดของอาร์เรย์
        int wordCount = 1;
        foreach (char c in sentence)
        {
            if (c == ' ')
            {
                wordCount++;
            }
        }

        string[] words = new string[wordCount];
        int wordIndex = 0;
        int startIndex = 0;

        // แบ่งคำออกจากประโยค
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ')
            {
                words[wordIndex++] = sentence.Substring(startIndex, i - startIndex);
                startIndex = i + 1;
            }
        }
        words[wordIndex] = sentence.Substring(startIndex);

        return words;
    }

    // ฟังก์ชันเพื่อรีเวิร์สคำ
    static string ReverseWord(string word)
    {
        char[] reversed = new char[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            reversed[i] = word[word.Length - 1 - i];
        }
        return new string(reversed);
    }

    // ฟังก์ชันเพื่อรวมคำที่รีเวิร์สแล้วเป็นประโยค
    static string JoinWords(string[] words)
    {
        string result = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (i > 0)
            {
                result += " ";
            }
            result += words[i];
        }
        return result;
    }
}