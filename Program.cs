﻿Console.WriteLine("Pet Hotel Check-in\n");

Console.Write("Espécie......: ");
string especie = Console.ReadLine()!;

Console.Write("Raça.........: ");
string raca = Console.ReadLine()!;

Console.Write("Alcunha......: ");
string alcunha = Console.ReadLine()!;

Console.Write("Idade (anos).: ");
string idade = Console.ReadLine()!;

Console.Write("Pelagem/cor..: ");
string pelagemCor = Console.ReadLine()!;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("+=========================================================+");
Console.Write("|                 ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Pet Hotel \"Nem um pio\"");
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("                  |");

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("+=========================================================+");
Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.Black;
Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("+=========================================================+");
Console.Write("| Atende pela alcunha de: ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write(alcunha.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(" |");
Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
Console.ForegroundColor = ConsoleColor.Black;
Console.Write(" | Pelagem/cor: ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write(pelagemCor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.Black;
Console.Write("+=========================================================+");

Console.ResetColor();

