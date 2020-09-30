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

namespace afalunchdb {
    class Program {
        static void Main (string[] args) {
            DiwineReceiver diwine = new DiwineReceiver();
            diwine.ReceiverOfDiwine();
            IlmoloReceiver ilmolo = new IlmoloReceiver();
            ilmolo.ReceiverOfIlmolo();
        }
    }
}