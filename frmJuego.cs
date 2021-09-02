using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{

    public partial class frmJuego : Form
    {
        private int jugadores;

        public frmJuego()
        {
            InitializeComponent();
        }

        private void frmJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void setJugadores(int jugadores)
        {
            switch(jugadores){
                case 0:
                    this.jugadores = 2;
                    break;
                case 1:
                    this.jugadores = 3;
                    break;
                case 2:
                    this.jugadores = 4;
                    break;
                default:
                    break;
            }
        }

        public void setLabelJugadores()
        {
            lblJugadores.Text = "Los jugadores son: " + this.jugadores;
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {

        }
    }
}
