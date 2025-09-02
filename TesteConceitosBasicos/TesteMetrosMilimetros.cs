using ConceitosBasicos.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class TesteMetrosMilimetros
    {
        [TestMethod]
        public void TestMetros()
        {
            //cenario
            int metros = 10;
            int milimetro;

            //ação
            milimetro = MetrosMilimetros.Converter(metros);

            //verificação
            Assert.AreEqual(10000, milimetro);

        }
    }
}