namespace Web.Models
{
    public interface Usuarios : IDisposable
    {
        IEnumerable<Usuario> ListaTodos();
        Usuario ListaPorId(int id);
        void Inclui(Usuario usuario);
        void Remove(int id);
        void Atualiza(Usuario usuario);
        void Salve();
    }
}
