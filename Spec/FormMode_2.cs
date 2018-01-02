using System;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using unvell.ReoGrid.DataFormat;
using static Spec.CommonSerialPort;
namespace Spec
{
    public partial class FormMode_2 : Form
    {
        int RowIndex = 0;
        int interval = 1000;
        bool enable = false;
        private int pause = 100;
        Stopwatch stopWatch = new Stopwatch();
        public FormMode_1 BaseForm;
        public FormMode_2(FormMode_1 BaseForm)
        {
            this.BaseForm = BaseForm;
            InitializeComponent();
            Table.CurrentWorksheet.ColumnCount = 4;
            Table.CurrentWorksheet.ColumnHeaders[0].Width = 100;
            Table.CurrentWorksheet.ColumnHeaders[1].Width = 100;
            Table.CurrentWorksheet.ColumnHeaders[2].Width = 100;
            Table.CurrentWorksheet.ColumnHeaders[3].Width = 100;
            Table.CurrentWorksheet.RowCount = 1;
            Table.CurrentWorksheet.Name = "Graph";
            Table.CurrentWorksheet.ColumnHeaders[0].Text = "Время";
            Table.CurrentWorksheet.ColumnHeaders[1].Text = "Сигнал";
            Table.CurrentWorksheet.ColumnHeaders[2].Text = "Ноль";
            Table.CurrentWorksheet.ColumnHeaders[3].Text = "Значение";
        }
        private void Mode_2_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseForm.Show();
            this.Hide();
        }
        private void stop()
        {
            enable = false;
            StartStopToolButton.Text = (enable) ? "Стоп" : "Старт";
            timer.Stop();
        }
        private void FileSaveToolButton_Click(object sender, EventArgs e)
        {
            Table.CurrentWorksheet.Name = DateTime.Now.ToShortDateString();
            if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                Table.Save(SaveFileDialog.FileName, unvell.ReoGrid.IO.FileFormat.Excel2007);

            }
            catch (Exception exc) { MessageBox.Show(exc.ToString(), "Ошибка:"); }
        }

        private void ResetToolButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите сбросить данные?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) { return; }
            RowIndex = 0;
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
                COMPORT.Write("Y");
                COMPORT.Write("S");
                if (int.TryParse(COMPORT.ReadLine(), out var result) && result == 'R')
                {
                    PortToolButton.Text = "Порт: " + COMPORT.PortName;
                }
                else { throw new Exception("невозможно установить соединение с устройством"); }
            }
            catch (Exception exc) { MessageBox.Show("Ошибка открытия порта: " + exc.Message); }

        }
        private void ClosePortToolButton_Click(object sender, EventArgs e)
        {
            stop();
            COMPORT.Close();
            PortToolButton.Text = "Порт:";
        }
        private bool PortToolButton_isOpen = false;
        private void StartStopToolButton_Click(object sender, EventArgs e)
        {

            if (!enable)
            {
                if (!COMPORT.IsOpen) { MessageBox.Show("Выберете порт!"); return; }
                try
                {
                    interval = Convert.ToInt32(IntervalTextBox.Text);
                    timer.Interval = interval;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Введены неверные данные:" + "\n" + exc.ToString().Replace("System.Exception: ", ""), "Ошибка:");
                    return;
                }
                enable = true; 
                timer.Start();
            }
            else { stop(); }
            StartStopToolButton.Text = (enable) ? "Стоп" : "Старт";
        }
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
                PortNameToolButton.Click += PortSetToolButton_Click;
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
                ClosePortToolButton.Click += ClosePortToolButton_Click;
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

        private void FormMode_2_Activated(object sender, EventArgs e)
        {
            PortToolButton.Text = (COMPORT.IsOpen) ? "Порт: " + COMPORT.PortName : "Порт: ";
            try
            {
                if (COMPORT.IsOpen)
                {
                    COMPORT.Write("Y");
                }
            }
            catch (Exception)
            {

            }
        }

        private bool LazerOn = false;
        private void LazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (COMPORT.IsOpen)
                {
                    COMPORT.Write((LazerOn) ? "Z" : "T" );
                    LazerToolStripMenuItem.BackColor = (LazerOn) ? Color.Red : Color.LimeGreen;
                    LazerToolStripMenuItem.Text = (LazerOn) ? "Лазер: выключен" : "Лазер: включён";
                    LazerOn = !LazerOn;                   
                }
            }
            catch (Exception)
            {

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RowIndex++;
            double signal;
            double zero;
            Read(out signal, out zero);
            Table.CurrentWorksheet.RowCount = Table.CurrentWorksheet.RowCount + 1;
            double time = ((double)stopWatch.ElapsedMilliseconds) / 1000;
            Table.CurrentWorksheet.Cells["A" + RowIndex].Data = time;
            Table.CurrentWorksheet.Cells["B" + RowIndex].Data = signal;
            Table.CurrentWorksheet.Cells["C" + RowIndex].Data = zero;                     
            Table.CurrentWorksheet.Cells["D" + RowIndex].Data = (signal - zero);
            Graph.Series[0].Points.AddXY(time, signal);
            Graph.Series[1].Points.AddXY(time, zero);
            Graph.Series[2].Points.AddXY(time, signal - zero);
            stopWatch.Start();
        }

        private void Read(out double signal, out double zero)
        {
            try
            {
                COMPORT.Write("P");
                System.Threading.Thread.Sleep(pause);
                signal = Convert.ToDouble(COMPORT.ReadLine());
                System.Threading.Thread.Sleep(pause);
                zero = Convert.ToDouble(COMPORT.ReadLine());
            }
            catch (Exception e)
            {
                stop();
                MessageBox.Show("Ошибка соединения, чтение остановлено: " + e.Message);
                signal = 0;
                zero = 0;
            }

        }
    }
}
