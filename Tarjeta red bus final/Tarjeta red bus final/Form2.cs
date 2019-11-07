using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Negocio;
using System.Windows.Forms;

namespace Tarjeta_red_bus_final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderText = "Nombre";
            dataGridView1.Columns[1].HeaderText = "Apellido";
            dataGridView1.Columns[2].HeaderText = "Sexo";
            dataGridView1.Columns[3].HeaderText = "Fecha de Nacimiento";
            dataGridView1.Columns[4].HeaderText = "DNI";
            dataGridView1.Columns[5].HeaderText = "Cuild";

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Width = 200;
            llenarDvg();
        }
        public Persona objEntPersona = new Persona();
        public NegocioPersona objNegPersona = new NegocioPersona();
        private void llenarDvg()
        {
            dataGridView1.Rows.Clear();

            DataSet ds = new DataSet();

            ds = objNegPersona.listadoPersona("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1], dr[2],dr[3],dr[4],dr[5]);
                }
            }
            else
                label5.Text = "No existe tal tarjeta";
        }
        private void TxtBox_a_obj()
        {
            objEntPersona.Nombre = TxBNom.Text;
            objEntPersona.Apellido = TxBApell.Text;
            objEntPersona.Sexo = Char.Parse(TxBSex.Text);
            objEntPersona.FechaNac = DateTime.Parse(TxBFech.Text);
            objEntPersona.DNI = int.Parse(TxBDNI.Text);
            objEntPersona.Cuild = int.Parse(TxBCu.Text);
        }
        private void Limpiar()
        {
            TxBNom.Text = string.Empty;
            TxBApell.Text = string.Empty;
            TxBSex.Text = string.Empty;
            TxBFech.Text = string.Empty;
            TxBDNI.Text = string.Empty;
            TxBCu.Text = string.Empty;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nGrabado = -1;
            TxtBox_a_obj();
            nGrabado = objNegPersona.abmPersonas("Agregar", objEntPersona);
            if (nGrabado == -1)
                label5.Text = "No pudo grabar la persona en el sistema";
            else
            {
                label5.Text = "Se grabo con exito la tarjeta";
                llenarDvg();
                Limpiar();
            }

        }
        private void ds_a_TxtBox(DataSet ds)
        {
            TxBNom.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            TxBApell.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
            TxBSex.Text = ds.Tables[0].Rows[0]["Sexo"].ToString();
            TxBFech.Text = ds.Tables[0].Rows[0]["FechaNac"].ToString();
            TxBDNI.Text = ds.Tables[0].Rows[0]["DNI"].ToString();
            TxBCu.Text = ds.Tables[0].Rows[0]["Cuild"].ToString();
            TxBDNI.Enabled = false;
            TxBCu.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            objEntPersona.DNI = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ds = objNegPersona.listadoPersona(objEntPersona.DNI.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                ds_a_TxtBox(ds);
                button1.Visible = false;
                label4.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }
    }
}
