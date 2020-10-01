using System;
using System.Collections.Generic;
using System.Text;
using database.manager;
using Dbitems.MenuItem;
using Newtonsoft;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Receiver.Diwine;
using Receiver.Ilmolo;
using Sender.Data;
using database.manager;

namespace afalunchdb {
    class Program {
        static void Main (string[] args) {
/*             DiwineReceiver diwine = new DiwineReceiver();
            diwine.ReceiverOfDiwine();
            IlmoloReceiver ilmolo = new IlmoloReceiver();
            ilmolo.ReceiverOfIlmolo();
 */
            DbManager dbManager = new DbManager();

            var data = dbManager.SelectAllDishes();


            DataSender dataSender = new DataSender();
            dataSender.SendAllData(data);

        }
    }
}