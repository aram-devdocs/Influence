using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace GameServer.Networking
{
    public class _Server
    {
        private readonly TcpListener _listener; // Non-nullable field, initialized in constructor

        private bool _isRunning;
        private readonly List<ClientHandler> _clients = new List<ClientHandler>();
        // Constructor initializes the listener
        public _Server(int port)
        {
            _listener = new TcpListener(IPAddress.Any, port);
        }
        public void Start()
        {
            // _listener = new TcpListener(IPAddress.Any, 8080);
            _listener.Start();
            _isRunning = true;
            Console.WriteLine("Server started on port 8080.");

            // Start accepting clients asynchronously
            Thread acceptThread = new Thread(AcceptClients);
            acceptThread.Start();
        }

        private void AcceptClients()
        {
            while (_isRunning)
            {
                try
                {
                    var clientSocket = _listener.AcceptTcpClient();
                    var clientHandler = new ClientHandler(clientSocket);
                    _clients.Add(clientHandler);
                    Console.WriteLine("New client connected.");
                    clientHandler.Start();
                }
                catch (SocketException ex)
                {
                    if (_isRunning)
                    {
                        Console.WriteLine($"SocketException: {ex.Message}");
                    }
                    // If _isRunning is false, this was likely triggered by Stop() and can be safely ignored
                }
            }
        }

        public void Stop()
        {
            _isRunning = false;
            _listener.Stop();
            foreach (var client in _clients)
            {
                client.Disconnect();
            }
            Console.WriteLine("Server stopped.");
        }
    }
}