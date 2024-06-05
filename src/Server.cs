using System.Net;
using System.Net.Sockets;

TcpListener server = new TcpListener(IPAddress.Any, 4221);
server.Start();
server.AcceptSocket(); // wait for client
const String version = "HTTP/1.1";
int statusCode = 200;
Console.Write($"{version} {statusCode} OK\r\n\r\n");