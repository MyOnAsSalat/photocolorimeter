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
using System.IO.Ports;
using static Spec.CommonSerialPort;
namespace Spec
{
    public partial class FormMode_1 : Form
    {       
        Stopwatch stopWatch = new Stopwatch();
        int i = 0;
        public FormMode_1()
        {
            InitializeComponent();
            Table.CurrentWorksheet.ColumnCount = 4;
            Table.CurrentWorksheet.ColumnHeaders[0].Width = 100;
            Table.CurrentWorksheet.ColumnHeaders[1].Width = 100;
            Table.CurrentWorksheet.ColumnHeaders[2].Width = 100;
            Table.CurrentWorksheet.ColumnHeaders[3].Width = 100;
            Table.CurrentWorksheet.RowCount = 1;
            Table.CurrentWorksheet.Name = "Graph";                      
        }
        bool enable = false;
        double a = 0.5d;
        int interval = 1000;
        int shift = 0;
        private void StartStopToolButton_Click(object sender, EventArgs e)
        {
            
            if (!enable)
            {
                if (!COMPORT.IsOpen) { MessageBox.Show("Выберете порт!"); return; }
                try
                {
                    interval = Convert.ToInt32(IntervalTextBox.Text);
                    if (Convert.ToDouble(AlphaTextBox.Text) == 0) { throw new Exception("Альфа не может быть = 0"); }
                    a = 1d / Convert.ToDouble(AlphaTextBox.Text);
                    shift = Convert.ToInt32(ShiftTextBox.Text);
                    timer.Interval = interval;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Введены неверные данные:" + "\n" + exc.ToString().Replace("System.Exception: ", ""), "Ошибка:");
                    return;
                }
                enable = true;
                
                buf = Read();
                timer.Start();
            } else { stop(); }
            StartStopToolButton.Text = (enable) ? "Стоп" : "Старт";
        }
        private void stop()
        {
            enable = false;
            StartStopToolButton.Text = (enable) ? "Стоп" : "Старт";
            timer.Stop();          
        }
        double buf = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            Table.CurrentWorksheet.RowCount = Table.CurrentWorksheet.RowCount + 1;
            Table.CurrentWorksheet.Cells["A" + i].DataFormat = CellDataFormatFlag.DateTime;
            Table.CurrentWorksheet.Cells["A" + i].Data = stopWatch.Elapsed.ToString("hh\\:mm\\:ss\\:ff");
            double time = ((double)stopWatch.ElapsedMilliseconds) / 1000;
            Table.CurrentWorksheet.Cells["B" + i].Data = time;
            double cur = Math.Round(Read(), 3)+shift;
            Graph.Series[0].Points.AddXY(time, cur);
            Table.CurrentWorksheet.Cells["C" + i].Data = cur;
            buf = Math.Round((1 - a) * buf + a * cur, 3);
            Graph.Series[1].Points.AddXY(time, buf);
            Table.CurrentWorksheet.Cells["D" + i].Data = buf;
            stopWatch.Start();           
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private double Read()
        {
            COMPORT.Write("R");
            string msg = COMPORT.ReadLine().Replace(".",",");
            return Convert.ToDouble(msg);           
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
            DialogResult result = MessageBox.Show("Вы уверены что хотите сбросить данные?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) { return; }
            i = 0;
            stop();
            StartStopToolButton.Text = "Старт";
            Table.CurrentWorksheet.RowCount = 1;
            Table.CurrentWorksheet.Cells["A" + 1].Data = null;
            Table.CurrentWorksheet.Cells["B" + 1].Data = null;
            Table.CurrentWorksheet.Cells["C" + 1].Data = null;
            Table.CurrentWorksheet.Cells["D" + 1].Data = null;
            Graph.Series[0].Points.Clear();
            Graph.Series[1].Points.Clear();
            stopWatch = new Stopwatch();
        }
        private void PortSetToolButton_Click(object sender, EventArgs e)
        {
            COMPORT.Close();
            COMPORT.PortName = sender.ToString();
            try
            {
                COMPORT.Open();
                COMPORT.Write("S");
                if (int.TryParse(COMPORT.ReadLine(), out var result) && result == 'R')
                {
                    PortToolButton.Text = "Порт: " + COMPORT.PortName;
                }
                else { throw new Exception("невозможно установить соединение с устройством"); }
            } catch (Exception exc) { MessageBox.Show("Ошибка открытия порта: " + exc.Message); }
            
        }
        private void ClosePortToolButton_Click(object sender, EventArgs e)
        {
            stop();
            COMPORT.Close();
            PortToolButton.Text = "Порт:";
        }
        private bool PortToolButton_isOpen = false;
        private void PortToolButton_MouseEnter(object sender, EventArgs e)
        {
            if (PortToolButton_isOpen) return;
            PortToolButton.DropDownItems.Clear();
            string[] PortNames = SerialPort.GetPortNames();      
            for (int i = 0; i < PortNames.Length; i++)
            {
                ToolStripMenuItem PortNameToolButton = new ToolStripMenuItem
                {
                    Name = PortNames[i],
                    Size = new Size(181, 26),
                    Text = PortNames[i]
                    
                };               
                PortToolButton.DropDownItems.Add(PortNameToolButton);
                PortNameToolButton.Click += new EventHandler(PortSetToolButton_Click);
            }
            if (COMPORT.IsOpen)
            {
                ToolStripMenuItem ClosePortToolButton = new ToolStripMenuItem
                {
                    Name = "ClosePortToolButton",
                    Size = new Size(181, 26),
                    Text = "Закрыть порт"

                };
                PortToolButton.DropDownItems.Add(ClosePortToolButton);
                ClosePortToolButton.Click += new EventHandler(ClosePortToolButton_Click);
            }
        }
        private void PortToolButton_DropDownClosed(object sender, EventArgs e)
        {
            PortToolButton_isOpen = false;
        }
        private void PortToolButton_DropDownOpening(object sender, EventArgs e)
        {
            PortToolButton_isOpen = true;
        }


    }
}
