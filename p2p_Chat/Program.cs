using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace p2p_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Использование: P2PChat.exe <имя> <IP>");
                return;
            }

            string name = args[0];
            string ip = args[1];

            ChatNode node = new ChatNode(name, ip);
            node.Start();

            Console.WriteLine($"[{name}] Чат запущен. Введите сообщения:");
        }
    }
}
