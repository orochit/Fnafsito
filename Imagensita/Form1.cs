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

        double Bateria = 100.0, ConsumoDePoder = 0.0, ConsumoPorPuerta = 0.2;

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

            RelojConsumoDePoder();
            Puertas.Interval = 1000;

            ChanceMovimientoBonnie = random.Next(1, 6);
            ChanceMovimientoChica = random.Next(1, 6);
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            Actividad++;

            lblHora.Text = Actividad.ToString() + "am";
        }

        private bool MoveChance(ref int num)
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
            if (MoveChance(ref ChanceMovimientoBonnie))
            {
                BonnieDangerLvl++;
                lblBonnieDangerLvl.Text = BonnieDangerLvl.ToString();

                if (BonnieDangerLvl == 6)
                {
                    Temporizador(3);

                    if (!isLeftDoorClosed)
                    {
                        GamerOverScreen();
                    }

                    BonnieDangerLvl = 1;
                    lblBonnieDangerLvl.Text = BonnieDangerLvl.ToString();
                }
            }

            if (Actividad < 1) return;

            if (MoveChance(ref ChanceMovimientoChica))
            {
                ChicaDangerLvl++;
                lblChicaDangerLvl.Text = ChicaDangerLvl.ToString();

                if (ChicaDangerLvl == 6)
                {
                    Temporizador(2);

                    if (!isRightDoorClosed)
                    {
                        GamerOverScreen();
                    }

                    ChicaDangerLvl = 0;
                }

                if (Actividad < 2) return;
            }
        }

        private void Puertas_Tick(object sender, EventArgs e)
        {
            Bateria -= ConsumoDePoder;

            Bateria = Math.Max(0.0, Math.Min(100.0, Bateria)); // clamp
            lblEnergia.Text = $"{Bateria:F0}%";

            if (Bateria <= 0)
            {
                GamerOverScreen();
            }
        }

        private void ToggleDoor(bool isLeft)
        {
            bool closed = isLeft ? isLeftDoorClosed : isRightDoorClosed;

            if (!closed)
            {
                if (isLeft) { isLeftDoorClosed = true; btnLPuerta.Text = "Cerrado"; }
                else { isRightDoorClosed = true; btnRPuerta.Text = "Cerrado"; }

                ConsumoDePoder += ConsumoPorPuerta;

                return;
            }

            if (isLeft) { isLeftDoorClosed = false; btnLPuerta.Text = "Abierto"; }
            else { isRightDoorClosed = false; btnRPuerta.Text = "Abierto"; }

            ConsumoDePoder -= ConsumoPorPuerta;
        }

        private void btnLPuerta_Click(object sender, EventArgs e) => ToggleDoor(true);
        private void btnRPuerta_Click(object sender, EventArgs e) => ToggleDoor(false);

        private void GamerOverScreen()
        {
            lblHora.Text = "Perdiste";

            Tick.Stop();
            Hora.Stop();
            Puertas.Stop();

            pbxTenedor.Visible = true;
            pbxScreamer.Visible = true;

            var temporizadorCerrar = new System.Windows.Forms.Timer();
            temporizadorCerrar.Interval = 3000;
            temporizadorCerrar.Tick += (s, ev) =>
            {
                temporizadorCerrar.Stop();
                Close();
            };

            temporizadorCerrar.Start();
        }

        private void RelojConsumoDePoder()
        {
            Puertas.Tick -= Puertas_Tick;
            Puertas.Tick += Puertas_Tick;
            Puertas.Start();
        }

        private void Temporizador(int num)
        {
            var temporizador = new System.Windows.Forms.Timer();
            temporizador.Interval = num * 1000;
            temporizador.Tick += (s, ev) =>
            {
                temporizador.Stop();
            };
            temporizador.Start();
        }
    }
}
