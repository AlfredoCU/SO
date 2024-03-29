﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tetris_cs
{
    /// <summary>
    /// Se usa para mostrar una vista previa de forma.
    /// </summary>
    class ShapePreview : DataGridView
    {
        // Constantes utilizadas para ignorar el enfoque DGV.
        const int WM_LBUTTONDOWN = 0x201;
        const int WM_LBUTTONDBLCLK = 0x203;
        const int WM_KEYDOWN = 0x100;

        // Evita enfocarse.
        protected override void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e) {
            int p = (int)e.PaintParts;
            p -= (int)DataGridViewPaintParts.Focus;
            e.PaintParts = (DataGridViewPaintParts)p;
		    base.OnRowPrePaint(e);
        }

        // Ignora el enfoque.
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == WM_LBUTTONDBLCLK || m.Msg == WM_LBUTTONDOWN || m.Msg == WM_KEYDOWN)
            {
                return;
            }
            base.WndProc(ref m);
        }
    }
}