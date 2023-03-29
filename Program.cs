namespace c_sharp_file
{
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il nome del file che vuoi creare");
            string nomeFile = Console.ReadLine();
            Console.WriteLine("Inserisci il contenuto del file");
            string? contenuto = Console.ReadLine();
            File.WriteAllText($"{nomeFile}.txt", contenuto == "" ? "File vuoto" : contenuto);
        }
    }
}