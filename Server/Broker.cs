using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domen;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sesija
{
    public class Broker
    {
        SqlConnection konekcija;
        SqlTransaction transakcija;
        public static Broker instanca;

        public static Broker dajSesiju()
        {
            if (instanca == null)
            {
                instanca = new Broker();
            }
            return instanca;
        }
        public void otvoriKonekciju()
        {
            try
            {
                konekcija = new SqlConnection(@"Data Source=DESKTOP-0LRIJEF;Initial Catalog=Osiguranje;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                konekcija.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("Neuspesna konekcija!");
            }
        }
        public void zatvoriKonekciju()
        {
            try
            {

                konekcija.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Nije moguce zatvoriti konekciju!");
            }
        }
        public void zapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
            }
            catch (Exception)
            {

                MessageBox.Show("Neuspesna transakcija!");
            }
        }
        public void ponistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {

                MessageBox.Show("Neuspesno ponistavanje!");
            }
        }
        public void potvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {

                MessageBox.Show("Neuspesna potvrda transakcije!");
            }
        }


        public List<OpstiDomenskiObjekat> vratiSve(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.nazivTabele;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat pom = odo.procitaj(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }
        public List<OpstiDomenskiObjekat> vratiSveZaUslovOpsti(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.nazivTabele+" WHERE "+odo.uslovOstalo;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat pom = odo.procitaj(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }
        public OpstiDomenskiObjekat VratiZaUslovPrimarni(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.nazivTabele + " WHERE " + odo.uslovPrimarni;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                DataRow red;
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }
                return odo.procitaj(red);
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }
        public OpstiDomenskiObjekat VratiZaUslovOstalo(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.nazivTabele + " WHERE " + odo.uslovOstalo;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                DataRow red;
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }
                return odo.procitaj(red);
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }
        public int IzmeniUslovPrimarni(OpstiDomenskiObjekat odo)
        {
            string upit = "UPDATE " + odo.nazivTabele + " SET " + odo.izmena + " WHERE " + odo.uslovPrimarni;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }
        public int IzmeniUslovOstalo(OpstiDomenskiObjekat odo)
        {
            string upit = "UPDATE " + odo.nazivTabele + " SET " + odo.izmena + " WHERE " + odo.uslovOstalo;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }
        public int Sacuvaj(OpstiDomenskiObjekat odo)
        {
            string upit = "INSERT INTO " + odo.nazivTabele + " " + odo.unos;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }
        public int ObrisiZaUslovPrimarni(OpstiDomenskiObjekat odo)
        {
            string upit = "DELETE FROM " + odo.nazivTabele + " WHERE " + odo.uslovPrimarni;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }
        public int ObrisiZaUslovOstalo(OpstiDomenskiObjekat odo)
        {
            string upit = "DELETE FROM " + odo.nazivTabele + " WHERE " + odo.uslovOstalo;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }
        public int VratiSifru(OpstiDomenskiObjekat odo)
        {
            string upit = "SELECT MAX(" + odo.primarniKljuc + ") FROM " + odo.nazivTabele;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                Object o = komanda.ExecuteScalar();
                if (o == DBNull.Value) return 1;
                else return Convert.ToInt32(o) + 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
