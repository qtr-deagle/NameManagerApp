using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Alamares_Ptask
{
    public partial class RemoveForm : Form
    {
        public string FullNameToRemove { get; private set; }   // Add this property
        public string ErrorMessage { get; private set; }

        public RemoveForm() 
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullNameToRemove = textBoxFullName.Text.Trim();

            if (string.IsNullOrWhiteSpace(FullNameToRemove))
            {
                ErrorMessage = "Please enter a full name to remove.";
                this.DialogResult = DialogResult.Cancel; // Cancel instead of OK
                this.Close();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RemoveForm_Load(object sender, EventArgs e)
        {

        }
    }
}
