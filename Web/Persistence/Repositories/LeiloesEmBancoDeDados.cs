using Web.Models;

namespace Web.Persistence.Repositories
{
    public class LeiloesEmBancoDeDados : Leiloes, IDisposable
    {
        private LeilaoContext context;
        public LeiloesEmBancoDeDados(LeilaoContext context)
        {
            this.context = context;
        }

        public void Atualiza(Leilao leilao)
        {
            context.Entry(leilao).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Inclui(Leilao leilao)
        {
            context.Leiloes.Add(leilao);
        }

        public Leilao ListaPorId(int id)
        {
            return context.Leiloes.Find(id);
        }

        public IEnumerable<Leilao> ListaTodos()
        {
            return context.Leiloes.ToList();
        }

        public void Remove(int id)
        {
            Leilao leilao = context.Leiloes.Find(id);
            context.Leiloes.Remove(leilao);
        }

        public void Salve()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}