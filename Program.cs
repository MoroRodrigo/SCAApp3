using SCAApp3.Model;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando instâncias das classes
        Aluno aluno1 = new Aluno { Matricula = 1, Nome = "Aluno 1" };
        Aluno aluno2 = new Aluno { Matricula = 2, Nome = "Aluno 2" };
        Professor profJava = new Professor { Matricula = 101, Nome = "João" };
        Professor profNet = new Professor { Matricula = 102, Nome = "José" };
        Disciplina disciplinaJava = new Disciplina { Codigo = 1, Nome = "Java" };
        Disciplina disciplinaNet = new Disciplina { Codigo = 2, Nome = ".Net" };

        // Criando turmas
        Turma turmaJava = new Turma { Codigo = 1 };
        turmaJava.AddProfessor(profJava);
        turmaJava.AddDisciplina(disciplinaJava);

        Turma turmaNet = new Turma { Codigo = 2 };
        turmaNet.AddProfessor(profNet);
        turmaNet.AddDisciplina(disciplinaNet);

        // Adicionando alunos às turmas
        Console.WriteLine(turmaJava.AddAluno(aluno1)); // Deve imprimir "Aluno adicionado à turma."
        Console.WriteLine(turmaJava.AddAluno(aluno2)); // Deve imprimir "Aluno adicionado à turma."
        Console.WriteLine(turmaNet.AddAluno(aluno1)); // Deve imprimir "Aluno adicionado à turma."

        // Gerando pautas das turmas
        Console.WriteLine(turmaJava.GerarPauta());
        Console.WriteLine(turmaNet.GerarPauta());

        // Exibindo turmas dos alunos e dos professores
        Console.WriteLine(aluno1.ExibirTurmas());
        Console.WriteLine(profNet.ExibirTurmas());

        // Exibindo turmas das disciplinas
        Console.WriteLine(disciplinaNet.ExibirTurmas());
    }
}
