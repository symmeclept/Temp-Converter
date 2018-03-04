namespace Temp_Converter
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
			this.button1 = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblTempOut = new System.Windows.Forms.Label();
			this.txtTempIn = new System.Windows.Forms.TextBox();
			this.cmbTypeIn = new System.Windows.Forms.ComboBox();
			this.cmbTypeOut = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(106, 205);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "Convert!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(12, 227);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(28, 27);
			this.btnReset.TabIndex = 0;
			this.btnReset.Text = "X";
			this.btnReset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnReset.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 39);
			this.label1.TabIndex = 1;
			this.label1.Text = "Enter the temp to be converted,\r\nthen select the method of\r\nconversion.";
			// 
			// lblTempOut
			// 
			this.lblTempOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTempOut.Location = new System.Drawing.Point(83, 154);
			this.lblTempOut.Name = "lblTempOut";
			this.lblTempOut.Size = new System.Drawing.Size(113, 21);
			this.lblTempOut.TabIndex = 1;
			this.lblTempOut.Text = "...";
			this.lblTempOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtTempIn
			// 
			this.txtTempIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTempIn.Location = new System.Drawing.Point(185, 15);
			this.txtTempIn.Name = "txtTempIn";
			this.txtTempIn.Size = new System.Drawing.Size(91, 20);
			this.txtTempIn.TabIndex = 2;
			this.txtTempIn.Text = "Enter temp";
			// 
			// cmbTypeIn
			// 
			this.cmbTypeIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTypeIn.FormattingEnabled = true;
			this.cmbTypeIn.Items.AddRange(new object[] {
            "Celsius(C)",
            "Farenheit(F)",
            "Kelvin(K)"});
			this.cmbTypeIn.Location = new System.Drawing.Point(12, 99);
			this.cmbTypeIn.Name = "cmbTypeIn";
			this.cmbTypeIn.Size = new System.Drawing.Size(121, 21);
			this.cmbTypeIn.TabIndex = 3;
			// 
			// cmbTypeOut
			// 
			this.cmbTypeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTypeOut.Items.AddRange(new object[] {
            "Celsius(C)",
            "Farenheit(F)",
            "Kelvin(K)"});
			this.cmbTypeOut.Location = new System.Drawing.Point(155, 99);
			this.cmbTypeOut.Name = "cmbTypeOut";
			this.cmbTypeOut.Size = new System.Drawing.Size(121, 21);
			this.cmbTypeOut.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Convert from...";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(152, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Convert to...";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 211);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Reset";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(288, 266);
			this.Controls.Add(this.cmbTypeOut);
			this.Controls.Add(this.cmbTypeIn);
			this.Controls.Add(this.txtTempIn);
			this.Controls.Add(this.lblTempOut);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTempOut;
		private System.Windows.Forms.TextBox txtTempIn;
		private System.Windows.Forms.ComboBox cmbTypeIn;
		private System.Windows.Forms.ComboBox cmbTypeOut;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

