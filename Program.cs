﻿using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Bruno";
p1.Sobrenome = "Mota";

Pessoa p2 = new Pessoa();
p2.Nome = "Bruno";
p2.Sobrenome = "Oliveira";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
































// Pessoa p1 = new Pessoa();
// p1.Nome = "Bruno";
// p1.Sobrenome = "Mota";
// p1.Idade = 31;
// //p1._nome = "";

// p1.Apresentar();