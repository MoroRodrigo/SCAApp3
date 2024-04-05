using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAApp3.Model
{
    public class Turma
    {
        public int Codigo { get; set; }
        private List<Aluno> alunos = new List<Aluno>();
        private Professor professor;
        private Disciplina disciplina;

        public string AddAluno(Aluno aluno)
        {
            if (alunos.Count >= 50)
                return "Limite de alunos excedido para esta turma.";

            alunos.Add(aluno);
            return "Aluno adicionado à turma.";
        }

        public void AddProfessor(Professor prof)
        {
            professor = prof;
        }

        public void AddDisciplina(Disciplina disc)
        {
            disciplina = disc;
        }

        public bool AbrirTurma()
        {
            return alunos.Count >= 10 && alunos.Count <= 50;
        }

        public string GerarPauta()
        {
            return $"Pauta da Turma {Codigo}\nDisciplina: {disciplina.Nome}\nProfessor: {professor.Nome}\n";
        }
    }

}
