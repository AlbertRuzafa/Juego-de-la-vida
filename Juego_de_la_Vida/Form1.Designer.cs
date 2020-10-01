namespace Juego_de_la_Vida
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Dibujar = new System.Windows.Forms.Button();
            this.MyGrid = new System.Windows.Forms.DataGridView();
            this.filasInput = new System.Windows.Forms.TextBox();
            this.colInput = new System.Windows.Forms.TextBox();
            this.Filaslbl = new System.Windows.Forms.Label();
            this.ColLbl = new System.Windows.Forms.Label();
            this.Step = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Dibujar
            // 
            this.Dibujar.Location = new System.Drawing.Point(114, 135);
            this.Dibujar.Name = "Dibujar";
            this.Dibujar.Size = new System.Drawing.Size(75, 23);
            this.Dibujar.TabIndex = 0;
            this.Dibujar.Text = "Dibujar";
            this.Dibujar.UseVisualStyleBackColor = true;
            this.Dibujar.Click += new System.EventHandler(this.Dibujar_Click);
            // 
            // MyGrid
            // 
            this.MyGrid.AllowUserToAddRows = false;
            this.MyGrid.AllowUserToDeleteRows = false;
            this.MyGrid.AllowUserToResizeColumns = false;
            this.MyGrid.AllowUserToResizeRows = false;
            this.MyGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MyGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MyGrid.Location = new System.Drawing.Point(237, 51);
            this.MyGrid.MultiSelect = false;
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.ReadOnly = true;
            this.MyGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MyGrid.Size = new System.Drawing.Size(341, 295);
            this.MyGrid.TabIndex = 1;
            this.MyGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyGrid_CellClick);
            this.MyGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyGrid_CellClick);
            // 
            // filasInput
            // 
            this.filasInput.Location = new System.Drawing.Point(89, 51);
            this.filasInput.Name = "filasInput";
            this.filasInput.Size = new System.Drawing.Size(100, 20);
            this.filasInput.TabIndex = 2;
            // 
            // colInput
            // 
            this.colInput.Location = new System.Drawing.Point(89, 91);
            this.colInput.Name = "colInput";
            this.colInput.Size = new System.Drawing.Size(100, 20);
            this.colInput.TabIndex = 3;
            // 
            // Filaslbl
            // 
            this.Filaslbl.AutoSize = true;
            this.Filaslbl.Location = new System.Drawing.Point(12, 54);
            this.Filaslbl.Name = "Filaslbl";
            this.Filaslbl.Size = new System.Drawing.Size(55, 13);
            this.Filaslbl.TabIndex = 4;
            this.Filaslbl.Text = "Nº de filas";
            // 
            // ColLbl
            // 
            this.ColLbl.AutoSize = true;
            this.ColLbl.Location = new System.Drawing.Point(1, 94);
            this.ColLbl.Name = "ColLbl";
            this.ColLbl.Size = new System.Drawing.Size(82, 13);
            this.ColLbl.TabIndex = 5;
            this.ColLbl.Text = "Nº de columnas";
            // 
            // Step
            // 
            this.Step.Image = ((System.Drawing.Image)(resources.GetObject("Step.Image")));
            this.Step.Location = new System.Drawing.Point(72, 164);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(117, 144);
            this.Step.TabIndex = 6;
            this.Step.Text = ">>";
            this.Step.UseVisualStyleBackColor = true;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.ColLbl);
            this.Controls.Add(this.Filaslbl);
            this.Controls.Add(this.colInput);
            this.Controls.Add(this.filasInput);
            this.Controls.Add(this.MyGrid);
            this.Controls.Add(this.Dibujar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button Dibujar;
        private System.Windows.Forms.DataGridView MyGrid;
        private System.Windows.Forms.TextBox filasInput;
        private System.Windows.Forms.TextBox colInput;
        private System.Windows.Forms.Label Filaslbl;
        private System.Windows.Forms.Label ColLbl;
        private System.Windows.Forms.Button Step;
    }
}

