using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KnerdyKnitter.Models
{
    public static class Rules
    {
        public static string[][] AllRules { get; set; }
        public static int Count { get; set; }
        public static int Power { get; set; }
        public static void MakeRules(){
            AllRules = new string[256][];
            Power = 128;
            GetAllRules();
        }
        
        public static string[] GetRule(string[] rule, int count, int power)
        {
            if (power == 0)
            {
                return rule;
            }
            else
            {
                int index = Array.IndexOf(rule, null);
                if ((count - power) >= 0)
                {
                    rule[index] = "1";
                    count = count - power;
                }
                else
                {
                    rule[index] = "0";
                }
                if (power == 1)
                {
                    power = 0;
                }
                power = power / 2;
                return GetRule(rule, count, power);
            }
        }

        public static void GetAllRules()
        {
            int count;
            int power = 128;
            for (var i = 0; i < 256; i++)
            {
                count = i;
                string[] rule = new string[8];
                rule = GetRule(rule, count, power);
                AllRules[i] = rule;
            }
        }
    }
}
