using System;
using abstraindo_um_jogo_rpg.src.entities;

namespace  abstraindo_um_jogo_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 22, "Knight");
            Wizard jennica = new Wizard("Jennica", 23, "White Wizard");
            
           
            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack(1));
        }
    }
    
}