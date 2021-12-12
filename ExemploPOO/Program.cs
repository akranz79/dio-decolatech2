using System;
using ExemploPOO.Helper;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program

    {
        static void Main(String[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";

            FileHelper helper = new FileHelper();
            helper.ListarDiretorios(caminho);


            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(10, 30);
            // System.Console.WriteLine($"Area: {r.ObterArea()}");


            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Alexandre";
            // p1.Idade = 42;

            // p1.Apresentar();
        }
    }
}
