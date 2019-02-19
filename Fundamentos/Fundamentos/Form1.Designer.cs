namespace Fundamentos
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.btncambio = new System.Windows.Forms.Button();
			this.cajatexto = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btncambio
			// 
			this.btncambio.BackColor = System.Drawing.SystemColors.ControlText;
			this.btncambio.ForeColor = System.Drawing.Color.Black;
			this.btncambio.Location = new System.Drawing.Point(183, 177);
			this.btncambio.Name = "btncambio";
			this.btncambio.Size = new System.Drawing.Size(138, 73);
			this.btncambio.TabIndex = 0;
			this.btncambio.Text = "Cambiar algo de la caja";
			this.btncambio.UseVisualStyleBackColor = false;
			this.btncambio.Click += new System.EventHandler(this.button1_Click);
			// 
			// cajatexto
			// 
			this.cajatexto.Location = new System.Drawing.Point(201, 133);
			this.cajatexto.Name = "cajatexto";
			this.cajatexto.Size = new System.Drawing.Size(100, 20);
			this.cajatexto.TabIndex = 1;
			this.cajatexto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(198, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Hola soy un label";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(489, 363);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cajatexto);
			this.Controls.Add(this.btncambio);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox cajatexto;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btncambio;
	}
}

