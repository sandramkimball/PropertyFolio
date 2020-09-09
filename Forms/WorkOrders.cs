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
    public partial class WorkOrdersForm : Form
    {
        public WorkOrdersForm()
        {
            InitializeComponent();
        }

        private void ContactLlabel_Click(object sender, EventArgs e)
        {

        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            StatusInput.Text = "Cancelled";
        }
        private void CompletedBtn_Click(object sender, EventArgs e)
        {
            StatusInput.Text = "Completed";
        }
        private void IncompleteBtn_Click(object sender, EventArgs e)
        {
            StatusInput.Text = "In Progress";
        }
    }
}
