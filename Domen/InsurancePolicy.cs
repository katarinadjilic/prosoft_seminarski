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
    public class InsurancePolicy : OpstiDomenskiObjekat
    {
        int policyID;
        DateTime dateFrom;
        DateTime expDate;
        double value;
        Agent agent;
        Client client;
        BindingList<PolicyItem> itemList;

        public InsurancePolicy()
        {
            itemList = new BindingList<PolicyItem>();
        }

        public int PolicyID { get => policyID; set => policyID = value; }
        public DateTime DateFrom { get => dateFrom; set => dateFrom = value; }
        public DateTime ExpDate { get => expDate; set => expDate = value; }
        public double Value { get => value; set => this.value = value; }
        [Browsable(false)]
        public Agent Agent { get => agent; set => agent = value; }
        [Browsable(false)]
        public Client Client { get => client; set => client = value; }
        public BindingList<PolicyItem> ItemList { get => itemList; set => itemList = value; }

        [Browsable(false)]
        public string nazivTabele => "InsurancePolicy";
        [Browsable(false)]
        public string primarniKljuc => "PolicyID";
        [Browsable(false)]
        public string uslovPrimarni => "PolicyID="+policyID;
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovOstalo => USLOV;
        [Browsable(false)]
        public string izmena => " DateFrom='"+ dateFrom.ToString("yyyy-MM-dd") + "', ExpitarionDate='"+ expDate.ToString("yyyy-MM-dd") + "', Value="+Value+", AgentID="+agent.AgentID+"  ";
        [Browsable(false)]
        public string unos => " values (" + PolicyID + ",'" + dateFrom.ToString("yyyy-MM-dd") + "','" + expDate.ToString("yyyy-MM-dd") + "', " + value + ", " + client.ClientID + "," + agent.AgentID + ")";

        [Browsable(false)]
        public virtual OpstiDomenskiObjekat procitaj(DataRow red)
        {
            InsurancePolicy p = new InsurancePolicy();
            p.PolicyID = Convert.ToInt32(red["PolicyID"]);
            p.DateFrom = Convert.ToDateTime(red["DateFrom"]);
            p.ExpDate = Convert.ToDateTime(red["ExpitarionDate"]);
            p.Value = Convert.ToDouble(red["Value"]);
            p.Client = new Client();
            p.Client.ClientID = Convert.ToInt32(red["ClientID"]);
            p.Agent = new Agent();
            p.Agent.AgentID = Convert.ToInt32(red["AgentID"]);

            return p;
        }
    }
}
