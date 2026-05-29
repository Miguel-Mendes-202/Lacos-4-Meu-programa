﻿string ProsseguirProgramaTexto;
bool ProsseguirPrograma;

Console.WriteLine("Gostaria de Usar este Programa? Digite (Sim/Não) ");
ProsseguirProgramaTexto = Console.ReadLine()!;

ProsseguirPrograma = ProsseguirProgramaTexto.ToUpper().Substring(0,1) == "Sim";


if (ProsseguirProgramaTexto == "Sim")
{
string continuar = "s";

while(continuar == "s")
{
  Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Qual a Largura? ");
int Largura = Convert.ToInt32(Console.ReadLine());

Console.Write("Qual a Altura? ");
int Altura = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

string preenchimento = "*";

int contadorLinha = 0;
while (contadorLinha < Altura)
{
    int contadorColuna = 0;
    while(contadorColuna < Largura)
    {
        Console.Write(preenchimento);
        contadorColuna = contadorColuna + 1;
    }

    Console.WriteLine();
    contadorLinha = contadorLinha + 1;
}
Console.Write("Deseja executar Novament? (s/n)? ");
continuar = Console.ReadLine()!.ToLower();

}
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Fechando.");
    Console.ResetColor();
}