using System;

class Sistema
{
    private List<Aluno> alunos = new List<Aluno>();
    private List<Orientador> orientadores = new List<Orientador>();
    private List<Entrega> entregas = new List<Entrega>();
    private List<Periodo> periodos = new List<Periodo>();

    public List<Aluno> buscarTodosAlunos()
    {
        return alunos;
    }
    public Aluno buscarAlunoPorEmail(string email)
    {
        foreach(Aluno aluno in alunos)
        {
            if(aluno.Email == email)
            {
                return aluno;
            }
        }
        return null;
    }
    public List<Orientador> buscarTodosOrientadores()
    {
        return orientadores;
    }
    public Orientador buscarOrientadorPorEmail(string email)
    {
        foreach(Orientador orientador in orientadores)
        {
            if(orientador.Email == email)
            {
                return orientador;
            }
        }
        return null;
    }

    public void addAluno(Aluno aluno)
    {
        alunos.Add(aluno);
    }
    public void addOrientador(Orientador orientador)
    {
        orientadores.Add(orientador);
    }
    public void addEntrega(Entrega entrega)
    {
        entregas.Add(entrega);
    }
    public List<Periodo> buscarTodosPeriodos()
    {
        return periodos;
    }
    public void addPeriodo(Periodo periodo)
    {
        periodos.Add(periodo);
    }
}