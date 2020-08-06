using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.Api
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/Documents/Cod3r/CursoCSharp/CursoCSharp/CursoCSharp".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("-----------Pastas-----------");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n---------Arquivos------------");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n---------------Raiz------------");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Console.WriteLine("\n\n---------------Mover------------");
            Directory.Move(novoDir, novoDirDestino);



        }
    }
}
