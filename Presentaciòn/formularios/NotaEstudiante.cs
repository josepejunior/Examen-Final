using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciòn.formularios
{
    public partial class NotaEstudiante : Form
    {
        public NotaEstudiante()
        {
            InitializeComponent();
        }

        private void NotaEstudiante_Load(object sender, EventArgs e)
        {
            cmbAsignatura.Items.AddRange(Enum.GetValues(RichTextBoxSelectionTypes(Asignatura)).Cast<object>().ToArray());
        }

        private void btnMejores_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
