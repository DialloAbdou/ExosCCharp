// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Namespace;

Console.WriteLine("Hello, World!");

Console.WriteLine(" Traitement des différents Exercices");

var t = Exercice1.Main();

Console.WriteLine($"name: {t.Item1}, age : {t.Item2} , weight : {t.Item3}, isHuman: {t.Item4}");

Console.WriteLine("===DisplayCompute===");
Exercice1.ComputeAndDisplay(10,2);
Exercice1.ComputeAndDisplay(21,21);
Exercice1.ComputeAndDisplay(99,3);

Console.WriteLine("Correction du problème de typage");
// appelle de function Divide
var divise = Exercice1.Divide(10,3);

Console.WriteLine($"la division est : {divise}");

//condition qui vérifie l'age 

Console.WriteLine($"condition qui vérifie l'âge: {Exercice1.CheckAge(17)}");

//Le Jeu de FizzBuzz

// Console.WriteLine("le de FizzBuzz");

// Exercice1.fn_fizzbuzz();

// Création d'un tableau
var tab =  Exercice1.GetTabStr();
Console.WriteLine(" Creation tableau");
foreach( string t1 in tab)
{
    Console.WriteLine($"{t1}");
}

// fonction string
var bonjour = Exercice1.SayHello("Abdoou");

Console.WriteLine(bonjour);

var phrase = Exercice1.RemoveAtPosition("bonjour",1);
Console.WriteLine(phrase);