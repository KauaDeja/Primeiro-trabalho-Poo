using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Personagem frodo = new Personagem();
           frodo.espada = "Ferruada";
           
           Console.WriteLine(frodo.nome);
           Console.WriteLine(frodo.espada);
           Console.WriteLine(frodo.raça);

           Console.WriteLine(frodo.Atacar());

          
        }
    }
}
