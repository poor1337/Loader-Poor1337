using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string src = "ABCDEFGHIJKLMAOPQRUSTUVWXYZ1234567890";
            int length = 16;
            var sb = new StringBuilder();
            Random RNG = new Random();
            for (var i = 0; i < length; i++)
            {
                var c = src[RNG.Next(0, src.Length)];
                sb.Append(c);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Process.Start("winver.exe");
            var processes = Process.GetProcessesByName("winver");
            Thread.Sleep(450);
            foreach (var process in processes)
                process.Kill();
            Console.Title = (sb.ToString());
            t("poor1337 C# Loader Tut, https://discord.gg/xhjjm2sarU Enjoy!");
            Console.ReadKey(); 
        }
        static void t(string message) //typewrite effect
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]); //Writes The Message Ofc
                System.Threading.Thread.Sleep(35); //delay of speed
            }
        }
                static string random_string()
                {
                    string str = null;

                    Random random = new Random();
                    for (int i = 0; i < 5; i++)
                    {
                        str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
                    }
                    return str;
                }
            }
        }
    