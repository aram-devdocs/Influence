using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace GameServer.Networking
{
    public class ClientHandler
    {
        private readonly TcpClient _clientSocket;
        private bool _isConnected;
        private NetworkStream _networkStream;
        private StreamReader _reader;
        private StreamWriter _writer;

        public ClientHandler(TcpClient clientSocket)
        {
            _clientSocket = clientSocket;
            _networkStream = _clientSocket.GetStream();
            _reader = new StreamReader(_networkStream);
            _writer = new StreamWriter(_networkStream) { AutoFlush = true };
            _isConnected = true;
        }

        public void Start()
        {
            Thread clientThread = new Thread(ProcessClient);
            clientThread.Start();
        }

        private void ProcessClient()
        {
            while (_isConnected)
            {
                try
                {
                    // Read data from client
                    var message = _reader.ReadLine();
                    if (message != null)
                    {
                        Console.WriteLine($"Received: {message}");
                        HandleMessage(message);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Client disconnected: {ex.Message}");
                    Disconnect();
                }
            }
        }

        private void HandleMessage(string message)
        {
            // Here you can parse client messages and respond accordingly.
            // For example: if (message == "connect") { /* Send map data */ }
            Console.WriteLine($"Handling message: {message}");
            _writer.WriteLine("Server received: " + message);
        }

        public void Disconnect()
        {
            _isConnected = false;
            _networkStream.Close();
            _clientSocket.Close();
            Console.WriteLine("Client disconnected.");
        }
    }
}