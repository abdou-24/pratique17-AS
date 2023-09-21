// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quel est votre nom?");

string line = Console.ReadLine();

Console.WriteLine("Bienvenue " + line + " à l'application !");

Console.WriteLine("Entrer votre température en Celsius ! ");
double temperature = Convert.ToDouble(Console.ReadLine());
double temperatureEnFahrenheit = temperature * 9 / 5 + 32;
Console.WriteLine("Votre température en Fahrenheit est {temperatureEnFahrennheit}");