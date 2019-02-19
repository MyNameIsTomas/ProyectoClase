namespace Fundamentos
{
	partial class Form33TemperaturaAnual
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
			this.SuspendLayout();
			// 
			// btnGenerar
			// 
			this.btnGenerar.Location = new System.Drawing.Point(206, 190);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(100, 55);
			this.btnGenerar.TabIndex = 16;
			this.btnGenerar.Text = "Generar";
			this.btnGenerar.UseVisualStyleBackColor = true;
			this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
			// 
			// txtMinima
			// 
			this.txtMinima.Location = new System.Drawing.Point(206, 164);
			this.txtMinima.Name = "txtMinima";
			this.txtMinima.Size = new System.Drawing.Size(100, 20);
			this.txtMinima.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(206, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "Minima";
			// 
			// txtMedia
			// 
			this.txtMedia.Location = new System.Drawing.Point(206, 115);
			this.txtMedia.Name = "txtMedia";
			this.txtMedia.Size = new System.Drawing.Size(100, 20);
			this.txtMedia.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(206, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "Media";
			// 
			// txtMaxima
			// 
			this.txtMaxima.Location = new System.Drawing.Point(206, 66);
			this.txtMaxima.Name = "txtMaxima";
			this.txtMaxima.Size = new System.Drawing.Size(100, 20);
			this.txtMaxima.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(206, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "Maxima";
			// 
			// listMeses
			// 
			this.listMeses.FormattingEnabled = true;
			this.listMeses.Location = new System.Drawing.Point(0, -1);
			this.listMeses.Name = "listMeses";
			this.listMeses.Size = new System.Drawing.Size(200, 368);
			this.listMeses.TabIndex = 9;
			this.listMeses.SelectedIndexChanged += new System.EventHandler(this.listMeses_SelectedIndexChanged);
			// 
			// Form33TemperaturaAnual
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 368);
			this.Controls.Add(this.btnGenerar);
			this.Controls.Add(this.txtMinima);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMedia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMaxima);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listMeses);
			this.Name = "Form33TemperaturaAnual";
			this.Text = "Form33TemperaturaAnual";
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
	}
}