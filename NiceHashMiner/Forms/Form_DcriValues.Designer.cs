﻿namespace NiceHashMiner.Forms
{
    partial class FormDcriValues
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.listView_Intensities = new System.Windows.Forms.ListView();
            this.columnHeader_DcriValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_SecondarySpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Profit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Power = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.checkBox_TuningEnabled = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox_TuningEnabled = new System.Windows.Forms.PictureBox();
            this.field_Power = new NiceHashMiner.Forms.Components.Field();
            this.field_TuningEnd = new NiceHashMiner.Forms.Components.Field();
            this.field_TuningInterval = new NiceHashMiner.Forms.Components.Field();
            this.field_TuningStart = new NiceHashMiner.Forms.Components.Field();
            this.field_SecondarySpeed = new NiceHashMiner.Forms.Components.Field();
            this.field_Speed = new NiceHashMiner.Forms.Components.Field();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TuningEnabled)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Intensities
            // 
            this.listView_Intensities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Intensities.BackColor = System.Drawing.SystemColors.Window;
            this.listView_Intensities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_DcriValue,
            this.columnHeader_Speed,
            this.columnHeader_SecondarySpeed,
            this.columnHeader_Profit,
            this.columnHeader_Power});
            this.listView_Intensities.FullRowSelect = true;
            this.listView_Intensities.GridLines = true;
            this.listView_Intensities.Location = new System.Drawing.Point(12, 42);
            this.listView_Intensities.MultiSelect = false;
            this.listView_Intensities.Name = "listView_Intensities";
            this.listView_Intensities.Size = new System.Drawing.Size(580, 562);
            this.listView_Intensities.TabIndex = 0;
            this.listView_Intensities.UseCompatibleStateImageBehavior = false;
            this.listView_Intensities.View = System.Windows.Forms.View.Details;
            this.listView_Intensities.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_Intensities_ItemSelectionChanged);
            this.listView_Intensities.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Intensities_MouseClick);
            // 
            // columnHeader_DcriValue
            // 
            this.columnHeader_DcriValue.Text = "Intensity";
            this.columnHeader_DcriValue.Width = 55;
            // 
            // columnHeader_Speed
            // 
            this.columnHeader_Speed.Text = "Speed";
            this.columnHeader_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader_Speed.Width = 100;
            // 
            // columnHeader_SecondarySpeed
            // 
            this.columnHeader_SecondarySpeed.Text = "Secondary Speed";
            this.columnHeader_SecondarySpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader_SecondarySpeed.Width = 100;
            // 
            // columnHeader_Profit
            // 
            this.columnHeader_Profit.Text = "BTC/Day";
            this.columnHeader_Profit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader_Profit.Width = 75;
            // 
            // columnHeader_Power
            // 
            this.columnHeader_Power.Text = "Power";
            this.columnHeader_Power.Width = 76;
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.Location = new System.Drawing.Point(729, 570);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(201, 35);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.Button_Close_Clicked);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(729, 529);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(201, 35);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Clicked);
            // 
            // checkBox_TuningEnabled
            // 
            this.checkBox_TuningEnabled.AutoSize = true;
            this.checkBox_TuningEnabled.Location = new System.Drawing.Point(12, 12);
            this.checkBox_TuningEnabled.Name = "checkBox_TuningEnabled";
            this.checkBox_TuningEnabled.Size = new System.Drawing.Size(178, 24);
            this.checkBox_TuningEnabled.TabIndex = 3;
            this.checkBox_TuningEnabled.Text = "Dcri Tuning Enabled";
            this.checkBox_TuningEnabled.UseVisualStyleBackColor = true;
            this.checkBox_TuningEnabled.CheckedChanged += new System.EventHandler(this.CheckBox_TuningEnabledCheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox_TuningEnabled
            // 
            this.pictureBox_TuningEnabled.Image = global::NiceHashMiner.Properties.Resources.info_black_18;
            this.pictureBox_TuningEnabled.Location = new System.Drawing.Point(196, 12);
            this.pictureBox_TuningEnabled.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox_TuningEnabled.Name = "pictureBox_TuningEnabled";
            this.pictureBox_TuningEnabled.Size = new System.Drawing.Size(18, 18);
            this.pictureBox_TuningEnabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_TuningEnabled.TabIndex = 365;
            this.pictureBox_TuningEnabled.TabStop = false;
            // 
            // field_Power
            // 
            this.field_Power.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.field_Power.AutoSize = true;
            this.field_Power.BackColor = System.Drawing.Color.Transparent;
            this.field_Power.Enabled = false;
            this.field_Power.EntryText = "";
            this.field_Power.LabelText = "Power Usage (W)";
            this.field_Power.Location = new System.Drawing.Point(600, 442);
            this.field_Power.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.field_Power.Name = "field_Power";
            this.field_Power.Size = new System.Drawing.Size(330, 72);
            this.field_Power.TabIndex = 366;
            // 
            // field_TuningEnd
            // 
            this.field_TuningEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.field_TuningEnd.AutoSize = true;
            this.field_TuningEnd.BackColor = System.Drawing.Color.Transparent;
            this.field_TuningEnd.EntryText = "";
            this.field_TuningEnd.LabelText = "Tuning End";
            this.field_TuningEnd.Location = new System.Drawing.Point(600, 275);
            this.field_TuningEnd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.field_TuningEnd.Name = "field_TuningEnd";
            this.field_TuningEnd.Size = new System.Drawing.Size(330, 72);
            this.field_TuningEnd.TabIndex = 8;
            // 
            // field_TuningInterval
            // 
            this.field_TuningInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.field_TuningInterval.AutoSize = true;
            this.field_TuningInterval.BackColor = System.Drawing.Color.Transparent;
            this.field_TuningInterval.EntryText = "";
            this.field_TuningInterval.LabelText = "Tuning Interval";
            this.field_TuningInterval.Location = new System.Drawing.Point(600, 354);
            this.field_TuningInterval.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.field_TuningInterval.Name = "field_TuningInterval";
            this.field_TuningInterval.Size = new System.Drawing.Size(330, 72);
            this.field_TuningInterval.TabIndex = 7;
            // 
            // field_TuningStart
            // 
            this.field_TuningStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.field_TuningStart.AutoSize = true;
            this.field_TuningStart.BackColor = System.Drawing.Color.Transparent;
            this.field_TuningStart.EntryText = "";
            this.field_TuningStart.LabelText = "Tuning Start";
            this.field_TuningStart.Location = new System.Drawing.Point(600, 198);
            this.field_TuningStart.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.field_TuningStart.Name = "field_TuningStart";
            this.field_TuningStart.Size = new System.Drawing.Size(330, 72);
            this.field_TuningStart.TabIndex = 6;
            // 
            // field_SecondarySpeed
            // 
            this.field_SecondarySpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.field_SecondarySpeed.AutoSize = true;
            this.field_SecondarySpeed.BackColor = System.Drawing.Color.Transparent;
            this.field_SecondarySpeed.Enabled = false;
            this.field_SecondarySpeed.EntryText = "";
            this.field_SecondarySpeed.LabelText = "Secondary Speed (H/s)";
            this.field_SecondarySpeed.Location = new System.Drawing.Point(600, 120);
            this.field_SecondarySpeed.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.field_SecondarySpeed.Name = "field_SecondarySpeed";
            this.field_SecondarySpeed.Size = new System.Drawing.Size(330, 72);
            this.field_SecondarySpeed.TabIndex = 5;
            // 
            // field_Speed
            // 
            this.field_Speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.field_Speed.AutoSize = true;
            this.field_Speed.BackColor = System.Drawing.Color.Transparent;
            this.field_Speed.Enabled = false;
            this.field_Speed.EntryText = "";
            this.field_Speed.LabelText = "Speed (H/s)";
            this.field_Speed.Location = new System.Drawing.Point(600, 42);
            this.field_Speed.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.field_Speed.Name = "field_Speed";
            this.field_Speed.Size = new System.Drawing.Size(336, 72);
            this.field_Speed.TabIndex = 4;
            // 
            // FormDcriValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 632);
            this.Controls.Add(this.field_Power);
            this.Controls.Add(this.pictureBox_TuningEnabled);
            this.Controls.Add(this.field_TuningEnd);
            this.Controls.Add(this.field_TuningInterval);
            this.Controls.Add(this.field_TuningStart);
            this.Controls.Add(this.field_SecondarySpeed);
            this.Controls.Add(this.field_Speed);
            this.Controls.Add(this.checkBox_TuningEnabled);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.listView_Intensities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(901, 546);
            this.Name = "FormDcriValues";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dcri Values";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_DcriValues_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TuningEnabled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Intensities;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ColumnHeader columnHeader_DcriValue;
        private System.Windows.Forms.ColumnHeader columnHeader_Speed;
        private System.Windows.Forms.ColumnHeader columnHeader_SecondarySpeed;
        private System.Windows.Forms.ColumnHeader columnHeader_Profit;
        private System.Windows.Forms.CheckBox checkBox_TuningEnabled;
        private Components.Field field_Speed;
        private Components.Field field_SecondarySpeed;
        private Components.Field field_TuningStart;
        private Components.Field field_TuningInterval;
        private Components.Field field_TuningEnd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox_TuningEnabled;
        private Components.Field field_Power;
        private System.Windows.Forms.ColumnHeader columnHeader_Power;
    }
}