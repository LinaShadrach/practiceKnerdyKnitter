using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KnerdyKnitter.Models
{
    public class Garment
    {
        public static string[] BaseCombos { get; set; }
        public string[][] AllRows { get; set; }
        public string[] ChosenRule { get; set; }
        public int Dimension { get; set; }
        public Garment(string[] chosenRule, int dimension = 30)
        {
            ChosenRule = chosenRule;
            Dimension = dimension;
            AllRows = new string[Dimension][];
            BaseCombos = new string[8];
            BaseCombos[0] = "111";
            BaseCombos[1] = "110";
            BaseCombos[2] = "101";
            BaseCombos[3] = "100";
            BaseCombos[4] = "011";
            BaseCombos[5] = "010";
            BaseCombos[6] = "001";
            BaseCombos[7] = "000";
        }
        public void MakeGarment(string[] currentRow, int dimension)
        {
            if(dimension > 0)
            {
                string[] nextRow = GetNextRow(currentRow);
                AllRows[(Dimension - dimension)] = nextRow;
                MakeGarment((nextRow), dimension - 1);
            }
        }
        public string[] GetNextRow(string[] currentRow) {
            string[] nextRow = new string[currentRow.Length];
            for (var i = 0; i < currentRow.Length; i++)
            {
                var key = "";
                if (i == 0)
                {
                    key = key + currentRow[currentRow.Length-1];
                }
                else
                {

                    key = key + currentRow[i - 1];
                }
                key = key + currentRow[i];
                if (i == (currentRow.Length - 1))
                {
                    key = key + currentRow[0];
                }
                else
                {
                    key = key + currentRow[i + 1];
                }
                var keyIndex = Array.IndexOf(BaseCombos, key);
                Debug.WriteLine(keyIndex);
                nextRow[i]=ChosenRule[keyIndex];
            }
            return nextRow;
        }



        //var count = 20;
        //var scarf = [];
        //function rows(count, row) {
        //    if (count > 0)
        //    {
        //        scarf.push(row);
        //        rows(count - 1, getNextRow(rules[30], row));
        //    }
        //}
    }
}
