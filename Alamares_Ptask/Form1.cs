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

        // ✅ Helper method to enable/disable REMOVE button
        private void UpdateRemoveButtonState()
        {
            button2.Enabled = (listbox1.Items.Count > 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input1 = textBox1.Text.Trim(); // First name
            string input2 = textBox2.Text.Trim(); // Middle name
            string input3 = textBox3.Text.Trim(); // Last name

            // Check if all fields are empty
            if (string.IsNullOrEmpty(input1) && string.IsNullOrEmpty(input2) && string.IsNullOrEmpty(input3))
            {
                label4.Text = "Error: All fields are empty. Please enter your full name.";
                return;
            }

            // Check if any field is empty
            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2) || string.IsNullOrEmpty(input3))
            {
                label4.Text = "Error: Please fill out all fields before submitting.";
                return;
            }

            // Check for duplicate first name
            bool isDuplicate = listbox1.Items.Cast<string>().Any(item => item.Equals(input1, StringComparison.OrdinalIgnoreCase));
            if (isDuplicate)
            {
                label4.Text = $"Error: \"{input1}\" is already in the first name list.";
                return;
            }

            // Success: Add to lists and show processed result
            listbox1.Items.Add(input1);
            listBox2.Items.Add(input2);
            listBox3.Items.Add(input3);
            label4.Text = $"Processed: {input1} {input2} {input3}";

            // ✅ Enable REMOVE if list has items
            UpdateRemoveButtonState();
        }


        private void button2_Click(object sender, EventArgs e) // REMOVE button
        {
            using (RemoveForm removeForm = new RemoveForm())
            {
                var result = removeForm.ShowDialog(); // disables Form1 until closed

                if (result == DialogResult.OK)
                {
                    string fullName = removeForm.FullNameToRemove;
                    string[] parts = fullName.Split(' ');

                    if (parts.Length != 3)
                    {
                        label4.Text = "Error: Please enter full name in 'First Middle Last' format.";
                        return;
                    }

                    string first = parts[0];
                    string middle = parts[1];
                    string last = parts[2];

                    bool found = false;

                    for (int i = 0; i < listbox1.Items.Count; i++)
                    {
                        if (listbox1.Items[i].ToString().Equals(first, StringComparison.OrdinalIgnoreCase) &&
                            listBox2.Items[i].ToString().Equals(middle, StringComparison.OrdinalIgnoreCase) &&
                            listBox3.Items[i].ToString().Equals(last, StringComparison.OrdinalIgnoreCase))
                        {
                            listbox1.Items.RemoveAt(i);
                            listBox2.Items.RemoveAt(i);
                            listBox3.Items.RemoveAt(i);
                            label4.Text = $"Removed: {fullName}";
                            found = true;

                            // ✅ Update REMOVE button state after removal
                            UpdateRemoveButtonState();
                            break;
                        }
                    }

                    if (!found)
                    {
                        label4.Text = $"Error: \"{fullName}\" not found in the list.";
                    }
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
            // ✅ Disable REMOVE at startup
            button2.Enabled = false;
        }
    }
}
