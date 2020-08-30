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
using Server.SO.LoginSO;
using Server.SO.ClientSO;
using Server.SO.PolicySO;

namespace Server
{
    public class NitKlijenta
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public NitKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradi;
            new Thread(ts).Start();
        }

        void obradi()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch (transfer.Operacija)
                    {

                        case Operacije.Login:
                            FindAgent fa = new FindAgent();
                            transfer.Rezultat = fa.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.AddClient:
                            AddClient ac = new AddClient();
                            transfer.Rezultat = ac.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.GetListClients:
                            GetLIstClients glc = new GetLIstClients();
                            transfer.Rezultat = glc.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.SearchClients:
                            SearchClients sc = new SearchClients();
                            transfer.Rezultat = sc.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.SelectClient:
                            SelectClient scl = new SelectClient();
                            transfer.Rezultat = scl.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UpdateClient:
                            UpdateClient uc = new UpdateClient();
                            transfer.Rezultat = uc.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.AddPolicy:
                            AddPolicy ap = new AddPolicy();
                            transfer.Rezultat = ap.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UpdatePolicy:
                            UpdatePolicy up = new UpdatePolicy();
                            transfer.Rezultat = up.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.DeletePolicy:
                            DeletePolicy dp = new DeletePolicy();
                            transfer.Rezultat = dp.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.SearchPolicy:
                            SearchPolicy sp = new SearchPolicy();
                            transfer.Rezultat = sp.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.SelectPolicy:
                            SelectPolicy spo = new SelectPolicy();
                            transfer.Rezultat = spo.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.GetListInsTypes:
                            GetListInsuranceTypes git = new GetListInsuranceTypes();
                            transfer.Rezultat = git.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.DeleteClient:
                            DeleteClient dc = new DeleteClient();
                            transfer.Rezultat = dc.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaTokova.Remove(tok);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Server.listaTokova.Remove(tok);
            }
        }
    }
}
