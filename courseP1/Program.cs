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
            // Вот что в шарпе мне не зашло так это строгое разграничение по строкам (в прочем, как и везде).
            // Однако в Lua можно сделать вот так:
            // 
            // local text = "Хоффман развил свою предыдущую работу по моделированию TFT [27]
            // исследованиями на DC (постоянном токе) до модели тонкопленочного транзистора с длинным каналом,
            // что очень важно при расчете зависимости подвижности от напряжения на затворе [46]."
            //
            // тейблы тоже можно так делать
            //
            // JMod.EZ_GRADE_UPGRADE_COSTS = {.5, 1, 1.5, 2}
            //
            // JMod.PrimitiveResourceTypes = {
            //      ["wood"] = { JMod.EZ_RESOURCE_TYPES.WOOD },
            //      ["metal"] = { JMod.EZ_RESOURCE_TYPES.ALUMINUM, JMod.EZ_RESOURCE_TYPES.COPPER, JMod.EZ_RESOURCE_TYPES.STEEL },
            //      ["rock"] = { JMod.EZ_RESOURCE_TYPES.CONCRETE, JMod.EZ_RESOURCE_TYPES.CERAMIC }
            // }
            //
            //
            // PrintTextInFrame( text )
            //
            string text = "Хоффман развил свою предыдущую работу по моделированию TFT [27] исследованиями на DC (постоянном токе) до модели тонкопленочного транзистора с длинным каналом, что очень важно при расчете зависимости подвижности от напряжения на затворе [46].";
            // 
            PrintTextInFrame(text);
        }
        static void PrintTextInFrame(string text)
        {
            // чтобы не писать кучу \n
            string[] lines = WrapText(text, Console.WindowWidth - 6);
            //
            int maxLength = 0;
            foreach (string line in lines)
            {
                // Капец Intellisense стал умный, строку как я и хотел предугадал
                if (line.Length > maxLength) maxLength = line.Length;
            }
            // Стырил с какого-то сайта крутые символы ╔ ╗ ║ ╚ ╝ ═ (это не равно) даже не знал что такие в юникоде есть
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
