using database.manager;
using Sender.Data;

namespace afalunchdb {
    class Program {
        static void Main (string[] args) {
/*          DiwineReceiver diwine = new DiwineReceiver();
            diwine.ReceiverOfDiwine();

            IlmoloReceiver ilmolo = new IlmoloReceiver();
            ilmolo.ReceiverOfIlmolo(); */
            
            DbManager dbManager = new DbManager();
            var data = dbManager.SelectAllDishes();

            DataSender dataSender = new DataSender();
            dataSender.SendAllData(data);

        }
    }
}