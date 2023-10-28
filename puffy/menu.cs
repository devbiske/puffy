using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace puffy
{
    class menu
    {

        public static async void Menumain()
        {

            Thread.Sleep(1500);
            Console.Clear();
            menu.wLogo();
            Console.WriteLine("");

            say2("+", "https://github.com/devbiske");


            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            say("1", "Track İp");
            Console.WriteLine("");
            say("2", "Exit");
            Console.WriteLine("");
     
            Console.ForegroundColor = ConsoleColor.Yellow;
            string prompt = "root@puffy ~> ";
            Console.WriteLine("");
            Console.Write(prompt);
            string option = Console.ReadLine();
            if (option == "1")
            {
                Console.Clear();
                Console.Write("enter IP address: ");
               
                string ipAddress = Console.ReadLine();

                if (!string.IsNullOrEmpty(ipAddress))
                {
                    string ipLocation = await FetchIpLocation(ipAddress);
                    Console.WriteLine(ipLocation);
                }
                else
                {
                    Console.WriteLine("İnvalid IP");
                }
                Console.WriteLine("Press 5 to go back to the menu.");
                while (Console.ReadKey().Key != ConsoleKey.D5) { }

            }
            if (option == "2")
            {
                Console.Clear();
                Console.WriteLine("\nExiting... Goodbye!");
                Thread.Sleep(2000);
                Environment.Exit(0);


            }
            

        



        }
       
        static async Task<string> FetchIpLocation(string ipAddress)
        {
            Console.Clear();
            string strIpLocation = string.Empty;

            var client = new RestClient("https://ipapi.co/" + ipAddress + "/json/");
            var request = new RestRequest()
            {
              
            };

            var response = await client.ExecuteAsync(request);

            var dictionary = JsonConvert.DeserializeObject<IDictionary>(response.Content);
            foreach (var key in dictionary.Keys)
            {
                strIpLocation += key.ToString() + ": " + dictionary[key] + "\n";
            }

            return strIpLocation;
        }
    

    public static void say(string pr, string txt)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(pr);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ] " + txt);
        }
        public static void say2(string pr, string txt)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(pr);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ] " + txt);




            


        
    








    }
        public static void wLogo()
        {
          
            Console.WriteLine("");
            Console.WriteLine("");
          

            
           
            string text = @"
██▓███   █    ██   █████▒ █████▒▓██   ██▓   ▄▄▄█████▓ ▒█████   ▒█████   ██▓      ██████ 
▓██░  ██▒ ██  ▓██▒▓██   ▒▓██   ▒  ▒██  ██▒   ▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    ▒██    ▒ 
▓██░ ██▓▒▓██  ▒██░▒████ ░▒████ ░   ▒██ ██░   ▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    ░ ▓██▄   
▒██▄█▓▒ ▒▓▓█  ░██░░▓█▒  ░░▓█▒  ░   ░ ▐██▓░   ░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░      ▒   ██▒
▒██▒ ░  ░▒▒█████▓ ░▒█░   ░▒█░      ░ ██▒▓░     ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒▒██████▒▒
▒▓▒░ ░  ░░▒▓▒ ▒ ▒  ▒ ░    ▒ ░       ██▒▒▒      ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░▒ ▒▓▒ ▒ ░
░▒ ░     ░░▒░ ░ ░  ░      ░       ▓██ ░▒░        ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░ ░▒  ░ ░
░░        ░░░ ░ ░  ░ ░    ░ ░     ▒ ▒ ░░       ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░  ░  ░  
            ░                     ░ ░                     ░ ░      ░ ░      ░  ░      ░   ";

            Console.ForegroundColor = ConsoleColor.Yellow;
        
            Console.WriteLine(text);
          


        }

      
    }
  

}
    


