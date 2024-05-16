using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Andrej_Paunovic_projekat_baze
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            txt_DatumPopulate();
            cmb_DatePoupulate();
        }
        private void txt_DatumPopulate()
        {
            SqlConnection veza = MojaKonekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(" SELECT DATEADD(day, 1, (Select datum from Datum where id = (select MAX(id) from Datum)))", veza);
            DataTable dt_datum = new DataTable();
            adapter.Fill(dt_datum);
            string a= dt_datum.Rows[0][0].ToString();
            string b, c;
            int d = 0;
            b ="";
            c = "";
            for (int i =0; i < a.Length; i++)
            {
                if ((d == 0) && (a[i] == '/') && (a[i+2]!='/'))
                {
                    b = a[i + 1].ToString() + a[i + 2];
                    d = 1;
                }
                if ((d == 0) && (a[i] == '/') && (a[i + 2] == '/'))
                {
                    b = a[i + 1].ToString();
                    d = 1;
                }
                if ((d == 1) && (a[i] == '/'))
                {
                    c = a[i + 1].ToString() + a[i + 2] + a[i + 3] + a[i+4];
                    d = 1;
                }

            }
            if (a[1] == '/')
            {
                b = c+"-" + "0" + a[0] + "-" + b;
            }
            if(a[1] != '/')
            {
                b = c + "-" + a[0] + a[1] + "-" + b;
            }
            txt_Datum.Text = b;
            
        }

        private void btn_Napravi_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("Insert into Datum (datum) VALUES('");
            naredba.Append(txt_Datum.Text + "')");
            SqlConnection veza = MojaKonekcija.Connect();
            SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
            int prosao = 0;
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
                prosao = 1;
            }
            if (prosao == 0)
            {
                naredba.Clear();
                if(checkBox1.Checked==true)
                {
                    for(int i = 0; i < 4; i++)
                    {

                        naredba = new StringBuilder("Insert into Termini(id_datuma,id_prostorije,s10_11, s11_12, s12_13, s13_14, s14_15, s15_16, s16_17, s17_18, s18_19, s19_20, s20_21, s21_22, s22_23, s23_24) values(");
                        naredba.Append("(select MAX(id) from Datum), ");
                        naredba.Append((i + 1).ToString() + ",0,0,0,0,0,0,0,0,0,0,0,0,0,0)");
                        veza = MojaKonekcija.Connect();
                        Komanda = new SqlCommand(naredba.ToString(), veza);
                        try
                        {
                            veza.Open();
                            Komanda.ExecuteNonQuery();
                            veza.Close();
                        }
                        catch (Exception Greska)
                        {
                            MessageBox.Show(Greska.Message);
                        }
                        naredba.Clear();
                    }

                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {

                        naredba = new StringBuilder("Insert into Termini(id_datuma,id_prostorije,s10_11, s11_12, s12_13, s13_14, s14_15, s15_16, s16_17, s17_18, s18_19, s19_20, s20_21, s21_22, s22_23, s23_24) values(");
                        naredba.Append("(select MAX(id) from Datum), ");
                        naredba.Append((i + 1).ToString() + ",1,1,1,1,1,1,1,1,1,1,1,1,1,1)");
                        veza = MojaKonekcija.Connect();
                        Komanda = new SqlCommand(naredba.ToString(), veza);
                        try
                        {
                            veza.Open();
                            Komanda.ExecuteNonQuery();
                            veza.Close();
                        }
                        catch (Exception Greska)
                        {
                            MessageBox.Show(Greska.Message);
                        }
                        naredba.Clear();
                    }
                }
                txt_DatumPopulate();
                cmb_DatePoupulate();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_Date_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_DatePoupulate()
        {
            SqlConnection veza = MojaKonekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Datum order by id desc", veza);
            DataTable dt_date = new DataTable();
            adapter.Fill(dt_date);
            cmb_Date.DataSource = dt_date;
            cmb_Date.ValueMember = "id";
            cmb_Date.DisplayMember = "datum";
            cmb_Date.SelectedValue = 0;
        }

        private void GridPopulate()
        {
            StringBuilder naredba = new StringBuilder("Select datum, s10_11 as '10-11', s11_12 as '11-12', s12_13 as '12-13', s13_14 as '13-14', s14_15 as '14-15', s15_16 as'15-16', s16_17 as '16-17', s17_18 as '17-18', s18_19 as '18-19', s19_20 as '19-20', s20_21 as '20-21', s21_22 as '21-22', s22_23 as '22-23', s23_24 as '23-24', ime_studija from Termini join Prostorija on id_prostorije = Prostorija.id join Datum on id_datuma = Datum.id where id_datuma =  ");
            naredba.Append(cmb_Date.SelectedValue.ToString() + "order by id_datuma desc");
            SqlConnection veza = MojaKonekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_termini = new DataTable();
            adapter.Fill(dt_termini);
            grid_termini.DataSource = dt_termini;
            grid_termini.AllowUserToAddRows = false;
        }

        private void ZakazivanjeGridPopulate()
        {
            StringBuilder naredba = new StringBuilder("Select ime_studija,pocetak_termina,kraj_termina,ime, broj_telefona from Zakazivanje join Prostorija on id_prostorije=Prostorija.id join Datum on id_datuma=Datum.id join Osoba on id_osoba= Osoba.id where id_datuma=  ");
            naredba.Append(cmb_Date.SelectedValue.ToString() +"order by id_prostorije asc");
            SqlConnection veza = MojaKonekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_termini = new DataTable();
            adapter.Fill(dt_termini);
            grid_zakazivanje.DataSource = dt_termini;
            grid_zakazivanje.AllowUserToAddRows = false;
        }

        private void btn_proveri_Click(object sender, EventArgs e)
        {
            if (cmb_Date.SelectedIndex >= 0)
            {
                GridPopulate();
                ZakazivanjeGridPopulate();
            }
        }
    }
}
