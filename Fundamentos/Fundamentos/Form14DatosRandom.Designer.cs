namespace Fundamentos
{
	partial class Form14DatosRandom
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
			this.listDatos = new System.Windows.Forms.ListBox();
			this.btngenerar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSuma = new System.Windows.Forms.TextBox();
			this.btnVerDatos = new System.Windows.Forms.Button();
			this.txtImpares = new System.Windows.Forms.TextBox();
			this.txtPares = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listDatos
			// 
			this.listDatos.FormattingEnabled = true;
			this.listDatos.Location = new System.Drawing.Point(15, 35);
			this.listDatos.Name = "listDatos";
			this.listDatos.Size = new System.Drawing.Size(120, 199);
			this.listDatos.TabIndex = 0;
			// 
			// btngenerar
			// 
			this.btngenerar.Location = new System.Drawing.Point(171, 35);
			this.btngenerar.Name = "btngenerar";
			this.btngenerar.Size = new System.Drawing.Size(124, 23);
			this.btngenerar.TabIndex = 1;
			this.btngenerar.Text = "Generar";
			this.btngenerar.UseVisualStyleBackColor = true;
			this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Datos";
			// 
			// txtSuma
			// 
			this.txtSuma.Location = new System.Drawing.Point(220, 132);
			this.txtSuma.Name = "txtSuma";
			this.txtSuma.Size = new System.Drawing.Size(75, 20);
			this.txtSuma.TabIndex = 3;
			// 
			// btnVerDatos
			// 
			this.btnVerDatos.Location = new System.Drawing.Point(171, 74);
			this.btnVerDatos.Name = "btnVerDatos";
			this.btnVerDatos.Size = new System.Drawing.Size(124, 23);
			this.btnVerDatos.TabIndex = 4;
			this.btnVerDatos.Text = "Ver Datos";
			this.btnVerDatos.UseVisualStyleBackColor = true;
			this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
			// 
			// txtImpares
			// 
			this.txtImpares.Location = new System.Drawing.Point(220, 208);
			this.txtImpares.Name = "txtImpares";
			this.txtImpares.Size = new System.Drawing.Size(75, 20);
			this.txtImpares.TabIndex = 5;
			// 
			// txtPares
			// 
			this.txtPares.Location = new System.Drawing.Point(220, 171);
			this.txtPares.Name = "txtPares";
			this.txtPares.Size = new System.Drawing.Size(75, 20);
			this.txtPares.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(168, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Suma";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(168, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Pares";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(168, 215);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Impares";
			// 
			// Form14DatosRandom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 250);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPares);
			this.Controls.Add(this.txtImpares);
			this.Controls.Add(this.btnVerDatos);
			this.Controls.Add(this.txtSuma);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btngenerar);
			this.Controls.Add(this.listDatos);
			this.Name = "Form14DatosRandom";
			this.Text = "Form14DatosRandom";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listDatos;
		private System.Windows.Forms.Button btngenerar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSuma;
		private System.Windows.Forms.Button btnVerDatos;
		private System.Windows.Forms.TextBox txtImpares;
		private System.Windows.Forms.TextBox txtPares;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}