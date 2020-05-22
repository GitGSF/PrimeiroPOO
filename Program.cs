using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
               personagem Batman = new personagem();
            Batman.armadura = "Hellbat";

            Console.WriteLine(Batman.nome);

            Console.WriteLine(Batman.armadura);

            Console.WriteLine(Batman.Atacar());
        }
    }
}
