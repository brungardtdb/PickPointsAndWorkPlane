namespace PickPointsAndWorkPlane
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
            this.btnPickPoints = new System.Windows.Forms.Button();
            this.btnPickPart = new System.Windows.Forms.Button();
            this.btnGlobal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPickPoints
            // 
            this.btnPickPoints.Location = new System.Drawing.Point(12, 12);
            this.btnPickPoints.Name = "btnPickPoints";
            this.btnPickPoints.Size = new System.Drawing.Size(75, 23);
            this.btnPickPoints.TabIndex = 0;
            this.btnPickPoints.Text = "Pick Points";
            this.btnPickPoints.UseVisualStyleBackColor = true;
            this.btnPickPoints.Click += new System.EventHandler(this.btnPickPoints_Click);
            // 
            // btnPickPart
            // 
            this.btnPickPart.Location = new System.Drawing.Point(12, 41);
            this.btnPickPart.Name = "btnPickPart";
            this.btnPickPart.Size = new System.Drawing.Size(75, 23);
            this.btnPickPart.TabIndex = 1;
            this.btnPickPart.Text = "Pick Part";
            this.btnPickPart.UseVisualStyleBackColor = true;
            this.btnPickPart.Click += new System.EventHandler(this.btnPickPart_Click);
            // 
            // btnGlobal
            // 
            this.btnGlobal.Location = new System.Drawing.Point(12, 70);
            this.btnGlobal.Name = "btnGlobal";
            this.btnGlobal.Size = new System.Drawing.Size(75, 23);
            this.btnGlobal.TabIndex = 2;
            this.btnGlobal.Text = "Global";
            this.btnGlobal.UseVisualStyleBackColor = true;
            this.btnGlobal.Click += new System.EventHandler(this.btnGlobal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 104);
            this.Controls.Add(this.btnGlobal);
            this.Controls.Add(this.btnPickPart);
            this.Controls.Add(this.btnPickPoints);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPickPoints;
        private System.Windows.Forms.Button btnPickPart;
        private System.Windows.Forms.Button btnGlobal;
    }
}

