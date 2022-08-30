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

        private const int ID = 11;

        [SetUp]
        public void Init()
        {
            var database = "C:\\Users\\gomes\\Workspace\\Leilao\\Tests\\data\\test.db";
            context = new LeilaoContext(database);
            usuarios = new UsuariosEmBancoDeDados(context);
        }
        [Test]
        public void UsuariosEmBancoDeDados_Inclui_DeveRetornarOMesmoUsuarioIncluido()
        {
            // Arranjo
            var esperado = new Usuario(ID, "Jobs");

            // Ação
            usuarios.Inclui(esperado);
            usuarios.Salve();

            // Asserção
            var retornado = usuarios.ListaPorId(ID);
            Assert.AreEqual(esperado.Id, retornado.Id);
            Assert.AreEqual(esperado.Nome, retornado.Nome);
        }

        [TearDown]
        public void Cleanup()
        {
            usuarios.Remove(ID);
            usuarios.Salve();
        }
    }
}