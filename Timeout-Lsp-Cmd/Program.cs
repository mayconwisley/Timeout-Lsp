using System;
using System.Threading;

namespace Timeout_Lsp_Cmd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                int timeout = int.Parse(args[0]);
                for (int i = timeout; i > 0; i--)
                {
                    Console.WriteLine($"Aguardando... {i:00} segundos.");
                    if (i == 1)
                    {
                        Console.Clear();
                        Console.WriteLine($"Aguardando... {i:00} segundo.");
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine($"Aguardando... 01 segundo.");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
