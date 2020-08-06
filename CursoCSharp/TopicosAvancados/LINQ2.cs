using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "André", Idade = 21, Nota = 4.3},
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5},
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5},
                new Aluno() {Nome = "Márcio", Idade = 18, Nota = 6.8}
            };

            //caso você pedir um nome inexistente dará um erro.
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            //Neste caso se não existir dará a mensagem "Aluno Inexistente".
            var fulano = alunos.SingleOrDefault(Aluno => Aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno Inexistente!!!");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefault(
                aluno => aluno.Nota.Equals("Sicrano"));
            if (sicrano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);

            //media somente dos alunos aprovados
            var mediaDaTurmaAprovados = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurmaAprovados);
        }
    }
}
