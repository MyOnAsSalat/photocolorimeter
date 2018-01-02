namespace Spec
{
    partial class FormMode_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveToolButton = new System.Windows.Forms.ToolStripMenuItem();
            this.StartStopToolButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PortToolButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mode_2_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Table = new unvell.ReoGrid.ReoGridControl();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.StartStopToolButton,
            this.ResetToolButton,
            this.PortToolButton,
            this.ModeToolStripMenuItem,
            this.LazerToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileSaveToolButton});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // FileSaveToolButton
            // 
            this.FileSaveToolButton.Name = "FileSaveToolButton";
            this.FileSaveToolButton.Size = new System.Drawing.Size(158, 26);
            this.FileSaveToolButton.Text = "Сохранить";
            this.FileSaveToolButton.Click += new System.EventHandler(this.FileSaveToolButton_Click);
            // 
            // StartStopToolButton
            // 
            this.StartStopToolButton.Name = "StartStopToolButton";
            this.StartStopToolButton.Size = new System.Drawing.Size(59, 24);
            this.StartStopToolButton.Text = "Старт";
            this.StartStopToolButton.Click += new System.EventHandler(this.StartStopToolButton_Click);
            // 
            // ResetToolButton
            // 
            this.ResetToolButton.Name = "ResetToolButton";
            this.ResetToolButton.Size = new System.Drawing.Size(64, 24);
            this.ResetToolButton.Text = "Сброс";
            this.ResetToolButton.Click += new System.EventHandler(this.ResetToolButton_Click);
            // 
            // PortToolButton
            // 
            this.PortToolButton.Name = "PortToolButton";
            this.PortToolButton.Size = new System.Drawing.Size(59, 24);
            this.PortToolButton.Text = "Порт:";
            this.PortToolButton.ToolTipText = "Выберете порт для подключения";
            this.PortToolButton.DropDownClosed += new System.EventHandler(this.PortToolButton_DropDownClosed);
            this.PortToolButton.DropDownOpening += new System.EventHandler(this.PortToolButton_DropDownOpening);
            this.PortToolButton.MouseEnter += new System.EventHandler(this.PortToolButton_MouseEnter);
            // 
            // ModeToolStripMenuItem
            // 
            this.ModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mode_2_ToolStripMenuItem});
            this.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem";
            this.ModeToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.ModeToolStripMenuItem.Text = "Режим: 2";
            // 
            // Mode_2_ToolStripMenuItem
            // 
            this.Mode_2_ToolStripMenuItem.Name = "Mode_2_ToolStripMenuItem";
            this.Mode_2_ToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.Mode_2_ToolStripMenuItem.Text = "Режим: 1";
            this.Mode_2_ToolStripMenuItem.Click += new System.EventHandler(this.Mode_2_ToolStripMenuItem_Click);
            // 
            // LazerToolStripMenuItem
            // 
            this.LazerToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.LazerToolStripMenuItem.Name = "LazerToolStripMenuItem";
            this.LazerToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.LazerToolStripMenuItem.Text = "Лазер: Выключен";
            this.LazerToolStripMenuItem.Click += new System.EventHandler(this.LazerToolStripMenuItem_Click);
            // 
            // Table
            // 
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Table.BackColor = System.Drawing.Color.White;
            this.Table.ColumnHeaderContextMenuStrip = null;
            this.Table.LeadHeaderContextMenuStrip = null;
            this.Table.Location = new System.Drawing.Point(12, 56);
            this.Table.Name = "Table";
            this.Table.RowHeaderContextMenuStrip = null;
            this.Table.Script = null;
            this.Table.SheetTabContextMenuStrip = null;
            this.Table.SheetTabNewButtonVisible = true;
            this.Table.SheetTabVisible = true;
            this.Table.SheetTabWidth = 60;
            this.Table.ShowScrollEndSpacing = true;
            this.Table.Size = new System.Drawing.Size(590, 434);
            this.Table.TabIndex = 6;
            this.Table.Text = "Таблица";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Интервал -";
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(96, 28);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(100, 22);
            this.IntervalTextBox.TabIndex = 9;
            this.IntervalTextBox.Text = "1000";
            this.IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Graph
            // 
            this.Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graph.BackColor = System.Drawing.Color.Transparent;
            this.Graph.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Graph.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            this.Graph.Location = new System.Drawing.Point(605, 56);
            this.Graph.Margin = new System.Windows.Forms.Padding(0);
            this.Graph.Name = "Graph";
            this.Graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "GraphSignal";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "GraphZero";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "GraphValue";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.Graph.Series.Add(series1);
            this.Graph.Series.Add(series2);
            this.Graph.Series.Add(series3);
            this.Graph.Size = new System.Drawing.Size(648, 501);
            this.Graph.TabIndex = 11;
            this.Graph.Text = "График";
            // 
            // FormMode_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 511);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IntervalTextBox);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.menuStrip);
            this.Name = "FormMode_2";
            this.Text = "FormMode_2";
            this.Activated += new System.EventHandler(this.FormMode_2_Activated);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveToolButton;
        private System.Windows.Forms.ToolStripMenuItem StartStopToolButton;
        private System.Windows.Forms.ToolStripMenuItem ResetToolButton;
        private System.Windows.Forms.ToolStripMenuItem PortToolButton;
        private System.Windows.Forms.ToolStripMenuItem ModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mode_2_ToolStripMenuItem;
        private unvell.ReoGrid.ReoGridControl Table;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.ToolStripMenuItem LazerToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
    }
}