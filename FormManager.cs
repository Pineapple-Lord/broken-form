using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class FormManager
    {
        Menu menuForm;
        Retail retailForm;
        Physical physicalForm;
        Time timeForm;
        Constraints constraintsForm;
        Summary summaryForm;
        public void initialize()
        {
            retailForm = new Retail();
            physicalForm = new Physical();
            retailForm.SetFM(this);
            physicalForm.SetFM(this);
        }

        public void SetMenuForm(Menu f)
        {
            menuForm = f;
        }
        public void ShowMenu()
        {
            retailForm.Show();
            physicalForm.Hide();
            menuForm.Hide();
        }

        public void ShowTime()
        {
            menuForm.Show();
            retailForm.Hide();
            physicalForm.Hide();
        }

        public void ShowRetail()
        {
            physicalForm.Show();
            retailForm.Hide();
            menuForm.Hide();
        }
        public void ShowPhysical()
        {

        }
        public void ShowConstraints()
        {

        }
        public void ShowSummary()
        {

        }
    }
}
