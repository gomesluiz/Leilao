namespace Web.Models
{
    public class Usuario
    {
        private int id;
        private String nome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        public Usuario(int id, string nome)
        {
            this.nome = nome;
            this.id = id;
        }
    }
}