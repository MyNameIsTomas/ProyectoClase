using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
	public partial class Form18ColeccionesNoGraficas : Form
	{
		public Form18ColeccionesNoGraficas()
		{
			InitializeComponent();
			/*
			//Declarar una colección convencional
			ArrayList antigua = new ArrayList();
			//Dentro de dicha colección podemos guardar cualquier clase,
			//ya que es d etipo object. Vamos a almacenar botones
			antigua.Add(this.button1);
			//Cambiar el color al primer elemento (Button)
			((Button)antigua[0]).BackColor = Color.Red;
			antigua.Add(this.button2);
			antigua.Add(this.button3);
			//Añadimos una caja a la colección
			antigua.Add(this.textBox1);
			//Añadimos un string a la colección
			antigua.Add("Hoy es miercoles");
			//Queremos recorrer todos los elementos de la colección
			//Un bucle Each permite el Casting dentro de la declaración
			//Abstraemos hasta Control, ahora abstraemos hasta Object
			foreach (Object btn in antigua) {
				//Tenemos objetos dentro de una clase abastracta (object), 
				//para manejar cada objeto, ahora debemos hacer casting
				if (btn is Button) {
					//Aquí tenemos botones, pero vienen como object
					//(Clase)objeto
					((Button)btn).BackColor = Color.Yellow;
				}
				//btn.BackColor = Color.Yellow;
			}
			*/

			//Vamos a realizar la misma acción pero con colecciones
			//genericas o tipadas. Un generic es un tipo de clase dinamica
			//es decir, podemos declararlo como un comodin
			//Al declarar una colección con tipo ahorramos memoria, ademas
			//evita errores de programación y ahorra Casting. 
			//El compilador detecta el <T>
			//La colección generica es List<T>
			//La abstracción la realizamos en <T>
			//Colección de botones <T>
			List<Control> botones = new List<Control>();
			//El compilador detecta el <T>
			botones.Add(this.button1);
			botones[0].ForeColor = Color.Blue;
			botones.Add(this.button2);
			botones.Add(this.button3);
			//Si añadimos un textBox...
			botones.Add(this.textBox1);
			foreach (Control obj in botones) {
				//Podemos diferenciar cada clase como hemos hecho anteriormente
				if (obj is TextBox) {
					((TextBox)obj).Paste();
				} else if (obj is Button) {
					((Button)obj).BackColor = Color.Red;
				}
			}
		}
	}
}
