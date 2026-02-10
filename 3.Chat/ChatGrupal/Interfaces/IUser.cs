using System;
using System.Collections.Generic;
using System.Text;

namespace ChatGrupal.Interfaces
{
    public interface IUser
    {
        string Name { get; }
        void Join(IChatRoom room);
        void SendToAll(string message);
        void SendTo(string toUser, string message);
        void Receive(string message, string fromUser);
    }
}
