using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alamares_Ptask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Helper method to enable/disable REMOVE button
        private void UpdateRemoveButtonState()
        {
            Remove.Enabled = (FirstNameList.Items.Count > 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input1 = FirstNameBox.Text.Trim(); // First name
            string input2 = MiddleNameBox.Text.Trim(); // Middle name
            string input3 = LastNameBox.Text.Trim(); // Last name

            // Check if all fields are empty
            if (string.IsNullOrEmpty(input1) && string.IsNullOrEmpty(input2) && string.IsNullOrEmpty(input3))
            {
                Result.Text = "Error: All fields are empty. Please enter your full name.";
                return;
            }

            // Check individual fields
            if (string.IsNullOrEmpty(input1))
            {
                Result.Text = "Error: First name is blank. Please enter your first name.";
                return;
            }
            if (string.IsNullOrEmpty(input2))
            {
                Result.Text = "Error: Middle name is blank. Please enter your middle name.";
                return;
            }
            if (string.IsNullOrEmpty(input3))
            {
                Result.Text = "Error: Last name is blank. Please enter your last name.";
                return;
            }

            // Check for duplicate first name
            bool isDuplicate = FirstNameList.Items.Cast<string>().Any(item => item.Equals(input1, StringComparison.OrdinalIgnoreCase));
            if (isDuplicate)
            {
                Result.Text = $"Error: \"{input1}\" is already in the first name list.";
                return;
            }

            // Success: Add to lists and show processed result
            FirstNameList.Items.Add(input1);
            MiddleNameList.Items.Add(input2);
            LastNameList.Items.Add(input3);
            Result.Text = $"Processed: {input1} {input2} {input3}";

            // Enable REMOVE if list has items
            UpdateRemoveButtonState();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (RemoveForm removeForm = new RemoveForm())
            {
                var result = removeForm.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    Result.Text = removeForm.ErrorMessage; // Show error from RemoveForm
                    return;
                }

                string fullName = removeForm.FullNameToRemove;
                string[] parts = fullName.Split(' ');

                if (parts.Length != 3)
                {
                    Result.Text = "Error: Please enter full name in 'First Middle Last' format.";
                    return;
                }

                string first = parts[0];
                string middle = parts[1];
                string last = parts[2];

                bool found = false;

                for (int i = 0; i < FirstNameList.Items.Count; i++)
                {
                    if (FirstNameList.Items[i].ToString().Equals(first, StringComparison.OrdinalIgnoreCase) &&
                        MiddleNameList.Items[i].ToString().Equals(middle, StringComparison.OrdinalIgnoreCase) &&
                        LastNameList.Items[i].ToString().Equals(last, StringComparison.OrdinalIgnoreCase))
                    {
                        FirstNameList.Items.RemoveAt(i);
                        MiddleNameList.Items.RemoveAt(i);
                        LastNameList.Items.RemoveAt(i);
                        Result.Text = $"Removed: {fullName}";
                        found = true;

                        UpdateRemoveButtonState();
                        break;
                    }
                }

                if (!found)
                {
                    Result.Text = $"Error: \"{fullName}\" not found in the list.";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void listbox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Disable REMOVE at startup
            Remove.Enabled = false;
        }
    }
}
