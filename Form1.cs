using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable(); 
        
          
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "select * from personas";
            Class1 personas = new Class1();
            dt = personas.personas(sql);

           

            dataGridView1.Rows.Clear();
            foreach (DataRow fila in dt.Rows)
            {

                if (listBox1.SelectedIndex == 0)
                {
                    if (radioButton3.Checked == true)
                    {

                        if (fila["sexo"].ToString() == "f" && fila["trabaja"].ToString() == "1")
                        {
                          
                          dataGridView1.Rows.Add(fila["idpersonas"], fila["nombre"], fila["sexo"], "si", fila["nacio"], fila["idbarrio"]);
                         
                        }
                    }

                }
                if (listBox1.SelectedIndex == 0)
                {
                    if (radioButton4.Checked == true)
                    {

                        if (fila["sexo"].ToString() == "f" && fila["trabaja"].ToString() == "0")
                        {

                            dataGridView1.Rows.Add(fila["idpersonas"], fila["nombre"], fila["sexo"], "no", fila["nacio"], fila["idbarrio"]);

                        }
                    }

                }
                if (listBox1.SelectedIndex == 1)
                {
                    if (radioButton3.Checked == true)
                    {

                        if (fila["sexo"].ToString() == "m" && fila["trabaja"].ToString() == "1")
                        {

                            dataGridView1.Rows.Add(fila["idpersonas"], fila["nombre"], fila["sexo"], "si", fila["nacio"], fila["idbarrio"]);

                        }
                    }

                }
                if (listBox1.SelectedIndex == 1)
                {
                    if (radioButton4.Checked == true)
                    {

                        if (fila["sexo"].ToString() == "m" && fila["trabaja"].ToString() == "0")
                        {

                            dataGridView1.Rows.Add(fila["idpersonas"], fila["nombre"], fila["sexo"], "no", fila["nacio"], fila["idbarrio"]);

                        }
                    }

                }
                if (listBox1.SelectedIndex == 2)
                {
                    if (radioButton3.Checked == true)
                    {

                        if (fila["trabaja"].ToString() == "1")
                        {

                            dataGridView1.Rows.Add(fila["idpersonas"], fila["nombre"], fila["sexo"], "si", fila["nacio"], fila["idbarrio"]);

                        }
                    }
                }
                if (listBox1.SelectedIndex == 2)
                {
                    if (radioButton4.Checked == true)
                    {

                        if (fila["trabaja"].ToString() == "0")
                        {

                            dataGridView1.Rows.Add(fila["idpersonas"], fila["nombre"], fila["sexo"], "no", fila["nacio"], fila["idbarrio"]);

                        }
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select * from personas";
            Class1 personas = new Class1();
            dt = personas.personas(sql);
            foreach (DataRow fila in dt.Rows) 
            {
                if (textBox1.Text == fila["idpersonas"].ToString())
                {
                    if (fila["sexo"].ToString() == "m" )
                    {
                        radioButton1.Checked = true;
                        if (Convert.ToInt32(fila["trabaja"]) == 1) 
                        {
                            checkBox1.Checked = true;
                            textBox1.Text = fila["idpersonas"].ToString();
                            textBox2.Text = fila["nombre"].ToString();
                            dateTimePicker1.Value = Convert.ToDateTime(fila["nacio"]);
                            comboBox1.SelectedValue = fila["idbarrio"].ToString();
                        }
                        if (Convert.ToInt32(fila["trabaja"]) == 0)
                        {
                            checkBox1.Checked = false;
                            textBox1.Text = fila["idpersonas"].ToString();
                            textBox2.Text = fila["nombre"].ToString();
                            dateTimePicker1.Value = Convert.ToDateTime(fila["nacio"]);
                            comboBox1.SelectedValue = fila["idbarrio"].ToString();
                        }

                    }

                    if (fila["sexo"].ToString() == "f")
                    {
                        radioButton2.Checked = true;
                        if (Convert.ToInt32(fila["trabaja"]) == 1)
                        {
                            checkBox1.Checked = true;    
                            textBox1.Text = fila["idpersonas"].ToString();
                            textBox2.Text = fila["nombre"].ToString();
                            dateTimePicker1.Value = Convert.ToDateTime(fila["nacio"]);
                            comboBox1.SelectedValue = fila["idbarrio"].ToString();

                        }
                        if (Convert.ToInt32(fila["trabaja"]) == 0)
                        {
                            checkBox1.Checked = false;
                            textBox1.Text = fila["idpersonas"].ToString();
                            textBox2.Text = fila["nombre"].ToString();
                            dateTimePicker1.Value = Convert.ToDateTime(fila["nacio"]);
                            comboBox1.SelectedValue = fila["idbarrio"].ToString();

                        }
                    }
                }
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {  
            int id = Convert.ToInt32(textBox1.Text);
            string sql = $"DELETE FROM personas WHERE idpersonas = {id}";
            Class1 personas = new Class1();
            dt = personas.personas(sql);


            textBox1.Clear();
            textBox2.Clear();
            
        }
    }
}
