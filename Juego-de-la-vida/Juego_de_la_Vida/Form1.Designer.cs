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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Dibujar = new System.Windows.Forms.Button();
            this.MyGrid = new System.Windows.Forms.DataGridView();
            this.filasInput = new System.Windows.Forms.TextBox();
            this.colInput = new System.Windows.Forms.TextBox();
            this.Filaslbl = new System.Windows.Forms.Label();
            this.ColLbl = new System.Windows.Forms.Label();
            this.Step = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.aplicar = new System.Windows.Forms.Button();
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
            this.Dibujar.Location = new System.Drawing.Point(152, 166);
            this.Dibujar.Margin = new System.Windows.Forms.Padding(4);
            this.Dibujar.Name = "Dibujar";
            this.Dibujar.Size = new System.Drawing.Size(100, 28);
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
            this.MyGrid.Location = new System.Drawing.Point(291, 69);
            this.MyGrid.Margin = new System.Windows.Forms.Padding(4);
            this.MyGrid.MultiSelect = false;
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.ReadOnly = true;
            this.MyGrid.RowHeadersWidth = 51;
            this.MyGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MyGrid.Size = new System.Drawing.Size(455, 363);
            this.MyGrid.TabIndex = 1;
            this.MyGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyGrid_CellClick);
            this.MyGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyGrid_CellClick);
            // 
            // filasInput
            // 
            this.filasInput.Location = new System.Drawing.Point(119, 63);
            this.filasInput.Margin = new System.Windows.Forms.Padding(4);
            this.filasInput.Name = "filasInput";
            this.filasInput.Size = new System.Drawing.Size(132, 22);
            this.filasInput.TabIndex = 2;
            // 
            // colInput
            // 
            this.colInput.Location = new System.Drawing.Point(119, 112);
            this.colInput.Margin = new System.Windows.Forms.Padding(4);
            this.colInput.Name = "colInput";
            this.colInput.Size = new System.Drawing.Size(132, 22);
            this.colInput.TabIndex = 3;
            // 
            // Filaslbl
            // 
            this.Filaslbl.AutoSize = true;
            this.Filaslbl.Location = new System.Drawing.Point(16, 66);
            this.Filaslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Filaslbl.Name = "Filaslbl";
            this.Filaslbl.Size = new System.Drawing.Size(72, 17);
            this.Filaslbl.TabIndex = 4;
            this.Filaslbl.Text = "Nº de filas";
            // 
            // ColLbl
            // 
            this.ColLbl.AutoSize = true;
            this.ColLbl.Location = new System.Drawing.Point(1, 116);
            this.ColLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColLbl.Name = "ColLbl";
            this.ColLbl.Size = new System.Drawing.Size(107, 17);
            this.ColLbl.TabIndex = 5;
            this.ColLbl.Text = "Nº de columnas";
            // 
            // Step
            // 
            this.Step.Image = ((System.Drawing.Image)(resources.GetObject("Step.Image")));
            this.Step.Location = new System.Drawing.Point(96, 202);
            this.Step.Margin = new System.Windows.Forms.Padding(4);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(117, 89);
            this.Step.TabIndex = 6;
            this.Step.Text = ">>";
            this.Step.UseVisualStyleBackColor = true;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(132, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 83);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(119, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 111);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(980, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Si esta vivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(880, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Si esta muerto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Num de vecis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(788, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(788, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(788, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(788, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(788, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(788, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(788, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(788, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(788, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "8";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(907, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 22);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(907, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 22);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(907, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 22);
            this.textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(907, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(32, 22);
            this.textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(907, 258);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(32, 22);
            this.textBox5.TabIndex = 25;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(907, 288);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(32, 22);
            this.textBox6.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(907, 321);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(32, 22);
            this.textBox7.TabIndex = 27;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(907, 349);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(32, 22);
            this.textBox8.TabIndex = 28;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(907, 379);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(32, 22);
            this.textBox9.TabIndex = 29;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1006, 129);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(32, 22);
            this.textBox10.TabIndex = 30;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(1006, 153);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(32, 22);
            this.textBox11.TabIndex = 31;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1006, 183);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(32, 22);
            this.textBox12.TabIndex = 32;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(1006, 219);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(32, 22);
            this.textBox13.TabIndex = 33;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(1006, 258);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(32, 22);
            this.textBox14.TabIndex = 34;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(1006, 288);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(32, 22);
            this.textBox15.TabIndex = 35;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(1006, 321);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(32, 22);
            this.textBox16.TabIndex = 36;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(1006, 349);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(32, 22);
            this.textBox17.TabIndex = 37;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(1006, 380);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(32, 22);
            this.textBox18.TabIndex = 38;
            // 
            // aplicar
            // 
            this.aplicar.Location = new System.Drawing.Point(916, 459);
            this.aplicar.Name = "aplicar";
            this.aplicar.Size = new System.Drawing.Size(84, 31);
            this.aplicar.TabIndex = 39;
            this.aplicar.Text = "aplicar";
            this.aplicar.UseVisualStyleBackColor = true;
            this.aplicar.Click += new System.EventHandler(this.aplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.aplicar);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.ColLbl);
            this.Controls.Add(this.Filaslbl);
            this.Controls.Add(this.colInput);
            this.Controls.Add(this.filasInput);
            this.Controls.Add(this.MyGrid);
            this.Controls.Add(this.Dibujar);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button aplicar;
    }
}

