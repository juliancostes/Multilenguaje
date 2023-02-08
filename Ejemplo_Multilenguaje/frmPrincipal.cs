using Ejemplo_Multilenguaje.Idiomas;
using Ejemplo_Multilenguaje.Properties;
using System;
using System.Windows.Forms;

namespace Ejemplo_Multilenguaje
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {//Constructor del formulario
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
            CargarComboLenguajes();//Llamo al metodo que cargara el BomboBox
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {//Disparo un Cuadro de Mensajes, pero con el texto guardado en los archivos resx
            MessageBox.Show(Strings.Mensaje);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            frmSecundario frm = new frmSecundario();
            frm.ShowDialog();
        }

        private void CargarComboLenguajes()
        {
            cmbLenguaje.DataSource = Idioma.ObtenerIdiomas();//Cargo el Combo con la lista de la clase Idioma
            cmbLenguaje.DisplayMember = "Nombre"; //Muestro el "campo" nombre de la lista
            cmbLenguaje.ValueMember = "InfoCultura";//Guardo la informacion Cultural en el Combo
            cmbLenguaje.SelectedValue = Settings.Default.Idioma; //Selecciono el idioma guardado por defecto
        }

        private void cmbLenguaje_SelectionChangeCommitted(object sender, EventArgs e)
        {//Este evento ocurre cuando cambia el estado del combo
            Settings.Default.Idioma = cmbLenguaje.SelectedValue.ToString();//Cargo el idioma seleccionado por el combo
            Settings.Default.Save(); //Guardo el idioma seleccionado para que quede grabado
            Idioma.CargarIdioma(this.Controls, this);//Llamo al metodo que cambiara el idioma en los formularios
        }
    }
}
