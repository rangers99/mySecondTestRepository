using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
