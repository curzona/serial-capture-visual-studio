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
  partial class SerialCaptureToolOptionsSessionControl
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
      this.portNameLabel = new System.Windows.Forms.Label();
      this.portNameCombo = new System.Windows.Forms.ComboBox();
      this.baudRateLabel = new System.Windows.Forms.Label();
      this.baudRateTestBox = new System.Windows.Forms.TextBox();
      this.parityLabel = new System.Windows.Forms.Label();
      this.parityCombo = new System.Windows.Forms.ComboBox();
      this.dataBitsLabel = new System.Windows.Forms.Label();
      this.dataBitsCombo = new System.Windows.Forms.ComboBox();
      this.stopBitsLabel = new System.Windows.Forms.Label();
      this.stopBitsCombo = new System.Windows.Forms.ComboBox();
      this.handshakeLabel = new System.Windows.Forms.Label();
      this.handshakeCombo = new System.Windows.Forms.ComboBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.sessionGroupBox = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.sessionGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // portNameLabel
      // 
      this.portNameLabel.AutoSize = true;
      this.portNameLabel.Location = new System.Drawing.Point(3, 4);
      this.portNameLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.portNameLabel.Name = "portNameLabel";
      this.portNameLabel.Size = new System.Drawing.Size(54, 13);
      this.portNameLabel.TabIndex = 0;
      this.portNameLabel.Text = "PortName";
      // 
      // portNameCombo
      // 
      this.portNameCombo.FormattingEnabled = true;
      this.portNameCombo.Location = new System.Drawing.Point(89, 4);
      this.portNameCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.portNameCombo.Name = "portNameCombo";
      this.portNameCombo.Size = new System.Drawing.Size(121, 21);
      this.portNameCombo.TabIndex = 1;
      this.portNameCombo.SelectedIndexChanged += new System.EventHandler(this.portNameCombo_SelectedIndexChanged);
      // 
      // baudRateLabel
      // 
      this.baudRateLabel.AutoSize = true;
      this.baudRateLabel.Location = new System.Drawing.Point(3, 62);
      this.baudRateLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.baudRateLabel.Name = "baudRateLabel";
      this.baudRateLabel.Size = new System.Drawing.Size(58, 13);
      this.baudRateLabel.TabIndex = 2;
      this.baudRateLabel.Text = "Baud Rate";
      // 
      // baudRateTestBox
      // 
      this.baudRateTestBox.Location = new System.Drawing.Point(89, 62);
      this.baudRateTestBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.baudRateTestBox.Name = "baudRateTestBox";
      this.baudRateTestBox.Size = new System.Drawing.Size(100, 20);
      this.baudRateTestBox.TabIndex = 3;
      this.baudRateTestBox.TextChanged += new System.EventHandler(this.baudRateTestBox_TextChanged);
      // 
      // parityLabel
      // 
      this.parityLabel.AutoSize = true;
      this.parityLabel.Location = new System.Drawing.Point(3, 33);
      this.parityLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.parityLabel.Name = "parityLabel";
      this.parityLabel.Size = new System.Drawing.Size(33, 13);
      this.parityLabel.TabIndex = 4;
      this.parityLabel.Text = "Parity";
      // 
      // parityCombo
      // 
      this.parityCombo.FormattingEnabled = true;
      this.parityCombo.Location = new System.Drawing.Point(89, 33);
      this.parityCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.parityCombo.Name = "parityCombo";
      this.parityCombo.Size = new System.Drawing.Size(121, 21);
      this.parityCombo.TabIndex = 5;
      this.parityCombo.SelectedIndexChanged += new System.EventHandler(this.parityCombo_SelectedIndexChanged);
      // 
      // dataBitsLabel
      // 
      this.dataBitsLabel.AutoSize = true;
      this.dataBitsLabel.Location = new System.Drawing.Point(3, 90);
      this.dataBitsLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.dataBitsLabel.Name = "dataBitsLabel";
      this.dataBitsLabel.Size = new System.Drawing.Size(50, 13);
      this.dataBitsLabel.TabIndex = 6;
      this.dataBitsLabel.Text = "Data Bits";
      // 
      // dataBitsCombo
      // 
      this.dataBitsCombo.FormattingEnabled = true;
      this.dataBitsCombo.Location = new System.Drawing.Point(89, 90);
      this.dataBitsCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.dataBitsCombo.Name = "dataBitsCombo";
      this.dataBitsCombo.Size = new System.Drawing.Size(121, 21);
      this.dataBitsCombo.TabIndex = 7;
      this.dataBitsCombo.SelectedIndexChanged += new System.EventHandler(this.dataBitsCombo_SelectedIndexChanged);
      // 
      // stopBitsLabel
      // 
      this.stopBitsLabel.AutoSize = true;
      this.stopBitsLabel.Location = new System.Drawing.Point(3, 120);
      this.stopBitsLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.stopBitsLabel.Name = "stopBitsLabel";
      this.stopBitsLabel.Size = new System.Drawing.Size(49, 13);
      this.stopBitsLabel.TabIndex = 8;
      this.stopBitsLabel.Text = "Stop Bits";
      // 
      // stopBitsCombo
      // 
      this.stopBitsCombo.FormattingEnabled = true;
      this.stopBitsCombo.Location = new System.Drawing.Point(89, 120);
      this.stopBitsCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.stopBitsCombo.Name = "stopBitsCombo";
      this.stopBitsCombo.Size = new System.Drawing.Size(121, 21);
      this.stopBitsCombo.TabIndex = 9;
      this.stopBitsCombo.SelectedIndexChanged += new System.EventHandler(this.stopBitsCombo_SelectedIndexChanged);
      // 
      // handshakeLabel
      // 
      this.handshakeLabel.AutoSize = true;
      this.handshakeLabel.Location = new System.Drawing.Point(3, 150);
      this.handshakeLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.handshakeLabel.Name = "handshakeLabel";
      this.handshakeLabel.Size = new System.Drawing.Size(62, 13);
      this.handshakeLabel.TabIndex = 10;
      this.handshakeLabel.Text = "Handshake";
      // 
      // handshakeCombo
      // 
      this.handshakeCombo.FormattingEnabled = true;
      this.handshakeCombo.Items.AddRange(new object[] {
            "None",
            "XON/XOFF",
            "Request-to-Send",
            "Request-to-Send and XON/XOFF"});
      this.handshakeCombo.Location = new System.Drawing.Point(89, 150);
      this.handshakeCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.handshakeCombo.Name = "handshakeCombo";
      this.handshakeCombo.Size = new System.Drawing.Size(121, 21);
      this.handshakeCombo.TabIndex = 11;
      this.handshakeCombo.SelectedIndexChanged += new System.EventHandler(this.handshakeCombo_SelectedIndexChanged);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.AutoSize = true;
      this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
      this.tableLayoutPanel1.Controls.Add(this.portNameCombo);
      this.tableLayoutPanel1.Controls.Add(this.parityLabel);
      this.tableLayoutPanel1.Controls.Add(this.parityCombo);
      this.tableLayoutPanel1.Controls.Add(this.baudRateLabel);
      this.tableLayoutPanel1.Controls.Add(this.baudRateTestBox);
      this.tableLayoutPanel1.Controls.Add(this.dataBitsLabel);
      this.tableLayoutPanel1.Controls.Add(this.dataBitsCombo);
      this.tableLayoutPanel1.Controls.Add(this.stopBitsLabel);
      this.tableLayoutPanel1.Controls.Add(this.stopBitsCombo);
      this.tableLayoutPanel1.Controls.Add(this.handshakeLabel);
      this.tableLayoutPanel1.Controls.Add(this.handshakeCombo);
      this.tableLayoutPanel1.Controls.Add(this.portNameLabel, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 6;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 258);
      this.tableLayoutPanel1.TabIndex = 12;
      // 
      // sessionGroupBox
      // 
      this.sessionGroupBox.AutoSize = true;
      this.sessionGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.sessionGroupBox.Controls.Add(this.tableLayoutPanel1);
      this.sessionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.sessionGroupBox.Location = new System.Drawing.Point(0, 0);
      this.sessionGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.sessionGroupBox.Name = "sessionGroupBox";
      this.sessionGroupBox.Size = new System.Drawing.Size(440, 320);
      this.sessionGroupBox.TabIndex = 13;
      this.sessionGroupBox.TabStop = false;
      this.sessionGroupBox.Text = "Session";
      // 
      // SerialCaptureToolOptionsGeneralControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.sessionGroupBox);
      this.Name = "SerialCaptureToolOptionsGeneralControl";
      this.Size = new System.Drawing.Size(440, 320);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.sessionGroupBox.ResumeLayout(false);
      this.sessionGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label portNameLabel;
    private System.Windows.Forms.ComboBox portNameCombo;
    private System.Windows.Forms.Label baudRateLabel;
    private System.Windows.Forms.TextBox baudRateTestBox;
    private System.Windows.Forms.Label parityLabel;
    private System.Windows.Forms.ComboBox parityCombo;
    private System.Windows.Forms.Label dataBitsLabel;
    private System.Windows.Forms.ComboBox dataBitsCombo;
    private System.Windows.Forms.Label stopBitsLabel;
    private System.Windows.Forms.ComboBox stopBitsCombo;
    private System.Windows.Forms.Label handshakeLabel;
    private System.Windows.Forms.ComboBox handshakeCombo;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.GroupBox sessionGroupBox;

  }
}
