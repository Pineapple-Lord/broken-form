using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Physical : Retail 
    {
        public Physical()
        {
            InitializeComponent();
        }

        private void BTNBack2Menu_Click(object sender, EventArgs e)
        {
        }

        private void BTNRetail_Click(object sender, EventArgs e)
        {
        }

        private void BTNTime_Click(object sender, EventArgs e)
        {
            GetFM().ShowTime();
        }

        private void BTNConstraints_Click(object sender, EventArgs e)
        {
        }

        private void BTNSummary_Click(object sender, EventArgs e)
        {
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            //Will save all data
        }
    }
}
