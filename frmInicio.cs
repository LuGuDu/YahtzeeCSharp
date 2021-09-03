using System;
using System.Windows.Forms;

namespace Yahtzee {
    public partial class frmInicio : Form {
        static frmInicio mInstance;

        private frmInicio() {
            InitializeComponent();
        }

        public static frmInicio getInstance() {
            if (mInstance == null) {
                mInstance = new frmInicio();
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
            frmJuego juego = frmJuego.getInstance();
            juego.setJugadores(cbJugadores.SelectedIndex);
            juego.Show();
        }
    }
}
