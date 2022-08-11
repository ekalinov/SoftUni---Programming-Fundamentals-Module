using System;
using System.Collections.Generic;

namespace _0003.Heroes_of_Code_and_Logic_VII
{
    public class Hero
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input;
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            var heroesNames = new List<Hero>(n);


            for (int i = 0; i < n; i++)
            {
                string[] heroArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string heroName = heroArgs[0];

                heroes.Add(heroName, new Hero { Name = $"{heroName}" });

                heroes[heroName].HP = int.Parse(heroArgs[1]);
                heroes[heroName].MP = int.Parse(heroArgs[2]);

            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
                string heroName;


                switch (command)
                {
                    case "CastSpell":
                        //"CastSpell – {hero name} – {MP needed} – {spell name}"
                        //  •	If the hero has the required MP, he casts the spell, thus reducing his MP.Print this message:
                        //       o"{hero name} has successfully cast {spell name} and now has {mana points left} MP!"
                        //  •	If the hero is unable to cast the spell print:
                        //       o"{hero name} does not have enough MP to cast {spell name}!"
                        heroName = commandArgs[1];
                        int mpNeeded = int.Parse(commandArgs[2]);
                        string spellName = commandArgs[3];


                        if (heroes[heroName].MP >= mpNeeded)
                        {
                            heroes[heroName].MP -= mpNeeded;

                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].MP} MP!");
                        }
                        else Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        break;
                    case "TakeDamage":
                        //"TakeDamage – {hero name} – {damage} – {attacker}"
                        //  •	Reduce the hero HP by the given damage amount.If the hero is still alive (his HP is greater than 0) print:
                        //       o  "{hero name} was hit for {damage} HP by {attacker} and now has {current HP} HP left!"
                        //  •	If the hero has died, remove him from your party and print:
                        //       o   "{hero name} has been killed by {attacker}!"

                        heroName = commandArgs[1];
                        int demage = int.Parse(commandArgs[2]);
                        string attacker = commandArgs[3];


                        heroes[heroName].HP -= demage;
                        if (heroes[heroName].HP > 0)
                        {
                            Console.WriteLine($"{heroName} was hit for {demage} HP by {attacker} and now has {heroes[heroName].HP} HP left!");
                        }
                        else Console.WriteLine($"{heroName} has been killed by {attacker}!");

                        break;
                    case "Recharge":
                        //"Recharge – {hero name} – {amount}"
                        //  •	The hero increases his MP.If it brings the MP of the hero above the maximum value(200), MP is increased to 200. (the MP can't go over the maximum value).
                        //  •	 Print the following message:
                        //      o   "{hero name} recharged for {amount recovered} MP!"
                        heroName = commandArgs[1];
                        int amount = int.Parse(commandArgs[2]);

                        heroes[heroName].MP += amount;

                        if (heroes[heroName].MP > 200)
                        {
                            amount -= Math.Abs(200-heroes[heroName].MP);
                            heroes[heroName].MP = 200;
                        }

                        Console.WriteLine($"{heroName} recharged for {amount} MP!");

                        break;
                    case "Heal":
                        //"Heal – {hero name} – {amount}"
                        //  •	The hero increases his HP.If a command is given that would bring the HP of the hero above the maximum value(100), HP is increased to 100(the HP can't go over the maximum value).
                        //  •	 Print the following message:
                        //      o   "{hero name} healed for {amount recovered} HP!"



                        heroName = commandArgs[1];
                        int amountHp = int.Parse(commandArgs[2]);

                        heroes[heroName].HP += amountHp;

                        if (heroes[heroName].HP > 100)
                        {
                            amountHp -= Math.Abs(100- heroes[heroName].HP);
                            heroes[heroName].HP = 100;
                        }

                        Console.WriteLine($"{heroName} healed for {amountHp} HP!");
                        break;
                }

            }

            foreach (var hero in heroes)
            {
                if (hero.Value.HP > 0)
                {

                    Console.WriteLine($"{hero.Key}");
                    Console.WriteLine($"  HP: {hero.Value.HP}");
                    Console.WriteLine($"  MP: {hero.Value.MP}");
                }
            }


        }
    }
}
