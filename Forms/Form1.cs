using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        List<string> grouplist;

        public Form1()
        {
            grouplist = new List<string>();
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
           

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtName.Text + " " + txtEmail.Text);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string groupname = txtAdd.Text;
            if (groupname.Length !=0)
            {
                grouplist.Add(groupname);
                cmbGroup.Items.Clear();
                foreach ( var item in grouplist)
                {
                    cmbGroup.Items.Add(item);
                }
                MessageBox.Show("Successfully!");
               
            }
            else
            {
                lblError.Text = "Bos buraxmayin";
                lblError.Visible = true;
            }

        }

        private void LblError_Click(object sender, EventArgs e)
        {

        }

        private void TxtAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
