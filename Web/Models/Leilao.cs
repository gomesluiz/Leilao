namespace Web.Models;

using System;
using System.Collections;

public class Leilao
{
    private int id;
    private String descricao;
    private ArrayList lances;
    public string Descricao { get => descricao; set => descricao = value; }
    public ArrayList Lances { get => lances; }
    public int Id { get => id; set => id = value; }

    public Leilao(int id, String descricao)
    {
        this.id = id;
        this.descricao = descricao;
        this.lances = new ArrayList();
    }

    public void Propoe(Lance lance)
    {
        lances.Add(lance);
    }
}