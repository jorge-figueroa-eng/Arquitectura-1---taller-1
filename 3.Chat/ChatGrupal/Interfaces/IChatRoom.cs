using System;
using System.Collections.Generic;
using System.Text;

namespace ChatGrupal.Interfaces
{
    public interface IChatRoom
    {
        void Register(IUser user);
        void Unregister(string userName);
        void Send(string message, string fromUser, string? toUser = null);
    }
}
