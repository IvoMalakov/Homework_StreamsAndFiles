using System;
using System.IO;
using System.Text;

public class OddLines
{
    public static void Main()
    {
        StreamReader fileSource = new StreamReader("domashno_chernova.txt", Encoding.UTF8);

        using (fileSource)
        {
            int lineNumber = 0;
            string line = fileSource.ReadLine();

            while (line != null)
            {
                int checkRemainder = lineNumber % 2;
                if (checkRemainder != 0)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }

                lineNumber++;
                line = fileSource.ReadLine();
            }
        }
    }
}