using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Schema;

namespace Andrej_Paunovic_projekat_baze
{
    public partial class loginforma : Form
    {
        public static string ime, broj;
        public loginforma()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox2.Select();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if(textBox2.Text == "")
            {
                label3.Visible = true;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (textBox1.Text == "")
            {
                label2.Visible = true;
            }
        }
        public String vrati()
        {
            return ime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortedSet<char> a= new SortedSet<char>();
            a.Add('+');
            a.Add('1');
            a.Add('2');
            a.Add('3');
            a.Add('4');
            a.Add('5');
            a.Add('6');
            a.Add('7');
            a.Add('8');
            a.Add('9');
            a.Add('0');
            a.Add('-');
            a.Add('/');
            int p = 0;
            if((textBox1.Text=="") || (textBox2.Text==""))
            {
                p = 1;
                MessageBox.Show("Niste upisali korisnicko ime ili broj telefona!", "Greska!");
            }
            if((textBox2.Text.Length<6) ||(textBox2.Text.Length>14))
            {
                p = 1;
                MessageBox.Show("Upisali ste pogresan broj telefona!", "Greska!");
            }
            if((textBox1.Text.Length>19))
            {
                p = 1;
                MessageBox.Show("Ime koje ste probali da unesete je previse dugacko!", "Greska!");
            }
            if((textBox1.Text=="Pusic") && (textBox2.Text=="000000"))
            {
                p = 1;
                Admin admin = new Admin();
                admin.Show();
            }
            for(int i=0;i<textBox2.Text.Length;i++)
            {
                if (a.Contains(textBox2.Text[i])==false )
                {
                    MessageBox.Show("Upisali ste pogresan broj telefona!", "Greska!");
                    p = 1;
                }
                if (p == 1)
                    break;
            }
            if(p==0)
            {
                StringBuilder naredba = new StringBuilder("Insert into Osoba (ime, broj_telefona) VALUES('");
                naredba.Append(textBox1.Text + "', '"+ textBox2.Text + "') ");
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
                    StringBuilder novo = new StringBuilder("Select MAX(id) from Osoba");
                    SqlConnection sqlConnection = MojaKonekcija.Connect();
                    SqlDataAdapter adapter = new SqlDataAdapter(novo.ToString(), veza);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    ime = dt.Rows[0][0].ToString();
                    Aplikacija aplikacija = new Aplikacija();
                    aplikacija.Show();
                }

            }
        }
    }
}
