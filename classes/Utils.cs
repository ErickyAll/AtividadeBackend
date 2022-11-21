using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeBackend.classes
{
  public static class Utils
  {
    public static void loading(string text)
    {
      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Write($"{text}");

      for (int i = 0; i < 6; i++)
      {
        Thread.Sleep(300);
        Console.Write($".");
      }

      Console.ResetColor();
    }
  }
}