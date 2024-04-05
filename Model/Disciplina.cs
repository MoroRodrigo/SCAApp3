using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAApp3.Model
{
    public class Disciplina
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        private List<Turma> turmas = new List<Turma>();

        public void AddTurma(Turma turma)
        {
            turmas.Add(turma);
        }

        public string ExibirTurmas()
        {
            string result = $"Turmas da Disciplina {Nome}:\n";
            foreach (var turma in turmas)
            {
                result += $"Turma: {turma.Codigo}\n";
            }
            return result;
        }
    }
}
