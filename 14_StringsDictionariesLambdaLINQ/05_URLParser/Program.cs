using System;

namespace _05_URLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int protocolEnd = input.IndexOf("://");
            string protocol = (protocolEnd != -1)
                ? input.Substring(0, protocolEnd)
                : string.Empty;

            string serverAndResource = (protocolEnd != -1)
                ? input.Substring(protocolEnd + 3)
                : input;

            int serverEnd = serverAndResource.IndexOf('/');
            (string server, string resource) = (serverEnd != -1)
                ? (
                    serverAndResource.Substring(0, serverEnd),
                    serverAndResource.Substring(serverEnd + 1)
                  )
                : (serverAndResource, string.Empty);

            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");

            Console.ReadKey();
        }
    }
}
