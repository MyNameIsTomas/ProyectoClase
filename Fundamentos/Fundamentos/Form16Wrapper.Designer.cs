namespace Fundamentos
{
	partial class Form16Wrapper
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
			this.btnLlamar = new System.Windows.Forms.Button();
			this.lblrespuesta = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLlamar
			// 
			this.btnLlamar.Location = new System.Drawing.Point(40, 21);
			this.btnLlamar.Name = "btnLlamar";
			this.btnLlamar.Size = new System.Drawing.Size(195, 87);
			this.btnLlamar.TabIndex = 0;
			this.btnLlamar.Text = "Llamar metodo";
			this.btnLlamar.UseVisualStyleBackColor = true;
			this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
			// 
			// lblrespuesta
			// 
			this.lblrespuesta.AutoSize = true;
			this.lblrespuesta.Location = new System.Drawing.Point(37, 140);
			this.lblrespuesta.Name = "lblrespuesta";
			this.lblrespuesta.Size = new System.Drawing.Size(35, 13);
			this.lblrespuesta.TabIndex = 1;
			this.lblrespuesta.Text = "label1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(105, 129);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(130, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "Llamar metodo";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form16Wrapper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 213);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblrespuesta);
			this.Controls.Add(this.btnLlamar);
			this.Name = "Form16Wrapper";
			this.Text = "Form16Wrapper";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLlamar;
		private System.Windows.Forms.Label lblrespuesta;
		private System.Windows.Forms.Button button1;
	}
}