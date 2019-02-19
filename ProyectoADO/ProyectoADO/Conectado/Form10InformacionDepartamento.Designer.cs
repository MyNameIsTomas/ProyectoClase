namespace ProyectoADO.Conectado
{
	partial class Form10InformacionDepartamento
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
            this.listEmpleados = new System.Windows.Forms.ListBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.comboDepartamentos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPersonas = new System.Windows.Forms.TextBox();
            this.textSumaSalarial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.textSalario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboOficio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboDepartamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamentos";
            // 
            // listEmpleados
            // 
            this.listEmpleados.FormattingEnabled = true;
            this.listEmpleados.Location = new System.Drawing.Point(139, 25);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(120, 186);
            this.listEmpleados.TabIndex = 1;
            this.listEmpleados.SelectedIndexChanged += new System.EventHandler(this.listEmpleados_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(268, 132);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 35);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // comboDepartamentos
            // 
            this.comboDepartamentos.FormattingEnabled = true;
            this.comboDepartamentos.Location = new System.Drawing.Point(12, 25);
            this.comboDepartamentos.Name = "comboDepartamentos";
            this.comboDepartamentos.Size = new System.Drawing.Size(121, 21);
            this.comboDepartamentos.TabIndex = 4;
            this.comboDepartamentos.SelectedIndexChanged += new System.EventHandler(this.comboDepartamentos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personas";
            // 
            // textPersonas
            // 
            this.textPersonas.Location = new System.Drawing.Point(15, 152);
            this.textPersonas.Name = "textPersonas";
            this.textPersonas.Size = new System.Drawing.Size(100, 20);
            this.textPersonas.TabIndex = 7;
            // 
            // textSumaSalarial
            // 
            this.textSumaSalarial.Location = new System.Drawing.Point(15, 191);
            this.textSumaSalarial.Name = "textSumaSalarial";
            this.textSumaSalarial.Size = new System.Drawing.Size(100, 20);
            this.textSumaSalarial.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Suma salarial";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(268, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 36);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // textSalario
            // 
            this.textSalario.Location = new System.Drawing.Point(268, 26);
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(121, 20);
            this.textSalario.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Salario";
            // 
            // comboOficio
            // 
            this.comboOficio.FormattingEnabled = true;
            this.comboOficio.Location = new System.Drawing.Point(268, 65);
            this.comboOficio.Name = "comboOficio";
            this.comboOficio.Size = new System.Drawing.Size(121, 21);
            this.comboOficio.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Oficio";
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Location = new System.Drawing.Point(268, 105);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(121, 21);
            this.comboDepartamento.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Departamento";
            // 
            // Form10InformacionDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 222);
            this.Controls.Add(this.comboDepartamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboOficio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textSalario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSumaSalarial);
            this.Controls.Add(this.textPersonas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboDepartamentos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.label1);
            this.Name = "Form10InformacionDepartamento";
            this.Text = "Form10InformacionDepartamento";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listEmpleados;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.ComboBox comboDepartamentos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textPersonas;
		private System.Windows.Forms.TextBox textSumaSalarial;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.TextBox textSalario;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboOficio;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboDepartamento;
		private System.Windows.Forms.Label label7;
	}
}