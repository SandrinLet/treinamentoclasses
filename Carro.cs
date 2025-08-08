using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoClasses
{
    internal class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;
        public string Cor;
        public double VelocidadeAtual;


        public void Acelerar()


        {
            while (VelocidadeAtual <= 200)
            {
                VelocidadeAtual += 10;

                Console.WriteLine($"Acelerando: {VelocidadeAtual} km/h");

            }


        }


        public void Frear()
        {
            while (VelocidadeAtual != 0)
            {

                VelocidadeAtual -= 10;
                Console.WriteLine($"Acelerando: {VelocidadeAtual} km/h");

            }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Marca: {Marca} " +
                $"Modelo {Modelo} " +
                $"Ano {Ano} " +
                $" Cor {Cor} " +
                $" Velocidade Atual : {VelocidadeAtual} ");
        
}   }    }

