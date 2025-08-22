using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCorrerRutina_Click(object sender, EventArgs e)
        {
            Granja granja = new Granja(); //Creo la Granja
            List<string> acciones = granja.CorrerRutina(); //Voy a pedirle la lista de acciones de la granja
            tbResultado.Clear();
            foreach (string accion in acciones)
            {
                tbResultado.Text += accion + "\r\n";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
