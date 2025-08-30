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
        public string FullNameToRemove { get; private set; }   // ✅ Add this property

        public RemoveForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // This is your Confirm button
        {
            FullNameToRemove = textBoxFullName.Text.Trim();  // textBox1 is your "Enter Name" input

            if (string.IsNullOrWhiteSpace(FullNameToRemove))
            {
                MessageBox.Show("Please enter a full name to remove.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
