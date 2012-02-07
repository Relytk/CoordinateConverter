﻿namespace CoordinateConverter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.latitudeText = new System.Windows.Forms.TextBox();
            this.longitudeText = new System.Windows.Forms.TextBox();
            this.coordList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eclipticLabel = new System.Windows.Forms.Label();
            this.equatorialLabel = new System.Windows.Forms.Label();
            this.galacticLabel = new System.Windows.Forms.Label();
            this.convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Longitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latitude";
            // 
            // latitudeText
            // 
            this.latitudeText.Location = new System.Drawing.Point(81, 58);
            this.latitudeText.Name = "latitudeText";
            this.latitudeText.Size = new System.Drawing.Size(100, 20);
            this.latitudeText.TabIndex = 2;
            // 
            // longitudeText
            // 
            this.longitudeText.Location = new System.Drawing.Point(81, 26);
            this.longitudeText.Name = "longitudeText";
            this.longitudeText.Size = new System.Drawing.Size(100, 20);
            this.longitudeText.TabIndex = 1;
            // 
            // coordList
            // 
            this.coordList.FormattingEnabled = true;
            this.coordList.Items.AddRange(new object[] {
            "Equatorial",
            "Ecliptic",
            "Galactic"});
            this.coordList.Location = new System.Drawing.Point(224, 26);
            this.coordList.Name = "coordList";
            this.coordList.Size = new System.Drawing.Size(100, 56);
            this.coordList.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Equatorial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ecliptic:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Galactic:";
            // 
            // eclipticLabel
            // 
            this.eclipticLabel.AutoSize = true;
            this.eclipticLabel.Location = new System.Drawing.Point(22, 216);
            this.eclipticLabel.Name = "eclipticLabel";
            this.eclipticLabel.Size = new System.Drawing.Size(35, 13);
            this.eclipticLabel.TabIndex = 8;
            this.eclipticLabel.Text = "label6";
            // 
            // equatorialLabel
            // 
            this.equatorialLabel.AutoSize = true;
            this.equatorialLabel.Location = new System.Drawing.Point(129, 216);
            this.equatorialLabel.Name = "equatorialLabel";
            this.equatorialLabel.Size = new System.Drawing.Size(35, 13);
            this.equatorialLabel.TabIndex = 9;
            this.equatorialLabel.Text = "label7";
            // 
            // galacticLabel
            // 
            this.galacticLabel.AutoSize = true;
            this.galacticLabel.Location = new System.Drawing.Point(255, 216);
            this.galacticLabel.Name = "galacticLabel";
            this.galacticLabel.Size = new System.Drawing.Size(35, 13);
            this.galacticLabel.TabIndex = 10;
            this.galacticLabel.Text = "label8";
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(132, 109);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(99, 40);
            this.convert.TabIndex = 11;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 263);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.galacticLabel);
            this.Controls.Add(this.equatorialLabel);
            this.Controls.Add(this.eclipticLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coordList);
            this.Controls.Add(this.longitudeText);
            this.Controls.Add(this.latitudeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Coordinate Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox latitudeText;
        private System.Windows.Forms.TextBox longitudeText;
        private System.Windows.Forms.ListBox coordList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label eclipticLabel;
        private System.Windows.Forms.Label equatorialLabel;
        private System.Windows.Forms.Label galacticLabel;
        private System.Windows.Forms.Button convert;
    }
}

