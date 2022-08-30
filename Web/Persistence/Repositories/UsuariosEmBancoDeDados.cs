using Web.Models;

namespace Web.Persistence.Repositories
{
    public class UsuariosEmBancoDeDados : Usuarios, IDisposable
    {
        private LeilaoContext context;
        public UsuariosEmBancoDeDados(LeilaoContext context)
        {
            this.context = context;
        }

        public void Atualiza(Usuario usuario)
        {
            context.Entry(usuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Inclui(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
        }

        public Usuario ListaPorId(int id)
        {
            return context.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> ListaTodos()
        {
            return context.Usuarios.ToList();
        }

        public void Remove(int id)
        {
            Usuario usuario = context.Usuarios.Find(id);
            context.Usuarios.Remove(usuario);
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

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}