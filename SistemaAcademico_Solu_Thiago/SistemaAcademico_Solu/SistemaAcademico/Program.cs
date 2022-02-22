using System;
using SistemaAcademico.Model;

namespace SistemaAcademico
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno objAluno = new Aluno(); //Aluno() método construtor
            Professor joao = new Professor();
            Carros Evo = new Carros();
            Carros Gol = new Carros();

            
            objAluno.CPF = 46465564;
            objAluno.dataNascimento = DateTime.Now;
            objAluno.nome = "Maria";
            objAluno.RG = 1234567;
            objAluno.sexo = "Masculino";
            objAluno.endereco = "Rua Joao";
            objAluno.telefone = "9999999999";

            joao.CPF = 2124578635;
            joao.nome = "João Pedro";
            joao.RG = 124124214;
            joao.sexo = "Masculino";
            joao.endereco = "Rua Nunca nem vi";
            joao.telefone = "9999999999";

            Evo.nome = "Lancer Evolution";
            Evo.marca = "Mitsubishi";
            Evo.cor = "Branco";
            Evo.tipo = "Esportivo";
            Evo.km = 12000000;

            Gol.nome = "Gol G5";
            Gol.marca = "Volkswagen";
            Gol.cor = "Vermelho";
            Gol.tipo = "Casual";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Evo.nome);
            Console.WriteLine();
            Console.WriteLine(Evo.marca);
            Console.WriteLine();
            Console.WriteLine(Evo.cor);
            Console.WriteLine();
            Console.WriteLine(Evo.tipo);
            Console.WriteLine();
            Console.WriteLine(Evo.km);
            Console.WriteLine();

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Gol.nome);
            Console.WriteLine();
            Console.WriteLine(Gol.marca);
            Console.WriteLine();
            Console.WriteLine(Gol.cor);
            Console.WriteLine();
            Console.WriteLine(Gol.tipo);
            Console.WriteLine();

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(objAluno.CPF);
            Console.WriteLine();
            Console.WriteLine(objAluno.nome);
            Console.WriteLine();
            Console.WriteLine(objAluno.RG);
            Console.WriteLine();
            Console.WriteLine(objAluno.sexo);
            Console.WriteLine();
            Console.WriteLine(objAluno.endereco);
            Console.WriteLine();
            Console.WriteLine(objAluno.telefone);


            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(joao.CPF);
            Console.WriteLine();
            Console.WriteLine(joao.nome);
            Console.WriteLine();
            Console.WriteLine(joao.RG);
            Console.WriteLine();
            Console.WriteLine(joao.sexo);
            Console.WriteLine();
            Console.WriteLine(joao.endereco);
            Console.WriteLine();
            Console.WriteLine(joao.telefone);

            Console.ReadKey();

        }
    }
}
