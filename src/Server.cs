using System.Net;
using System.Net.Sockets;
using System.Text;

TcpListener server = new TcpListener(IPAddress.Any, 4221);
server.Start();
Socket socket = server.AcceptSocket(); // wait for client
const String version = "HTTP/1.1";
int statusCode = 200;
socket.Send(Encoding.UTF8.GetBytes($"{version} {statusCode} OK\r\n\r\n"));