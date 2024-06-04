using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraBasica
    {
        private List<string> historicoLista;

        public CalculadoraBasica(){
            historicoLista = new List<string>();
        }
        public int Somar(int n1, int n2)
        { 
            int resultado = n1 + n2;
            historicoLista.Insert(0, "Res:" + resultado);
            return resultado;
        }

        public int Subtrair(int n1, int n2)
        {
            int resultado = n1 - n2;
            historicoLista.Insert(0, "Res:" + resultado);
            return resultado;
        }

        public int Multiplicar(int n1, int n2)
        {
            int resultado = n1 * n2;
            historicoLista.Insert(0, "Res:" + resultado);
            return resultado;
        }

        public decimal Dividir(decimal n1, decimal n2)
        {
            if(n2 == 0)
            {
                throw new DivideByZeroException("Não é possivel dividr por zero.");
            }
            decimal resultado = n1 / n2;
            historicoLista.Insert(0, "Res:" + resultado.ToString("N2"));
            return resultado;
        }
        public decimal Porcentagem(decimal n1, decimal n2)
        {
            decimal resultado = (n1 / 100) * n2;
            historicoLista.Insert(0, "Res:" + resultado);
            return resultado;
        }

        public List<string> Historico()
        {
            if (historicoLista.Count > 3)
        {
            historicoLista.RemoveRange(3, historicoLista.Count - 3);
        }
            return historicoLista;
        }
    }
}