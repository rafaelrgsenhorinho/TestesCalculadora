using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _valid;

        public ValidacoesStringTests()
        {
            _valid = new ValidacoesString();
        } 

        [Fact]
        public void Contar3CaracteresEmOlaERetornar()
        {
            string texto = "Ola";

            int resultado = _valid.ContarCaracteres(texto);

            Assert.Equal(3, resultado);
        }
    }
}