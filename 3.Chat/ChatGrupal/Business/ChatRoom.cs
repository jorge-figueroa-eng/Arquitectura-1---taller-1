using ChatGrupal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatGrupal.Business
{
    public sealed class ChatRoom : IChatRoom
    {
        private readonly Dictionary<string, IUser> _users = new(StringComparer.OrdinalIgnoreCase);

        public void Register(IUser user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrWhiteSpace(user.Name)) throw new ArgumentException("El usuario debe tener Name.", nameof(user));
            _users[user.Name] = user;
            user.Join(this);
            BroadcastSystemMessage($"{user.Name} se unió a la sala.");
        }

        public void Unregister(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName)) return;
            if (_users.Remove(userName.Trim()))
            {
                BroadcastSystemMessage($"{userName.Trim()} salió de la sala.");
            }
        }

        public void Send(string message, string fromUser, string? toUser = null)
        {
            if (string.IsNullOrWhiteSpace(fromUser)) throw new ArgumentException("fromUser es obligatorio.", nameof(fromUser));

            if (string.IsNullOrWhiteSpace(message)) return;

            fromUser = fromUser.Trim();
            message = message.Trim();
            toUser = string.IsNullOrWhiteSpace(toUser) ? null : toUser.Trim();

            if (!_users.ContainsKey(fromUser))
            {
                Console.WriteLine($"[Sistema] Mensaje rechazado: '{fromUser}' no está registrado.");
                return;
            }

            if (toUser is null)
            {
                foreach (var (name, user) in _users)
                {
                    if (!name.Equals(fromUser, StringComparison.OrdinalIgnoreCase))
                    {
                        user.Receive(message, fromUser);
                    }
                }
                return;
            }

            if (_users.TryGetValue(toUser, out var receiver))
            {
                receiver.Receive(message, fromUser);
            }
            else
            {
                _users[fromUser].Receive($"[Sistema] El usuario '{toUser}' no está en la sala.", "Sala");
            }
        }

        private void BroadcastSystemMessage(string message)
        {
            foreach (var (_, user) in _users)
            {
                user.Receive($"[Sistema] {message}", "Sala");
            }
        }
    }
}
