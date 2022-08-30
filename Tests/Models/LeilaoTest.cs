using NUnit.Framework;
using Web.Models;

namespace Tests
{
    [TestFixture]
    public class LeilaoTest
    {
        [Test]
        public void Leilao_ComNenhumaPropostaDeLancamento_EsperaseUmQuantidadeDeLancesIgualAZero()
        {
            //Arranjo
            var leilao = new Leilao(1, "Asus X509D");
            var gates  = new Usuario(1, "Bill Gates");
            var esperado = 0;

            //Ação
            var retornado = leilao.Lances.Count;

            //Asserção
            Assert.AreEqual(esperado, retornado);
        }
    }
}