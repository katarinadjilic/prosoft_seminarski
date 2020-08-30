using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Klijent
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 20000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public object findAgent(Agent a)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Login;
            transfer.TransferObjekat = a;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        //Client
        public object AddClient(Client c)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.AddClient;
            transfer.TransferObjekat = c;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public object SearchClients(Client c)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SearchClients;
            transfer.TransferObjekat = c;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public object GetListClients(Client c)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.GetListClients;
            transfer.TransferObjekat = c;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public object SelectClient(Client c)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SelectClient;
            transfer.TransferObjekat = c;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public object UpdateClient(Client c)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UpdateClient;
            transfer.TransferObjekat = c;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public object DeleteClient(Client c)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.DeleteClient;
            transfer.TransferObjekat = c;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        //Insurance Policy
        public object AddPolicy(InsurancePolicy p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.AddPolicy;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public object UpdatePolicy(InsurancePolicy p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UpdatePolicy;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public object DeletePolicy(InsurancePolicy p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.DeletePolicy;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public object SearchPolicy(InsurancePolicy p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SearchPolicy;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public object SelectPolicy(InsurancePolicy p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SelectPolicy;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public object GetListInsTypes()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.GetListInsTypes;
            transfer.TransferObjekat = new InsuranceType();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
    }
}
