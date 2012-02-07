namespace CoordinateConverter
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.eclipticLabel = new System.Windows.Forms.Label();
			this.equatorialLabel = new System.Windows.Forms.Label();
			this.galacticLabel = new System.Windows.Forms.Label();
			this.coordList = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Longitude:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Latitude:";
			// 
			// latitudeText
			// 
			this.latitudeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.latitudeText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.latitudeText.Location = new System.Drawing.Point(148, 52);
			this.latitudeText.Name = "latitudeText";
			this.latitudeText.Size = new System.Drawing.Size(304, 39);
			this.latitudeText.TabIndex = 2;
			this.latitudeText.TextChanged += new System.EventHandler(this.value_TextChanged);
			// 
			// longitudeText
			// 
			this.longitudeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.longitudeText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.longitudeText.Location = new System.Drawing.Point(148, 7);
			this.longitudeText.Name = "longitudeText";
			this.longitudeText.Size = new System.Drawing.Size(304, 39);
			this.longitudeText.TabIndex = 1;
			this.longitudeText.TextChanged += new System.EventHandler(this.value_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 190);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Equatorial:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "Ecliptic:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 226);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 15);
			this.label5.TabIndex = 7;
			this.label5.Text = "Galactic:";
			// 
			// eclipticLabel
			// 
			this.eclipticLabel.AutoSize = true;
			this.eclipticLabel.Location = new System.Drawing.Point(104, 158);
			this.eclipticLabel.Name = "eclipticLabel";
			this.eclipticLabel.Size = new System.Drawing.Size(38, 15);
			this.eclipticLabel.TabIndex = 8;
			this.eclipticLabel.Text = "label6";
			// 
			// equatorialLabel
			// 
			this.equatorialLabel.AutoSize = true;
			this.equatorialLabel.Location = new System.Drawing.Point(104, 190);
			this.equatorialLabel.Name = "equatorialLabel";
			this.equatorialLabel.Size = new System.Drawing.Size(38, 15);
			this.equatorialLabel.TabIndex = 9;
			this.equatorialLabel.Text = "label7";
			// 
			// galacticLabel
			// 
			this.galacticLabel.AutoSize = true;
			this.galacticLabel.Location = new System.Drawing.Point(104, 225);
			this.galacticLabel.Name = "galacticLabel";
			this.galacticLabel.Size = new System.Drawing.Size(38, 15);
			this.galacticLabel.TabIndex = 10;
			this.galacticLabel.Text = "label8";
			// 
			// coordList
			// 
			this.coordList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.coordList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.coordList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coordList.FormattingEnabled = true;
			this.coordList.Items.AddRange(new object[] {
            "Ecliptic",
            "Equatorial",
            "Galactic"});
			this.coordList.Location = new System.Drawing.Point(148, 97);
			this.coordList.MaxDropDownItems = 3;
			this.coordList.Name = "coordList";
			this.coordList.Size = new System.Drawing.Size(304, 33);
			this.coordList.TabIndex = 12;
			this.coordList.SelectedIndexChanged += new System.EventHandler(this.coordList_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(14, 98);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 32);
			this.label6.TabIndex = 13;
			this.label6.Text = "From:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 257);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.coordList);
			this.Controls.Add(this.galacticLabel);
			this.Controls.Add(this.equatorialLabel);
			this.Controls.Add(this.eclipticLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.longitudeText);
			this.Controls.Add(this.latitudeText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label eclipticLabel;
        private System.Windows.Forms.Label equatorialLabel;
		private System.Windows.Forms.Label galacticLabel;
		private System.Windows.Forms.ComboBox coordList;
		private System.Windows.Forms.Label label6;
    }
}

