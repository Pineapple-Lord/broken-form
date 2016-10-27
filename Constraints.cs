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
    public partial class Constraints : Form
    {
        public Constraints()
        {
            InitializeComponent();
        }

        private void BTNBack2Menu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu m = new Menu();
            m.Visible = true;
        }

        private void BTNRetail_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Retail r = new Retail();
            r.Visible = true;
        }
        private void BTNPhysical_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Physical p = new Physical();
            p.Visible = true;
        }

        private void BTNTime_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Time t = new Time();
            t.Visible = true;
        }

        private void BTNSummary_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Summary s = new Summary();
            s.Visible = true;
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            //Will save all data
        }
    }
}
