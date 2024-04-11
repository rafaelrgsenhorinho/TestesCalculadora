using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {

        private List<string> listahistorico;

        public CalculadoraImp()
        {
            listahistorico = new List<string>();
        }
        public int Somar (int num1, int num2)
        {
            int res = num1 + num2;

            listahistorico.Insert(0, "Res: " + res);
            
            return res;
        }

        public int Subtrair (int num1, int num2)
        {
            int res = num1 - num2;

            listahistorico.Insert(0, "Res: " + res);
            
            return res;
        }

        public int Multiplicar (int num1, int num2)
        {
            int res = num1 * num2;

            listahistorico.Insert(0, "Res: " + res);
            
            return res;
        }

        public int Dividir (int num1, int num2)
        {
            int res = num1 / num2;

            listahistorico.Insert(0, "Res: " + res);
            
            return res;
        }
        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
    }
}