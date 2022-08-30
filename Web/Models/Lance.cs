namespace Web.Models;
public class Lance
{
    private readonly Usuario usuario;
    private readonly double valor;
    public Usuario Usuario => usuario;
    public double Valor => valor;
    
    public Lance(Usuario usuario, double valor)
    {
        this.usuario = usuario;
        this.valor = valor;
    }
}