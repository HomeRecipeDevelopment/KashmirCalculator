namespace Kashmir
{
    partial class FrmCalc
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
            this.RadioSingle = new System.Windows.Forms.RadioButton();
            this.RadioDouble = new System.Windows.Forms.RadioButton();
            this.BtnResult = new System.Windows.Forms.Button();
            this.LblHeight = new System.Windows.Forms.Label();
            this.NumericHeight = new System.Windows.Forms.NumericUpDown();
            this.LblWidth = new System.Windows.Forms.Label();
            this.NumericWidth = new System.Windows.Forms.NumericUpDown();
            this.NumericResult = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericWidthCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWidthCount)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioSingle
            // 
            this.RadioSingle.AutoSize = true;
            this.RadioSingle.Checked = true;
            this.RadioSingle.Location = new System.Drawing.Point(371, 52);
            this.RadioSingle.Name = "RadioSingle";
            this.RadioSingle.Size = new System.Drawing.Size(85, 21);
            this.RadioSingle.TabIndex = 0;
            this.RadioSingle.TabStop = true;
            this.RadioSingle.Text = "عرض واحد";
            this.RadioSingle.UseVisualStyleBackColor = true;
            this.RadioSingle.CheckedChanged += new System.EventHandler(this.RadioSingle_CheckedChanged);
            // 
            // RadioDouble
            // 
            this.RadioDouble.AutoSize = true;
            this.RadioDouble.Location = new System.Drawing.Point(107, 52);
            this.RadioDouble.Name = "RadioDouble";
            this.RadioDouble.Size = new System.Drawing.Size(66, 21);
            this.RadioDouble.TabIndex = 1;
            this.RadioDouble.Text = "عرضين";
            this.RadioDouble.UseVisualStyleBackColor = true;
            this.RadioDouble.CheckedChanged += new System.EventHandler(this.RadioDouble_CheckedChanged);
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(201, 229);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(132, 53);
            this.BtnResult.TabIndex = 2;
            this.BtnResult.Text = "حساب";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(429, 133);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(44, 17);
            this.LblHeight.TabIndex = 3;
            this.LblHeight.Text = "الأرتفاع";
            // 
            // NumericHeight
            // 
            this.NumericHeight.DecimalPlaces = 2;
            this.NumericHeight.Location = new System.Drawing.Point(287, 131);
            this.NumericHeight.Name = "NumericHeight";
            this.NumericHeight.Size = new System.Drawing.Size(120, 22);
            this.NumericHeight.TabIndex = 4;
            // 
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Location = new System.Drawing.Point(216, 136);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(41, 17);
            this.LblWidth.TabIndex = 5;
            this.LblWidth.Text = "العرض";
            // 
            // NumericWidth
            // 
            this.NumericWidth.DecimalPlaces = 2;
            this.NumericWidth.Location = new System.Drawing.Point(74, 133);
            this.NumericWidth.Name = "NumericWidth";
            this.NumericWidth.Size = new System.Drawing.Size(120, 22);
            this.NumericWidth.TabIndex = 6;
            // 
            // NumericResult
            // 
            this.NumericResult.DecimalPlaces = 2;
            this.NumericResult.Enabled = false;
            this.NumericResult.Location = new System.Drawing.Point(160, 334);
            this.NumericResult.Name = "NumericResult";
            this.NumericResult.Size = new System.Drawing.Size(206, 22);
            this.NumericResult.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "عدد الأمتار";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "عدد العروض";
            // 
            // NumericWidthCount
            // 
            this.NumericWidthCount.Enabled = false;
            this.NumericWidthCount.Location = new System.Drawing.Point(160, 297);
            this.NumericWidthCount.Name = "NumericWidthCount";
            this.NumericWidthCount.Size = new System.Drawing.Size(206, 22);
            this.NumericWidthCount.TabIndex = 10;
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 395);
            this.Controls.Add(this.NumericWidthCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumericResult);
            this.Controls.Add(this.NumericWidth);
            this.Controls.Add(this.LblWidth);
            this.Controls.Add(this.NumericHeight);
            this.Controls.Add(this.LblHeight);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.RadioDouble);
            this.Controls.Add(this.RadioSingle);
            this.Name = "FrmCalc";
            this.Text = "Kashmir Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.NumericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWidthCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioSingle;
        private System.Windows.Forms.RadioButton RadioDouble;
        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.NumericUpDown NumericHeight;
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.NumericUpDown NumericWidth;
        private System.Windows.Forms.NumericUpDown NumericResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericWidthCount;
    }
}

