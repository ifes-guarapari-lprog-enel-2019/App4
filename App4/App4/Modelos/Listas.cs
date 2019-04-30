using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Modelos
{
    static class Listas
    {
        // lista de alunos
        public static List<Aluno> Alunos = new List<Aluno>();

        // vetor de disciplinas
        public static Disciplina[] Disciplinas = new Disciplina[4]
        {
            new Disciplina("Cálculo 1", 1, 1),
            new Disciplina("Introdução a Engenharia", 2, 2),
            new Disciplina("Cálculo 2", 3, 3),
            new Disciplina("Projetos de Engenharia", 4, 4)
        };
    }
}
