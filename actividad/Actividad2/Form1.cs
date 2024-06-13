using System.Windows.Forms;
using static Actividad2.Form1;

namespace Actividad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvPelicula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public class Pelicula
        {
            public string Titulo { get; set; }
            public string Genero { get; set; }
            public string Duracion { get; set; }
            public string Director { get; set; }
            public string Productora { get; set; }

            public Pelicula(string titulo, string genero, string duracion, string director, string productora)
            {
                Titulo = titulo;
                Genero = genero;
                Duracion = duracion;
                Director = director;
                Productora = productora;
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string titulo = txtTitulo.Text;
            string genero = cboGenero.SelectedItem.ToString();
            string duracion = txtDuraccion.Text;
            string director = txtDirector.Text;
            string productora = txtProductora.Text;


            Pelicula pelicula = new Pelicula(titulo, genero, duracion, director, productora);


            dgvPelicula.Rows.Add(pelicula.Titulo, pelicula.Genero, pelicula.Duracion, pelicula.Director, pelicula.Productora);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Verificar si hay datos en el DataGridView
            if (dgvPelicula.Rows.Count == 0 || (dgvPelicula.Rows.Count == 1 && dgvPelicula.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay datos para guardar en el archivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Guardar los datos en un archivo de texto
            using (StreamWriter writer = new StreamWriter("peliculas.txt", true))
            {
                foreach (DataGridViewRow row in dgvPelicula.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string line = string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), c => c.Value.ToString()));
                        writer.WriteLine(line);
                    }
                }
            }

            MessageBox.Show("Archivo generado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            try
            {

                // Abrir el archivo de texto para lectura
                using (StreamReader reader = new StreamReader("peliculas.txt"))
                {
                    // Leer y mostrar cada línea del archivo
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        txtContenidoArchivo.AppendText(line + Environment.NewLine);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("El archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

