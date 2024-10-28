using GameServer.Networking;

namespace GameServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Influence Game Server...");
            _Server server = new _Server(8080);
            server.Start();

            Console.WriteLine("Press any key to shut down.");
            Console.ReadKey();
            server.Stop();
        }
    }
}