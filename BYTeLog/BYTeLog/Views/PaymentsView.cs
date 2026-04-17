using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BYTeLog.Views
{
    public partial class PaymentsView : UserControl
    {
        public event EventHandler NavigateToSettingsRequested;
        public PaymentsView()
        {
            InitializeComponent();
        }

        private void btnGoToMemSettings_Click(object sender, EventArgs e)
        {
            NavigateToSettingsRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnRecordMemPayment_Click(object sender, EventArgs e)
        {
            // TODO: open RecordMemPaymentDialog
        }

        private void btnMemPayRemind_Click(object sender, EventArgs e)
        {
            // TODO: send payment reminders to unpaid / overdue members
        }

        private void btnMemPayExport_Click(object sender, EventArgs e)
        {
            // TODO: export membership payments grid
        }

        private void txtMemPaySearch_TextChanged(object sender, EventArgs e)
        {
            // TODO: filter dgvMemPayments by student name or receipt number
        }

        private void cmbMemPayStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: filter dgvMemPayments by selected payment status
        }

        private void cmbMemPayPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: filter dgvMemPayments by selected time period
        }

        private void dgvMemPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            // Actions column (···)
            if (dgvMemPayments.Columns[e.ColumnIndex].Name == nameof(colMemPayActions))
            {
                // TODO: show context menu with View / Edit / Delete options for the selected row
            }
        }

        private void btnMemPayPrev_Click(object sender, EventArgs e)
        {
            // TODO: go to previous page of membership payments
        }

        private void btnMemPayNext_Click(object sender, EventArgs e)
        {
            // TODO: go to next page of membership payments
        }
    }
}
