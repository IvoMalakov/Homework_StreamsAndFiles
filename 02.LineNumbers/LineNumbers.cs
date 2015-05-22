using System;
using System.IO;
using System.Text;

public class LineNumbers
{
    public static void Main()
    {
        StreamReader fileSource = new StreamReader("domashno_chernova.txt", Encoding.UTF8);
        StreamWriter fileDestination = new StreamWriter("destination_file_line_numbers.txt");

        using (fileSource)
        {
            using (fileDestination)
            {
                int lineNumber = 1;
                string line = fileSource.ReadLine();

                while (line != null)
                {
                    fileDestination.WriteLine("{0}     {1}", lineNumber, line);
                    Console.WriteLine("Line {0} added", lineNumber);
                    lineNumber++;
                    line = fileSource.ReadLine();
                }

                Console.WriteLine();
                Console.WriteLine("All lines are added");
            }
        }
    }
}