namespace Properties
{
    partial class mainForm
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
            this.targetButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.up = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.centerTarget = new System.Windows.Forms.Button();
            this.enabled = new System.Windows.Forms.Button();
            this.visibility = new System.Windows.Forms.Button();
            this.formSizeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetButton
            // 
            this.targetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetButton.Location = new System.Drawing.Point(0, 0);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(100, 100);
            this.targetButton.TabIndex = 0;
            this.targetButton.TabStop = false;
            this.targetButton.Text = "Target X = 0 Y = 0";
            this.targetButton.UseMnemonic = false;
            this.targetButton.UseVisualStyleBackColor = true;
            this.targetButton.Click += new System.EventHandler(this.targetButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.up);
            this.groupBox1.Controls.Add(this.left);
            this.groupBox1.Controls.Add(this.down);
            this.groupBox1.Controls.Add(this.right);
            this.groupBox1.Controls.Add(this.centerTarget);
            this.groupBox1.Controls.Add(this.enabled);
            this.groupBox1.Controls.Add(this.visibility);
            this.groupBox1.Location = new System.Drawing.Point(570, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(84, 385);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(50, 36);
            this.up.TabIndex = 4;
            this.up.Text = "^";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(28, 406);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(50, 36);
            this.left.TabIndex = 5;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(84, 427);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(50, 36);
            this.down.TabIndex = 7;
            this.down.Text = "∨";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(140, 406);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(50, 36);
            this.right.TabIndex = 6;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // centerTarget
            // 
            this.centerTarget.Location = new System.Drawing.Point(11, 200);
            this.centerTarget.Name = "centerTarget";
            this.centerTarget.Size = new System.Drawing.Size(179, 31);
            this.centerTarget.TabIndex = 3;
            this.centerTarget.Text = "Center Target";
            this.centerTarget.UseVisualStyleBackColor = true;
            this.centerTarget.Click += new System.EventHandler(this.centerTarget_Click);
            // 
            // enabled
            // 
            this.enabled.Location = new System.Drawing.Point(11, 159);
            this.enabled.Name = "enabled";
            this.enabled.Size = new System.Drawing.Size(179, 35);
            this.enabled.TabIndex = 2;
            this.enabled.Text = "Enable = True";
            this.enabled.UseVisualStyleBackColor = true;
            this.enabled.Click += new System.EventHandler(this.button2_Click);
            // 
            // visibility
            // 
            this.visibility.Location = new System.Drawing.Point(11, 120);
            this.visibility.Name = "visibility";
            this.visibility.Size = new System.Drawing.Size(179, 33);
            this.visibility.TabIndex = 1;
            this.visibility.Text = "Visibility = True";
            this.visibility.UseVisualStyleBackColor = true;
            this.visibility.Click += new System.EventHandler(this.visibility_Click);
            // 
            // formSizeLabel
            // 
            this.formSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.formSizeLabel.AutoSize = true;
            this.formSizeLabel.Location = new System.Drawing.Point(20, 530);
            this.formSizeLabel.Name = "formSizeLabel";
            this.formSizeLabel.Size = new System.Drawing.Size(135, 17);
            this.formSizeLabel.TabIndex = 2;
            this.formSizeLabel.Text = "Form Size: 800, 600";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Fixed3D",
            "FixedDialog",
            "FixedSingle",
            "FixedToolWindow",
            "Sizable",
            "SizableToolWindow"});
            this.comboBox1.Location = new System.Drawing.Point(11, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "FormBorderStyle";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.formSizeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.targetButton);
            this.Name = "mainForm";
            this.Text = "(0, 0) Winforms Components - Common Controls";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Move += new System.EventHandler(this.mainForm_Move);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label formSizeLabel;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button centerTarget;
        private System.Windows.Forms.Button enabled;
        private System.Windows.Forms.Button visibility;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

