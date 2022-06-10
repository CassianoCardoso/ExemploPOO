using ExemploPOO.Interfaces;
using ExemploPOO.Models;




//-------INTERFACES----------------
ICalculadora calc = new Calculadora();
System.Console.WriteLine(calc.Somar(10, 20));




//----- CALSSES OBJECT -------------------
// Computador comp = new Computador();
// // System.Console.WriteLine(comp.ToString());


// ------CLASSES ABSTRATAS -------------------
// Corrente c = new Corrente();
// c.Creditar(100);


// c.ExibirSaldo();



//------POLIMORFISMO ----------------------
// Calculadora calc = new Calculadora();


// System.Console.WriteLine($"Resultado da primeira soma: {calc.Somar(10,10)} ");
// System.Console.WriteLine($"Resultado da segunda soma: {calc.Somar(10,10,20)} ");






//----HERANÇA----------------------------------------------------------------
// Aluno p1 = new Aluno();
// //p1.Salario = 2000;
// p1.Nome = "Carlos";
// p1.Idade = 20;
// p1.Documento = "1234";
// p1.Nota = 10;
// p1.Apresentar();

// Professor p2 = new Professor();
// p2.Nome = "Marias";
// p2.Idade = 20;
// p2.Documento = "1223";
// p2.Salario = 2000;
// p2.Apresentar( );







//--------Encapsulamento------------

// //VALORES VÁLIDOS---------------
// Retangulo r = new Retangulo();
// r.DefinirMedidas(30, 30);
// System.Console.WriteLine($"Área: {r.ObterArea()}");


// //VALORES INVALIDOS
// Retangulo r2 = new Retangulo();
// r2.DefinirMedidas(0, 0);
// System.Console.WriteLine($"Área: {r2.ObterArea()}");



//---------Abstração---------------------------
// Pessoa p1 = new Pessoa();

// p1.Nome = "Cassiano";
// p1.Idade = 20;

// p1.Apresentar();