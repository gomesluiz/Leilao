using NUnit.Framework;

using Web.Models;
using Web.Persistence.Repositories;

namespace Tests.Persistence.Repositories
{
    [TestFixture]
    public class UsuariosTest
    {
        private LeilaoContext context;
        private UsuariosEmBancoDeDados usuarios;
        [SetUp]
        public void Init()
        {
            var database = "c:\\Users\\gomes\\Workspace\\Leilao\\Tests\\data\\test.db";
            context = new LeilaoContext(database);
            usuarios = new UsuariosEmBancoDeDados(context);
        }
        [Test]
        public void UsuariosEmBancoDeDados_Inclui()
        {
            // Arranjo
            var esperado = new Usuario(11, "Jobs");

            // Ação
            usuarios.Inclui(esperado);
            usuarios.Salve();

            // Asserção
            var retornado = usuarios.ListaPorId(11);
            Assert.AreEqual(esperado.Id, retornado.Id);
            Assert.AreEqual(esperado.Nome, retornado.Nome);
        }

        [TearDown]
        public void Cleanup()
        {
            usuarios.Remove(11);
            usuarios.Salve();
        }
    }
}