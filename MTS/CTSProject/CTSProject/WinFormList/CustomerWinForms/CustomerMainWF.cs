using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTSProject.WinFormList.CustomerWinForms
{
	public partial class CustomerMainWF : DevExpress.XtraEditors.XtraForm
	{
		public CustomerMainWF()
		{
			InitializeComponent();
		}

		private void CustomerMainWF_Load(object sender, EventArgs e)
		{

		}

		private void accordionControlElement2_Click(object sender, EventArgs e)
		{
			CustomerAddWF customerAddWF = new CustomerAddWF();
			customerAddWF.ShowDialog();
		}
	}
}