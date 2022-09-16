using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color ArribaColor;
        Color FueraColor;

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            //Evento "Click" del botón cerrar, indica que cuando se de click a ese botón la aplicación se cerrará
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //Evento "Click" del botón minimizar, para minimizar el formulario
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        //Atributos para guardar clicks de X y Y
        private int clickX = 0, clickY = 0;


        //evento para cuando el mouse se mueve dentro del panel
        private void pnSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            /*condicional para saber si no se presiona el boton izquierdo del mouse
             se guarda las cordenadas, esto pasa solo si pasa el mouse por el panel*/
            if (e.Button != MouseButtons.Left)
            {
                clickX = e.X; 
                
                clickY = e.Y;
            }
            else
            {
                this.Left += (e.X - clickX);

                this.Top += (e.Y - clickY);
            }  

        }

        private void pnLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        //creamos los temas
        //lightMode
        private bool LightMode( bool resp)
        {
            this.pnLateral.BackColor = Color.White;
            this.txtBuscar.BackColor = Color.WhiteSmoke;
            this.txtBuscar.ForeColor = Color.Gray;
            //this.pbLogo.BackColor = Color.White;

            this.btnOp1.ForeColor = Color.DimGray;            
            this.btnOp2.ForeColor = Color.DimGray;
            this.btnOp3.ForeColor = Color.DimGray;
            this.btnOp4.ForeColor = Color.DimGray;
            this.btnOp5.ForeColor = Color.DimGray;

            this.pnSuperior.BackColor = Color.WhiteSmoke;
            this.lblTitulo.ForeColor = Color.DimGray;
            this.lblSubTitulo.ForeColor = Color.DimGray;
            this.BtnCerrar.ForeColor = Color.DimGray;
            this.btnMin.ForeColor = Color.DimGray;

            this.BackColor = Color.WhiteSmoke;

            this.pnContent1.BackColor = Color.White;
            this.pnContent2.BackColor = Color.White;
            this.pnContent3.BackColor = Color.White;
            this.pnContent4.BackColor = Color.White;
            this.pnContent5.BackColor = Color.White;
            this.pnContent6.BackColor = Color.White;
            this.pnContent7.BackColor = Color.White;
            this.pnContent8.BackColor = Color.White;
            this.pnContent9.BackColor = Color.White;

            this.lblContent1.ForeColor = Color.DimGray;
            this.lblContent2.ForeColor = Color.DimGray;
            this.lblContent3.ForeColor = Color.DimGray;
            this.lblContent4.ForeColor = Color.DimGray;
            this.lblContent5.ForeColor = Color.DimGray;
            this.lblContent6.ForeColor = Color.DimGray;
            this.lblContent7.ForeColor = Color.DimGray;
            this.lblContent8.ForeColor = Color.DimGray;
            this.lblContent9.ForeColor = Color.DimGray;

            this.pnInferior.BackColor = Color.WhiteSmoke;

            this.lblUsuario.ForeColor = Color.DimGray;
            this.lblFecha.ForeColor = Color.DimGray;
            this.lblRol.ForeColor = Color.DimGray;

            ArribaColor = Color.WhiteSmoke;
            FueraColor = Color.White;
            

            return resp;

            /*this.lblUsuario.ForeColor = Color.Gray;
            this.lblRol.ForeColor = Color.Gray;
            this.lblFecha.ForeColor = Color.Gray; */
        }



        //DarkMode
        private bool DarkModeB( bool resp)
        {
            this.pnLateral.BackColor = Color.FromArgb(63,63,64) ;
            this.txtBuscar.BackColor = Color.Black;
            this.txtBuscar.ForeColor = Color.Gray;
            //this.pbLogo.BackColor = Color.White;

            this.btnOp1.ForeColor = Color.LightGray;
            this.btnOp2.ForeColor = Color.LightGray;
            this.btnOp3.ForeColor = Color.LightGray;
            this.btnOp4.ForeColor = Color.LightGray;
            this.btnOp5.ForeColor = Color.LightGray;

            this.pnSuperior.BackColor = Color.FromArgb(24,24,24);
            this.lblTitulo.ForeColor = Color.LightGray;
            this.lblSubTitulo.ForeColor = Color.LightGray;
            this.BtnCerrar.ForeColor = Color.White;
            this.btnMin.ForeColor = Color.White;

            this.BackColor = Color.FromArgb(37,37,37);

            this.pnContent1.BackColor = Color.FromArgb(63,63,64);
            this.pnContent2.BackColor = Color.FromArgb(63,63,64);
            this.pnContent3.BackColor = Color.FromArgb(63,63,64);
            this.pnContent4.BackColor = Color.FromArgb(63,63,64);
            this.pnContent5.BackColor = Color.FromArgb(63,63,64);
            this.pnContent6.BackColor = Color.FromArgb(63,63,64);
            this.pnContent7.BackColor = Color.FromArgb(63,63,64);
            this.pnContent8.BackColor = Color.FromArgb(63,63,64);
            this.pnContent9.BackColor = Color.FromArgb(63,63,64);

            this.lblContent1.ForeColor = Color.Silver;
            this.lblContent2.ForeColor = Color.Silver;
            this.lblContent3.ForeColor = Color.Silver;
            this.lblContent4.ForeColor = Color.Silver;
            this.lblContent5.ForeColor = Color.Silver;
            this.lblContent6.ForeColor = Color.Silver;
            this.lblContent7.ForeColor = Color.Silver;
            this.lblContent8.ForeColor = Color.Silver;
            this.lblContent9.ForeColor = Color.Silver;

            this.pnInferior.BackColor = Color.FromArgb(24, 24, 24);

            this.lblUsuario.ForeColor = Color.LightGray;
            this.lblFecha.ForeColor = Color.LightGray;
            this.lblRol.ForeColor = Color.LightGray;

            ArribaColor = Color.FromArgb(37, 37, 37);
            FueraColor = Color.FromArgb(63, 63, 64);

            return resp;

            /*this.lblUsuario.ForeColor = Color.Gray;
            this.lblRol.ForeColor = Color.Gray;
            this.lblFecha.ForeColor = Color.Gray;*/
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(rbLight.Checked )
            {
                rbDark.Checked = true;
                this.btnCheck.Image = DarkMode.Properties.Resources.icons8_verano_25;

            }

            else
            {
                rbLight.Checked = true;
                this.btnCheck.Image = DarkMode.Properties.Resources.icons8_satélite_luna_25;
            }
        }

        private void rbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLight.Checked)
            {
                //MessageBox.Show("Light Mode");
                DarkModeB(false);
                LightMode(true);
                
            }
        }

        private void rbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDark.Checked)
            {
                //MessageBox.Show("Dark Mode");
                LightMode(false);
                DarkModeB(true);
            }
        }

        private void pnContent1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("si");
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                txtBuscar.Text = "";
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
                txtBuscar.Text = "Busqueda...";
        }

        private void pnContent1_MouseHover(object sender, EventArgs e)
        {
           // this.pnContent1.Width = 

            /*if (rbLight.Checked)
            {
                pnContent1.BackColor = Color.FromArgb(61, 61, 51);
                //pnContent1.BackColor = Color.Black;
                //MessageBox.Show("claro");
            }

            else
            {
                pnContent1.BackColor = Color.FromArgb(61, 61, 51);
                
            }*/
          
        }

        private void btnOp1_MouseHover(object sender, EventArgs e)
        {
            //if (rbDark.Checked)
            //{
            //btnOp1.FlatAppearance.MouseOverBackColor = ArribaColor;
            //MessageBox.Show(ArribaColor.ToString());
            //}

            //else if(rbLight.Checked)
            //{
            //    btnOp1.FlatAppearance.MouseOverBackColor = ArribaColor;
            //    //MessageBox.Show(ArribaColor.ToString());
            //} 
        }

        private void btnOp1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DarkModeB(true);
           rbLight.Checked = true;
        }

        private void btnOp1_MouseEnter(object sender, EventArgs e)
        {
            btnOp1.FlatAppearance.MouseOverBackColor = ArribaColor;
        }

        private void btnOp2_MouseEnter(object sender, EventArgs e)
        {
            btnOp2.FlatAppearance.MouseOverBackColor = ArribaColor;
        }

        private void btnOp3_MouseEnter(object sender, EventArgs e)
        {
            btnOp3.FlatAppearance.MouseOverBackColor = ArribaColor;
        }

        private void btnOp4_MouseEnter(object sender, EventArgs e)
        {
            btnOp4.FlatAppearance.MouseOverBackColor = ArribaColor;
        }

        private void btnOp5_MouseEnter(object sender, EventArgs e)
        {
            btnOp5.FlatAppearance.MouseOverBackColor = ArribaColor;
        }

        private void pnContent1_MouseEnter(object sender, EventArgs e)
        {
            this.pnContent1.BackColor = ArribaColor;
        }

        private void pnContent1_MouseLeave(object sender, EventArgs e)
        {
            this.pnContent1.BackColor = FueraColor;
        }

        private void pnContent2_MouseEnter(object sender, EventArgs e)
        {
            this.pnContent2.BackColor = ArribaColor;
        }

        private void pnContent3_MouseEnter(object sender, EventArgs e)
        {
            this.pnContent3.BackColor = ArribaColor;
        }

        private void pnContent4_MouseEnter(object sender, EventArgs e)
        {
            this.pnContent4.BackColor = ArribaColor;
        }

        private void pnContent5_MouseEnter(object sender, EventArgs e)
        {
            this.pnContent5.BackColor = ArribaColor;
        }

        private void pnContent6_MouseEnter(object sender, EventArgs e)
        {
            this.pnContent6.BackColor = ArribaColor;
        }

        private void pnContent7_MouseEnter(object sender, EventArgs e)
        {
            this.pnContent7.BackColor = ArribaColor;
        }

        private void pnContent8_MouseEnter(object sender, EventArgs e)
        {
            this.pnContent8.BackColor = ArribaColor;
        }

        private void pnContent9_MouseEnter(object sender, EventArgs e)
        {
            this.pnContent9.BackColor = ArribaColor;
        }

        private void pnContent2_MouseLeave(object sender, EventArgs e)
        {
            this.pnContent2.BackColor = FueraColor;
        }

        private void pnContent3_MouseLeave(object sender, EventArgs e)
        {
            this.pnContent3.BackColor = FueraColor;
        }

        private void pnContent4_MouseLeave(object sender, EventArgs e)
        {
            this.pnContent4.BackColor = FueraColor;
        }

        private void pnContent5_MouseLeave(object sender, EventArgs e)
        {
            this.pnContent5.BackColor = FueraColor;
        }

        private void pnContent6_MouseLeave(object sender, EventArgs e)
        {
            this.pnContent6.BackColor = FueraColor;
        }

        private void pnContent7_MouseLeave(object sender, EventArgs e)
        {
            this.pnContent7.BackColor = FueraColor;
        }

        private void pnContent8_MouseLeave(object sender, EventArgs e)
        {
            this.pnContent8.BackColor = FueraColor;
        }

        private void pnContent9_MouseLeave(object sender, EventArgs e)
        {
            this.pnContent9.BackColor = FueraColor;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias Por Utilizar DM-RETAIL " , "DM-RETAIL", MessageBoxButtons.OK);
            Application.Exit();
        }
    }
}
