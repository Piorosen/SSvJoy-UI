using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SSvJoyUI
{
    internal class Requester
    {
        public string IP { get; private set; } = "127.0.0.1";
        public int Port { get; private set; } = 80;
        public bool IsConnect { get; private set;  } = false;

        private readonly ConcurrentQueue<string> queue = new ConcurrentQueue<string>();

        // 100 -> 1023
        // 0 -> 0
        private int _ludder = 0;
        public int Ludder
        {
            get
            {
                return _ludder;
            }
            set
            {
                _ludder = value * 1023 / 100;
                queue.Enqueue($"{{\"type\":4,\"id\":0,\"value\":{_ludder}}}");
            }
        }

        private int _engineL = 0;
        public int EngineL
        {
            get
            {
                return _engineL;
            }
            set
            {
                _engineL = value * 1023 / 100;
                queue.Enqueue($"{{\"type\":6,\"id\":0,\"value\":{_engineL}}}");
            }
        }

        private int _engineR = 0;
        public int EngineR
        {
            get
            {
                return _engineR;
            }
            set
            {
                _engineR = value * 1023 / 100;
                queue.Enqueue($"{{\"type\":8,\"id\":0,\"value\":{_engineR}}}");
            }
        }


        public void Connect(string ip, int port)
        {
            this.IP = ip;
            this.Port = port;
            this.IsConnect = true;
            _ = RunLoop();
        }

        public void Disconnect()
        {
            IsConnect = false;
        }

        public async Task RunLoop()
        {
            await Task.Run(() =>
            {
                while (IsConnect && queue.TryDequeue(out string message))
                {
                    var client = new HttpClient();
                    var request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:80/serial");
                    var content = new StringContent(message, Encoding.UTF8, "application/json");
                    request.Content = content;
                    client.SendAsync(request);
                }
            });
        }

    }
}
