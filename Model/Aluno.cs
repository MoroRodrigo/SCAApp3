using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAApp3.Model
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        private List<Turma> turmas = new List<Turma>();

        public string AddTurma(Turma turma)
        {
            if (turmas.Count >= 10)
                return "Limite de turmas excedido para este aluno.";

            turmas.Add(turma);
            return "Aluno adicionado à turma.";
        }

        public string ExibirTurmas()
        {
            string result = $"Turmas do Aluno {Nome}:\n";
            foreach (var turma in turmas)
            {
                result += $"Turma: {turma.Codigo}\n";
            }
            return result;
        }
    }

}
