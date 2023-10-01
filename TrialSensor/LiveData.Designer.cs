using System;

namespace TrialSensor
{
    partial class LiveData
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.humidityTextBox = new System.Windows.Forms.TextBox();
            this.temperatureTextBox2 = new System.Windows.Forms.TextBox();
            this.humidityTextBox2 = new System.Windows.Forms.TextBox();
            this.lb_Temp = new System.Windows.Forms.Label();
            this.lb_Humid = new System.Windows.Forms.Label();
            this.lb_Temp1 = new System.Windows.Forms.Label();
            this.lb_Humid1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceivedHandler);
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(104, 36);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(55, 20);
            this.temperatureTextBox.TabIndex = 0;
            // 
            // humidityTextBox
            // 
            this.humidityTextBox.Location = new System.Drawing.Point(104, 91);
            this.humidityTextBox.Name = "humidityTextBox";
            this.humidityTextBox.Size = new System.Drawing.Size(55, 20);
            this.humidityTextBox.TabIndex = 1;
            // 
            // temperatureTextBox2
            // 
            this.temperatureTextBox2.Location = new System.Drawing.Point(295, 39);
            this.temperatureTextBox2.Name = "temperatureTextBox2";
            this.temperatureTextBox2.Size = new System.Drawing.Size(55, 20);
            this.temperatureTextBox2.TabIndex = 2;
            // 
            // humidityTextBox2
            // 
            this.humidityTextBox2.Location = new System.Drawing.Point(295, 91);
            this.humidityTextBox2.Name = "humidityTextBox2";
            this.humidityTextBox2.Size = new System.Drawing.Size(55, 20);
            this.humidityTextBox2.TabIndex = 3;
            // 
            // lb_Temp
            // 
            this.lb_Temp.AutoSize = true;
            this.lb_Temp.Location = new System.Drawing.Point(12, 39);
            this.lb_Temp.Name = "lb_Temp";
            this.lb_Temp.Size = new System.Drawing.Size(67, 13);
            this.lb_Temp.TabIndex = 4;
            this.lb_Temp.Text = "Temperature";
            // 
            // lb_Humid
            // 
            this.lb_Humid.AutoSize = true;
            this.lb_Humid.Location = new System.Drawing.Point(12, 94);
            this.lb_Humid.Name = "lb_Humid";
            this.lb_Humid.Size = new System.Drawing.Size(47, 13);
            this.lb_Humid.TabIndex = 5;
            this.lb_Humid.Text = "Humidity";
            // 
            // lb_Temp1
            // 
            this.lb_Temp1.AutoSize = true;
            this.lb_Temp1.Location = new System.Drawing.Point(213, 39);
            this.lb_Temp1.Name = "lb_Temp1";
            this.lb_Temp1.Size = new System.Drawing.Size(76, 13);
            this.lb_Temp1.TabIndex = 6;
            this.lb_Temp1.Text = "Temperature 1";
            // 
            // lb_Humid1
            // 
            this.lb_Humid1.AutoSize = true;
            this.lb_Humid1.Location = new System.Drawing.Point(213, 94);
            this.lb_Humid1.Name = "lb_Humid1";
            this.lb_Humid1.Size = new System.Drawing.Size(56, 13);
            this.lb_Humid1.TabIndex = 7;
            this.lb_Humid1.Text = "Humidity 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date:";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(68, 149);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(0, 13);
            this.lb_date.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Time: ";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(254, 149);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(0, 13);
            this.lb_time.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 231);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Humid1);
            this.Controls.Add(this.lb_Temp1);
            this.Controls.Add(this.lb_Humid);
            this.Controls.Add(this.lb_Temp);
            this.Controls.Add(this.humidityTextBox2);
            this.Controls.Add(this.temperatureTextBox2);
            this.Controls.Add(this.humidityTextBox);
            this.Controls.Add(this.temperatureTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.TextBox humidityTextBox;
        private System.Windows.Forms.TextBox temperatureTextBox2;
        private System.Windows.Forms.TextBox humidityTextBox2;
        private System.Windows.Forms.Label lb_Temp;
        private System.Windows.Forms.Label lb_Humid;
        private System.Windows.Forms.Label lb_Temp1;
        private System.Windows.Forms.Label lb_Humid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_time;
    }
}

