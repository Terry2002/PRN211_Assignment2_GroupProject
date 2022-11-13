using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string _adminName;
        private string _name;
        public string adminName
        {
            get { return _adminName ; }
            set { _adminName = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMembersManagement_Click(object sender, EventArgs e)
        {
            frmMembers frmmenber = new frmMembers();
            if (_adminName != null)
            {
                frmmenber.adminName = _adminName;
            }
            else
            {
                frmmenber.name = _adminName;
            }
            this.Hide();
            frmmenber.ShowDialog();
            this.Show();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            frmProducts frmproduct = new frmProducts();
            this.Hide();
            frmproduct.ShowDialog();
            this.Show();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            frmOrders frmorder = new frmOrders();
            this.Hide();
            frmorder.ShowDialog();
            this.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(_adminName != null)
            {
                lbName.Text = _adminName;
            }else
            {
                lbName.Text = _name;
            }       
        }
    }
}
