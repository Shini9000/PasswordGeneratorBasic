using System.Text;

namespace PasswordGen
{
    class Program
    {
        static string generatePassword(int length)
        {
            const string validChars =
                "abcdefghijklmnopqrstuvwxyz1234567890!.";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(validChars[rnd.Next(validChars.Length)]);
            }
            return res.ToString();
        }

        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string pass = generatePassword(length);
            Console.WriteLine(pass);
            Console.WriteLine("Press any button to exit!");
            Console.ReadLine(); 
        }

    }
}
