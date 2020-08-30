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
    public class InsuranceType:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return name;
        }

        int typeID;
        string name;
        double pricePremium;

        public int TypeID { get => typeID; set => typeID = value; }
        public string Name { get => name; set => name = value; }
        public double PricePremium { get => pricePremium; set => pricePremium = value; }

        public override bool Equals(object obj)
        {
            var type = obj as InsuranceType;
            return type != null &&
                   typeID == type.typeID;
        }

        [Browsable(false)]
        public string nazivTabele => "InsuranceType";
        [Browsable(false)]
        public string primarniKljuc => "TypeID";
        [Browsable(false)]
        public string uslovPrimarni => "TypeID =" + TypeID;
        [Browsable(false)]
        public string USLOV = "";
        [Browsable(false)]
        public string uslovOstalo => USLOV;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;

        [Browsable(false)]
        public virtual OpstiDomenskiObjekat procitaj(DataRow red)
        {
            InsuranceType t = new InsuranceType();
            t.TypeID = Convert.ToInt32(red["TypeID"]);
            t.Name = red["Name"].ToString();
            t.PricePremium = Convert.ToDouble(red["PricePremium"]);
          
            return t;
        }
    }
}
