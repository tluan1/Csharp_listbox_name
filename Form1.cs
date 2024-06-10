using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_listbox_name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            lbskq.Items.Add(txttensv.Text);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lbskq.Items.RemoveAt(lbskq.SelectedIndex);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lbskq.SelectedIndex < 0) return;
            lbskq.Items[lbskq.SelectedIndex] = txttensv.Text;
        }
        private void lbsketqua_SelectedindexChanged(object sender, EventArgs e)
        {
            txttensv.Text = lbskq.SelectedItem.ToString();
        }
    }
}
