namespace Fundamentos
{
	partial class Form05DiaSemana
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.resultado = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comprobar = new System.Windows.Forms.Button();
			this.dia = new System.Windows.Forms.TextBox();
			this.mes = new System.Windows.Forms.TextBox();
			this.ano = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(96, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Día Semana";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(96, 188);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Naciste un";
			// 
			// resultado
			// 
			this.resultado.Location = new System.Drawing.Point(77, 220);
			this.resultado.Name = "resultado";
			this.resultado.Size = new System.Drawing.Size(100, 20);
			this.resultado.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Día";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Mes";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 108);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Año";
			// 
			// comprobar
			// 
			this.comprobar.Location = new System.Drawing.Point(88, 146);
			this.comprobar.Name = "comprobar";
			this.comprobar.Size = new System.Drawing.Size(75, 23);
			this.comprobar.TabIndex = 12;
			this.comprobar.Text = "Comprobar";
			this.comprobar.UseVisualStyleBackColor = true;
			this.comprobar.Click += new System.EventHandler(this.comprobar_Click);
			// 
			// dia
			// 
			this.dia.Location = new System.Drawing.Point(88, 54);
			this.dia.MaxLength = 2;
			this.dia.Name = "dia";
			this.dia.Size = new System.Drawing.Size(100, 20);
			this.dia.TabIndex = 13;
			// 
			// mes
			// 
			this.mes.Location = new System.Drawing.Point(88, 79);
			this.mes.Name = "mes";
			this.mes.Size = new System.Drawing.Size(100, 20);
			this.mes.TabIndex = 14;
			// 
			// ano
			// 
			this.ano.Location = new System.Drawing.Point(88, 105);
			this.ano.Name = "ano";
			this.ano.Size = new System.Drawing.Size(100, 20);
			this.ano.TabIndex = 15;
			// 
			// Form05DiaSemana
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 272);
			this.Controls.Add(this.ano);
			this.Controls.Add(this.mes);
			this.Controls.Add(this.dia);
			this.Controls.Add(this.comprobar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.resultado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form05DiaSemana";
			this.Text = "Form05DiaSemana";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox resultado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button comprobar;
		private System.Windows.Forms.TextBox dia;
		private System.Windows.Forms.TextBox mes;
		private System.Windows.Forms.TextBox ano;
	}
}