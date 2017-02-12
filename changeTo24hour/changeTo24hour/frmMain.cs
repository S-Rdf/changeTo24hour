using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changeTo24hour
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            bool isPM=true;

            if (CheckRenj(txtHour.Text) == true)
                ChangeHour(int.Parse(txtHour.Text),isPM);
        }

        public bool CheckRenj(string txtHour)
        {
            int hour;
            bool isSuccess = int.TryParse(txtHour,out hour);

            if (isSuccess == true)
                if (hour >= 1 && hour <= 12)
                    return true;
                else
                {
                    MessageBox.Show("عدد ساعت را بین 1 تا 12 وارد کنید");
                    return false;
                }                   
            else
            {
                MessageBox.Show("عدد ساعت را بین 1 تا 12 وارد کنید");
                return false;
            }     
        }

        void ChangeHour(int hour,bool isPM)
        {
            if (isPM == false)
                MessageBox.Show(hour.ToString());
            else
                MessageBox.Show((hour + 12).ToString());
        }
    }
}
