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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.DelayTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IntervalTextBox = new System.Windows.Forms.MaskedTextBox();
            this.GetValueButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
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
            this.Table.Size = new System.Drawing.Size(610, 434);
            this.Table.TabIndex = 6;
            this.Table.Text = "Таблица";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "xlsx";
            this.SaveFileDialog.FileName = "Измерения фотоколориметр";
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
            // Graph
            // 
            this.Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graph.BackColor = System.Drawing.Color.Transparent;
            this.Graph.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Graph.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea7.BackColor = System.Drawing.Color.Black;
            chartArea7.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea7.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea7);
            this.Graph.Location = new System.Drawing.Point(625, 56);
            this.Graph.Margin = new System.Windows.Forms.Padding(0);
            this.Graph.Name = "Graph";
            this.Graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Name = "GraphSignal";
            series19.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Name = "GraphZero";
            series20.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Name = "GraphValue";
            series21.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.Graph.Series.Add(series19);
            this.Graph.Series.Add(series20);
            this.Graph.Series.Add(series21);
            this.Graph.Size = new System.Drawing.Size(628, 446);
            this.Graph.TabIndex = 11;
            this.Graph.Text = "График";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пауза -";
            // 
            // DelayTextBox
            // 
            this.DelayTextBox.Location = new System.Drawing.Point(217, 28);
            this.DelayTextBox.Mask = "00000";
            this.DelayTextBox.Name = "DelayTextBox";
            this.DelayTextBox.ResetOnSpace = false;
            this.DelayTextBox.Size = new System.Drawing.Size(52, 22);
            this.DelayTextBox.TabIndex = 15;
            this.DelayTextBox.Text = "100";
            this.DelayTextBox.ValidatingType = typeof(int);
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(96, 28);
            this.IntervalTextBox.Mask = "00000";
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.ResetOnSpace = false;
            this.IntervalTextBox.Size = new System.Drawing.Size(52, 22);
            this.IntervalTextBox.TabIndex = 15;
            this.IntervalTextBox.Text = "1000";
            this.IntervalTextBox.ValidatingType = typeof(int);
            // 
            // GetValueButton
            // 
            this.GetValueButton.Location = new System.Drawing.Point(287, 27);
            this.GetValueButton.Name = "GetValueButton";
            this.GetValueButton.Size = new System.Drawing.Size(156, 26);
            this.GetValueButton.TabIndex = 16;
            this.GetValueButton.Text = "Получить значение";
            this.GetValueButton.UseVisualStyleBackColor = true;
            this.GetValueButton.Click += new System.EventHandler(this.GetValueButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "-";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Enabled = false;
            this.ValueTextBox.Location = new System.Drawing.Point(469, 27);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.ValueTextBox.TabIndex = 18;
            // 
            // FormMode_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 511);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GetValueButton);
            this.Controls.Add(this.IntervalTextBox);
            this.Controls.Add(this.DelayTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.menuStrip);
            this.Name = "FormMode_2";
            this.Text = "FormMode_2";
            this.Activated += new System.EventHandler(this.FormMode_2_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMode_2_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem LazerToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox DelayTextBox;
        private System.Windows.Forms.MaskedTextBox IntervalTextBox;
        private System.Windows.Forms.Button GetValueButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValueTextBox;
    }
}