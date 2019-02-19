namespace Fundamentos
{
	partial class Form09SumarNumeros
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
			this.btnsumar = new System.Windows.Forms.Button();
			this.txtnumeros = new System.Windows.Forms.TextBox();
			this.resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Introduzca numeros";
			// 
			// btnsumar
			// 
			this.btnsumar.Location = new System.Drawing.Point(63, 71);
			this.btnsumar.Name = "btnsumar";
			this.btnsumar.Size = new System.Drawing.Size(75, 23);
			this.btnsumar.TabIndex = 1;
			this.btnsumar.Text = "Sumar";
			this.btnsumar.UseVisualStyleBackColor = true;
			this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
			// 
			// txtnumeros
			// 
			this.txtnumeros.Location = new System.Drawing.Point(51, 45);
			this.txtnumeros.Name = "txtnumeros";
			this.txtnumeros.Size = new System.Drawing.Size(100, 20);
			this.txtnumeros.TabIndex = 2;
			// 
			// resultado
			// 
			this.resultado.AutoSize = true;
			this.resultado.Location = new System.Drawing.Point(72, 120);
			this.resultado.Name = "resultado";
			this.resultado.Size = new System.Drawing.Size(55, 13);
			this.resultado.TabIndex = 3;
			this.resultado.Text = "Resultado";
			// 
			// Form09SumarNumeros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(208, 183);
			this.Controls.Add(this.resultado);
			this.Controls.Add(this.txtnumeros);
			this.Controls.Add(this.btnsumar);
			this.Controls.Add(this.label1);
			this.Name = "Form09SumarNumeros";
			this.Text = "Form09SumarNumeros";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnsumar;
		private System.Windows.Forms.TextBox txtnumeros;
		private System.Windows.Forms.Label resultado;
	}
}