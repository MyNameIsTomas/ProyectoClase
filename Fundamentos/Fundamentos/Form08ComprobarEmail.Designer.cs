namespace Fundamentos
{
	partial class Form08ComprobarEmail
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
			this.txtemail = new System.Windows.Forms.TextBox();
			this.comprobar = new System.Windows.Forms.Button();
			this.resultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Email:";
			// 
			// txtemail
			// 
			this.txtemail.Location = new System.Drawing.Point(85, 22);
			this.txtemail.Name = "txtemail";
			this.txtemail.Size = new System.Drawing.Size(208, 20);
			this.txtemail.TabIndex = 1;
			// 
			// comprobar
			// 
			this.comprobar.Location = new System.Drawing.Point(102, 48);
			this.comprobar.Name = "comprobar";
			this.comprobar.Size = new System.Drawing.Size(167, 23);
			this.comprobar.TabIndex = 2;
			this.comprobar.Text = "Comprobar email";
			this.comprobar.UseVisualStyleBackColor = true;
			this.comprobar.Click += new System.EventHandler(this.comprobar_Click);
			// 
			// resultado
			// 
			this.resultado.AutoSize = true;
			this.resultado.Location = new System.Drawing.Point(44, 106);
			this.resultado.Name = "resultado";
			this.resultado.Size = new System.Drawing.Size(0, 13);
			this.resultado.TabIndex = 3;
			// 
			// Form08ComprobarEmail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 154);
			this.Controls.Add(this.resultado);
			this.Controls.Add(this.comprobar);
			this.Controls.Add(this.txtemail);
			this.Controls.Add(this.label1);
			this.Name = "Form08ComprobarEmail";
			this.Text = "Form08ComprobarEmail";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtemail;
		private System.Windows.Forms.Button comprobar;
		private System.Windows.Forms.Label resultado;
	}
}