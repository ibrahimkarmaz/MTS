using CTSProject.WinFormList.CustomerWinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CTSProject
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		CustomerMainWF customerMainWF;
		private void barCustomerProcess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (customerMainWF==null || customerMainWF.IsDisposed)
			{
				customerMainWF = new CustomerMainWF();
				customerMainWF.MdiParent = this;
				customerMainWF.Show();
			}
		}
	}
}
