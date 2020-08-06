using System;
//using System.Collections.Generic;
using System.IO;
//using System.Text;

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        /*
         * Este método faz com que o programa identifique se é um:
         * mac, linux ou windows. E de acordo com o qual ramifica a onde
         * será colocado o arquivo;
         */
        public  static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix |
                    Environment.OSVersion.Platform == PlatformID.MacOSX)
                    ? Environment.GetEnvironmentVariable("HOME")
                    : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    class PrimeiroArquivo
    {
        public static void Executar()
        {
            // Substitui o "~" pelo método ParseHome
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                //Cria um arquivo e add texto.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }

            // Adiciona mais textos no arquivo criado
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }

        }
    }
}
