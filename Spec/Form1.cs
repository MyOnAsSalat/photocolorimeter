using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using unvell.ReoGrid.DataFormat;

namespace Spec
{
    public partial class Form1 : Form
    {
        
        Boolean enable = false;
        Stopwatch stopWatch = new Stopwatch();
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            Table.CurrentWorksheet.ColumnCount = 3;
            Table.CurrentWorksheet.ColumnHeaders[0].Width = 80;
            Table.CurrentWorksheet.ColumnHeaders[1].Width = 80;
            Table.CurrentWorksheet.ColumnHeaders[2].Width = 80;
            Table.CurrentWorksheet.RowCount = 1;
            Table.CurrentWorksheet.Name = "Graph";
            
            stopWatch.Start();
        }
        double a = 0.5d;
        int interval = 1000;
        int shift = 0;
        private void StartStopToolButton_Click(object sender, EventArgs e)
        {
            if (!enable)
            {
                try
                {
                    interval = Convert.ToInt32(IntervalTextBox.Text);
                    if (Convert.ToDouble(AlphaTextBox.Text) == 0) { throw new Exception("Альфа не может быть = 0"); }
                    a = 1d / Convert.ToDouble(AlphaTextBox.Text);
                    shift = Convert.ToInt32(ShiftTextBox.Text);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Введены неверные данные:"+ "\n" + exc.ToString().Replace("System.Exception: ",""), "Ошибка:");
                    return;
                }
                buf = Function(i);
            }
            enable = !enable;
            timer.Enabled = enable;
            timer.Interval = interval;
            StartStopToolButton.Text = (enable) ? "Стоп" : "Старт";
           
        }
        double buf = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            Table.CurrentWorksheet.RowCount = Table.CurrentWorksheet.RowCount + 1;
            Table.CurrentWorksheet.Cells["A" + i].DataFormat = CellDataFormatFlag.DateTime;
            
            Table.CurrentWorksheet.Cells["A" + i].Data = stopWatch.Elapsed.ToString("hh\\:mm\\:ss\\:ff");
            double cur = Function(i);
            Graph.Series[0].Points.AddXY(i, cur);
            Table.CurrentWorksheet.Cells["B" + i].Data = cur;
            buf = (1 - a) * buf + a * cur;
            Graph.Series[1].Points.AddXY(i, buf);
            Table.CurrentWorksheet.Cells["C" + i].Data = buf;

            stopWatch.Start();
            
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private double Function(int i)
        {         
            return Math.Sin(((double)i) / 5) + shift;
        }

        private void FileSaveToolButton_Click(object sender, EventArgs e)
        {
            Table.CurrentWorksheet.Name = DateTime.Now.ToShortDateString();
            if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            try
            {
                Table.Save(SaveFileDialog.FileName, unvell.ReoGrid.IO.FileFormat.Excel2007);
                
            } catch (Exception exc) { MessageBox.Show(exc.ToString(), "Ошибка:"); }
        }

        private void ResetToolButton_Click(object sender, EventArgs e)
        {
            i = 0;
            Table.CurrentWorksheet.RowCount = 1;
            Table.CurrentWorksheet.Cells["A" + 1].Data = null;
            Table.CurrentWorksheet.Cells["B" + 1].Data = null;
            Table.CurrentWorksheet.Cells["C" + 1].Data = null;
            Graph.Series[0].Points.Clear();
            Graph.Series[1].Points.Clear();
            stopWatch = new Stopwatch();
        }

  
    }
}
