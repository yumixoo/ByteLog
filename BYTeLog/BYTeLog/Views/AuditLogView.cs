using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BYTeLog.Views
{
    public partial class AuditLogView : UserControl
    {
        public AuditLogView()
        {
            InitializeComponent();
        }

        private void ToolbarCard_Paint(object sender, PaintEventArgs e)
        {
            var panel = (System.Windows.Forms.Panel)sender;
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using var pen = new System.Drawing.Pen(Color.FromArgb(236, 230, 222), 1f);
            var rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
            int r = 8;
            using var path = RoundedRect(rect, r);
            g.DrawPath(pen, path);
        }
        private void StatCard_Paint(object sender, PaintEventArgs e)
        {
            var panel = (System.Windows.Forms.Panel)sender;
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using var pen = new System.Drawing.Pen(Color.FromArgb(236, 230, 222), 1f);
            var rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
            int r = 8;
            using var path = RoundedRect(rect, r);
            g.DrawPath(pen, path);
        }
        private static System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
