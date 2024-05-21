using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Testes
{
    public class Calculadora
    {
        private List<string> historico;

        public Calculadora()
        {
            historico = new List<string>();
        }

        public int Somar(int n1, int n2)
        {
            historico.Insert(0, $"{n1} + {n2} = {n1 + n2}");
            return n1 + n2;
        }

        public int Subtrair(int n1, int n2)
        {
            historico.Insert(0, $"{n1} - {n2} = {n1 - n2}");

            return n1 - n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            historico.Insert(0, $"{n1} * {n2} = {n1 * n2}");

            return n1 * n2;
        }

        public int Dividir(int n1, int n2)
        {
            historico.Insert(0, $"{n1} / {n2} = {n1 / n2}");

            return n1 / n2;
        }

        public List<string> HistoticoDeOperacoes()
        {
            return new List<string>() { historico[0], historico[1], historico[2] };
        } 
    }
}
