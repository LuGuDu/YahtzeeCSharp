using System.Windows.Forms;

namespace Yahtzee
{
    partial class frmJuego
    {

        private string[] tituloCombos = { "Aces", "Twos", "Threes", "Fours", "Fives",
            "Sixes", "Total Score", "Bonus", "Total Upper Section",
            "LOWER SELECTION", "3 of a kind", "4 of a kind", "Full House",
            "Small Straight", "Long Straight", "YAHTZEE", "Chance",
            "Yahtzee Bonus", "Total Lower Section", "TOTAL SCORE"};

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJugadores = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.j1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.j2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.j3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.j4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnDado1 = new System.Windows.Forms.Button();
            this.btnDado2 = new System.Windows.Forms.Button();
            this.btnDado3 = new System.Windows.Forms.Button();
            this.btnDado4 = new System.Windows.Forms.Button();
            this.btnDado5 = new System.Windows.Forms.Button();
            this.btnTirarDados = new System.Windows.Forms.Button();
            this.btnSiguente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJugadores
            // 
            this.lblJugadores.AutoSize = true;
            this.lblJugadores.Location = new System.Drawing.Point(32, 25);
            this.lblJugadores.Name = "lblJugadores";
            this.lblJugadores.Size = new System.Drawing.Size(46, 17);
            this.lblJugadores.TabIndex = 0;
            this.lblJugadores.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.combos,
            this.j1,
            this.j2,
            this.j3,
            this.j4});
            this.dataGridView1.Location = new System.Drawing.Point(542, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(510, 647);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // combos
            // 
            this.combos.HeaderText = "Combos";
            this.combos.MinimumWidth = 6;
            this.combos.Name = "combos";
            this.combos.ReadOnly = true;
            this.combos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.combos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.combos.Width = 125;
            // 
            // j1
            // 
            this.j1.HeaderText = "j1";
            this.j1.MinimumWidth = 6;
            this.j1.Name = "j1";
            this.j1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.j1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.j1.Width = 50;
            // 
            // j2
            // 
            this.j2.HeaderText = "j2";
            this.j2.MinimumWidth = 6;
            this.j2.Name = "j2";
            this.j2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.j2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.j2.Width = 50;
            // 
            // j3
            // 
            this.j3.HeaderText = "j3";
            this.j3.MinimumWidth = 6;
            this.j3.Name = "j3";
            this.j3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.j3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.j3.Width = 50;
            // 
            // j4
            // 
            this.j4.HeaderText = "j4";
            this.j4.MinimumWidth = 6;
            this.j4.Name = "j4";
            this.j4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.j4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.j4.Width = 50;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(950, 25);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(102, 34);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnDado1
            // 
            this.btnDado1.Enabled = false;
            this.btnDado1.Location = new System.Drawing.Point(45, 172);
            this.btnDado1.Name = "btnDado1";
            this.btnDado1.Size = new System.Drawing.Size(65, 60);
            this.btnDado1.TabIndex = 3;
            this.btnDado1.Text = "4";
            this.btnDado1.UseVisualStyleBackColor = true;
            this.btnDado1.Click += new System.EventHandler(this.btnDado1_Click);
            // 
            // btnDado2
            // 
            this.btnDado2.Enabled = false;
            this.btnDado2.Location = new System.Drawing.Point(198, 172);
            this.btnDado2.Name = "btnDado2";
            this.btnDado2.Size = new System.Drawing.Size(65, 60);
            this.btnDado2.TabIndex = 4;
            this.btnDado2.Text = "5";
            this.btnDado2.UseVisualStyleBackColor = true;
            this.btnDado2.Click += new System.EventHandler(this.btnDado2_Click);
            // 
            // btnDado3
            // 
            this.btnDado3.Enabled = false;
            this.btnDado3.Location = new System.Drawing.Point(339, 172);
            this.btnDado3.Name = "btnDado3";
            this.btnDado3.Size = new System.Drawing.Size(65, 60);
            this.btnDado3.TabIndex = 5;
            this.btnDado3.Text = "5";
            this.btnDado3.UseVisualStyleBackColor = true;
            this.btnDado3.Click += new System.EventHandler(this.btnDado3_Click);
            // 
            // btnDado4
            // 
            this.btnDado4.Enabled = false;
            this.btnDado4.Location = new System.Drawing.Point(121, 277);
            this.btnDado4.Name = "btnDado4";
            this.btnDado4.Size = new System.Drawing.Size(65, 60);
            this.btnDado4.TabIndex = 6;
            this.btnDado4.Text = "2";
            this.btnDado4.UseVisualStyleBackColor = true;
            this.btnDado4.Click += new System.EventHandler(this.btnDado4_Click);
            // 
            // btnDado5
            // 
            this.btnDado5.Enabled = false;
            this.btnDado5.Location = new System.Drawing.Point(270, 277);
            this.btnDado5.Name = "btnDado5";
            this.btnDado5.Size = new System.Drawing.Size(65, 60);
            this.btnDado5.TabIndex = 7;
            this.btnDado5.Text = "3";
            this.btnDado5.UseVisualStyleBackColor = true;
            this.btnDado5.Click += new System.EventHandler(this.btnDado5_Click);
            // 
            // btnTirarDados
            // 
            this.btnTirarDados.Location = new System.Drawing.Point(62, 555);
            this.btnTirarDados.Name = "btnTirarDados";
            this.btnTirarDados.Size = new System.Drawing.Size(410, 36);
            this.btnTirarDados.TabIndex = 8;
            this.btnTirarDados.Text = "Tirar Dados";
            this.btnTirarDados.UseVisualStyleBackColor = true;
            this.btnTirarDados.Click += new System.EventHandler(this.btnTirarDados_Click);
            // 
            // btnSiguente
            // 
            this.btnSiguente.Enabled = false;
            this.btnSiguente.Location = new System.Drawing.Point(270, 620);
            this.btnSiguente.Name = "btnSiguente";
            this.btnSiguente.Size = new System.Drawing.Size(202, 47);
            this.btnSiguente.TabIndex = 9;
            this.btnSiguente.Text = "Siguiente Turno";
            this.btnSiguente.UseVisualStyleBackColor = true;
            this.btnSiguente.Click += new System.EventHandler(this.btnSiguente_Click);
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1087, 805);
            this.Controls.Add(this.btnSiguente);
            this.Controls.Add(this.btnTirarDados);
            this.Controls.Add(this.btnDado5);
            this.Controls.Add(this.btnDado4);
            this.Controls.Add(this.btnDado3);
            this.Controls.Add(this.btnDado2);
            this.Controls.Add(this.btnDado1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblJugadores);
            this.Name = "frmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yahtzee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmJuego_FormClosing);
            this.Load += new System.EventHandler(this.frmJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public void SetTable(int jugadores) {
            if(jugadores == 2) {
                this.j3.Visible = false;
                this.j4.Visible = false;
            } else if (jugadores == 3){
                this.j3.Visible = true;
                this.j4.Visible = false;
            } else {
                this.j3.Visible = true;
                this.j4.Visible = true;
            }
            rellenarPrimeraColumna();
        }

        private void rellenarPrimeraColumna() {
            this.dataGridView1.Rows.Clear();
            for (int i = 0; i<this.tituloCombos.Length; i++){
                this.dataGridView1.Rows.Add(this.tituloCombos[i], "", "", "", "");
            }
        }

        private System.Windows.Forms.Label lblJugadores;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVolver;
        private DataGridViewTextBoxColumn combos;
        private DataGridViewTextBoxColumn j1;
        private DataGridViewTextBoxColumn j2;
        private DataGridViewTextBoxColumn j3;
        private DataGridViewTextBoxColumn j4;
        private Button btnDado1;
        private Button btnDado2;
        private Button btnDado3;
        private Button btnDado4;
        private Button btnDado5;
        private Button btnTirarDados;
        private Button btnSiguente;
    }
}