using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCasa
{
    class Casa
    {
        //====Definicao de variáveis====

        //Quarto Principal
        public bool mainQuartoLuz;
        public int  mainQuartoTemp;
        public bool mainQuartoBanheira;
        public bool mainQuartoArCond;

        //Quarto de Visitas
        public bool visitQuartoLuz;
        public int  visitQuartoTemp;
        public bool visitQuartoArCond;

        //Sala de TV
        public bool tvLigada;
        public int tvSalaTemp;
        public bool tvSalaLuz;
        public int tvCanal;
        public bool tvSalaArCond;

        //Sala de visitas
        public int visitSalaTemp;
        public bool visitSalaLuz;
        public bool visitSalaPorta;
        public bool visitSalaArCond;



        //====Construtores====
        public Casa()
        {
            this.mainQuartoLuz = false;
            this.mainQuartoBanheira = false;
            this.mainQuartoTemp = 18;
            this.mainQuartoArCond = false;

            this.visitQuartoLuz = false;
            this.visitQuartoTemp = 18;
            this.visitQuartoArCond = false;

            this.tvSalaTemp = 18;
            this.tvCanal = 1;
            this.tvSalaLuz = false;
            this.tvLigada = false;
            this.tvSalaArCond = false;

            this.visitSalaLuz = false;
            this.visitSalaTemp = 18;
            this.visitSalaPorta = false;
            this.visitSalaArCond = false;
        }

        //====Métodos(Funcionalidades)====

        public void AcenderLuzMainQuarto()
        {
            this.mainQuartoLuz = true;            
        }
        public void DesligarLuzMainQuarto()
        {
            this.mainQuartoLuz = false;
        }


        public void LigarArCondicionadoMainQuarto()
        {
            this.mainQuartoArCond = true;
        }
        public void DesligarArCondicionadoMainQuarto()
        {
            this.mainQuartoArCond = false;
        }


        public void EncherBanheira()
        {
            this.mainQuartoBanheira = true;
        }
        public void DesligarBanheira()
        {
            this.mainQuartoBanheira = false;
        }


        public void AcenderLuzQuartoVisita()
        {
            this.visitQuartoLuz = true;
        }
        public void ApagarLuzQuartoVisita()
        {
            this.visitQuartoLuz = false;
        }


        public void LigarArCondicionadoVisitQuarto()
        {
            this.visitQuartoArCond = true;
        }
        public void DesligarArCondicionadoVisitQuarto()
        {
            this.visitQuartoArCond = false;
        }


        public void AcenderLuzTvSala()
        {
            this.tvSalaLuz = true;
        }
        public void ApagarLuzTvSala()
        {
            this.tvSalaLuz = false;
        }


        public void LigarTvSalaArCond()
        {
            this.tvSalaArCond = true;
        }
        public void DesligarTvSalaArCond()
        {
            this.tvSalaArCond = false;
        }


        public void LigarTV()
        {
            this.tvLigada = true;
            this.tvCanal = 1;
        }
        public void DesligarTV()
        {
            this.tvLigada = false;
            this.tvCanal = 0;
        }


        public void ProximoCanal()
        {
            if (this.tvCanal <= 5)
            {
                this.tvCanal++;
            }
            else
            {
                this.tvCanal = 1;
            }
        }
        public void AnteriorCanal()
        {
            if (this.tvCanal >= 1)
            {
                this.tvCanal--;
            }
            else
            {
                this.tvCanal = 5;
            }
        }


        public void AcenderLuzSalaVisitas()
        {
            this.visitSalaLuz = true;
        }
        public void ApagarLuzSalaVisitas()
        {
            this.visitSalaLuz = false;
        }


        public void LigarArCondSalaVisitas()
        {
            this.visitSalaArCond = true;
        }
        public void DesligarArCondSalaVisitas()
        {
            this.visitSalaArCond = false;
        }


        public void AbrirPorta()
        {
            this.visitSalaPorta = true;
        }
        public void FecharPorta()
        {
            this.visitSalaPorta = false;
        }
    }
}
