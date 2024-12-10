internal class Program
{
    private static void Mainx(string[] args)
    {
        string st = "";
        Random rnd = new Random();
        for (int i = 0; i < 1000; i++)
        {
            st += rnd.Next(500) + ",";
        }
        writeText("data.txt", st);

        Console.WriteLine("noi dung file data.txt");
        string content = readContent("data.txt");
        Console.WriteLine(content);

        int max = solonnhat("data.txt");
        Console.WriteLine(max);
    }

    /// <summary>
    /// Ghi 1 noi dung dang text vcao file
    /// </summary>
    /// <param name="path"></param>
    /// <param name="content"></param>
    static void writeText(string path, string content)
    {
        StreamWriter writer = new StreamWriter(path);
        writer.WriteLine(content);
        writer.Close();
    }

    /// <summary>
    /// Doc mot file text
    /// </summary>
    /// <param name="path">duong dan den file can do</param>
    /// <returns>noi dung cua file</returns>
    static string readContent(string path)
    {
        StreamReader reader = new StreamReader(path);
        string content = reader.ReadToEnd();
        reader.Close();
        return content;
    }

    static int solonnhat(string path)
    {

        string content = readContent(path);
        content = content.Trim().Substring(0, content.Length - 2);
        string[] lst = content.Split(',');

        int max = int.Parse(lst[0]);
        foreach (string s in lst)
        {
            if (s != "")
            {
                int num = int.Parse(s);
                if (num > max)
                    max = num;
            }
        }

        return max;
    }
    static void insoNT(string path)
    {
        string content = readContent(path);
        content = content.Trim().Substring(0, content.Length - 2);
        string[] lst = content.Split(',');

        foreach (string s in lst)
        {
            if (s != "")
            {
                int num = int.Parse(s);
                if (isPrime(num))
                    Console.WriteLine(num + " ");
            }
        }

    }

    private static bool isPrime(int num)
    {
        throw new NotImplementedException();
    }
}