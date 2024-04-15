using System;
using System.Text;
namespace HashEx;

public class HashCode
{
    public string[] StringinFor(string message)
    {
        if (string.IsNullOrEmpty(message))
        {
            return new string[0];
        }

        int parts = (int)Math.Ceiling((double)message.Length / 4);
        string[] arrayParts = new string[parts];

        for (int i = 0; i < parts; i++)
        {
            int startIndex = i * 4;
            int length = Math.Min(4, message.Length - startIndex);
            arrayParts[i] = message.Substring(startIndex, length);
        }

        return arrayParts;
    }

    public string[] StringReverse(string[] arr)
    {
        string[] result = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = new string(arr[i].Reverse().ToArray());
        }
        return result;
    }

    public void ChangeToAsciiThanBinary(string[] arr)
    {
        int totalValue = 0;
        string concatenatedBinary = "";

        foreach (string s in arr)
        {
            int value = 0;

            foreach (char c in s)
            {
                value = (value << 8) | c;
                int asciiValue = c;
                string binaryValue = Convert.ToString(asciiValue, 2);
                while (binaryValue.Length < 8)
                {
                    binaryValue = "0" + binaryValue; 
                }
                concatenatedBinary += binaryValue;
            }
            totalValue += value;
        }
        Console.WriteLine($"Concatenated Binary: {concatenatedBinary}");
        Console.WriteLine($"Total Value: {totalValue}");
    }    
}
