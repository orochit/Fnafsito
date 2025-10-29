using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Imagensita
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        int Actividad = 0;

        int ChanceMovimientoBonnie = 0, ChanceMovimientoChica = 0;

        bool isRightDoorClosed = false, isLeftDoorClosed = false;        

        int BonnieDangerLvl = 0, ChicaDangerLvl = 0;

        public Form1()
        {
            InitializeComponent();

            Hora.Interval = (30) * 1000;
            Hora.Tick += Hora_Tick;
            Hora.Tick -= Hora_Tick;
            Hora.Start();

            Tick.Interval = (1) * 1000;
            Tick.Tick += Tick_Tick;
            Tick.Tick -= Tick_Tick;
            Tick.Start();

            ChanceMovimientoBonnie = random.Next(1, 6);
            ChanceMovimientoChica = random.Next(1, 6);
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            Actividad++;

            lblHora.Text = Actividad.ToString() + "am";
        }

        private bool Bonnie(ref int num)
        {
            if (num >= 5)
            {
                num = random.Next(1, 6);
                return true;
            }

            num++;
            return false;

        }

        private bool Chica(ref int num)
        {
            if (num >= 5)
            {
                num = random.Next(1, 6);
                return true;
            }

            num++;
            return false;

        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            if (Bonnie(ref ChanceMovimientoBonnie))
            {
                BonnieDangerLvl++;
                lblBonnieDangerLvl.Text = BonnieDangerLvl.ToString();

                if (BonnieDangerLvl == 6)
                {
                    if (!isLeftDoorClosed)
                    {
                        lblHora.Text = "Te culearon";

                        Tick.Stop();
                        Hora.Stop();

                        var temporizadorCerrar = new System.Windows.Forms.Timer();
                        temporizadorCerrar.Interval = 3000;
                        temporizadorCerrar.Tick += (s, ev) =>
                        {
                            temporizadorCerrar.Stop();
                            Close();
                        };

                        temporizadorCerrar.Start();
                    }

                    BonnieDangerLvl = 0;
                }
            }

            if (Actividad < 1) return;

            if (Chica(ref ChanceMovimientoChica))
            {
                ChicaDangerLvl++;
                lblChicaDangerLvl.Text = ChicaDangerLvl.ToString();

                if (ChicaDangerLvl == 6)
                {
                    if (!isRightDoorClosed)
                    {
                        lblHora.Text = "Te culearon";

                        Tick.Stop();
                        Hora.Stop();

                        var temporizadorCerrar = new System.Windows.Forms.Timer();
                        temporizadorCerrar.Interval = 3000;
                        temporizadorCerrar.Tick += (s, ev) =>
                        {
                            temporizadorCerrar.Stop();
                            Close();
                        };

                        temporizadorCerrar.Start();
                    }

                    ChicaDangerLvl = 0;
                }

                if (Actividad < 2) return;
            }
        }

        private void btnLPuerta_Click(object sender, EventArgs e)
        {
            if (!isLeftDoorClosed)
            {
                isLeftDoorClosed = true;
                btnLPuerta.Text = "Cerrado";

                return;
            }

            isLeftDoorClosed = false;
            btnLPuerta.Text = "Abierto";
        }

        private void btnRPuerta_Click(object sender, EventArgs e)
        {
            if (!isRightDoorClosed)
            {
                isRightDoorClosed = true;
                btnRPuerta.Text = "Cerrado";

                return;
            }

            isRightDoorClosed = false;
            btnRPuerta.Text = "Abierto";
        }
    }
}
