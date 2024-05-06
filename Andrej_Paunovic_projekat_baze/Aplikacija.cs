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

namespace Andrej_Paunovic_projekat_baze
{
    public partial class Aplikacija : Form
    {
        public Aplikacija()
        {
            InitializeComponent();
        }
        DataTable dt_termini;

        private void Aplikacija_Load(object sender, EventArgs e)
        {
            cmb_StudioPopulate();
            cmb_DatePoupulate();

        }

        private void cmb_StudioPopulate()
        {
            SqlConnection veza = MojaKonekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Prostorija", veza);
            DataTable dt_studio = new DataTable();
            adapter.Fill(dt_studio);
            cmb_Studio.DataSource = dt_studio;
            cmb_Studio.ValueMember = "id";
            cmb_Studio.DisplayMember = "ime_studija";
            cmb_Studio.SelectedValue = 0;
        }
        private void cmb_DatePoupulate()
        {
            SqlConnection veza = MojaKonekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Datum", veza);
            DataTable dt_date = new DataTable();
            adapter.Fill(dt_date);
            cmb_Date.DataSource = dt_date;
            cmb_Date.ValueMember = "id";
            cmb_Date.DisplayMember = "datum";
            cmb_Date.SelectedValue = 0;
        }
        private void cmb_odPopulate()
        {
            SqlConnection veza = MojaKonekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select s10_11, s11_12, s12_13, s13_14, s14_15, s15_16, s16_17, s17_18, s18_19, s19_20, s20_21, s21_22, s22_23, s23_24 from Termini join Prostorija on id_prostorije = Prostorija.id join Datum on id_datuma = Datum.id  Where id_prostorije = " + cmb_Studio.SelectedValue.ToString()+ " and id_datuma = "+cmb_Date.SelectedValue.ToString() , veza);
            DataTable dt_od = new DataTable();
            adapter.Fill(dt_od);
            for(int i=0;i<13;i++)
            {
                if ((dt_od.Rows[0][i].ToString()=="False") && (dt_od.Rows[0][i+1].ToString() == "False"))
                {
                    cmb_od.Items.Add(i + 10);
                }
            }
        }

        private void cmb_doPopulate()
        {
            SqlConnection veza = MojaKonekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select s10_11, s11_12, s12_13, s13_14, s14_15, s15_16, s16_17, s17_18, s18_19, s19_20, s20_21, s21_22, s22_23, s23_24 from Termini join Prostorija on id_prostorije = Prostorija.id join Datum on id_datuma = Datum.id  Where id_prostorije = " + cmb_Studio.SelectedValue.ToString() + " and id_datuma = " + cmb_Date.SelectedValue.ToString(), veza);
            DataTable dt_do = new DataTable();
            adapter.Fill(dt_do);
            for (int i = int.Parse(cmb_od.Text)-10; i < 13; i++)
            {

                if ((dt_do.Rows[0][i].ToString() == "False") && (dt_do.Rows[0][i + 1].ToString() == "False"))
                {
                    cmb_do.Items.Add(i + 12);
                }
                else break;
            }
        }

        private void btn_proveri_Click(object sender, EventArgs e)
        {
            if((cmb_Studio.SelectedIndex>=0)&&(cmb_Date.SelectedIndex>=0))
            {
                cmb_odPopulate();
                textBox1.Text = cmb_Studio.Text;
                GridPopulate();
            }
            else
            {
                MessageBox.Show("Niste uneli datum ili niste izabrali studio.", "Greska");
            }
        }

        private void cmb_od_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_do.Items.Clear();
            cmb_do.ResetText();
            if(cmb_od.SelectedIndex>=0)
            {
                cmb_doPopulate();
            }
        }

        private void GridPopulate()
        {
            StringBuilder naredba = new StringBuilder("Select datum, s10_11 as '10-11', s11_12 as '11-12', s12_13 as '12-13', s13_14 as '13-14', s14_15 as '14-15', s15_16 as'15-16', s16_17 as '16-17', s17_18 as '17-18', s18_19 as '18-19', s19_20 as '19-20', s20_21 as '20-21', s21_22 as '21-22', s22_23 as '22-23', s23_24 as '23-24', ime_studija from Termini join Prostorija on id_prostorije = Prostorija.id join Datum on id_datuma = Datum.id where id_prostorije =  ");
            naredba.Append(cmb_Studio.SelectedValue.ToString());
            SqlConnection veza = MojaKonekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            dt_termini = new DataTable();
            adapter.Fill(dt_termini);
            grid_termini.DataSource = dt_termini;
            grid_termini.AllowUserToAddRows = false;
            //grid_termini.Columns["ucenik_id"].Visible = false;
        }
    }
}
