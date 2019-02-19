namespace Fundamentos
{
	partial class OrdenarNumeros
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Limpiar los recursos que se estén usando.
	/// </summary>
	/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Código generado por el Diseñador de Windows Forms

	/// <summary>
	/// Método necesario para admitir el Diseñador. No se puede modificar
	/// el contenido de este método con el editor de código.
	/// </summary>
	private void InitializeComponent()
	{
			this.comprobar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.num1 = new System.Windows.Forms.TextBox();
			this.num2 = new System.Windows.Forms.TextBox();
			this.num3 = new System.Windows.Forms.TextBox();
			this.mayor = new System.Windows.Forms.TextBox();
			this.intermedio = new System.Windows.Forms.TextBox();
			this.menor = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// comprobar
			// 
			this.comprobar.Location = new System.Drawing.Point(25, 162);
			this.comprobar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comprobar.Name = "comprobar";
			this.comprobar.Size = new System.Drawing.Size(150, 19);
			this.comprobar.TabIndex = 0;
			this.comprobar.Text = "Comprobar Numeros";
			this.comprobar.UseVisualStyleBackColor = true;
			this.comprobar.Click += new System.EventHandler(this.comprobar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 25);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Numero 1:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 63);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Numero 2:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 104);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Numero 3:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 214);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Mayor";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 260);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Intermedio";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 310);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Menor";
			// 
			// num1
			// 
			this.num1.Location = new System.Drawing.Point(100, 21);
			this.num1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.num1.Name = "num1";
			this.num1.Size = new System.Drawing.Size(76, 20);
			this.num1.TabIndex = 7;
			// 
			// num2
			// 
			this.num2.Location = new System.Drawing.Point(100, 63);
			this.num2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.num2.Name = "num2";
			this.num2.Size = new System.Drawing.Size(76, 20);
			this.num2.TabIndex = 9;
			// 
			// num3
			// 
			this.num3.Location = new System.Drawing.Point(100, 104);
			this.num3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.num3.Name = "num3";
			this.num3.Size = new System.Drawing.Size(76, 20);
			this.num3.TabIndex = 10;
			// 
			// mayor
			// 
			this.mayor.Location = new System.Drawing.Point(100, 214);
			this.mayor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.mayor.Name = "mayor";
			this.mayor.Size = new System.Drawing.Size(76, 20);
			this.mayor.TabIndex = 11;
			// 
			// intermedio
			// 
			this.intermedio.Location = new System.Drawing.Point(100, 260);
			this.intermedio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.intermedio.Name = "intermedio";
			this.intermedio.Size = new System.Drawing.Size(76, 20);
			this.intermedio.TabIndex = 12;
			// 
			// menor
			// 
			this.menor.Location = new System.Drawing.Point(100, 310);
			this.menor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.menor.Name = "menor";
			this.menor.Size = new System.Drawing.Size(76, 20);
			this.menor.TabIndex = 13;
			// 
			// OrdenarNumeros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(199, 360);
			this.Controls.Add(this.menor);
			this.Controls.Add(this.intermedio);
			this.Controls.Add(this.mayor);
			this.Controls.Add(this.num3);
			this.Controls.Add(this.num2);
			this.Controls.Add(this.num1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comprobar);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "OrdenarNumeros";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.Button comprobar;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.Label label5;
	private System.Windows.Forms.Label label6;
	private System.Windows.Forms.TextBox num1;
	private System.Windows.Forms.TextBox num2;
	private System.Windows.Forms.TextBox num3;
	private System.Windows.Forms.TextBox mayor;
	private System.Windows.Forms.TextBox intermedio;
	private System.Windows.Forms.TextBox menor;
}
}