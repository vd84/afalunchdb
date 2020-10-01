using System;
using System.Text;
using database.manager;
using Newtonsoft;
using Npgsql;
using RabbitMQ;
using RabbitMQ.Client;
namespace Sender.Data {
    public class DataSender {

        public void SendAllData (string data) {

            var factory = new ConnectionFactory () { HostName = "localhost" };
            using (var connection = factory.CreateConnection ()) {
                using (var channel = connection.CreateModel ()) {
                    channel.QueueDeclare (queue: "datafromdatabase",
                        durable : false,
                        exclusive : false,
                        autoDelete : false,
                        arguments : null);

                    var body = Encoding.UTF8.GetBytes (data);

                    channel.BasicPublish (exchange: "",
                        routingKey: "datafromdatabase",
                        basicProperties : null,
                        body : body);
                    Console.WriteLine (" [x] Sent {0}", data);

                }
                Console.WriteLine (" Press [enter] to exit.");
                Console.ReadLine ();

            }

        }
    }
}