using ClosedXML.Excel;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Administrador
{
    public partial class lbTareasHechas : Form
    {
        private string basePath;
        private string cosasPorHacerPath;
        private string tareasHechasPath;

        public lbTareasHechas()
        {
            InitializeComponent();

            basePath = Path.Combine(Application.StartupPath, "Tareas");
            cosasPorHacerPath = Path.Combine(basePath, "CosasPorHacer");
            tareasHechasPath = Path.Combine(basePath, "TareasHechas");

            Directory.CreateDirectory(cosasPorHacerPath);
            Directory.CreateDirectory(tareasHechasPath);

            CargarTareas();
            CargarCsvEnListBox();
            timer1.Start();
        }

        private void lbTareasHechas_Load(object sender, EventArgs e)
        {
        }

        private void CargarTareas()
        {
            listBoxCosasPorHacer.Items.Clear();
            listBoxTareasHechas.Items.Clear();

            int pendientes = 0;
            int hechas = 0;

            try
            {
                var archivosPendientes = Directory
                    .EnumerateFiles(cosasPorHacerPath)
                    .Where(f => f.EndsWith(".txt") || f.EndsWith(".ahk"))
                    .ToList();

                foreach (string filePath in archivosPendientes)
                {
                    listBoxCosasPorHacer.Items.Add(Path.GetFileName(filePath));
                    pendientes++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas pendientes: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                var archivosHechos = Directory
                    .EnumerateFiles(tareasHechasPath)
                    .Where(f => f.EndsWith(".txt") || f.EndsWith(".ahk"))
                    .ToList();

                foreach (string filePath in archivosHechos)
                {
                    listBoxTareasHechas.Items.Add(Path.GetFileName(filePath));
                    hechas++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas hechas: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblContadorPendientes.Text = $"Pendientes: {pendientes}";
            lblContadorHechas.Text = $"Hechas: {hechas}";
        }

        private void btnCompletarTarea_Click(object sender, EventArgs e)
        {
            if (listBoxCosasPorHacer.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una tarea para completar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreTarea = listBoxCosasPorHacer.SelectedItem.ToString();
            string origenPath = Path.Combine(cosasPorHacerPath, nombreTarea);
            string destinoPath = Path.Combine(tareasHechasPath, nombreTarea);

            try
            {
                if (File.Exists(origenPath))
                {
                    File.Move(origenPath, destinoPath);
                    MessageBox.Show($"Tarea '{nombreTarea}' completada!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTareas();
                }
                else
                {
                    MessageBox.Show("El archivo de la tarea no se encontró en la carpeta de pendientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mover la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarcarPendiente_Click(object sender, EventArgs e)
        {
            if (listBoxTareasHechas.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una tarea para marcar como pendiente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreTarea = listBoxTareasHechas.SelectedItem.ToString();
            string origenPath = Path.Combine(tareasHechasPath, nombreTarea);
            string destinoPath = Path.Combine(cosasPorHacerPath, nombreTarea);

            try
            {
                if (File.Exists(origenPath))
                {
                    File.Move(origenPath, destinoPath);
                    MessageBox.Show($"Tarea '{nombreTarea}' marcada como pendiente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTareas();
                }
                else
                {
                    MessageBox.Show("El archivo de la tarea no se encontró en la carpeta de hechas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mover la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrirTarea_Click(object sender, EventArgs e)
        {
            string nombreTarea = null;
            string rutaArchivo = null;

            if (listBoxCosasPorHacer.SelectedItem != null)
            {
                nombreTarea = listBoxCosasPorHacer.SelectedItem.ToString();
                rutaArchivo = Path.Combine(cosasPorHacerPath, nombreTarea);
            }
            else if (listBoxTareasHechas.SelectedItem != null)
            {
                nombreTarea = listBoxTareasHechas.SelectedItem.ToString();
                rutaArchivo = Path.Combine(tareasHechasPath, nombreTarea);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para abrir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (File.Exists(rutaArchivo))
            {
                try
                {
                    System.Diagnostics.Process.Start(rutaArchivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo abrir el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxCosasPorHacer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCosasPorHacer.SelectedIndex != -1)
            {
                listBoxTareasHechas.ClearSelected();
            }
        }

        private void listBoxTareasHechas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTareasHechas.SelectedIndex != -1)
            {
                listBoxCosasPorHacer.ClearSelected();
            }
        }

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
            string nombreArchivo = txtNombreArchivo.Text.Trim();

            if (string.IsNullOrEmpty(nombreArchivo))
            {
                MessageBox.Show("Por favor escribe un nombre para el archivo.", "Aviso");
                return;
            }

            // Asegurarse de que tenga extensión .txt
            if (!nombreArchivo.EndsWith(".txt"))
            {
                nombreArchivo += ".txt";
            }

            // Ruta final: cosasPorHacer + nombre que escribió el usuario
            string rutaArchivo = Path.Combine(cosasPorHacerPath, nombreArchivo);

            try
            {
                // Crear archivo vacío (si ya existe, lo sobreescribe)
                File.WriteAllText(rutaArchivo, "Nuevo archivo creado desde C#,10");

                MessageBox.Show("Archivo creado en:\n" + rutaArchivo, "Éxito");
                CargarTareas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear archivo: " + ex.Message, "Error");
            }
        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            string rutaExcel = Path.Combine(cosasPorHacerPath, "Resumen.csv");
            using (StreamWriter sw = new StreamWriter(rutaExcel))
            {
                sw.WriteLine("Texto,Número");

                foreach (string archivo in Directory.GetFiles(cosasPorHacerPath, "*.txt"))
                {
                    string[] lineas = File.ReadAllLines(archivo);

                    foreach (string linea in lineas)
                    {
                        if (string.IsNullOrWhiteSpace(linea)) continue;

                        string[] partes = linea.Split(',');
                        if (partes.Length == 2)
                            sw.WriteLine($"{partes[0].Trim()},{partes[1].Trim()}");
                    }
                }
                MessageBox.Show("Archivo Creado correctamente....");
                CargarCsvEnListBox();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void CargarCsvEnListBox()
        {
            // Buscar archivos CSV en la carpeta
            string[] archivosCsv = Directory.GetFiles(cosasPorHacerPath, "*.csv");

            // Mostrar/ocultar ListBox según si hay archivos
            if (archivosCsv.Length > 0)
            {
                listBox1.Visible = true;
                listBox1.Items.Clear();

                foreach (string archivo in archivosCsv)
                {
                    listBox1.Items.Add(Path.GetFileName(archivo));
                }
            }
            else
            {
                listBox1.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now;
            DateTime hoy10pm = new DateTime(ahora.Year, ahora.Month, ahora.Day, 22, 0, 0);

            if (ahora > hoy10pm)
            {
                hoy10pm = hoy10pm.AddDays(1);
            }

            TimeSpan diferencia = hoy10pm - ahora;

            label3.Text = $"Quedan {diferencia.TotalMinutes:F0} minutos hasta las 10:00 pm.\n" +
                          $"Quedan {diferencia.Hours} horas y {diferencia.Minutes} minutos.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica que haya un item seleccionado
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un archivo CSV.");
                return;
            }

            // Nombre del archivo seleccionado
            string archivoSeleccionado = listBox1.SelectedItem.ToString();

            // Construir la ruta completa (asumiendo que Tareas y CosasPorHacer están en el mismo directorio de la app)
            string rutaBase = System.IO.Path.Combine(Application.StartupPath, "Tareas", "CosasPorHacer");
            string rutaArchivo = System.IO.Path.Combine(rutaBase, archivoSeleccionado);

            // Abrir el archivo con la aplicación predeterminada
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaArchivo,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el archivo: " + ex.Message);
            }
        }
    }
}
