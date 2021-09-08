using System;

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Adjective:");
string adjective = Console.ReadLine();
Console.Clear();

Console.WriteLine("Adverb:");
string adverb = Console.ReadLine();
Console.Clear();

Console.WriteLine("Noun 1:");
string noun1 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Noun 2:");
string noun2 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Noun 3:");
string noun3 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Noun 4:");
string noun4 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Noun 5:");
string noun5 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Noun 6:");
string noun6 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Plural Noun 1:");
string pNoun1 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Plural Noun 2:");
string pNoun2 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Plural Noun 3:");
string pNoun3 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Plural Noun 4:");
string pNoun4 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Plural Noun 5:");
string pNoun5 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Verb 1:");
string verb1 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Verb 2:");
string verb2 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Word Beginning with M:");
string mWord = Console.ReadLine();
Console.Clear();

Console.WriteLine($"If you want to become {noun1} literate, here are some key");
Console.WriteLine($"{pNoun1} that you should {verb1} as quickly as possible:");
Console.WriteLine();
Console.WriteLine($"CD ROM: Stands for compact {noun2}... read only");
Console.WriteLine($"{mWord}. This compact disc can hold as many as 600"); 
Console.WriteLine($"{pNoun2}, which is the equivalent of 700 floppy {pNoun3}.");
Console.WriteLine();
Console.WriteLine($"CYBERSPACE: Stands for the imaginary {noun3} that people");
Console.WriteLine($"enter when they {verb2} with each other through computers on");  
Console.WriteLine($"a collection of {pNoun4}, known as the Inter{noun4}.");
Console.WriteLine();
Console.WriteLine($"E-Mail: Means {adverb} transmitted {noun5}.");
Console.WriteLine();
Console.WriteLine($"MODEM: Is the device that allows a {adjective} computer to");
Console.WriteLine($"transmit {pNoun5} over a phone {noun6}.");

Console.ReadLine();