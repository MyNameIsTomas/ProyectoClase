namespace Fundamentos
{
	partial class Form02SumarNumeros
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
			this.btnSumar = new System.Windows.Forms.Button();
			this.lblresultado = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtnumero1 = new System.Windows.Forms.TextBox();
			this.txtnumero2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSumar
			// 
			this.btnSumar.Location = new System.Drawing.Point(228, 203);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(75, 23);
			this.btnSumar.TabIndex = 0;
			this.btnSumar.Text = "Sumar";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
			// 
			// lblresultado
			// 
			this.lblresultado.AutoSize = true;
			this.lblresultado.Location = new System.Drawing.Point(246, 290);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(55, 13);
			this.lblresultado.TabIndex = 1;
			this.lblresultado.Text = "Resultado";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(127, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Numero 1";
			// 
			// txtnumero1
			// 
			this.txtnumero1.Location = new System.Drawing.Point(130, 125);
			this.txtnumero1.Name = "txtnumero1";
			this.txtnumero1.Size = new System.Drawing.Size(100, 20);
			this.txtnumero1.TabIndex = 3;
			// 
			// txtnumero2
			// 
			this.txtnumero2.Location = new System.Drawing.Point(299, 125);
			this.txtnumero2.Name = "txtnumero2";
			this.txtnumero2.Size = new System.Drawing.Size(100, 20);
			this.txtnumero2.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(296, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Numero2";
			// 
			// Form02SumarNumeros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 506);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtnumero2);
			this.Controls.Add(this.txtnumero1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.btnSumar);
			this.Name = "Form02SumarNumeros";
			this.Text = "Form02SumarNumeros";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSumar;
		private System.Windows.Forms.Label lblresultado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtnumero1;
		private System.Windows.Forms.TextBox txtnumero2;
		private System.Windows.Forms.Label label3;
	}
}