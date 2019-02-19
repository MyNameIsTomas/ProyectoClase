namespace Fundamentos
{
	partial class Form11NumeroNarcisista
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
			this.resultado = new System.Windows.Forms.Label();
			this.comprobar = new System.Windows.Forms.Button();
			this.txtnarcisista = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Introduzca un número";
			// 
			// resultado
			// 
			this.resultado.AutoSize = true;
			this.resultado.Location = new System.Drawing.Point(20, 114);
			this.resultado.Name = "resultado";
			this.resultado.Size = new System.Drawing.Size(0, 13);
			this.resultado.TabIndex = 1;
			// 
			// comprobar
			// 
			this.comprobar.Location = new System.Drawing.Point(23, 64);
			this.comprobar.Name = "comprobar";
			this.comprobar.Size = new System.Drawing.Size(241, 23);
			this.comprobar.TabIndex = 2;
			this.comprobar.Text = "Comprobar número narcisista";
			this.comprobar.UseVisualStyleBackColor = true;
			this.comprobar.Click += new System.EventHandler(this.comprobar_Click);
			// 
			// txtnarcisista
			// 
			this.txtnarcisista.Location = new System.Drawing.Point(136, 25);
			this.txtnarcisista.Name = "txtnarcisista";
			this.txtnarcisista.Size = new System.Drawing.Size(128, 20);
			this.txtnarcisista.TabIndex = 3;
			// 
			// Form11NumeroNarcisista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 157);
			this.Controls.Add(this.txtnarcisista);
			this.Controls.Add(this.comprobar);
			this.Controls.Add(this.resultado);
			this.Controls.Add(this.label1);
			this.Name = "Form11NumeroNarcisista";
			this.Text = "Form11NumeroNarcisista";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label resultado;
		private System.Windows.Forms.Button comprobar;
		private System.Windows.Forms.TextBox txtnarcisista;
	}
}