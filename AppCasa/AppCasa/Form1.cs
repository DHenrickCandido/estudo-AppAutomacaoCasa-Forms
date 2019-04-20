using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCasa
{
    public partial class Form1 : Form
    {
        Casa casa = new Casa();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void acenderLuzMainQuarto_Click(object sender, EventArgs e)
        {
            if (casa.mainQuartoLuz == false)
            {
                casa.AcenderLuzMainQuarto();
                btnAcenderLuzMainQuarto.Text = "Desligar Luz";
                pbLuzMainQuarto.Image = Properties.Resources.acesa1;
            }
            else
            {
                casa.DesligarLuzMainQuarto();
                btnAcenderLuzMainQuarto.Text = "Acender Luz";
                pbLuzMainQuarto.Image = Properties.Resources.apagada;
            }
                

        }

        private void pbLuzMainQuarto_Click(object sender, EventArgs e)
        {

            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // The Maximum property sets the value of the track bar when
            // the slider is all the way to the right.
            tbTemperaturaMainQuarto.Maximum = 15;

            // The TickFrequency property establishes how many positions
            // are between each tick-mark.
            tbTemperaturaMainQuarto.TickFrequency = 3;

            // The LargeChange property sets how many positions to move
            // if the bar is clicked on either side of the slider.
            tbTemperaturaMainQuarto.LargeChange = 3;

            // The SmallChange property sets how many positions to move
            // if the keyboard arrows are used to move the slider.
            tbTemperaturaMainQuarto.SmallChange = 1;

            if (tbTemperaturaMainQuarto.Value <= 5)
            {
                pbTempMainQuarto.Image = Properties.Resources.cold;
            }
            else
            {
                pbTempMainQuarto.Image = Properties.Resources.warm;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (casa.mainQuartoArCond == false)
            {
                casa.LigarArCondicionadoMainQuarto();
                btnArCondicionadoMainQuarto.Text = "Desligar Ar Condicionado"; 
                tbTemperaturaMainQuarto.Enabled = true;
            }
            else
            {
                casa.DesligarArCondicionadoMainQuarto();
                btnArCondicionadoMainQuarto.Text = "Ligar Ar Condicionado";
                tbTemperaturaMainQuarto.Enabled = false;
            }
        }

        private void btnEncherBanheira_Click(object sender, EventArgs e)
        {
            if (casa.mainQuartoBanheira == false)
            {
                casa.EncherBanheira();
                btnEncherBanheira.Text = "Desligar Banheira";
                pbBanheiraEstado.Image = Properties.Resources.switch_on_icon_34343;
            }
            else
            {
                casa.DesligarBanheira();
                btnEncherBanheira.Text = "Encher Banheira";
                pbBanheiraEstado.Image = Properties.Resources.switch_off_icon_34344;
            }
            
        }

        private void btnArCondicionadoVisitQuarto_Click(object sender, EventArgs e)
        {
            if (casa.visitQuartoArCond == false)
            {
                casa.LigarArCondicionadoVisitQuarto();
                btnArCondicionadoVisitQuarto.Text = "Desligar Ar Condicionado";
                tbTempVisitQuarto.Enabled = true;
            }
            else
            {
                casa.DesligarArCondicionadoVisitQuarto();
                btnArCondicionadoVisitQuarto.Text = "Ligar Ar Condicionado";
                tbTempVisitQuarto.Enabled = false;
            }
        }

        private void btLuzVisitQuarto_Click(object sender, EventArgs e)
        {
            if (casa.visitQuartoLuz == false)
            {
                casa.AcenderLuzQuartoVisita();
                btLuzVisitQuarto.Text = "Apagar luz";
                pbLuzVisitQuarto.Image = Properties.Resources.acesa1;
            }
            else
            {
                casa.ApagarLuzQuartoVisita();
                btLuzVisitQuarto.Text = "Acender luz";
                pbLuzVisitQuarto.Image = Properties.Resources.apagada;
            }
        }

        private void tbTempVisitQuarto_Scroll(object sender, EventArgs e)
        {
            // The Maximum property sets the value of the track bar when
            // the slider is all the way to the right.
            tbTempVisitQuarto.Maximum = 15;

            // The TickFrequency property establishes how many positions
            // are between each tick-mark.
            tbTempVisitQuarto.TickFrequency = 3;

            // The LargeChange property sets how many positions to move
            // if the bar is clicked on either side of the slider.
            tbTempVisitQuarto.LargeChange = 3;

            // The SmallChange property sets how many positions to move
            // if the keyboard arrows are used to move the slider.
            tbTempVisitQuarto.SmallChange = 1;

            if (tbTempVisitQuarto.Value <= 5)
            {
                pbTempVisitQuarto.Image = Properties.Resources.cold;
            }
            else
            {
                pbTempVisitQuarto.Image = Properties.Resources.warm;
            }
        }

        private void btnTvSalaLuz_Click(object sender, EventArgs e)
        {
            if (casa.tvSalaLuz == false)
            {
                casa.AcenderLuzTvSala();
                btnTvSalaLuz.Text = "Apagar luz";
                pbTvSalaLuz.Image = Properties.Resources.acesa1;
            }
            else
            {
                casa.ApagarLuzTvSala();
                btnTvSalaLuz.Text = "Acender luz";
                pbTvSalaLuz.Image = Properties.Resources.apagada;
            }
        }

        private void btnTvSalaArCond_Click(object sender, EventArgs e)
        {
            if (casa.tvSalaArCond == false)
            {
                casa.LigarTvSalaArCond();
                btnTvSalaArCond.Text = "Desligar Ar Condicionado";
                tbTvSalaTemp.Enabled = true;
            }
            else
            {
                casa.DesligarTvSalaArCond();
                btnTvSalaArCond.Text = "Ligar Ar Condicionado";
                tbTvSalaTemp.Enabled = false;
            }
        }

        private void tbTvSalaTemp_Scroll(object sender, EventArgs e)
        {
            // The Maximum property sets the value of the track bar when
            // the slider is all the way to the right.
            tbTvSalaTemp.Maximum = 15;

            // The TickFrequency property establishes how many positions
            // are between each tick-mark.
            tbTvSalaTemp.TickFrequency = 3;

            // The LargeChange property sets how many positions to move
            // if the bar is clicked on either side of the slider.
            tbTvSalaTemp.LargeChange = 3;

            // The SmallChange property sets how many positions to move
            // if the keyboard arrows are used to move the slider.
            tbTvSalaTemp.SmallChange = 1;

            if (tbTvSalaTemp.Value <= 5)
            {
                pbTvSalaTemp.Image = Properties.Resources.cold;
            }
            else
            {
                pbTvSalaTemp.Image = Properties.Resources.warm;
            }
        }

        private void btnTvSalaTV_Click(object sender, EventArgs e)
        {
            if (casa.tvLigada == false)
            {
                casa.LigarTV();
                btnTvSalaTV.Text = "Desligar TV";
                btnTvSalaCanalProximo.Enabled = true;
                btnTvSalaCanalAnterior.Enabled = true;
                pbTvSalaCanal.Image = Properties.Resources.globo;
            }
            else
            {
                casa.DesligarTV();
                btnTvSalaTV.Text = "Ligar TV";
                btnTvSalaCanalProximo.Enabled = false;
                btnTvSalaCanalAnterior.Enabled = false;
                pbTvSalaCanal.Image = Properties.Resources.tv_off;
            }
        }

        private void pbTvSalaCanal_Click(object sender, EventArgs e)
        {

        }

        private void btnTvSalaCanalProximo_Click(object sender, EventArgs e)
        {
            casa.ProximoCanal();

            if (casa.tvCanal == 0)
            {
                pbTvSalaCanal.Image = Properties.Resources.tv_off;
            }
            else if (casa.tvCanal == 1)
            {
                pbTvSalaCanal.Image = Properties.Resources.globo;
            }
            else if (casa.tvCanal == 2)
            {
                pbTvSalaCanal.Image = Properties.Resources.sbt;
            }
            else if (casa.tvCanal == 3)
            {
                pbTvSalaCanal.Image = Properties.Resources.espn;
            }
            else if (casa.tvCanal == 4)
            {
                pbTvSalaCanal.Image = Properties.Resources.mtv;
            }
            else if (casa.tvCanal == 5)
            {
                pbTvSalaCanal.Image = Properties.Resources.cn;
            }
        }

        private void btnTvSalaCanalAnterior_Click(object sender, EventArgs e)
        {
            casa.AnteriorCanal();

            if (casa.tvCanal == 0)
            {
                casa.tvCanal = 5;
            }
            else if (casa.tvCanal == 1)
            {
                pbTvSalaCanal.Image = Properties.Resources.globo;
            }
            else if (casa.tvCanal == 2)
            {
                pbTvSalaCanal.Image = Properties.Resources.sbt;
            }
            else if (casa.tvCanal == 3)
            {
                pbTvSalaCanal.Image = Properties.Resources.espn;
            }
            else if (casa.tvCanal == 4)
            {
                pbTvSalaCanal.Image = Properties.Resources.mtv;
            }
            else if (casa.tvCanal == 5)
            {
                pbTvSalaCanal.Image = Properties.Resources.cn; 
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (casa.visitSalaLuz == false)
            {
                casa.AcenderLuzSalaVisitas();
                btnLuzVisitSala.Text = "Apagar luz";
                pbLuzVisitSala.Image = Properties.Resources.acesa1;
            }
            else
            {
                casa.ApagarLuzSalaVisitas();
                btnLuzVisitSala.Text = "Acender luz";
                pbLuzVisitSala.Image = Properties.Resources.apagada;
            }
        }

        private void btnArCondVisitSala_Click(object sender, EventArgs e)
        {
            if (casa.visitSalaArCond == false)
            {
                casa.LigarArCondSalaVisitas();
                btnArCondVisitSala.Text = "Desligar Ar Condicionado";
                tbTempVisitSala.Enabled = true;
            }
            else
            {
                casa.DesligarArCondSalaVisitas();
                btnArCondVisitSala.Text = "Ligar Ar Condicionado";
                tbTempVisitSala.Enabled = false;
            }
        }

        private void tbTempVisitSala_Scroll(object sender, EventArgs e)
        {
            // The Maximum property sets the value of the track bar when
            // the slider is all the way to the right.
            tbTempVisitSala.Maximum = 15;

            // The TickFrequency property establishes how many positions
            // are between each tick-mark.
            tbTempVisitSala.TickFrequency = 3;

            // The LargeChange property sets how many positions to move
            // if the bar is clicked on either side of the slider.
            tbTempVisitSala.LargeChange = 3;

            // The SmallChange property sets how many positions to move
            // if the keyboard arrows are used to move the slider.
            tbTempVisitSala.SmallChange = 1;

            if (tbTempVisitSala.Value <= 5)
            {
                pbTempVisitSala.Image = Properties.Resources.cold;
            }
            else
            {
                pbTempVisitSala.Image = Properties.Resources.warm;
            }
        }

        private void btnPortaVisitSala_Click(object sender, EventArgs e)
        {
            if (casa.visitSalaPorta == false)
            {
                casa.AbrirPorta();
                btnPortaVisitSala.Text = "Trancar Porta";
                pbPortaVisitSala.Image = Properties.Resources.exit_5121;
            }
            else
            {
                casa.FecharPorta();
                btnPortaVisitSala.Text = "Destrancar Porta";
                pbPortaVisitSala.Image = Properties.Resources.closed_door_5121;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
