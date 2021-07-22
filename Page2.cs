using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creation1
{
    public partial class Page2 : Form
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Page1Button_Click(object sender, EventArgs e)
        {
            Form_Validation form_Validation = new Form_Validation();
            form_Validation.Show();
            this.Visible = false;
            this.Hide();
        }
    }
}
