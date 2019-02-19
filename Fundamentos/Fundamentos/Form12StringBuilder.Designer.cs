namespace Fundamentos
{
	partial class Form12StringBuilder
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
			this.txttexto = new System.Windows.Forms.RichTextBox();
			this.btninvertir = new System.Windows.Forms.Button();
			this.btnstringbuilder = new System.Windows.Forms.Button();
			this.resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txttexto
			// 
			this.txttexto.Location = new System.Drawing.Point(12, 12);
			this.txttexto.Name = "txttexto";
			this.txttexto.Size = new System.Drawing.Size(302, 491);
			this.txttexto.TabIndex = 0;
			this.txttexto.Text = "";
			// 
			// btninvertir
			// 
			this.btninvertir.Location = new System.Drawing.Point(378, 57);
			this.btninvertir.Name = "btninvertir";
			this.btninvertir.Size = new System.Drawing.Size(127, 76);
			this.btninvertir.TabIndex = 1;
			this.btninvertir.Text = "Invertir String";
			this.btninvertir.UseVisualStyleBackColor = true;
			this.btninvertir.Click += new System.EventHandler(this.btninvertir_Click);
			// 
			// btnstringbuilder
			// 
			this.btnstringbuilder.Location = new System.Drawing.Point(378, 176);
			this.btnstringbuilder.Name = "btnstringbuilder";
			this.btnstringbuilder.Size = new System.Drawing.Size(127, 90);
			this.btnstringbuilder.TabIndex = 2;
			this.btnstringbuilder.Text = "Invertir StringBuilder";
			this.btnstringbuilder.UseVisualStyleBackColor = true;
			this.btnstringbuilder.Click += new System.EventHandler(this.btnstringbuilder_Click);
			// 
			// resultado
			// 
			this.resultado.AutoSize = true;
			this.resultado.Location = new System.Drawing.Point(320, 385);
			this.resultado.Name = "resultado";
			this.resultado.Size = new System.Drawing.Size(0, 13);
			this.resultado.TabIndex = 3;
			// 
			// Form12StringBuilder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(579, 515);
			this.Controls.Add(this.resultado);
			this.Controls.Add(this.btnstringbuilder);
			this.Controls.Add(this.btninvertir);
			this.Controls.Add(this.txttexto);
			this.Name = "Form12StringBuilder";
			this.Text = "Form12StringBuilder";
			this.Load += new System.EventHandler(this.Form12StringBuilder_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox txttexto;
		private System.Windows.Forms.Button btninvertir;
		private System.Windows.Forms.Button btnstringbuilder;
		private System.Windows.Forms.Label resultado;
	}
}