namespace lab1
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMakeGood = new System.Windows.Forms.Button();
            this.btnFillGrids = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridB = new System.Windows.Forms.DataGridView();
            this.MatrB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridC = new System.Windows.Forms.DataGridView();
            this.gridA = new System.Windows.Forms.DataGridView();
            this.MatrA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFirstPay = new System.Windows.Forms.Label();
            this.btnFirstPay = new System.Windows.Forms.Button();
            this.lblCheck2 = new System.Windows.Forms.Label();
            this.lblCheck1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnNordWest = new System.Windows.Forms.Button();
            this.gridSupport = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblOptimum = new System.Windows.Forms.Label();
            this.btnStep2 = new System.Windows.Forms.Button();
            this.btnStep1 = new System.Windows.Forms.Button();
            this.gridFinal = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupport)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnMakeGood);
            this.panel1.Controls.Add(this.btnFillGrids);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 290);
            this.panel1.TabIndex = 0;
            // 
            // btnMakeGood
            // 
            this.btnMakeGood.Location = new System.Drawing.Point(3, 264);
            this.btnMakeGood.Name = "btnMakeGood";
            this.btnMakeGood.Size = new System.Drawing.Size(104, 23);
            this.btnMakeGood.TabIndex = 6;
            this.btnMakeGood.Text = "Сделать хорошо";
            this.btnMakeGood.UseVisualStyleBackColor = true;
            this.btnMakeGood.Click += new System.EventHandler(this.btnMakeGood_Click);
            // 
            // btnFillGrids
            // 
            this.btnFillGrids.Location = new System.Drawing.Point(3, 22);
            this.btnFillGrids.Name = "btnFillGrids";
            this.btnFillGrids.Size = new System.Drawing.Size(104, 23);
            this.btnFillGrids.TabIndex = 3;
            this.btnFillGrids.Text = "Заполнить";
            this.btnFillGrids.UseVisualStyleBackColor = true;
            this.btnFillGrids.Click += new System.EventHandler(this.btnFillGrids_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(3, 0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(104, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Открыть из файла";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(128, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 290);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.gridB);
            this.tabPage1.Controls.Add(this.gridC);
            this.tabPage1.Controls.Add(this.gridA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Условия задачи";
            // 
            // gridB
            // 
            this.gridB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridB.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatrB});
            this.gridB.Location = new System.Drawing.Point(100, 0);
            this.gridB.Name = "gridB";
            this.gridB.Size = new System.Drawing.Size(94, 264);
            this.gridB.TabIndex = 2;
            this.gridB.Visible = false;
            this.gridB.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridB_RowsAdded);
            this.gridB.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridB_RowsRemoved);
            // 
            // MatrB
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewCellStyle23.NullValue = "null";
            this.MatrB.DefaultCellStyle = dataGridViewCellStyle23;
            this.MatrB.HeaderText = "MatrB";
            this.MatrB.Name = "MatrB";
            this.MatrB.Width = 50;
            // 
            // gridC
            // 
            this.gridC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridC.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewCellStyle24.NullValue = "null";
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridC.DefaultCellStyle = dataGridViewCellStyle24;
            this.gridC.Location = new System.Drawing.Point(200, 0);
            this.gridC.Name = "gridC";
            this.gridC.RowHeadersWidth = 50;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewCellStyle25.NullValue = "null";
            this.gridC.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.gridC.Size = new System.Drawing.Size(368, 264);
            this.gridC.TabIndex = 1;
            this.gridC.Visible = false;
            // 
            // gridA
            // 
            this.gridA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridA.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatrA});
            this.gridA.Location = new System.Drawing.Point(3, 0);
            this.gridA.MultiSelect = false;
            this.gridA.Name = "gridA";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.NullValue = null;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridA.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.gridA.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridA.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridA.RowTemplate.DefaultCellStyle.Format = "N2";
            this.gridA.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.gridA.Size = new System.Drawing.Size(94, 264);
            this.gridA.TabIndex = 0;
            this.gridA.Visible = false;
            this.gridA.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridA_RowsAdded);
            this.gridA.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridA_RowsRemoved);
            // 
            // MatrA
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle26.Format = "N2";
            dataGridViewCellStyle26.NullValue = "null";
            this.MatrA.DefaultCellStyle = dataGridViewCellStyle26;
            this.MatrA.FillWeight = 50F;
            this.MatrA.HeaderText = "A";
            this.MatrA.Name = "MatrA";
            this.MatrA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MatrA.Width = 50;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage2.Controls.Add(this.lblFirstPay);
            this.tabPage2.Controls.Add(this.btnFirstPay);
            this.tabPage2.Controls.Add(this.lblCheck2);
            this.tabPage2.Controls.Add(this.lblCheck1);
            this.tabPage2.Controls.Add(this.btnCheck);
            this.tabPage2.Controls.Add(this.btnNordWest);
            this.tabPage2.Controls.Add(this.gridSupport);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Опорный план";
            // 
            // lblFirstPay
            // 
            this.lblFirstPay.AutoSize = true;
            this.lblFirstPay.Location = new System.Drawing.Point(6, 174);
            this.lblFirstPay.Name = "lblFirstPay";
            this.lblFirstPay.Size = new System.Drawing.Size(0, 13);
            this.lblFirstPay.TabIndex = 8;
            // 
            // btnFirstPay
            // 
            this.btnFirstPay.Location = new System.Drawing.Point(3, 148);
            this.btnFirstPay.Name = "btnFirstPay";
            this.btnFirstPay.Size = new System.Drawing.Size(104, 23);
            this.btnFirstPay.TabIndex = 7;
            this.btnFirstPay.Text = "Стоимость";
            this.btnFirstPay.UseVisualStyleBackColor = true;
            this.btnFirstPay.Click += new System.EventHandler(this.btnFirstPay_Click);
            // 
            // lblCheck2
            // 
            this.lblCheck2.AutoSize = true;
            this.lblCheck2.Location = new System.Drawing.Point(6, 132);
            this.lblCheck2.Name = "lblCheck2";
            this.lblCheck2.Size = new System.Drawing.Size(0, 13);
            this.lblCheck2.TabIndex = 6;
            // 
            // lblCheck1
            // 
            this.lblCheck1.AutoSize = true;
            this.lblCheck1.Location = new System.Drawing.Point(6, 119);
            this.lblCheck1.Name = "lblCheck1";
            this.lblCheck1.Size = new System.Drawing.Size(0, 13);
            this.lblCheck1.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(3, 32);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Вырожденность";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnNordWest
            // 
            this.btnNordWest.Location = new System.Drawing.Point(3, 3);
            this.btnNordWest.Name = "btnNordWest";
            this.btnNordWest.Size = new System.Drawing.Size(104, 23);
            this.btnNordWest.TabIndex = 1;
            this.btnNordWest.Text = "С-З угол";
            this.btnNordWest.UseVisualStyleBackColor = true;
            this.btnNordWest.Click += new System.EventHandler(this.btnNordWest_Click);
            // 
            // gridSupport
            // 
            this.gridSupport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewCellStyle22.NullValue = "null";
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSupport.DefaultCellStyle = dataGridViewCellStyle22;
            this.gridSupport.Location = new System.Drawing.Point(113, 3);
            this.gridSupport.Name = "gridSupport";
            this.gridSupport.RowHeadersWidth = 50;
            this.gridSupport.Size = new System.Drawing.Size(452, 258);
            this.gridSupport.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage3.Controls.Add(this.lblOptimum);
            this.tabPage3.Controls.Add(this.btnStep2);
            this.tabPage3.Controls.Add(this.btnStep1);
            this.tabPage3.Controls.Add(this.gridFinal);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(568, 264);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Оптимальное решение";
            // 
            // lblOptimum
            // 
            this.lblOptimum.AutoSize = true;
            this.lblOptimum.Location = new System.Drawing.Point(3, 58);
            this.lblOptimum.Name = "lblOptimum";
            this.lblOptimum.Size = new System.Drawing.Size(0, 13);
            this.lblOptimum.TabIndex = 6;
            // 
            // btnStep2
            // 
            this.btnStep2.Location = new System.Drawing.Point(3, 32);
            this.btnStep2.Name = "btnStep2";
            this.btnStep2.Size = new System.Drawing.Size(104, 23);
            this.btnStep2.TabIndex = 5;
            this.btnStep2.Text = "Стоимость";
            this.btnStep2.UseVisualStyleBackColor = true;
            this.btnStep2.Click += new System.EventHandler(this.btnStep2_Click);
            // 
            // btnStep1
            // 
            this.btnStep1.Location = new System.Drawing.Point(3, 3);
            this.btnStep1.Name = "btnStep1";
            this.btnStep1.Size = new System.Drawing.Size(104, 23);
            this.btnStep1.TabIndex = 4;
            this.btnStep1.Text = "Найти";
            this.btnStep1.UseVisualStyleBackColor = true;
            this.btnStep1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gridFinal
            // 
            this.gridFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.Format = "N2";
            dataGridViewCellStyle28.NullValue = "null";
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFinal.DefaultCellStyle = dataGridViewCellStyle28;
            this.gridFinal.Location = new System.Drawing.Point(113, 3);
            this.gridFinal.Name = "gridFinal";
            this.gridFinal.RowHeadersWidth = 50;
            this.gridFinal.Size = new System.Drawing.Size(452, 258);
            this.gridFinal.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 307);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Транспортная задача";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupport)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFinal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridA;
        private System.Windows.Forms.DataGridView gridC;
        private System.Windows.Forms.DataGridView gridB;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFillGrids;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatrA;
        private System.Windows.Forms.Button btnNordWest;
        private System.Windows.Forms.DataGridView gridSupport;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatrB;
        private System.Windows.Forms.Label lblCheck1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCheck2;
        private System.Windows.Forms.Label lblFirstPay;
        private System.Windows.Forms.Button btnFirstPay;
        private System.Windows.Forms.Button btnStep1;
        private System.Windows.Forms.DataGridView gridFinal;
        private System.Windows.Forms.Button btnStep2;
        private System.Windows.Forms.Button btnMakeGood;
        private System.Windows.Forms.Label lblOptimum;
    }
}

