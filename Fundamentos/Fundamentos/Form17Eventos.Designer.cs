namespace Fundamentos
{
	partial class Form17Eventos
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
			this.txtNumeros = new System.Windows.Forms.TextBox();
			this.txtLetras = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblRaton = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Solo numeros";
			// 
			// txtNumeros
			// 
			this.txtNumeros.Location = new System.Drawing.Point(43, 36);
			this.txtNumeros.Name = "txtNumeros";
			this.txtNumeros.Size = new System.Drawing.Size(100, 20);
			this.txtNumeros.TabIndex = 1;
			this.txtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
			// 
			// txtLetras
			// 
			this.txtLetras.Location = new System.Drawing.Point(43, 96);
			this.txtLetras.Name = "txtLetras";
			this.txtLetras.Size = new System.Drawing.Size(100, 20);
			this.txtLetras.TabIndex = 3;
			this.txtLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetras_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Solo letras";
			// 
			// lblRaton
			// 
			this.lblRaton.BackColor = System.Drawing.Color.GreenYellow;
			this.lblRaton.Location = new System.Drawing.Point(40, 133);
			this.lblRaton.Name = "lblRaton";
			this.lblRaton.Size = new System.Drawing.Size(325, 147);
			this.lblRaton.TabIndex = 4;
			this.lblRaton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblRaton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblRaton_MouseMove);
			// 
			// Form17Eventos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 306);
			this.Controls.Add(this.lblRaton);
			this.Controls.Add(this.txtLetras);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNumeros);
			this.Controls.Add(this.label1);
			this.Name = "Form17Eventos";
			this.Text = "Form17Eventos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNumeros;
		private System.Windows.Forms.TextBox txtLetras;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblRaton;
	}
}