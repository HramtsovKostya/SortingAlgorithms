using System.ComponentModel;
using System.Windows.Forms;

namespace Algorithm.UI
{
    partial class MainForm
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();       
            base.Dispose(disposing);
        }

        #region
        private void InitializeComponent()
        {
            this.AddPanel = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.FillPanel = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.CocktailSortButton = new System.Windows.Forms.Button();
            this.InsertSortButton = new System.Windows.Forms.Button();
            this.ShellSortButton = new System.Windows.Forms.Button();
            this.SortPanel = new System.Windows.Forms.Panel();
            this.GnomeSortButton = new System.Windows.Forms.Button();
            this.TreeSortButton = new System.Windows.Forms.Button();
            this.HeapSortButton = new System.Windows.Forms.Button();
            this.SelectSortButton = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.SleepTimeLabel = new System.Windows.Forms.Label();
            this.SleepTrackBar = new System.Windows.Forms.TrackBar();
            this.SwapsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComparisonsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SortNameLabel = new System.Windows.Forms.Label();
            this.SortTimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MsdRadixSortButton = new System.Windows.Forms.Button();
            this.LsdRadixSortButton = new System.Windows.Forms.Button();
            this.MergeSort = new System.Windows.Forms.Button();
            this.QuickSort = new System.Windows.Forms.Button();
            this.AddPanel.SuspendLayout();
            this.FillPanel.SuspendLayout();
            this.SortPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SleepTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPanel
            // 
            this.AddPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddPanel.Controls.Add(this.Label1);
            this.AddPanel.Controls.Add(this.AddButton);
            this.AddPanel.Controls.Add(this.AddTextBox);
            this.AddPanel.Location = new System.Drawing.Point(12, 12);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(472, 69);
            this.AddPanel.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(180, 17);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Добавить число в массив:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(333, 26);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(130, 30);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(6, 30);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(321, 22);
            this.AddTextBox.TabIndex = 0;
            // 
            // FillPanel
            // 
            this.FillPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FillPanel.Controls.Add(this.Label2);
            this.FillPanel.Controls.Add(this.FillButton);
            this.FillPanel.Controls.Add(this.FillTextBox);
            this.FillPanel.Location = new System.Drawing.Point(12, 87);
            this.FillPanel.Name = "FillPanel";
            this.FillPanel.Padding = new System.Windows.Forms.Padding(3);
            this.FillPanel.Size = new System.Drawing.Size(472, 69);
            this.FillPanel.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(3, 10);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(278, 17);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Заполнить массив случайными числами:";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(333, 26);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(130, 30);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(6, 30);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(321, 22);
            this.FillTextBox.TabIndex = 0;
            // 
            // ViewPanel
            // 
            this.ViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewPanel.Location = new System.Drawing.Point(490, 12);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Padding = new System.Windows.Forms.Padding(3);
            this.ViewPanel.Size = new System.Drawing.Size(650, 144);
            this.ViewPanel.TabIndex = 0;
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(6, 6);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(457, 35);
            this.BubbleSortButton.TabIndex = 1;
            this.BubbleSortButton.Text = "Сортировка пузырьком";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // CocktailSortButton
            // 
            this.CocktailSortButton.Location = new System.Drawing.Point(6, 47);
            this.CocktailSortButton.Name = "CocktailSortButton";
            this.CocktailSortButton.Size = new System.Drawing.Size(457, 35);
            this.CocktailSortButton.TabIndex = 1;
            this.CocktailSortButton.Text = "Шейкерная сортировка";
            this.CocktailSortButton.UseVisualStyleBackColor = true;
            this.CocktailSortButton.Click += new System.EventHandler(this.CocktailSortButton_Click);
            // 
            // InsertSortButton
            // 
            this.InsertSortButton.Location = new System.Drawing.Point(7, 129);
            this.InsertSortButton.Name = "InsertSortButton";
            this.InsertSortButton.Size = new System.Drawing.Size(457, 35);
            this.InsertSortButton.TabIndex = 1;
            this.InsertSortButton.Text = "Сортировка вставками";
            this.InsertSortButton.UseVisualStyleBackColor = true;
            this.InsertSortButton.Click += new System.EventHandler(this.InsertSortButton_Click);
            // 
            // ShellSortButton
            // 
            this.ShellSortButton.Location = new System.Drawing.Point(7, 214);
            this.ShellSortButton.Name = "ShellSortButton";
            this.ShellSortButton.Size = new System.Drawing.Size(457, 35);
            this.ShellSortButton.TabIndex = 1;
            this.ShellSortButton.Text = "Сортировка Шелла";
            this.ShellSortButton.UseVisualStyleBackColor = true;
            this.ShellSortButton.Click += new System.EventHandler(this.ShellSortButton_Click);
            // 
            // SortPanel
            // 
            this.SortPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SortPanel.Controls.Add(this.GnomeSortButton);
            this.SortPanel.Controls.Add(this.QuickSort);
            this.SortPanel.Controls.Add(this.MergeSort);
            this.SortPanel.Controls.Add(this.LsdRadixSortButton);
            this.SortPanel.Controls.Add(this.MsdRadixSortButton);
            this.SortPanel.Controls.Add(this.TreeSortButton);
            this.SortPanel.Controls.Add(this.HeapSortButton);
            this.SortPanel.Controls.Add(this.SelectSortButton);
            this.SortPanel.Controls.Add(this.ShellSortButton);
            this.SortPanel.Controls.Add(this.BubbleSortButton);
            this.SortPanel.Controls.Add(this.InsertSortButton);
            this.SortPanel.Controls.Add(this.CocktailSortButton);
            this.SortPanel.Location = new System.Drawing.Point(12, 162);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Padding = new System.Windows.Forms.Padding(3);
            this.SortPanel.Size = new System.Drawing.Size(472, 502);
            this.SortPanel.TabIndex = 0;
            // 
            // GnomeSortButton
            // 
            this.GnomeSortButton.Location = new System.Drawing.Point(7, 88);
            this.GnomeSortButton.Name = "GnomeSortButton";
            this.GnomeSortButton.Size = new System.Drawing.Size(457, 35);
            this.GnomeSortButton.TabIndex = 1;
            this.GnomeSortButton.Text = "Гномья сортировка";
            this.GnomeSortButton.UseVisualStyleBackColor = true;
            this.GnomeSortButton.Click += new System.EventHandler(this.GnomeSortButton_Click);
            // 
            // TreeSortButton
            // 
            this.TreeSortButton.Location = new System.Drawing.Point(7, 296);
            this.TreeSortButton.Name = "TreeSortButton";
            this.TreeSortButton.Size = new System.Drawing.Size(457, 35);
            this.TreeSortButton.TabIndex = 1;
            this.TreeSortButton.Text = "Сортировка деревом";
            this.TreeSortButton.UseVisualStyleBackColor = true;
            this.TreeSortButton.Click += new System.EventHandler(this.TreeSortButton_Click);
            // 
            // HeapSortButton
            // 
            this.HeapSortButton.Location = new System.Drawing.Point(7, 255);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(457, 35);
            this.HeapSortButton.TabIndex = 1;
            this.HeapSortButton.Text = "Пирамидальная сортировка";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            this.HeapSortButton.Click += new System.EventHandler(this.HeapSortButton_Click);
            // 
            // SelectSortButton
            // 
            this.SelectSortButton.Location = new System.Drawing.Point(6, 173);
            this.SelectSortButton.Name = "SelectSortButton";
            this.SelectSortButton.Size = new System.Drawing.Size(457, 35);
            this.SelectSortButton.TabIndex = 1;
            this.SelectSortButton.Text = "Сортировка выбором";
            this.SelectSortButton.UseVisualStyleBackColor = true;
            this.SelectSortButton.Click += new System.EventHandler(this.SelectSortButton_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoPanel.Controls.Add(this.SleepTimeLabel);
            this.InfoPanel.Controls.Add(this.SleepTrackBar);
            this.InfoPanel.Controls.Add(this.SwapsLabel);
            this.InfoPanel.Controls.Add(this.label7);
            this.InfoPanel.Controls.Add(this.label6);
            this.InfoPanel.Controls.Add(this.ComparisonsLabel);
            this.InfoPanel.Controls.Add(this.label5);
            this.InfoPanel.Controls.Add(this.SortNameLabel);
            this.InfoPanel.Controls.Add(this.SortTimeLabel);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.label4);
            this.InfoPanel.Location = new System.Drawing.Point(490, 162);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Padding = new System.Windows.Forms.Padding(3);
            this.InfoPanel.Size = new System.Drawing.Size(650, 502);
            this.InfoPanel.TabIndex = 0;
            // 
            // SleepTimeLabel
            // 
            this.SleepTimeLabel.AutoSize = true;
            this.SleepTimeLabel.Location = new System.Drawing.Point(211, 17);
            this.SleepTimeLabel.Name = "SleepTimeLabel";
            this.SleepTimeLabel.Size = new System.Drawing.Size(42, 17);
            this.SleepTimeLabel.TabIndex = 2;
            this.SleepTimeLabel.Text = "0 сек";
            // 
            // SleepTrackBar
            // 
            this.SleepTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SleepTrackBar.Location = new System.Drawing.Point(7, 38);
            this.SleepTrackBar.Maximum = 1000;
            this.SleepTrackBar.Name = "SleepTrackBar";
            this.SleepTrackBar.Size = new System.Drawing.Size(635, 56);
            this.SleepTrackBar.TabIndex = 1;
            this.SleepTrackBar.Scroll += new System.EventHandler(this.SleepTrackBar_Scroll);
            // 
            // SwapsLabel
            // 
            this.SwapsLabel.AutoSize = true;
            this.SwapsLabel.Location = new System.Drawing.Point(211, 191);
            this.SwapsLabel.Name = "SwapsLabel";
            this.SwapsLabel.Size = new System.Drawing.Size(0, 17);
            this.SwapsLabel.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Задержка визуализации:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Количество перестановок:";
            // 
            // ComparisonsLabel
            // 
            this.ComparisonsLabel.AutoSize = true;
            this.ComparisonsLabel.Location = new System.Drawing.Point(211, 161);
            this.ComparisonsLabel.Name = "ComparisonsLabel";
            this.ComparisonsLabel.Size = new System.Drawing.Size(0, 17);
            this.ComparisonsLabel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Количество сравнений:";
            // 
            // SortNameLabel
            // 
            this.SortNameLabel.AutoSize = true;
            this.SortNameLabel.Location = new System.Drawing.Point(211, 97);
            this.SortNameLabel.Name = "SortNameLabel";
            this.SortNameLabel.Size = new System.Drawing.Size(0, 17);
            this.SortNameLabel.TabIndex = 0;
            // 
            // SortTimeLabel
            // 
            this.SortTimeLabel.AutoSize = true;
            this.SortTimeLabel.Location = new System.Drawing.Point(211, 129);
            this.SortTimeLabel.Name = "SortTimeLabel";
            this.SortTimeLabel.Size = new System.Drawing.Size(0, 17);
            this.SortTimeLabel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Название сортировки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Общее время сортировки:";
            // 
            // MsdRadixSortButton
            // 
            this.MsdRadixSortButton.Location = new System.Drawing.Point(6, 378);
            this.MsdRadixSortButton.Name = "MsdRadixSortButton";
            this.MsdRadixSortButton.Size = new System.Drawing.Size(457, 35);
            this.MsdRadixSortButton.TabIndex = 1;
            this.MsdRadixSortButton.Text = "Поразрядная MSD-сортировка";
            this.MsdRadixSortButton.UseVisualStyleBackColor = true;
            this.MsdRadixSortButton.Click += new System.EventHandler(this.MsdRadixSortButton_Click);
            // 
            // LsdRadixSortButton
            // 
            this.LsdRadixSortButton.Location = new System.Drawing.Point(7, 337);
            this.LsdRadixSortButton.Name = "LsdRadixSortButton";
            this.LsdRadixSortButton.Size = new System.Drawing.Size(457, 35);
            this.LsdRadixSortButton.TabIndex = 1;
            this.LsdRadixSortButton.Text = "Поразрядная LSD-сортировка";
            this.LsdRadixSortButton.UseVisualStyleBackColor = true;
            this.LsdRadixSortButton.Click += new System.EventHandler(this.LsdRadixSortButton_Click);
            // 
            // MergeSort
            // 
            this.MergeSort.Location = new System.Drawing.Point(6, 419);
            this.MergeSort.Name = "MergeSort";
            this.MergeSort.Size = new System.Drawing.Size(457, 35);
            this.MergeSort.TabIndex = 1;
            this.MergeSort.Text = "Сортировка слиянием";
            this.MergeSort.UseVisualStyleBackColor = true;
            this.MergeSort.Click += new System.EventHandler(this.MergeSort_Click);
            // 
            // QuickSort
            // 
            this.QuickSort.Location = new System.Drawing.Point(6, 459);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(457, 35);
            this.QuickSort.TabIndex = 1;
            this.QuickSort.Text = "Быстрая сортировка Хоара";
            this.QuickSort.UseVisualStyleBackColor = true;
            this.QuickSort.Click += new System.EventHandler(this.QuickSort_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 676);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.FillPanel);
            this.Controls.Add(this.AddPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритмы сортировки";
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.FillPanel.ResumeLayout(false);
            this.FillPanel.PerformLayout();
            this.SortPanel.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SleepTrackBar)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Panel AddPanel;
        private Label Label1;
        private Button AddButton;
        private TextBox AddTextBox;
        private Panel FillPanel;
        private Label Label2;
        private Button FillButton;
        private TextBox FillTextBox;
        private Panel ViewPanel;
        private Button BubbleSortButton;
        private Button CocktailSortButton;
        private Button InsertSortButton;
        private Button ShellSortButton;
        private Panel SortPanel;
        private Panel InfoPanel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label SwapsLabel;
        private Label ComparisonsLabel;
        private Label SortNameLabel;
        private Label SortTimeLabel;
        private TrackBar SleepTrackBar;
        private Label label7;
        private Label SleepTimeLabel;
        private Button SelectSortButton;
        private Button HeapSortButton;
        private Button TreeSortButton;
        private Button GnomeSortButton;
        private Button LsdRadixSortButton;
        private Button MsdRadixSortButton;
        private Button MergeSort;
        private Button QuickSort;
    }
}