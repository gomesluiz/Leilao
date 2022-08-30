namespace Web.Models
{
    public interface Leiloes : IDisposable
    {
        IEnumerable<Leilao> ListaTodos();
        Leilao ListaPorId(int id);
        void Inclui(Leilao leilao);
        void Remove(int id);
        void Atualiza(Leilao leilao);
        void Salve();
    }
}


