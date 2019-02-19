namespace ProyectoADO.Conectado
{
	partial class Form08ParametrosSalida
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
			this.comboHospital = new System.Windows.Forms.ComboBox();
			this.textSalario = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textTrabajo = new System.Windows.Forms.TextBox();
			this.btnModificar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textPersona = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textSuma = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textMedia = new System.Windows.Forms.TextBox();
			this.lstEmpleados = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hospital";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(180, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Empleados";
			// 
			// comboHospital
			// 
			this.comboHospital.FormattingEnabled = true;
			this.comboHospital.Location = new System.Drawing.Point(12, 25);
			this.comboHospital.Name = "comboHospital";
			this.comboHospital.Size = new System.Drawing.Size(162, 21);
			this.comboHospital.TabIndex = 4;
			this.comboHospital.SelectedIndexChanged += new System.EventHandler(this.comboHospital_SelectedIndexChanged);
			// 
			// textSalario
			// 
			this.textSalario.Location = new System.Drawing.Point(370, 41);
			this.textSalario.Name = "textSalario";
			this.textSalario.Size = new System.Drawing.Size(100, 20);
			this.textSalario.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(367, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Salario";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(367, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Trabajo";
			// 
			// textTrabajo
			// 
			this.textTrabajo.Location = new System.Drawing.Point(370, 83);
			this.textTrabajo.Name = "textTrabajo";
			this.textTrabajo.Size = new System.Drawing.Size(100, 20);
			this.textTrabajo.TabIndex = 7;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(370, 109);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(100, 50);
			this.btnModificar.TabIndex = 9;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Persona";
			// 
			// textPersona
			// 
			this.textPersona.Location = new System.Drawing.Point(15, 67);
			this.textPersona.Name = "textPersona";
			this.textPersona.Size = new System.Drawing.Size(159, 20);
			this.textPersona.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Suma";
			// 
			// textSuma
			// 
			this.textSuma.Location = new System.Drawing.Point(15, 109);
			this.textSuma.Name = "textSuma";
			this.textSuma.Size = new System.Drawing.Size(159, 20);
			this.textSuma.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 137);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Media";
			// 
			// textMedia
			// 
			this.textMedia.Location = new System.Drawing.Point(15, 153);
			this.textMedia.Name = "textMedia";
			this.textMedia.Size = new System.Drawing.Size(159, 20);
			this.textMedia.TabIndex = 14;
			// 
			// lstEmpleados
			// 
			this.lstEmpleados.FormattingEnabled = true;
			this.lstEmpleados.Location = new System.Drawing.Point(180, 25);
			this.lstEmpleados.Name = "lstEmpleados";
			this.lstEmpleados.Size = new System.Drawing.Size(178, 147);
			this.lstEmpleados.TabIndex = 16;
			this.lstEmpleados.SelectedIndexChanged += new System.EventHandler(this.lstEmpleados_SelectedIndexChanged_1);
			// 
			// Form08ParametrosSalida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 186);
			this.Controls.Add(this.lstEmpleados);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textMedia);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textSuma);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textPersona);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textTrabajo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textSalario);
			this.Controls.Add(this.comboHospital);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form08ParametrosSalida";
			this.Text = "Form08ParametrosSalida";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboHospital;
		private System.Windows.Forms.TextBox textSalario;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textTrabajo;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textPersona;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textSuma;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textMedia;
		private System.Windows.Forms.ListBox lstEmpleados;
	}
}