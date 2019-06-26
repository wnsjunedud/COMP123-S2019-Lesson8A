using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8A
{
    public partial class Lab08Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is the default Constructor
        /// </summary>
        public Lab08Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the Event Handler for the Lab08Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab08Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
        }
        /// <summary>
        /// This is the Event Handler for the submitButton Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;

            //    //optopn A
            //    UserAge = Convert.ToSingle(AgeTextBox.Text);

            //option B
            UserAge = float.Parse(AgeTextBox.Text);

            ////option C
            //float tempFloat;
            //bool result = float.TryParse(AgeTextBox.Text, out tempFloat);
            //UserAge = tempFloat;
            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            ClearForm();

        }
        /// <summary>
        /// This is the Event Handler for the AgeTextBox Textchanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch
            {
            SubmitButton.Enabled = false;
            }
        }
        /// <summary>
        /// This is the Event Handler for the NameTextBox Textchanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length >= 2)? true : false;

        }
    }
}
