using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPromedio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa tu nombre");
            string name = Console.ReadLine();

            Player player = new Player(name, 100);
            player.ShowPlayerInfo();

            //Situaciones
            TextSituation s1 = new TextSituation("Te despiertas en una habitación oscura y ves una sombra pasar por delante de la entrada....." +
                " no sabes qué es pero no parece humano, sino un monstruo enorme");
            CombatSituation s2 = new CombatSituation("El monstruo te encuentra por culpa de tu olor y te saca de tu escondite arrastrandote del pie y alzandote en el aire", 15);
            TextSituation s3 = new TextSituation(" Corres por todo el lugar buscando una salida pero todo parece un laberinto y apenas puedes ver por la oscuridad....." +
                " el monstruo sigue al acecho pero tras explorar todo el lugar logras encontrar la salida de la mansión... o bueno las salidas, una puerta con llave y un túnel");

            //Finales
            FinalSituation good = new FinalSituation("Escapaste, al fin, del monstruo. Vuelves a ver la luz del día ante tus ojos", "Good");
            FinalSituation neutral = new FinalSituation("Sobreviviste por poco, deberias ir a sanar un poco tus heridas antes de seguir.... Ahora hace falta buscar un médico", "Neutral");
            FinalSituation bad = new FinalSituation("El monstruo te alcanzó y te encierra para siempre dentro de la mansión", "Bad");

            //Alternativas de selección

            //Situación 1
            s1.options.Add(new Option("Buscas un escondite dentro del cuarto oscuro para refugiarte de lo que se avecina", -10, s2));
            s1.options.Add(new Option("Decides correr furea de la habitación y probar suerte escapando mientras no te ha visto", -10, s2));




            //Situación 2

            s2.options.Add(new Option("Decides pelear contra el monstruo sabiendo que tienes todas las de perder", -30, s3));
            s2.options.Add(new Option("Intentas escapar de agarre del monstruo, asi que forcejeas, cayendo al piso luego de darle una patada", -15, s3));

            //Situación 3

            s3.options.Add(new Option("Decides buscar la llave rápidamente y salir por la puerta que da directo al exterior", -20, good));
            s3.options.Add(new Option("Corres rápidamente a través del túnel sin importar las consecuencias, tienes mucho miedo y solo quieres escapar", -15, neutral));
            s3.options.Add(new Option("Das la vuelta para enfrentar al monstruo porque no crees que ningún camino sea seguro", -60, bad));

            //--------------

            Game game = new Game();
            game.player = player;
            game.startSituation = s1;

            game.StartGame();




        }
    }
}
