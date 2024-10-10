using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AprobadosReprobadosApp
{
    public partial class Form1 : Form
    {
        private List<Alumno> listaAlumnos = new List<Alumno>();
        private List<Alumno> listaAprobados = new List<Alumno>();
        private List<Alumno> listaReprobados = new List<Alumno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && double.TryParse(txtCalificacion.Text, out double calificacion))
            {
                Alumno nuevoAlumno = new Alumno(txtNombre.Text, calificacion);
                listaAlumnos.Add(nuevoAlumno);
                MessageBox.Show($"{nuevoAlumno.Nombre} agregado con éxito.");
                txtNombre.Clear();
                txtCalificacion.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre y una calificación válida.");
            }
        }

        private void btnMostrarResultados_Click(object sender, EventArgs e)
        {
            listaAprobados.Clear();
            listaReprobados.Clear();
            lstAprobados.Items.Clear();
            lstReprobados.Items.Clear();

            // Clasificar alumnos
            foreach (var alumno in listaAlumnos)
            {
                if (alumno.Calificacion >= 7)
                {
                    listaAprobados.Add(alumno);
                    lstAprobados.Items.Add(alumno.ToString());
                }
                else
                {
                    listaReprobados.Add(alumno);
                    lstReprobados.Items.Add(alumno.ToString());
                }
            }
        }
    }
}
