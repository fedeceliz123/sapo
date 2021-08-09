using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sapo
{
    public partial class Sapo : Form
    {
        public Sapo()
        {
            InitializeComponent();
            
        }

        int contadorDia = 0;
        int sube = 7;
        int baja = 2;
        int subido = 0;
        int diaAux = 0;
        int altura = 0;
        int subir = 0;
        int locacion = 0;
        int locacionDefault = 0;
        int local2 = 0;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbAltura.Text)!=0)
            {

            


            altura = pbAlto.Size.Height;
            locacion = pbSapo.Location.Y;
            locacionDefault = pbSapo.Location.Y;
            local2 = pbSapo.Location.Y;

            timer1.Enabled = true;

            
            for (var i = 0; i < int.Parse(tbAltura.Text); i++)
            {
                contadorDia++;
                diaAux++;
                subido = subido + sube;
                if (subido<int.Parse(tbAltura.Text))
                {
                    subido = subido - baja;

                }
                else
                {
                    break;
                }
            }

            lblTotal.Text = contadorDia.ToString();
            lblMetros.Text = tbAltura.Text+" m";

            subir = altura / contadorDia;

            contadorDia = 0;
            subido = 0;

            btnCalcular.Enabled = false;




            for (var i=0;i<diaAux;i++)
            {
                local2 = local2 - subir;
            Label lblDias = new Label();


                lblDias.Text = "___Dia " + (i + 1);
                lblDias.Visible = true;
                lblDias.Location = new Point(lblMetros.Location.X+100,local2+20);
                panel1.Controls.Add( lblDias);
            }

            }
            else
            {
                MessageBox.Show("El valor no puede ser 0");
                tbAltura.Text = "";
            }
        }

            int aux = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            aux++;

            locacion = locacion - subir;

            if (aux >= int.Parse(lblTotal.Text))
            {
                timer1.Enabled = false;
                lblsubio.Visible = true;
            }
            pbSapo.Location = new Point(pbSapo.Location.X,locacion);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

          Application.Restart();

        }

        private void tbAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }



        public static void SoloNumeros(KeyPressEventArgs pr)
        {
            if (char.IsDigit(pr.KeyChar))
            {
                pr.Handled = false;
            }
            else if (char.IsControl(pr.KeyChar))
            {
                pr.Handled = false;
            }
            else
            {
                pr.Handled = true;

                MessageBox.Show("Solo Ingresar Numeros");
               
            }

        }
    }
}
