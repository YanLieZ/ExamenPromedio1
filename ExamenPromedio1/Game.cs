using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPromedio1
{
    internal class Game
    {

        public Player player;
        public Situation currentSituation;
        public Situation startSituation;

        public void StartGame()
        {
            bool play = true;

            while (play)
            {
                player.health = 100;
                currentSituation = startSituation;

                while(player.health > 0)
                {
                    currentSituation.ExecuteOption(player);

                    If(currentSituation == finalSituation) break;

                    for(int i = 0; i < currentSituation.options.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " . " + currentSituation.options[i].Text);
                    }

                    int choice = int.Parse(Console.ReadLine()) -1;

                    Option selected = currentSituation.options[choice];

                    player.health = player.health + selected.healthChange;

                    currentSituation = selected.nextSituation;
                }

                ShowEnding();

                Console.WriteLine("¿Jugar de nuevo? (s/n) ");
                string answer = Console.ReadLine().ToLower();

                if(answer != "y")
                {
                    play = false;
                }
            }
        }

        public void ShowEnding()
        {

            if(player.health <= 0)
            {
                Console.WriteLine("Bad ending...Moriste");
                return;
            }

            if(currentSituation == finalSituation)
            {
                finalSituation f = (finalSituation)currentSituation;

                if (f.endingType == "Good")
                {
                    Console.WriteLine("Final bueno");
                }
                else if (f.endingType == "Neutral")
                {
                    Console.WriteLine("Final neutral");
                }
                else Console.WriteLine("Final malo");
            }



        }







    }
}
