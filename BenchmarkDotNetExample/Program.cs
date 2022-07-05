// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using BenchmarkDotNetExample;

Console.WriteLine("Hello, World!");

//Run on Release to results
BenchmarkRunner.Run<PalindromeHandler>();