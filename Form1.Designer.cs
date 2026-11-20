namespace GeometricCalculator
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
            this.grpShape = new System.Windows.Forms.GroupBox();
            this.rbPyramid = new System.Windows.Forms.RadioButton();
            this.rbCone = new System.Windows.Forms.RadioButton();
            this.rbCylinder = new System.Windows.Forms.RadioButton();
            this.rbSphere = new System.Windows.Forms.RadioButton();
            this.txtPrimary = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblPrimary = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblPrimaryError = new System.Windows.Forms.Label();
            this.lblHeightError = new System.Windows.Forms.Label();
            this.chkRound = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblStats = new System.Windows.Forms.Label();
            this.grpShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpShape
            // 
            this.grpShape.Controls.Add(this.rbPyramid);
            this.grpShape.Controls.Add(this.rbCone);
            this.grpShape.Controls.Add(this.rbCylinder);
            this.grpShape.Controls.Add(this.rbSphere);
            this.grpShape.Location = new System.Drawing.Point(30, 33);
            this.grpShape.Name = "grpShape";
            this.grpShape.Size = new System.Drawing.Size(756, 141);
            this.grpShape.TabIndex = 0;
            this.grpShape.TabStop = false;
            this.grpShape.Text = "Select a 3D Geometric Body";
            // 
            // rbPyramid
            // 
            this.rbPyramid.AutoSize = true;
            this.rbPyramid.Location = new System.Drawing.Point(241, 83);
            this.rbPyramid.Name = "rbPyramid";
            this.rbPyramid.Size = new System.Drawing.Size(173, 20);
            this.rbPyramid.TabIndex = 3;
            this.rbPyramid.Text = "Regular Square Pyramid";
            this.rbPyramid.UseVisualStyleBackColor = true;
            this.rbPyramid.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbCone
            // 
            this.rbCone.AutoSize = true;
            this.rbCone.Location = new System.Drawing.Point(241, 41);
            this.rbCone.Name = "rbCone";
            this.rbCone.Size = new System.Drawing.Size(138, 20);
            this.rbCone.TabIndex = 2;
            this.rbCone.Text = "Right Circular Cone";
            this.rbCone.UseVisualStyleBackColor = true;
            this.rbCone.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbCylinder
            // 
            this.rbCylinder.AutoSize = true;
            this.rbCylinder.Location = new System.Drawing.Point(21, 83);
            this.rbCylinder.Name = "rbCylinder";
            this.rbCylinder.Size = new System.Drawing.Size(156, 20);
            this.rbCylinder.TabIndex = 1;
            this.rbCylinder.Text = "Right Circular Cylinder";
            this.rbCylinder.UseVisualStyleBackColor = true;
            this.rbCylinder.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbSphere
            // 
            this.rbSphere.AutoSize = true;
            this.rbSphere.Checked = true;
            this.rbSphere.Location = new System.Drawing.Point(21, 41);
            this.rbSphere.Name = "rbSphere";
            this.rbSphere.Size = new System.Drawing.Size(69, 20);
            this.rbSphere.TabIndex = 0;
            this.rbSphere.TabStop = true;
            this.rbSphere.Text = "Sphere";
            this.rbSphere.UseVisualStyleBackColor = true;
            this.rbSphere.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // txtPrimary
            // 
            this.txtPrimary.Location = new System.Drawing.Point(213, 206);
            this.txtPrimary.Name = "txtPrimary";
            this.txtPrimary.Size = new System.Drawing.Size(156, 22);
            this.txtPrimary.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.AcceptsReturn = true;
            this.txtHeight.Enabled = false;
            this.txtHeight.Location = new System.Drawing.Point(213, 265);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(156, 22);
            this.txtHeight.TabIndex = 2;
            // 
            // lblPrimary
            // 
            this.lblPrimary.AutoSize = true;
            this.lblPrimary.Location = new System.Drawing.Point(48, 212);
            this.lblPrimary.Name = "lblPrimary";
            this.lblPrimary.Size = new System.Drawing.Size(71, 16);
            this.lblPrimary.TabIndex = 3;
            this.lblPrimary.Text = "Radius (r): ";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(48, 271);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(67, 16);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height (h):";
            // 
            // lblPrimaryError
            // 
            this.lblPrimaryError.AutoSize = true;
            this.lblPrimaryError.Location = new System.Drawing.Point(444, 206);
            this.lblPrimaryError.Name = "lblPrimaryError";
            this.lblPrimaryError.Size = new System.Drawing.Size(0, 16);
            this.lblPrimaryError.ForeColor = System.Drawing.Color.Red;
            this.lblPrimaryError.TabIndex = 5;
            // 
            // lblHeightError
            // 
            this.lblHeightError.AutoSize = true;
            this.lblHeightError.Location = new System.Drawing.Point(444, 271);
            this.lblHeightError.Name = "lblHeightError";
            this.lblHeightError.Size = new System.Drawing.Size(0, 16);
            this.lblHeightError.ForeColor = System.Drawing.Color.Red;
            this.lblHeightError.TabIndex = 6;
            // 
            // chkRound
            // 
            this.chkRound.AutoSize = true;
            this.chkRound.Checked = true;
            this.chkRound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRound.Location = new System.Drawing.Point(51, 321);
            this.chkRound.Name = "chkRound";
            this.chkRound.Size = new System.Drawing.Size(213, 20);
            this.chkRound.TabIndex = 7;
            this.chkRound.Text = "Round results to decimal places"; 
            this.chkRound.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(30, 359);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(177, 52);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate area and volume and add body to list";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(244, 358);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(176, 53);
            this.btnStats.TabIndex = 9;
            this.btnStats.Text = "Statistics";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(672, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 52);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(460, 358);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 53);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(30, 433);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(819, 132);
            this.lstResults.TabIndex = 12;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(27, 592);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(0, 16);
            this.lblStats.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 815);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkRound);
            this.Controls.Add(this.lblHeightError);
            this.Controls.Add(this.lblPrimaryError);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblPrimary);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtPrimary);
            this.Controls.Add(this.grpShape);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeometricCalculator - Iana Sharova - f116160";
            this.grpShape.ResumeLayout(false);
            this.grpShape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpShape;
        private System.Windows.Forms.RadioButton rbPyramid;
        private System.Windows.Forms.RadioButton rbCone;
        private System.Windows.Forms.RadioButton rbCylinder;
        private System.Windows.Forms.RadioButton rbSphere;
        private System.Windows.Forms.TextBox txtPrimary;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblPrimary;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblPrimaryError;
        private System.Windows.Forms.Label lblHeightError;
        private System.Windows.Forms.CheckBox chkRound;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblStats;
    }
}

