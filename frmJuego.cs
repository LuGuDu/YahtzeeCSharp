using Microsoft.VisualBasic;
using System;
using System.Media;
using System.Windows.Forms;

namespace Yahtzee {

    public partial class FrmJuego : Form {
        private int jugadores;
        static FrmJuego mInstance;

        private int turno = 1;

        private bool dado1Tirar = true;
        private bool dado2Tirar = true;
        private bool dado3Tirar = true;
        private bool dado4Tirar = true;
        private bool dado5Tirar = true;

        private string nombreJ1 = "j1";
        private string nombreJ2 = "j2";
        private string nombreJ3 = "j3";
        private string nombreJ4 = "j4";

        private int contadorTirarDados = 0;
        
        private FrmJuego() {
            InitializeComponent();
        }

        private void lblTiradas_Click(object sender, EventArgs e) {

        }
        public void setNombreJ1(string nombre) {
            if(!nombre.Equals("")) {
                this.nombreJ1 = nombre;
            }
        }

        public void setNombreJ2(string nombre) {
            if(!nombre.Equals("")) {
                this.nombreJ2 = nombre;
            }
        }

        public void setNombreJ3(string nombre) {
            if(!nombre.Equals("")) {
                this.nombreJ3 = nombre;
            }
        }

        public void setNombreJ4(string nombre) {
            if (!nombre.Equals("")) {
                this.nombreJ4 = nombre;
            }
        }

