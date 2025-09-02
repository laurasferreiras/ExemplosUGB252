using ConceitosBasicos.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class TesteCalculaAumento
    {
        [TestMethod]
        public void TestAumento()
        {
            // cenario
            decimal salario = 5000;
            float aumento = 5;
            decimal novoSalario;
            CalculaAumento calcular = new CalculaAumento();

            // acao
            novoSalario = calcular.Calcular(salario, aumento);

            // verificacao
            Assert.AreEqual(250, novoSalario);

        }
    }
}
