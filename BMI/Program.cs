using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Initialization text color
                Console.ForegroundColor = ConsoleColor.White;

                // Enter Height and Convert it
                Console.WriteLine("請輸入身高  單位cm");
                float height = Convert.ToInt32(Console.ReadLine());
                height /= 100; //Change cm to m

                // Enter Weight and Convert it
                Console.WriteLine("請輸入體重  單位kg");
                float weight = Convert.ToInt32(Console.ReadLine());

                // Cauculate BMI(ans)
                float ans = weight / (height * height);
                // 過輕或過重需計算離正常體重差距
                Double normalWeight = 0;

                // Overweight Skinny or normal   and change text color by your BMI Rank
                if (ans < 18.5)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    // Judge have military service or not
                    if (ans < 16.5)
                    {
                        Console.WriteLine("免役");
                    }
                    // 計算離正常體重差多少
                    normalWeight = (18.5 - ans) * (height * height);
                    Console.WriteLine("\r\n過輕  離正常BMI需再增重" + normalWeight.ToString("#0.00") + "公斤\r\n");
                }
                else if (ans < 24)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\r\n正常！  請繼續保持\r\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    // Judge have military service or not
                    if (ans > 31.5)
                    {
                        Console.WriteLine("免役");
                    }
                    // 計算離正常體重差多少
                    normalWeight = (ans - 24) * (height * height);
                    Console.WriteLine("\r\n過重  離正常BMI需再減重" + normalWeight.ToString("#0.00") + "公斤\r\n");
                }

                // Print in format 0.00  Blank line for good watching
                Console.WriteLine("\r\nBMI為" + ans.ToString("#0.00") + "\r\n");

                // Set text color to white
                Console.ForegroundColor = ConsoleColor.White;
                
                // Whether user want to continue   Judge by "n"
                Console.WriteLine("輸入n離開或按任意鍵繼續");
                if (Console.ReadLine() == "n")
                {
                    break;
                }
            }
        }
    }
}
