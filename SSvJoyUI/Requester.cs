using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSvJoyUI
{
    internal class Requester
    {
        public string IP { get; private set; } = "127.0.0.1";
        public int Port { get; private set; } = 80;
        public bool IsConnect { get; private set;  } = false;

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

        private void Send(string message)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, $"http://{IP}:{Port}/serial");
            var content = new StringContent(message, Encoding.UTF8, "application/json");
            request.Content = content;
            client.Send(request);
        }

        public async Task RunLoop()
        {
            await Task.Run(() =>
            {
                int current_ludder = _ludder;
                int current_engineL = _engineL;
                int current_engineR = _engineR;

                while (IsConnect)
                {
                    string[] data = new string[3]
                    {
                        $"{{\"type\":4,\"id\":0,\"value\":{_ludder}}}",
                        $"{{\"type\":6,\"id\":0,\"value\":{_engineL}}}",
                        $"{{\"type\":8,\"id\":0,\"value\":{_engineR}}}"
                    };

                    if (current_ludder != _ludder)
                    {
                        Send(data[0]);
                        current_ludder = _ludder;
                        continue;
                    }
                    if (current_engineL != _engineL)
                    {
                        Send(data[0]);
                        current_engineL = _engineL;
                        continue;
                    }
                    if (current_engineR != _engineR)
                    {
                        Send(data[0]);
                        current_engineR = _engineR;
                        continue;
                    }

                    Task.Delay(500).Wait();
                }
            });
        }

    }
}
