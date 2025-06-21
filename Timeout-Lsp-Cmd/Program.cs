using System;
using System.Threading;

namespace Timeout_Lsp_Cmd
{
	internal class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 1)
			{
				Console.WriteLine("Uso incorreto. Apenas um argumento é esperado.");
				Console.WriteLine("Exemplo: Timeout_Lsp_Cmd 5");
				return;
			}

			int timeout;

			if (args.Length == 0)
			{
				timeout = 2;
			}
			else if (!int.TryParse(args[0], out timeout) || timeout < 1)
			{
				Console.WriteLine("Uso correto: Timeout_Lsp_Cmd <tempo_em_segundos>");
				Console.WriteLine("Exemplo: Timeout_Lsp_Cmd 5");
				return;
			}



			for (int i = timeout; i > 0; i--)
			{
				Console.Clear();
				string unidade = i == 1 ? "segundo" : "segundos";
				Console.WriteLine($"Aguardando... {i:00} {unidade}.");
				Thread.Sleep(1000);
			}
		}
	}
}
