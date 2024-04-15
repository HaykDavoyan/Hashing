namespace HashEx;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the text: ");
        string message = Console.ReadLine();
        HashCode hashCode = new HashCode();
        string[] result = hashCode.StringinFor(message);
        string[] result2 = hashCode.StringReverse(result);
        hashCode.ChangeToAsciiThanBinary(result2);
    }
}
