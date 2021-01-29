
// Peter Panduro, 9201015592
// L0002B
// Uppgift 3

using System;
using System.Windows.Forms;

namespace L0002B_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Person p;
            try
            {
                p = new Person(givenNameTextBox.Text, familyNameTextBox.Text, pNrTextBox.Text);
                showNameLabel.Text = $"{p.givenName} {p.familyName}";
                showPNrLabel.Text = p.pNr;
                showGenderLabel.Text = Person.GetGender(p.pNr);
            }
            catch (Exception)
            {
                // pNr är inte ett giltigt personnummer
                showNameLabel.Text = "Ogiltigt personnummer";
                showPNrLabel.Text = "";
                showGenderLabel.Text = "";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            givenNameTextBox.Text = "";
            familyNameTextBox.Text = "";
            pNrTextBox.Text = "";
            showNameLabel.Text = "";
            showPNrLabel.Text = "";
            showGenderLabel.Text = "";
        }
    }
}
