namespace c_sharp_file
{
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il nome del file da creare");
            string nomeFile = Console.ReadLine();
            Console.WriteLine("Inserisci il contenuto del file");
            string contenutoFile = Console.ReadLine();

            File.WriteAllText($@"c:\Users\gdema\Desktop\csharp\{nomeFile}.txt",contenutoFile);
        }
    }
}