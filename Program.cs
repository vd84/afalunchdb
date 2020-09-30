using System;
using System.Collections.Generic;
using System.Text;
using database.manager;
using Dbitems.MenuItem;
using Newtonsoft;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace afalunchdb {
    class Program {
        static void Main (string[] args) {

            DbManager dbManager = new DbManager (); 
            List<MenuItem> menuItems = null;

            var factory = new ConnectionFactory () { HostName = "localhost" };
            using (var connection = factory.CreateConnection ())
            using (var channel = connection.CreateModel ()) {
                channel.QueueDeclare (queue: "insertveckansluncher",
                    durable : false,
                    exclusive : false,
                    autoDelete : false,
                    arguments : null);

                var consumer = new EventingBasicConsumer (channel);
                consumer.Received += (model, ea) => {
                    var body = ea.Body.ToArray ();
                    var message = Encoding.UTF8.GetString (body);
                    Console.WriteLine (" [x] Received {0}", message);
                    menuItems = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MenuItem>> (message);
                    System.Console.WriteLine("MENU ITEMS LIST " + menuItems.Count);

                };
                channel.BasicConsume (queue: "insertveckansluncher",
                    autoAck : true,
                    consumer : consumer);

                Console.WriteLine (" Press [enter] to exit.");
                Console.ReadLine ();

            }


       
           //dbManager.INSERTINTORESTAURANG ();
        }
    }
}