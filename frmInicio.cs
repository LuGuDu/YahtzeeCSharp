using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Yahtzee {
    public partial class FrmInicio : Form {
        static FrmInicio mInstance;

        private FrmInicio() {
            InitializeComponent();
        }

        public static FrmInicio getInstance() {
            if (mInstance == null) {
                mInstance = new FrmInicio();
            }
            return mInstance;
        }

        private void Form1_Load(object sender, EventArgs e) {
            cbJugadores.SelectedIndex = 0;

        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cbJugadores_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnEmpezar_Click(object sender, EventArgs e) {

            this.Hide();
            FrmJuego juego = FrmJuego.getInstance();
            juego.setJugadores(cbJugadores.SelectedIndex);
            juego.Show();
        }
    }
}
