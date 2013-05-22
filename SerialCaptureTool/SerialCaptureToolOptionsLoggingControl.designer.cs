/*
Copyright 2013 Intel Corporation

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

namespace Intel.SerialCapture
{
  partial class SerialCaptureToolOptionsLoggingControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.loggingGroupBox = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.logFileNameTextBox = new System.Windows.Forms.TextBox();
      this.logFileNameButton = new System.Windows.Forms.Button();
      this.logFileNameLabel = new System.Windows.Forms.Label();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.overwriteRadioButton = new System.Windows.Forms.RadioButton();
      this.appendRadioButton = new System.Windows.Forms.RadioButton();
      this.askRadioButton = new System.Windows.Forms.RadioButton();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.noLoggingradioButton = new System.Windows.Forms.RadioButton();
      this.allLoggingRadioButton = new System.Windows.Forms.RadioButton();
      this.loggingGroupBox.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // loggingGroupBox
      // 
      this.loggingGroupBox.AutoSize = true;
      this.loggingGroupBox.Controls.Add(this.tableLayoutPanel1);
      this.loggingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.loggingGroupBox.Location = new System.Drawing.Point(0, 0);
      this.loggingGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.loggingGroupBox.Name = "loggingGroupBox";
      this.loggingGroupBox.Size = new System.Drawing.Size(440, 320);
      this.loggingGroupBox.TabIndex = 13;
      this.loggingGroupBox.TabStop = false;
      this.loggingGroupBox.Text = "Logging";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.7971F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.2029F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 301);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
      this.tableLayoutPanel2.Controls.Add(this.logFileNameTextBox, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.logFileNameButton, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.logFileNameLabel, 0, 0);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 82);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(428, 57);
      this.tableLayoutPanel2.TabIndex = 3;
      // 
      // logFileNameTextBox
      // 
      this.logFileNameTextBox.Location = new System.Drawing.Point(3, 27);
      this.logFileNameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
      this.logFileNameTextBox.Name = "logFileNameTextBox";
      this.logFileNameTextBox.Size = new System.Drawing.Size(279, 20);
      this.logFileNameTextBox.TabIndex = 1;
      this.logFileNameTextBox.TextChanged += new System.EventHandler(this.logFileNameTextBox_TextChanged);
      // 
      // logFileNameButton
      // 
      this.logFileNameButton.Location = new System.Drawing.Point(288, 25);
      this.logFileNameButton.Name = "logFileNameButton";
      this.logFileNameButton.Size = new System.Drawing.Size(75, 23);
      this.logFileNameButton.TabIndex = 2;
      this.logFileNameButton.Text = "Browse...";
      this.logFileNameButton.UseVisualStyleBackColor = true;
      this.logFileNameButton.Click += new System.EventHandler(this.logFileNameButton_Click);
      // 
      // logFileNameLabel
      // 
      this.logFileNameLabel.AutoSize = true;
      this.logFileNameLabel.Location = new System.Drawing.Point(3, 4);
      this.logFileNameLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.logFileNameLabel.Name = "logFileNameLabel";
      this.logFileNameLabel.Size = new System.Drawing.Size(73, 13);
      this.logFileNameLabel.TabIndex = 0;
      this.logFileNameLabel.Text = "Log file name:";
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Controls.Add(this.label1);
      this.tableLayoutPanel3.Controls.Add(this.overwriteRadioButton);
      this.tableLayoutPanel3.Controls.Add(this.appendRadioButton);
      this.tableLayoutPanel3.Controls.Add(this.askRadioButton);
      this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 145);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 4;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(428, 94);
      this.tableLayoutPanel3.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 4);
      this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(188, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "What to do if the log file already exists:";
      // 
      // overwriteRadioButton
      // 
      this.overwriteRadioButton.AutoSize = true;
      this.overwriteRadioButton.Location = new System.Drawing.Point(3, 25);
      this.overwriteRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.overwriteRadioButton.Name = "overwriteRadioButton";
      this.overwriteRadioButton.Size = new System.Drawing.Size(114, 16);
      this.overwriteRadioButton.TabIndex = 0;
      this.overwriteRadioButton.TabStop = true;
      this.overwriteRadioButton.Text = "Always Overwrite it";
      this.overwriteRadioButton.UseVisualStyleBackColor = true;
      this.overwriteRadioButton.CheckedChanged += new System.EventHandler(this.overwriteRadioButton_CheckedChanged);
      // 
      // appendRadioButton
      // 
      this.appendRadioButton.AutoSize = true;
      this.appendRadioButton.Location = new System.Drawing.Point(3, 49);
      this.appendRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.appendRadioButton.Name = "appendRadioButton";
      this.appendRadioButton.Size = new System.Drawing.Size(168, 15);
      this.appendRadioButton.TabIndex = 1;
      this.appendRadioButton.TabStop = true;
      this.appendRadioButton.Text = "Always append to the end of it";
      this.appendRadioButton.UseVisualStyleBackColor = true;
      this.appendRadioButton.CheckedChanged += new System.EventHandler(this.appendRadioButton_CheckedChanged);
      // 
      // askRadioButton
      // 
      this.askRadioButton.AutoSize = true;
      this.askRadioButton.Location = new System.Drawing.Point(3, 72);
      this.askRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.askRadioButton.Name = "askRadioButton";
      this.askRadioButton.Size = new System.Drawing.Size(135, 17);
      this.askRadioButton.TabIndex = 2;
      this.askRadioButton.TabStop = true;
      this.askRadioButton.Text = "Ask the user every time";
      this.askRadioButton.UseVisualStyleBackColor = true;
      this.askRadioButton.CheckedChanged += new System.EventHandler(this.askRadioButton_CheckedChanged);
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 1;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.Controls.Add(this.allLoggingRadioButton, 0, 2);
      this.tableLayoutPanel4.Controls.Add(this.noLoggingradioButton, 0, 1);
      this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 3;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.83721F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.16279F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(428, 69);
      this.tableLayoutPanel4.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 4);
      this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(88, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Session Logging:";
      // 
      // noLoggingradioButton
      // 
      this.noLoggingradioButton.AutoSize = true;
      this.noLoggingradioButton.Location = new System.Drawing.Point(3, 25);
      this.noLoggingradioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.noLoggingradioButton.Name = "noLoggingradioButton";
      this.noLoggingradioButton.Size = new System.Drawing.Size(51, 15);
      this.noLoggingradioButton.TabIndex = 5;
      this.noLoggingradioButton.TabStop = true;
      this.noLoggingradioButton.Text = "None";
      this.noLoggingradioButton.UseVisualStyleBackColor = true;
      this.noLoggingradioButton.CheckedChanged += new System.EventHandler(this.noLoggingradioButton_CheckedChanged);
      // 
      // allLoggingRadioButton
      // 
      this.allLoggingRadioButton.AutoSize = true;
      this.allLoggingRadioButton.Location = new System.Drawing.Point(3, 48);
      this.allLoggingRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.allLoggingRadioButton.Name = "allLoggingRadioButton";
      this.allLoggingRadioButton.Size = new System.Drawing.Size(107, 17);
      this.allLoggingRadioButton.TabIndex = 6;
      this.allLoggingRadioButton.TabStop = true;
      this.allLoggingRadioButton.Text = "All session output";
      this.allLoggingRadioButton.UseVisualStyleBackColor = true;
      this.allLoggingRadioButton.CheckedChanged += new System.EventHandler(this.allLoggingRadioButton_CheckedChanged);
      // 
      // SerialCaptureToolOptionsLoggingControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.loggingGroupBox);
      this.Name = "SerialCaptureToolOptionsLoggingControl";
      this.Size = new System.Drawing.Size(440, 320);
      this.loggingGroupBox.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox loggingGroupBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label logFileNameLabel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TextBox logFileNameTextBox;
    private System.Windows.Forms.Button logFileNameButton;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.RadioButton overwriteRadioButton;
    private System.Windows.Forms.RadioButton appendRadioButton;
    private System.Windows.Forms.RadioButton askRadioButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.RadioButton allLoggingRadioButton;
    private System.Windows.Forms.RadioButton noLoggingradioButton;
    private System.Windows.Forms.Label label2;

  }
}
