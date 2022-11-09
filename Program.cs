﻿using ExemploExplorando.Models;
using System.Globalization;

string dataString = "2022-04-170 18:00";

bool sucesso = DateTime.TryParseExact(dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, out DateTime data);

if(sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida.");
}









//DateTime data = DateTime.Parse("17/04/2022 18:00");
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());





























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 1582.40M;

// //Console.WriteLine($"{valorMonetario:C}");
// //Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));






























// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);




















// Pessoa p1 = new Pessoa(nome: "Bruno", sobrenome: "Mota");

// Pessoa p2 = new Pessoa(nome: "Bruno", sobrenome: "Oliveira");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();
































// Pessoa p1 = new Pessoa();
// p1.Nome = "Bruno";
// p1.Sobrenome = "Mota";
// p1.Idade = 31;
// //p1._nome = "";

// p1.Apresentar();