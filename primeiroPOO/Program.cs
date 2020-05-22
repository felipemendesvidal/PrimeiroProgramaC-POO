using System;

namespace primeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem tony = new Personagem();
            tony.armadura = "sei la esqueci mais funcionou";

            Console.WriteLine(tony.nome);
            Console.WriteLine(tony.armadura);
            Console.WriteLine(tony.Atacar(50,80));
        }
    }
}
