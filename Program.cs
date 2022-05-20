using System;
using abstraindo_um_jogo_rpg.src.entities;

namespace  abstraindo_um_jogo_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus("Arus", 22, "Knight");
            Arus oponent = new Arus("Jennica", 23, "White Wizard");
            
           
            Console.WriteLine(hero.Attack());
            Console.WriteLine(oponent.Attack());
        }
    }
}