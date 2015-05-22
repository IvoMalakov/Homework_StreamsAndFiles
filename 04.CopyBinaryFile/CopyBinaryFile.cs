using  System;
using System.IO;

public class CopyBinaryFile
{
    public static void Main()
    {
        FileStream fileSource = new FileStream("Standing_jaguar.jpg", FileMode.Open);
        FileStream fileDestination = new FileStream("Destination.jpg", FileMode.Create);

        try
        {
            byte[] buffer = new byte[4096];

            while (true)
            {
                int readBytes = fileSource.Read(buffer, 0, buffer.Length);

                if (readBytes == 0)
                {
                    break;
                }

                fileDestination.Write(buffer, 0, readBytes);
            }

            Console.WriteLine("File copied. Please check the file \"Destination.jpg\" to see the result");
            Console.WriteLine();
        }

        finally 
        {
            fileSource.Close();
            fileDestination.Close();
        }
    }
}