// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your bending type?"); //output
var element= Console.ReadLine(); //input

Console.WriteLine("Where are you from?"); //output
var homeland= Console.ReadLine(); //input

Console.WriteLine("What is your companion animal?"); //output
var guide= Console.ReadLine(); //input  

Console.WriteLine("what is your secondary bending type?"); //output 
var subtype= Console.ReadLine(); //input

Console.WriteLine($"You are a {element} bender from {homeland} and your companion is a {guide}. You are skilled at {subtype} bending.");