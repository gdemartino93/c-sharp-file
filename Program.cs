namespace c_sharp_file
{
    using System.IO;
    internal class Program
    {
        enum Opzioni
        {
            No,
            Yes
            
        }
        static void Main(string[] args)
        {
  
            Console.WriteLine("Inserisci il nome del file da creare");
            string nomeFile = Console.ReadLine();
            Console.WriteLine("Inserisci il contenuto del file");
            string contenutoFile = Console.ReadLine();

            string filePath = $@"c:\Users\gdema\Desktop\csharp\{nomeFile}.txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine("File già esistente. Vuoi sovrascriverlo? Si/No");
                Opzioni risposta = (Opzioni)Enum.Parse(typeof(Opzioni), Console.ReadLine(), true);
                if (risposta == Opzioni.No)
                {
                    Console.WriteLine("Il file non è stato sovrascritto.");
                    return;
                }
            }

            File.WriteAllText($@"c:\Users\gdema\Desktop\csharp\{nomeFile}.txt",contenutoFile);
        }
    }
}