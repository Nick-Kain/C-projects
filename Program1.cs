using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var MyText = Clipboard.GetText().Split('.', ',', ';', ':', '?', '!', '\n', '\r', ' ');
            if (MyText.Length == 1)
            {
                Console.WriteLine("Буфер пуст, либо содержит одно слово. Нечего делать.");
            }
            else
            {
                MyText.Take(1000).Distinct().OrderBy(s => s, StringComparer.OrdinalIgnoreCase).Where(s => !string.IsNullOrEmpty(s)).ToList().ForEach(Console.WriteLine);
            }
            Console.ReadKey();
        }
    }
}