using ChatGrupal.Business;
using ChatGrupal.Interfaces;
using System;

namespace MediatorChat
{
    internal static class Program
    {
        private static void Main()
        {
            IChatRoom room = new ChatRoom();

            IUser sebastian = new User("Sebastian");
            IUser esteban = new User("Esteban");
            IUser carlos = new User("Carlos");

            room.Register(sebastian);
            room.Register(esteban);
            room.Register(carlos);

            Console.WriteLine();
            Console.WriteLine("=== Mensajes ===");
            Console.WriteLine();

            sebastian.SendToAll("Hola a todos.");

            esteban.SendTo("Esteban", "Hola Sebastian, ¿cómo vas?");

            carlos.SendToAll("¿Hacemos una llamada en 10 minutos?");

            Console.WriteLine();
            Console.WriteLine("=== Carlos sale de la sala ===");
            Console.WriteLine();

            room.Unregister("Carlos");

            Console.WriteLine();
            Console.WriteLine("=== Seguimos chateando ===");
            Console.WriteLine();

            sebastian.SendToAll("Carlos ya no está, se ha salido de la sala");

            carlos.SendTo("Carlos", "¿Sigues ahí?");

            Console.WriteLine();
            Console.WriteLine("Fin de la sala");
            Console.ReadKey();
        }
    }
}