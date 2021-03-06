﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var characterName = Console.ReadLine();
            var characterHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var characterEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            string healthBar = buildStatBar(characterHealth, maxHealth);
            string energyBar = buildStatBar(characterEnergy, maxEnergy);
            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Health: {healthBar}");
            Console.WriteLine($"Energy: {energyBar}");
        }

        public static string buildStatBar(int statValue, int barMaxValue)
        {
            string statBar = "|" + new string('|', statValue) + new string('.', barMaxValue - statValue) + "|";
            return statBar;
        }
    }
}
