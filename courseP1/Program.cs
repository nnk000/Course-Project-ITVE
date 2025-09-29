using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Хоффман развил свою предыдущую работу по моделированию TFT [27] исследованиями на DC (постоянном токе) до модели тонкопленочного транзистора с длинным каналом, что очень важно при расчете зависимости подвижности от напряжения на затворе [46].";
            // 
            PrintTextInFrame(text);
        }
        static void PrintTextInFrame(string text)
        {
            //
            string[] lines = WrapText(text, Console.WindowWidth - 6);
            //
            int maxLength = 0;
            foreach (string line in lines)
            {
                //
                if (line.Length > maxLength) maxLength = line.Length;
            }
            // Для текста:
            // ╔ ╗ ║ ╚ ╝ ═ 
            // https://www.megacooltext.com/generator/big-letters/
            Console.WriteLine("╔" + new string('═', maxLength + 2) + "╗");

            foreach (string line in lines)
            {
                Console.WriteLine("║ " + line.PadRight(maxLength) + " ║");
            }

            Console.WriteLine("╚" + new string('═', maxLength + 2) + "╝");
        }
        static string[] WrapText(string text, int maxWidth)
        {
            string[] words = text.Split(' ');
            System.Collections.Generic.List<string> lines = new System.Collections.Generic.List<string>();
            string currentLine = "";

            foreach (string word in words)
            {
                if ((currentLine.Length + word.Length + 1) <= maxWidth)
                {
                    currentLine += (currentLine.Length == 0) ? word : " " + word;
                }
                else
                {
                    lines.Add(currentLine);
                    currentLine = word;
                }
            }
            if (!string.IsNullOrEmpty(currentLine))
                lines.Add(currentLine);
            return lines.ToArray();
        }
    }
}
