using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace notePadProj
{
    public class CDoubleBufferDataGridView : System.Windows.Forms.DataGridView
    {
        System.Drawing.SolidBrush solidBrush;
        public CDoubleBufferDataGridView()
        {
            solidBrush = new System.Drawing.SolidBrush(this.RowHeadersDefaultCellStyle.ForeColor);
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, solidBrush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5);
            base.OnRowPostPaint(e);
        }
    }
}