        public static FrmJuego getInstance() {
            if (mInstance == null) {
                mInstance = new FrmJuego();
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
            setNombreJugadores();
            SetTable(this.jugadores);
        }

        private void setNombreJugadores() {
            FrmJuego frmJuego = FrmJuego.getInstance();
            frmJuego.setNombreJ1(Interaction.InputBox("Inserte Nombre a j1", "Inserte Nombre", "j1"));

            if (jugadores >= 2) {
                frmJuego.setNombreJ2(Interaction.InputBox("Inserte Nombre a j2", "Inserte Nombre", "j2"));
            }

            if (jugadores >= 3) {
                frmJuego.setNombreJ3(Interaction.InputBox("Inserte Nombre a j3", "Inserte Nombre", "j3"));
            }

            if (jugadores >= 4) {
                frmJuego.setNombreJ4(Interaction.InputBox("Inserte Nombre a j4", "Inserte Nombre", "j4"));
            }
        }

        private void frmJuego_Load(object sender, EventArgs e) {
            this.btnDado1.Location = new System.Drawing.Point(45, 150);
            this.btnDado2.Location = new System.Drawing.Point(198, 150);
            this.btnDado3.Location = new System.Drawing.Point(339, 150);
            this.btnDado4.Location = new System.Drawing.Point(121, 250);
            this.btnDado5.Location = new System.Drawing.Point(270, 250);

            this.j1.HeaderText = nombreJ1;
            this.j2.HeaderText = nombreJ2;
            this.j3.HeaderText = nombreJ3;
            this.j4.HeaderText = nombreJ4;

            lblTextoTurno.Text = "Turno de: " + this.j1.HeaderText;
        }

        private void btnVolver_Click(object sender, EventArgs e) {
            confirmarVolver();
        }

        private void confirmarVolver() {
            var confirmResult = MessageBox.Show("Seguro que quereis abandonar?",
                                     "Confirmar Abandono",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) {
                this.Hide();
                FrmInicio.getInstance().Show();
                mInstance = null;
            } 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnDado1_Click(object sender, EventArgs e) {
            if (dado1Tirar) {
                this.btnDado1.Location = new System.Drawing.Point(45, 350);
                dado1Tirar = false;
            } else {
                this.btnDado1.Location = new System.Drawing.Point(45, 150);
                dado1Tirar = true;
            }
        }

        private void btnDado2_Click(object sender, EventArgs e) {
            if (dado2Tirar) {
                this.btnDado2.Location = new System.Drawing.Point(198, 350);
                dado2Tirar = false;
            } else {
                this.btnDado2.Location = new System.Drawing.Point(198, 150);
                dado2Tirar = true;
            }
        }

        private void btnDado3_Click(object sender, EventArgs e) {
            if (dado3Tirar) {
                this.btnDado3.Location = new System.Drawing.Point(339, 350);
                dado3Tirar = false;
            } else {
                this.btnDado3.Location = new System.Drawing.Point(339, 150);
                dado3Tirar = true;
            }
        }

        private void btnDado4_Click(object sender, EventArgs e) {
            if (dado4Tirar) {
                this.btnDado4.Location = new System.Drawing.Point(121, 350);
                dado4Tirar = false;
            } else {
                this.btnDado4.Location = new System.Drawing.Point(121, 250);
                dado4Tirar = true;
            }
        }

        private void btnDado5_Click(object sender, EventArgs e) {
            if (dado5Tirar) {
                this.btnDado5.Location = new System.Drawing.Point(270, 350);
                dado5Tirar = false;
            } else {
                this.btnDado5.Location = new System.Drawing.Point(270, 250);
                dado5Tirar = true;
            }
        }

        private void btnTirarDados_Click(object sender, EventArgs e) {

            lblTiradas.Text = "Tiradas: " + (2- contadorTirarDados);

            SoundPlayer simpleSound = new SoundPlayer(global::Yahtzee.Properties.Resources.sonidoDados2);
            simpleSound.Play();

            btnSiguente.Enabled = true;

            btnDado1.Enabled = true;
            btnDado2.Enabled = true;
            btnDado3.Enabled = true;
            btnDado4.Enabled = true;
            btnDado5.Enabled = true;

            contadorTirarDados++;

            Random r = new Random();

            if (dado1Tirar) {
                int rInt = r.Next(1, 7); //for ints
                setImagenBoton(btnDado1, rInt);
            }
            if (dado2Tirar) {
                int rInt = r.Next(1, 7); //for ints
                setImagenBoton(btnDado2, rInt);
            }
            if (dado3Tirar) {
                int rInt = r.Next(1, 7); //for ints
                setImagenBoton(btnDado3, rInt);
            }
            if (dado4Tirar) {
                int rInt = r.Next(1, 7); //for ints
                setImagenBoton(btnDado4, rInt);
            }
            if (dado5Tirar) {
                int rInt = r.Next(1, 7); //for ints
                setImagenBoton(btnDado5, rInt);
            }

            if (contadorTirarDados == 3) {
                btnTirarDados.Enabled = false;
                btnSiguente.Enabled = true;
            }
        }

        private void setImagenBoton(Button boton, int numero) {
            switch (numero) {
                case 1:
                    boton.Image = global::Yahtzee.Properties.Resources.dado1;
                    break;
                case 2:
                    boton.Image = global::Yahtzee.Properties.Resources.dado2;
                    break;
                case 3:
                    boton.Image = global::Yahtzee.Properties.Resources.dado3;
                    break;
                case 4:
                    boton.Image = global::Yahtzee.Properties.Resources.dado4;
                    break;
                case 5:
                    boton.Image = global::Yahtzee.Properties.Resources.dado5;
                    break;
                case 6:
                    boton.Image = global::Yahtzee.Properties.Resources.dado6;
                    break;
            }
        }

        private void btnSiguente_Click(object sender, EventArgs e) {
            lblTiradas.Text = "Tiradas: 3";
            contadorTirarDados = 0;
            btnTirarDados.Enabled = true;
            btnSiguente.Enabled = false;

            this.btnDado1.Location = new System.Drawing.Point(45, 150);
            this.btnDado2.Location = new System.Drawing.Point(198, 150);
            this.btnDado3.Location = new System.Drawing.Point(339, 150);
            this.btnDado4.Location = new System.Drawing.Point(121, 250);
            this.btnDado5.Location = new System.Drawing.Point(270, 250);

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

            turno++;

            if (turno > jugadores) {
                turno = 1;
            }

            switch (turno) {
                case 1:
                    lblTextoTurno.Text = "Turno de: " + this.j1.HeaderText;
                    break;
                case 2:
                    lblTextoTurno.Text = "Turno de: " + this.j2.HeaderText;
                    break;
                case 3:
                    lblTextoTurno.Text = "Turno de: " + this.j3.HeaderText;
                    break;
                case 4:
                    lblTextoTurno.Text = "Turno de: " + this.j4.HeaderText;
                    break;
                default:
                    lblTextoTurno.Text = "Turno de: " + this.j1.HeaderText;
                    break;
            }

        }


    }
}
