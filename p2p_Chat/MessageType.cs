using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2p_Chat
{
    public enum MessageType : byte
    {
        ChatMessage = 1,
        SendName = 2,
        UserConnected = 3,
        UserDisconnected = 4
    }

}
