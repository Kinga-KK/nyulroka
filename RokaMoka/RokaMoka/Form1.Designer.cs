
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
            this.label2 = new System.Windows.Forms.Label();
            this.oszlopok = new System.Windows.Forms.NumericUpDown();
            this.panel = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sorok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oszlopok)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sorok
            // 
            this.sorok.BackColor = System.Drawing.Color.Black;
            this.sorok.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorok.ForeColor = System.Drawing.Color.Red;
            this.sorok.Location = new System.Drawing.Point(143, 75);
            this.sorok.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sorok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sorok.Name = "sorok";
            this.sorok.Size = new System.Drawing.Size(79, 39);
            this.sorok.TabIndex = 0;
            this.sorok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sorok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mekkora játékteret szeretnél?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(261, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // oszlopok
            // 
            this.oszlopok.BackColor = System.Drawing.Color.Black;
            this.oszlopok.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oszlopok.ForeColor = System.Drawing.Color.Red;
            this.oszlopok.Location = new System.Drawing.Point(334, 75);
            this.oszlopok.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.oszlopok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.oszlopok.Name = "oszlopok";
            this.oszlopok.Size = new System.Drawing.Size(79, 39);
            this.oszlopok.TabIndex = 0;
            this.oszlopok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oszlopok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel
            // 
            this.panel.Controls.Add(this.Start);
            this.panel.Location = new System.Drawing.Point(101, 150);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(360, 260);
            this.panel.TabIndex = 2;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Red;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(104, 86);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(154, 64);
            this.Start.TabIndex = 0;
            this.Start.Text = "Mehet!";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(138, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Készítette: Kiss Kinga, Németh Kristóf";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(561, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oszlopok);
            this.Controls.Add(this.sorok);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RókaMóka";
            ((System.ComponentModel.ISupportInitialize)(this.sorok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oszlopok)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sorok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown oszlopok;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

