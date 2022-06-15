using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PasswordCrackerCentralized;

namespace TCPCrackerSlave
{
    class Crackerslave
    {
        private List<string> wordlist = new();

        public Crackerslave()
        {

        }


        internal void connect(string host, int port)
        {
            TcpClient clientSocket = new TcpClient(host, port);

            Stream ns = clientSocket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);


           sw.AutoFlush = true;
           Console.ReadLine();
            sw.WriteLine("chunk");
           

            var word = sr.ReadLine();
            
            wordlist = JsonSerializer.Deserialize<List<string>>(word);
            foreach (var x in wordlist)
            {
                Console.WriteLine(x);
            }
            



            DoCrack(wordlist);
    
             

            Console.ReadKey();
            ns.Close();
            clientSocket.Close();
            Console.ReadKey();
        }

        private void DoCrack(List<string> list)
        {
            Cracking crack = new Cracking();
            crack.RunCracking();
        }
    }
}
