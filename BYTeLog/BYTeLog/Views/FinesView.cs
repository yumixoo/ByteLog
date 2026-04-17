using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BYTeLog.Views
{
    public partial class FinesView : UserControl
    {
        public event EventHandler NavigateToSettingsRequested;
        public FinesView()
        {
            InitializeComponent();
        }

        private void btnGoToSettings_Click(object sender, EventArgs e)
        {
            NavigateToSettingsRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnIssueFine_Click(object sender, EventArgs e)
        {
            // TODO: open IssueFineDialog
        }
        private void btnPenMarkPaid_Click(object sender, EventArgs e)
        {
            // TODO: mark selected penalties as paid
        }
        private void btnPenExport_Click(object sender, EventArgs e)
        {
            // TODO: export penalties grid
        }
        private void btnPenPrev_Click(object sender, EventArgs e)
        {
            // TODO: previous page — penalties
        }
        private void btnPenNext_Click(object sender, EventArgs e)
        {
            // TODO: next page — penalties
        }
        private void btnRecordPayment_Click(object sender, EventArgs e)
        {
            // TODO: open RecordPaymentDialog
        }
        private void btnPayExport_Click(object sender, EventArgs e)
        {
            // TODO: export payments grid
        }
        private void btnPayPrev_Click(object sender, EventArgs e)
        {
            // TODO: previous page — payments
        }
        private void btnPayNext_Click(object sender, EventArgs e)
        {
            // TODO: next page — payments
        }
    }
}
