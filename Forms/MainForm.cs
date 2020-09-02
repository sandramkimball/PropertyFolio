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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PropertiesBtn_Click(object sender, EventArgs e)
        {
            PropertiesForm propForm = new PropertiesForm();
            propForm.Show();
        }
        
        private void PropertyTypesBtn_Click(object sender, EventArgs e)
        {
            PropertyTypeForm propTypeForm = new PropertyTypeForm();
            propTypeForm.Show();
        }
        
        private void OwnersBtn_Click(object sender, EventArgs e)
        {
            PropertyTypeForm propTypeForm = new PropertyTypeForm();
            propTypeForm.Show();
        }
        
        private void WorkOrdersBtn_Click(object sender, EventArgs e)
        {
            OwnersForm ownersForm = new OwnersForm();
            ownersForm.Show();
        }
        
        private void RentersBtn_Click(object sender, EventArgs e)
        {
            RentersForm rentersForm = new RentersForm();
            rentersForm.Show();
        }

        private void VacanciesBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
