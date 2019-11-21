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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DgVTarjeta.ColumnCount = 4;
            DgVTarjeta.Columns[0].HeaderText = "Nombre";
            DgVTarjeta.Columns[1].HeaderText = "DNI Tarjeta";
            DgVTarjeta.Columns[2].HeaderText = "Saldo";
            DgVTarjeta.Columns[3].HeaderText = "DNI";

            DgVTarjeta.Columns[0].Width = 60;
            DgVTarjeta.Columns[1].Width = 200;
            DgVTarjeta.Columns[2].Width = 60;
            DgVTarjeta.Columns[3].Width = 60;
            llenarDvg();

        }

        public Tarjeta objEntTarjeta = new Tarjeta();
        public NegocioTarjeta objNegTarjeta = new NegocioTarjeta();
       

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
        private void llenarDvg()
        {
            DgVTarjeta.Rows.Clear();

            DataSet ds = new DataSet();
            
            ds = objNegTarjeta.listadoTarjeta("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DgVTarjeta.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3]);
                }
            }
            else
                label4.Text = "No existe tal tarjeta";
        }
        private void TxtBox_a_obj()
        {
            objEntTarjeta.DNI = int.Parse(textBox1.Text);
            objEntTarjeta.Nombre = textNombre.Text;
            objEntTarjeta.DNITarjeta = int.Parse(textDni.Text);
            objEntTarjeta.Saldo = int.Parse(textBox3.Text);
        }

        private void Limpiar()
        {
            textBox1.Text = string.Empty;
            textNombre.Text = string.Empty;
            textDni.Text = string.Empty;
            textBox3.Text = string.Empty;


        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int nGrabado = -1;
            TxtBox_a_obj();
            nGrabado = objNegTarjeta.abmTarjeta("Agregar", objEntTarjeta);
            if (nGrabado == -1)
                label4.Text = "No pudo grabar la tarjeta en el sistema";
            else
            {
                label4.Text = "Se grabo con exito la tarjeta";
                llenarDvg();
                Limpiar();
            }
            
        }

  
        private void ds_a_TxtBox(DataSet ds)
        {
            textBox3.Text = ds.Tables[0].Rows[0]["Saldo"].ToString();
            textDni.Text = ds.Tables[0].Rows[0]["DNITarjeta"].ToString();
            textNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            textBox1.Text =ds.Tables[0].Rows[0]["DNI"].ToString();
            textDni.Enabled = false;
            textBox1.Enabled = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            objEntTarjeta.Saldo = Convert.ToInt32(DgVTarjeta.CurrentRow.Cells[0].Value);
            ds = objNegTarjeta.listadoTarjeta(objEntTarjeta.Saldo.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                ds_a_TxtBox(ds);
                button1.Visible = false;
                label4.Text = string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.Show();
        }
    }
}
