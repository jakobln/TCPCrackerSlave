using System;
using System.Net;
using System.Reflection;

namespace TCPCrackerSlave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cracker slave");
            Crackerslave cs = new Crackerslave();
            cs.connect("192.168.14.112", 7777);

        }
    }
}
