using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEmpleadosVIrtual
{
    public partial class Form1 : Form
    {
        public int Cont;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Cont++;
            //Empleado-Asalariado
            string Nombre = txtNom.Text;
            string Apellido = txtApell.Text;
            string NSS = txtNSS.Text;
            double Salario = double.Parse(txtSal.Text);
            int a = 1;
            EmpleadoAsalariado ObjEA = new EmpleadoAsalariado();
            ObjEA.CalculaSalario(Salario, 0, 0,a);
            lstNom.Items.Add(Nombre);
            lstApell.Items.Add(Apellido);
            lstNSS.Items.Add(NSS);
            lstSuel.Items.Add("$" + ObjEA.Sueldo);
            lstCont.Items.Add(Cont);
            txtNom.Clear();
            txtApell.Clear();
            txtNSS.Clear();
            txtSal.Clear();
        }

        private void btnCal2_Click(object sender, EventArgs e)
        {
            Cont++;
            //Empleado Por Horas
            string Nombre2 = txtNom2.Text;
            string Apellido2 = txtApell2.Text;
            string NSS2 = txtNSS2.Text;
            double SueldoHora2 = double.Parse(txtSal2.Text);
            int HorasTra2 = int.Parse(txtHoras.Text);
            EmpleadoXHora ObjEH = new EmpleadoXHora();
            int a = 2;
            ObjEH.CalculaSalario(0, SueldoHora2, HorasTra2,a);
            lstNom.Items.Add(Nombre2);
            lstApell.Items.Add(Apellido2);
            lstNSS.Items.Add(NSS2);
            lstSuel.Items.Add("$" + ObjEH.Sueldo);
            lstCont.Items.Add(Cont);
            txtNom2.Clear();
            txtApell2.Clear();
            txtNSS2.Clear();
            txtSal2.Clear();
            txtHoras.Clear();
        }

        private void btnCalc3_Click(object sender, EventArgs e)
        {
            Cont++;
            //Empleado Por Comision
            string Nombre3 = txtNom3.Text;
            string Apellido3 = txtApell3.Text;
            string NSS3 = txtNSS3.Text;
            int VentasBrutas3 = int.Parse(txtVenB3.Text);
            double TarifasComision3 = double.Parse(txtTarCo3.Text);
            EmpleadoPorComision ObjeEXC = new EmpleadoPorComision();
            int a = 3;
            ObjeEXC.CalculaSalario(TarifasComision3, VentasBrutas3, 0,a);
            lstNom.Items.Add(Nombre3);
            lstApell.Items.Add(Apellido3);
            lstNSS.Items.Add(NSS3);
            lstSuel.Items.Add("$" + ObjeEXC.Sueldo);
            lstCont.Items.Add(Cont);
            txtNom3.Clear();
            txtApell3.Clear();
            txtNSS3.Clear();
            txtVenB3.Clear();
            txtTarCo3.Clear();
        }

        private void btnCalc4_Click(object sender, EventArgs e)
        {
            Cont++;
            //Empleado Base Mas Comision
            string Nombre4 = txtNom4.Text;
            string Apellido4 = txtApell4.Text;
            string NSS4 = txtNSS4.Text;
            int VentasBrutas4 = int.Parse(txtVentB4.Text);
            double TarifasComision4 = double.Parse(txtTarC4.Text);
            double SalarioBase4 = double.Parse(txtSalB4.Text);
            EmpleadoBaseMasComision ObjeEBC = new EmpleadoBaseMasComision();
            int a = 4;
            ObjeEBC.CalculaSalario(TarifasComision4, SalarioBase4, VentasBrutas4,a);
            lstNom.Items.Add(Nombre4);
            lstApell.Items.Add(Apellido4);
            lstNSS.Items.Add(NSS4);
            lstSuel.Items.Add("$" + ObjeEBC.Sueldo);
            lstCont.Items.Add(Cont);
            txtNom4.Clear();
            txtApell4.Clear();
            txtNSS4.Clear();
            txtSalB4.Clear();
            txtTarC4.Clear();
            txtVentB4.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstApell.Items.Clear();
            lstNom.Items.Clear();
            lstNSS.Items.Clear();
            lstSuel.Items.Clear();
            lstCont.Items.Clear();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
