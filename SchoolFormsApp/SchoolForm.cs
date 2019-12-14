using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
    public partial class SchoolForm : Form
    {
        public SchoolForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPushtoTest_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.Name = textName.Text;
            testSchool.Address = textAddress.Text;
            testSchool.City = textCity.Text;
            testSchool.State = textState.Text;
            testSchool.Zip = textZip.Text;
            testSchool.PhoneNumber = textPhone.Text;
            try
            {
                testSchool.TwitterAddress = textTwitter.Text;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(testSchool.ToString());
        }

        private void textZip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}