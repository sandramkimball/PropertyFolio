using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyFolio.Forms
{
    public partial class OwnersForm : Form
    {
        public OwnersForm()
        {
            InitializeComponent();
        }

        private void ViewProperty_Click(object sender, EventArgs e)
        {
            PropertiesForm propForm = new PropertiesForm();
            propForm.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
