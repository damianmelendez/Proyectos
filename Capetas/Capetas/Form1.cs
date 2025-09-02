using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capetas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string semestre = txtSemestre.Text.Trim();
            if (string.IsNullOrEmpty(semestre)) 
            {
                MessageBox.Show("Fabor escribe el nombre del semestre");
                return;
            }
            string[] cursos =
            {
                txtCurso1.Text.Trim(),
                txtCurso2.Text.Trim(),
                txtCurso3.Text.Trim(),
                txtCurso4.Text.Trim(),
                txtCurso5.Text.Trim()
            };
            string rutabase = @"C:\Users\DELL\Desktop\" + semestre;
            try
            {
                Directory.CreateDirectory(rutabase);

                foreach (var curso in cursos) 
                {
                    if (String.IsNullOrWhiteSpace(curso)) continue;
                    String rutacurso = Path.Combine(rutabase, curso);
                    Directory.CreateDirectory(rutacurso);

                    string[] Subcarpets = { "Modulo 1", "Modulo 2", "Modulo 3", "Tareas", "Otros" };
                    foreach (var sub in Subcarpets) 
                    {
                        Directory.CreateDirectory(Path.Combine(rutacurso, sub));
                    }
                }
                MessageBox.Show("CARPETAS CREADAS CORRECTAMENTE");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("No se puedo crear las carpetas" + ex.Message);
            }
        }
    }
}
