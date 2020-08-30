using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Agent:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return firstName+" "+lastName;
        }

        int agentID;
        string firstName;
        string lastName;
        string username;
        string password;

        public int AgentID { get => agentID; set => agentID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public override bool Equals(object obj)
        {
            var agent = obj as Agent;
            return agent != null &&
                   agentID == agent.agentID;
        }

        public string nazivTabele => "Agent";

        public string primarniKljuc => "AgentID";

        public string uslovPrimarni => "AgentID="+agentID;

        public string uslovOstalo => "Username ='"+Username+"' and Password='"+Password+"'";

        public string izmena => null;

        public string unos => null;
       

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Agent a = new Agent();
            a.AgentID = Convert.ToInt32(red["AgentID"]);
            a.FirstName = red["FirstName"].ToString();
            a.LastName = red["LastName"].ToString();
            a.Username = red["Username"].ToString();
            a.Password = red["Password"].ToString();

            return a;
        }
    }
}
