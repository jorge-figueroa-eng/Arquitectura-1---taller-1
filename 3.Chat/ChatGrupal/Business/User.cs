using ChatGrupal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatGrupal.Business
{
    public sealed class User : IUser
    {
        private IChatRoom? _room;
        public string Name { get; }

        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre del usuario es obligatorio.", nameof(name));

            Name = name.Trim();
        }

        public void Join(IChatRoom room)
        {
            _room = room ?? throw new ArgumentNullException(nameof(room));
        }

        public void SendToAll(string message)
        {
            EnsureJoined();
            if (string.IsNullOrWhiteSpace(message)) return;

            _room!.Send(message.Trim(), fromUser: Name, toUser: null);
        }

        public void SendTo(string toUser, string message)
        {
            EnsureJoined();
            if (string.IsNullOrWhiteSpace(toUser)) return;
            if (string.IsNullOrWhiteSpace(message)) return;

            _room!.Send(message.Trim(), fromUser: Name, toUser: toUser.Trim());
        }

        public void Receive(string message, string fromUser)
        {
            Console.WriteLine($"[{Name}] <- {fromUser}: {message}");
        }

        private void EnsureJoined()
        {
            if (_room is null)
                throw new InvalidOperationException($"El usuario '{Name}' no está unido a ninguna sala.");
        }
    }
}
