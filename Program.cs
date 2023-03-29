namespace c_sharp_file
{
    using System;
    using System.IO;
    using System.Security.Cryptography;

    internal class Program
    {
        enum Opzioni
        {
            No,
            Si
            
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
                switch (risposta)
                {
                    case Opzioni.No:
                        Console.WriteLine("Il file non è stato sovrascritto. E' stato creato un nuovo file.");

                        //gestiamo l'univocità del nome del file

                        byte[] randomBytes = new byte[10];
                        RandomNumberGenerator.Fill(randomBytes);
   
                        string randomString = BitConverter.ToString(randomBytes).Replace("-","");//convertiamo gli array di bytes in stringa esa

                        nomeFile = randomString;
                        filePath = $@"c:\Users\gdema\Desktop\csharp\{nomeFile}.txt";
                        File.WriteAllText($"{filePath}",contenutoFile);
       
                        break;
                    case Opzioni.Si:
                        File.WriteAllText($"{filePath}", contenutoFile);
      
                        Console.WriteLine("Il file è stato sovrascritto");
                        break;
                }

            }
            else
            {
                File.WriteAllText($"{filePath}", contenutoFile);
            }

        }
    }
}