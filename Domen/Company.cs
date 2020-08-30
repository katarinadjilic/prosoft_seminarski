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
    public class Company:Client
    {
        public override string ToString()
        {
            return Name;
        }

        string name;
        string pib;
        string registrationNo;
        string address;

        public string Name { get => name; set => name = value; }
        public string Pib { get => pib; set => pib = value; }
        public string RegistrationNo { get => registrationNo; set => registrationNo = value; }
        public string Address { get => address; set => address = value; }

        [Browsable(false)]
        public override string nazivTabele => "Company";
        [Browsable(false)]
        public override string primarniKljuc => "ClientID";
        [Browsable(false)]
        public override string uslovPrimarni => "ClientID =" + ClientID;
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public override string uslovOstalo => USLOV;
        [Browsable(false)]
        public override string izmena => " Name='" + Name + "', PIB='" + Pib + "', RegistrationNumber='" + RegistrationNo + "', Address='" + Address + "'";
        [Browsable(false)]
        public override string unos => " values (" + ClientID + ",'"+Name+"','"+Pib+"','"+RegistrationNo+"','"+Address+"' )";

        [Browsable(false)]
        public override OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Company c = new Company();
            c.ClientID = Convert.ToInt32(red["ClientID"]);
            c.Name = red["Name"].ToString();
            c.Pib = red["PIB"].ToString();
            c.RegistrationNo = red["RegistrationNumber"].ToString();           
            c.Address = red["Address"].ToString();
          
            return c;
        }
    }
}
