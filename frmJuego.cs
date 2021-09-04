using System;
using System.Windows.Forms;

namespace Yahtzee {

    public partial class frmJuego : Form {
        private int jugadores;
        static frmJuego mInstance;

        private bool dado1Tirar = true;
        private bool dado2Tirar = true;
        private bool dado3Tirar = true;
        private bool dado4Tirar = true;
        private bool dado5Tirar = true;

        private int contadorTirarDados = 0;
        
        private frmJuego() {
            InitializeComponent();
        }

        public static frmJuego getInstance() {
            if (mInstance == null) {
                mInstance = new frmJuego();
            }
            return mInstance;
        }

        private void frmJuego_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        public void setJugadores(int jugadores) {
            switch (jugadores) {
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
            SetTable(this.jugadores);
        }

        private void frmJuego_Load(object sender, EventArgs e) {
            this.btnDado1.Location = new System.Drawing.Point(45, 172);
            this.btnDado2.Location = new System.Drawing.Point(198, 172);
            this.btnDado3.Location = new System.Drawing.Point(339, 172);
            this.btnDado4.Location = new System.Drawing.Point(121, 277);
            this.btnDado5.Location = new System.Drawing.Point(270, 277);
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            this.Hide();
            frmInicio.getInstance().Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnDado1_Click(object sender, EventArgs e) {
            if (dado1Tirar) {
                this.btnDado1.Location = new System.Drawing.Point(45, 350);
                dado1Tirar = false;
            } else {
                this.btnDado1.Location = new System.Drawing.Point(45, 172);
                dado1Tirar = true;
            }
        }

        private void btnDado2_Click(object sender, EventArgs e) {
            if (dado2Tirar) {
                this.btnDado2.Location = new System.Drawing.Point(198, 350);
                dado2Tirar = false;
            } else {
                this.btnDado2.Location = new System.Drawing.Point(198, 172);
                dado2Tirar = true;
            }
        }

        private void btnDado3_Click(object sender, EventArgs e) {
            if (dado3Tirar) {
                this.btnDado3.Location = new System.Drawing.Point(339, 350);
                dado3Tirar = false;
            } else {
                this.btnDado3.Location = new System.Drawing.Point(339, 172);
                dado3Tirar = true;
            }
        }

        private void btnDado4_Click(object sender, EventArgs e) {
            if (dado4Tirar) {
                this.btnDado4.Location = new System.Drawing.Point(121, 350);
                dado4Tirar = false;
            } else {
                this.btnDado4.Location = new System.Drawing.Point(121, 277);
                dado4Tirar = true;
            }
        }

        private void btnDado5_Click(object sender, EventArgs e) {
            if (dado5Tirar) {
                this.btnDado5.Location = new System.Drawing.Point(270, 350);
                dado5Tirar = false;
            } else {
                this.btnDado5.Location = new System.Drawing.Point(270, 277);
                dado5Tirar = true;
            }
        }

        private void btnTirarDados_Click(object sender, EventArgs e) {

            btnDado1.Enabled = true;
            btnDado2.Enabled = true;
            btnDado3.Enabled = true;
            btnDado4.Enabled = true;
            btnDado5.Enabled = true;

            contadorTirarDados++;

            Random r = new Random();

            if (dado1Tirar) {
                int rInt = r.Next(1, 7); //for ints
                btnDado1.Text = rInt.ToString();
            }
            if (dado2Tirar) {
                int rInt = r.Next(1, 7); //for ints
                btnDado2.Text = rInt.ToString();
            }
            if (dado3Tirar) {
                int rInt = r.Next(1, 7); //for ints
                btnDado3.Text = rInt.ToString();
            }
            if (dado4Tirar) {
                int rInt = r.Next(1, 7); //for ints
                btnDado4.Text = rInt.ToString();
            }
            if (dado5Tirar) {
                int rInt = r.Next(1, 7); //for ints
                btnDado5.Text = rInt.ToString();
            }

            if (contadorTirarDados == 3) {
                btnTirarDados.Enabled = false;
                btnSiguente.Enabled = true;
            }
        }

        private void btnSiguente_Click(object sender, EventArgs e) {
            contadorTirarDados = 0;
            btnTirarDados.Enabled = true;
            btnSiguente.Enabled = false;

            this.btnDado1.Location = new System.Drawing.Point(45, 172);
            this.btnDado2.Location = new System.Drawing.Point(198, 172);
            this.btnDado3.Location = new System.Drawing.Point(339, 172);
            this.btnDado4.Location = new System.Drawing.Point(121, 277);
            this.btnDado5.Location = new System.Drawing.Point(270, 277);

            dado1Tirar = true;
            dado2Tirar = true;
            dado3Tirar = true;
            dado4Tirar = true;
            dado5Tirar = true;

            btnDado1.Enabled = false;
            btnDado2.Enabled = false;
            btnDado3.Enabled = false;
            btnDado4.Enabled = false;
            btnDado5.Enabled = false;
        }
    }
}
