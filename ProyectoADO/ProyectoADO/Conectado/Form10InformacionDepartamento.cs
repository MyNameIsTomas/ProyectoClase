using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesSQL.Helpers;
using ClasesSQL.Models;

namespace ProyectoADO.Conectado {
	public partial class Form10InformacionDepartamento : Form {
        HelperDepartamentos helper;
        List<Departamento> departamentos;
        List<int> codigosempleados;
		public Form10InformacionDepartamento() {
			InitializeComponent();
            String cadenaConexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password='MCSD2018'";
            this.helper = new HelperDepartamentos(cadenaConexion);
            List<String> oficios = this.helper.GetOficios();
            this.codigosempleados = new List<int>();
            this.departamentos = this.helper.GetDepartamentos();
            foreach (String ofi in oficios) {
                this.comboOficio.Items.Add(ofi);
            }
            foreach (Departamento d in departamentos) {
                this.comboDepartamento.Items.Add(d.Nombre);
                this.comboDepartamentos.Items.Add(d.Nombre);
            }

        }

        private void comboDepartamentos_SelectedIndexChanged(object sender, EventArgs e) {
            int indice = this.comboDepartamentos.SelectedIndex;
            if (indice != -1) {
                int deptno = this.departamentos[indice].NumeroDepartamento;
                Departamento dept = this.helper.BuscarDepartamento(deptno);
                this.listEmpleados.Items.Clear();
                this.codigosempleados.Clear();
                if (dept is null)
                {
                    this.textPersonas.Text = "0";
                    this.textSalario.Text = "0";
                }
                else {
                    this.textPersonas.Text = dept.Personas.ToString();
                    this.textSumaSalarial.Text = dept.SumaSalarial.ToString();
                    foreach (Empleado emp in dept.Empleados) {
                        this.listEmpleados.Items.Add(emp.Apellido);
                        this.codigosempleados.Add(emp.NumeroEmpleado);
                    }
                }

            }
        }

        private void listEmpleados_SelectedIndexChanged(object sender, EventArgs e) {
            int indice = this.listEmpleados.SelectedIndex;
            if (indice != -1) {
                int empno = this.codigosempleados[indice];
                Empleado emp = this.helper.BuscarEmpleado(empno);
                this.textSalario.Text = emp.Salario.ToString();
                this.comboOficio.SelectedItem = emp.Oficio;
                this.comboDepartamento.SelectedIndex = this.comboDepartamentos.SelectedIndex;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            int indice = this.listEmpleados.SelectedIndex;
            int empno = this.codigosempleados[indice];
            int salario = int.Parse(this.textSalario.Text);
            String oficio = this.comboOficio.SelectedItem.ToString();
            int indicedept = this.comboDepartamento.SelectedIndex;
            int deptno = this.departamentos[indicedept].NumeroDepartamento;
            this.helper.modificarEmpleado(empno, salario, oficio, deptno);
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            int indice = this.listEmpleados.SelectedIndex;
            int empno = this.codigosempleados[indice];
            this.helper.EliminarEmpleado(empno);
        }
    }
}
