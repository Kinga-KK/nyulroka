
namespace RokaMoka
{
    partial class Form1
    {
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
            this.components = new System.ComponentModel.Container();
            this.sorok = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.oszlopok = new System.Windows.Forms.NumericUpDown();
            this.panel = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunnynumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sorok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oszlopok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnynumber)).BeginInit();
            this.SuspendLayout();
            // 
            // sorok
            // 
            this.sorok.BackColor = System.Drawing.Color.Black;
            this.sorok.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorok.ForeColor = System.Drawing.Color.Red;
            this.sorok.Location = new System.Drawing.Point(67, 103);
            this.sorok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sorok.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sorok.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sorok.Name = "sorok";
            this.sorok.Size = new System.Drawing.Size(105, 49);
            this.sorok.TabIndex = 0;
            this.sorok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sorok.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(52, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mekkora játékteret szeretnél?";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.Color.Black;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.Red;
            this.labelX.Location = new System.Drawing.Point(215, 91);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(79, 76);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X";
            // 
            // oszlopok
            // 
            this.oszlopok.BackColor = System.Drawing.Color.Black;
            this.oszlopok.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oszlopok.ForeColor = System.Drawing.Color.Red;
            this.oszlopok.Location = new System.Drawing.Point(321, 103);
            this.oszlopok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oszlopok.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.oszlopok.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.oszlopok.Name = "oszlopok";
            this.oszlopok.Size = new System.Drawing.Size(105, 49);
            this.oszlopok.TabIndex = 0;
            this.oszlopok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oszlopok.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(64, 364);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1140, 320);
            this.panel.TabIndex = 2;
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.BackColor = System.Drawing.Color.Red;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(1007, 20);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(379, 132);
            this.Start.TabIndex = 0;
            this.Start.Text = "Mehet!";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(56, 697);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(914, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Készítette: Kiss Kinga, Németh Kristóf, Sági Dániel";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(55, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bunny%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(215, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 76);
            this.label4.TabIndex = 7;
            this.label4.Text = "/";
            this.label4.Visible = false;
            // 
            // bunnynumber
            // 
            this.bunnynumber.BackColor = System.Drawing.Color.Black;
            this.bunnynumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunnynumber.ForeColor = System.Drawing.Color.Red;
            this.bunnynumber.Location = new System.Drawing.Point(67, 287);
            this.bunnynumber.Margin = new System.Windows.Forms.Padding(4);
            this.bunnynumber.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.bunnynumber.Name = "bunnynumber";
            this.bunnynumber.Size = new System.Drawing.Size(105, 49);
            this.bunnynumber.TabIndex = 6;
            this.bunnynumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunnynumber.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1513, 755);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunnynumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oszlopok);
            this.Controls.Add(this.sorok);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1500, 790);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RókaMóka";
            ((System.ComponentModel.ISupportInitialize)(this.sorok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oszlopok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnynumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sorok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.NumericUpDown oszlopok;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown bunnynumber;
    }
}

