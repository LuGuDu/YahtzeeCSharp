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
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1087, 805);
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

    }
}