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
    public partial class Menu : Form
    {
        FormManager fm;
        //Retail r = new Retail();
        //Physical p = new Physical();
        //Time t = new Time();
        //Constraints c = new Constraints();
        //Summary s = new Summary();
        public Menu()
        {
            InitializeComponent();
            fm = new FormManager();
            fm.initialize();
            fm.SetMenuForm(this);
        }

        private void BTNRetail_Click(object sender, EventArgs e)
        {
            fm.ShowRetail();
        }

        private void BTNPhysical_Click(object sender, EventArgs e)
        {
        }

        private void BTNTime_Click(object sender, EventArgs e)
        {
            fm.ShowTime();
        }

        private void BTNConstraints_Click(object sender, EventArgs e)
        {
        }
    }
}
