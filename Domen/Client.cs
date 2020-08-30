using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Client:OpstiDomenskiObjekat
    {
        public override bool Equals(object obj)
        {
            var client = obj as Client;
            return client != null &&
                   clientID == client.clientID;
        }

        int clientID;

        public virtual int ClientID { get => clientID; set => clientID = value; }

        [Browsable(false)]
        public virtual string nazivTabele => "Client";
        [Browsable(false)]
        public virtual string primarniKljuc => "ClientID";
        [Browsable(false)]
        public virtual string uslovPrimarni => "ClientID ="+ ClientID;
        [Browsable(false)]
        public virtual string uslovOstalo => null;
        [Browsable(false)]
        public virtual string izmena => null;
        [Browsable(false)]
        public virtual string unos => "values ("+ClientID+" )";

        public virtual OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Client c = new Client();
            c.ClientID = Convert.ToInt32(red["ClientID"]);

            return c;
        }
    }
}
