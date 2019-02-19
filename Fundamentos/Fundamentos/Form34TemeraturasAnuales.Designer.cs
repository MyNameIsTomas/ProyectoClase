namespace Fundamentos
{
	partial class Form34TemeraturasAnuales
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
			this.btnGenerar = new System.Windows.Forms.Button();
			this.txtMinima = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMedia = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaxima = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listMeses = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textNumAños = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textMaxAnual = new System.Windows.Forms.TextBox();
			this.textMinAnual = new System.Windows.Forms.TextBox();
			this.textMediaAnual = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.comboAños = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnGenerar
			// 
			this.btnGenerar.Location = new System.Drawing.Point(12, 55);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(164, 20);
			this.btnGenerar.TabIndex = 24;
			this.btnGenerar.Text = "Generar temperaturas";
			this.btnGenerar.UseVisualStyleBackColor = true;
			this.btnGenerar.Click += new System.EventHandler(this.btngenerar_Click);
			// 
			// txtMinima
			// 
			this.txtMinima.Location = new System.Drawing.Point(216, 258);
			this.txtMinima.Name = "txtMinima";
			this.txtMinima.Size = new System.Drawing.Size(100, 20);
			this.txtMinima.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(216, 232);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 22;
			this.label3.Text = "Minima";
			// 
			// txtMedia
			// 
			this.txtMedia.Location = new System.Drawing.Point(216, 209);
			this.txtMedia.Name = "txtMedia";
			this.txtMedia.Size = new System.Drawing.Size(100, 20);
			this.txtMedia.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(216, 183);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 20;
			this.label2.Text = "Media";
			// 
			// txtMaxima
			// 
			this.txtMaxima.Location = new System.Drawing.Point(216, 160);
			this.txtMaxima.Name = "txtMaxima";
			this.txtMaxima.Size = new System.Drawing.Size(100, 20);
			this.txtMaxima.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(216, 134);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "Maxima";
			// 
			// listMeses
			// 
			this.listMeses.FormattingEnabled = true;
			this.listMeses.Location = new System.Drawing.Point(-1, 134);
			this.listMeses.Name = "listMeses";
			this.listMeses.Size = new System.Drawing.Size(200, 316);
			this.listMeses.TabIndex = 17;
			this.listMeses.SelectedIndexChanged += new System.EventHandler(this.lstmeses_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 25;
			this.label4.Text = "Meses";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(9, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 26;
			this.label5.Text = "Año";
			// 
			// textNumAños
			// 
			this.textNumAños.Location = new System.Drawing.Point(226, 6);
			this.textNumAños.Name = "textNumAños";
			this.textNumAños.Size = new System.Drawing.Size(100, 20);
			this.textNumAños.TabIndex = 29;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(140, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 28;
			this.label6.Text = "Número de años:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(182, 38);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 30;
			this.label7.Text = "Max anual";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(255, 38);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 31;
			this.label8.Text = "Min anual";
			// 
			// textMaxAnual
			// 
			this.textMaxAnual.Location = new System.Drawing.Point(185, 55);
			this.textMaxAnual.Name = "textMaxAnual";
			this.textMaxAnual.Size = new System.Drawing.Size(58, 20);
			this.textMaxAnual.TabIndex = 32;
			// 
			// textMinAnual
			// 
			this.textMinAnual.Location = new System.Drawing.Point(258, 55);
			this.textMinAnual.Name = "textMinAnual";
			this.textMinAnual.Size = new System.Drawing.Size(58, 20);
			this.textMinAnual.TabIndex = 33;
			// 
			// textMediaAnual
			// 
			this.textMediaAnual.Location = new System.Drawing.Point(185, 106);
			this.textMediaAnual.Name = "textMediaAnual";
			this.textMediaAnual.Size = new System.Drawing.Size(131, 20);
			this.textMediaAnual.TabIndex = 35;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(216, 91);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 34;
			this.label9.Text = "Media anual";
			// 
			// comboAños
			// 
			this.comboAños.FormattingEnabled = true;
			this.comboAños.Location = new System.Drawing.Point(33, 5);
			this.comboAños.Name = "comboAños";
			this.comboAños.Size = new System.Drawing.Size(101, 21);
			this.comboAños.TabIndex = 37;
			this.comboAños.Click += new System.EventHandler(this.cmbanyos_SelectedIndexChanged);
			// 
			// Form34TemeraturasAnuales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 450);
			this.Controls.Add(this.comboAños);
			this.Controls.Add(this.textMediaAnual);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textMinAnual);
			this.Controls.Add(this.textMaxAnual);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textNumAños);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnGenerar);
			this.Controls.Add(this.txtMinima);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMedia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMaxima);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listMeses);
			this.Name = "Form34TemeraturasAnuales";
			this.Text = "Form34TemeraturasAnuales";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGenerar;
		private System.Windows.Forms.TextBox txtMinima;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMedia;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMaxima;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listMeses;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textNumAños;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textMaxAnual;
		private System.Windows.Forms.TextBox textMinAnual;
		private System.Windows.Forms.TextBox textMediaAnual;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox comboAños;
	}
}