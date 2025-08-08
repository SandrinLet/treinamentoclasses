// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoClasses
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Carro Brigadeirao = new Carro();
            Brigadeirao.Marca = "Fiat";
            Brigadeirao.Modelo = "Fiesta";
            Brigadeirao.Ano = 2006;
            Brigadeirao.Cor = "Preto";
            Brigadeirao.VelocidadeAtual = 20;
            Brigadeirao.ExibirDetalhes();
            Brigadeirao.Acelerar();


            Carro Tubarao = new Carro();
            Tubarao.Marca = "Honda";
            Tubarao.Modelo = "Civic";
            Tubarao.Ano = 2002;
            Tubarao.Cor = "Prata";
            Tubarao.VelocidadeAtual = 150;
            Tubarao.ExibirDetalhes();
            Tubarao.Frear();






        }
    }
}
