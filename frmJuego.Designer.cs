using System.Windows.Forms;

namespace Yahtzee
{
    partial class FrmJuego
    {

        private string[] tituloCombos = { "Aces", "Twos", "Threes", "Fours", "Fives",
            "Sixes", "Total Score", "Bonus", "Total Upper Section",
            "LOWER SELECTION", "3 of a kind", "4 of a kind", "Full House (25)",
            "Small Straight (30)", "Long Straight (40)", "YAHTZEE (50)", "Chance",
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJuego));
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
            this.lblTextoTurno = new System.Windows.Forms.Label();
            this.lblTiradas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(611, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(509, 647);
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
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Location = new System.Drawing.Point(61, 620);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(113, 47);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Abandonar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnDado1
            // 
            this.btnDado1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDado1.Enabled = false;
            this.btnDado1.Image = ((System.Drawing.Image)(resources.GetObject("btnDado1.Image")));
            this.btnDado1.Location = new System.Drawing.Point(45, 172);
            this.btnDado1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDado1.Name = "btnDado1";
            this.btnDado1.Size = new System.Drawing.Size(80, 74);
            this.btnDado1.TabIndex = 3;
            this.btnDado1.UseVisualStyleBackColor = true;
            this.btnDado1.Click += new System.EventHandler(this.btnDado1_Click);
            // 
            // btnDado2
            // 
            this.btnDado2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDado2.Enabled = false;
            this.btnDado2.Image = ((System.Drawing.Image)(resources.GetObject("btnDado2.Image")));
            this.btnDado2.Location = new System.Drawing.Point(197, 172);
            this.btnDado2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDado2.Name = "btnDado2";
            this.btnDado2.Size = new System.Drawing.Size(80, 74);
            this.btnDado2.TabIndex = 4;
            this.btnDado2.UseVisualStyleBackColor = true;
            this.btnDado2.Click += new System.EventHandler(this.btnDado2_Click);
            // 
            // btnDado3
            // 
            this.btnDado3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDado3.Enabled = false;
            this.btnDado3.Image = global::Yahtzee.Properties.Resources.dado2;
            this.btnDado3.Location = new System.Drawing.Point(339, 172);
            this.btnDado3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDado3.Name = "btnDado3";
            this.btnDado3.Size = new System.Drawing.Size(80, 74);
            this.btnDado3.TabIndex = 5;
            this.btnDado3.UseVisualStyleBackColor = true;
            this.btnDado3.Click += new System.EventHandler(this.btnDado3_Click);
            // 
            // btnDado4
            // 
            this.btnDado4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDado4.Enabled = false;
            this.btnDado4.Image = ((System.Drawing.Image)(resources.GetObject("btnDado4.Image")));
            this.btnDado4.Location = new System.Drawing.Point(121, 277);
            this.btnDado4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDado4.Name = "btnDado4";
            this.btnDado4.Size = new System.Drawing.Size(80, 74);
            this.btnDado4.TabIndex = 6;
            this.btnDado4.UseVisualStyleBackColor = true;
            this.btnDado4.Click += new System.EventHandler(this.btnDado4_Click);
            // 
            // btnDado5
            // 
            this.btnDado5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDado5.Enabled = false;
            this.btnDado5.Image = ((System.Drawing.Image)(resources.GetObject("btnDado5.Image")));
            this.btnDado5.Location = new System.Drawing.Point(269, 277);
            this.btnDado5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDado5.Name = "btnDado5";
            this.btnDado5.Size = new System.Drawing.Size(80, 74);
            this.btnDado5.TabIndex = 7;
            this.btnDado5.UseVisualStyleBackColor = true;
            this.btnDado5.Click += new System.EventHandler(this.btnDado5_Click);
            // 
            // btnTirarDados
            // 
            this.btnTirarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTirarDados.Location = new System.Drawing.Point(61, 555);
            this.btnTirarDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTirarDados.Name = "btnTirarDados";
            this.btnTirarDados.Size = new System.Drawing.Size(411, 36);
            this.btnTirarDados.TabIndex = 8;
            this.btnTirarDados.Text = "Tirar Dados";
            this.btnTirarDados.UseVisualStyleBackColor = true;
            this.btnTirarDados.Click += new System.EventHandler(this.btnTirarDados_Click);
            // 
            // btnSiguente
            // 
            this.btnSiguente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguente.Enabled = false;
            this.btnSiguente.Location = new System.Drawing.Point(197, 620);
            this.btnSiguente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiguente.Name = "btnSiguente";
            this.btnSiguente.Size = new System.Drawing.Size(275, 47);
            this.btnSiguente.TabIndex = 9;
            this.btnSiguente.Text = "Siguiente Turno";
            this.btnSiguente.UseVisualStyleBackColor = true;
            this.btnSiguente.Click += new System.EventHandler(this.btnSiguente_Click);
            // 
            // lblTextoTurno
            // 
            this.lblTextoTurno.AutoSize = true;
            this.lblTextoTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoTurno.Location = new System.Drawing.Point(39, 60);
            this.lblTextoTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextoTurno.Name = "lblTextoTurno";
            this.lblTextoTurno.Size = new System.Drawing.Size(139, 31);
            this.lblTextoTurno.TabIndex = 10;
            this.lblTextoTurno.Text = "Turno de:";
            // 
            // lblTiradas
            // 
            this.lblTiradas.AutoSize = true;
            this.lblTiradas.Location = new System.Drawing.Point(489, 565);
            this.lblTiradas.Name = "lblTiradas";
            this.lblTiradas.Size = new System.Drawing.Size(72, 17);
            this.lblTiradas.TabIndex = 11;
            this.lblTiradas.Text = "Tiradas: 3";
            this.lblTiradas.Click += new System.EventHandler(this.lblTiradas_Click);
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1164, 805);
            this.Controls.Add(this.lblTiradas);
            this.Controls.Add(this.lblTextoTurno);
            this.Controls.Add(this.btnSiguente);
            this.Controls.Add(this.btnTirarDados);
            this.Controls.Add(this.btnDado5);
            this.Controls.Add(this.btnDado4);
            this.Controls.Add(this.btnDado3);
            this.Controls.Add(this.btnDado2);
            this.Controls.Add(this.btnDado1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmJuego";
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
        private Label lblTextoTurno;
        private Label lblTiradas;
    }
}