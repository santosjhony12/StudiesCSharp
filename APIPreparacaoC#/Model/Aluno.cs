using System;

class Aluno
{
    private string nome { get; set; };
    private string email { get; set; };
    private string emailFatec { get; set; };
    private string emailOrientador { get; set; };
    private int idPeriodo { get; set; };
    private List<Nota> notas =  new List<Nota>();

    public List<Nota> buscarTodasNotas()
    {
        return notas;
    }
    public void addNota(Nota nota)
    {
        notas.Add(nota);
    }
}