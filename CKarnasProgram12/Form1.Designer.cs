namespace CKarnasProgram12
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudInitialVelocity = new System.Windows.Forms.NumericUpDown();
            this.nudInitialHeight = new System.Windows.Forms.NumericUpDown();
            this.lblInitialVelocity = new System.Windows.Forms.Label();
            this.lblInitialHeight = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLandingTime = new System.Windows.Forms.Label();
            this.lblMaxHeight = new System.Windows.Forms.Label();
            this.btnLandingTime = new System.Windows.Forms.Button();
            this.btnMaxHeight = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialHeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudInitialVelocity);
            this.groupBox1.Controls.Add(this.nudInitialHeight);
            this.groupBox1.Controls.Add(this.lblInitialVelocity);
            this.groupBox1.Controls.Add(this.lblInitialHeight);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projectile Data";
            // 
            // nudInitialVelocity
            // 
            this.nudInitialVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInitialVelocity.Location = new System.Drawing.Point(304, 74);
            this.nudInitialVelocity.Maximum = new decimal(new int[] {
            14439,
            0,
            0,
            0});
            this.nudInitialVelocity.Name = "nudInitialVelocity";
            this.nudInitialVelocity.Size = new System.Drawing.Size(152, 29);
            this.nudInitialVelocity.TabIndex = 9;
            this.nudInitialVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudInitialHeight
            // 
            this.nudInitialHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInitialHeight.Location = new System.Drawing.Point(304, 28);
            this.nudInitialHeight.Maximum = new decimal(new int[] {
            14439,
            0,
            0,
            0});
            this.nudInitialHeight.Name = "nudInitialHeight";
            this.nudInitialHeight.Size = new System.Drawing.Size(152, 29);
            this.nudInitialHeight.TabIndex = 8;
            this.nudInitialHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInitialVelocity
            // 
            this.lblInitialVelocity.AutoSize = true;
            this.lblInitialVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialVelocity.Location = new System.Drawing.Point(56, 76);
            this.lblInitialVelocity.Name = "lblInitialVelocity";
            this.lblInitialVelocity.Size = new System.Drawing.Size(209, 24);
            this.lblInitialVelocity.TabIndex = 7;
            this.lblInitialVelocity.Text = "Initial Velocity (feet/sec):";
            // 
            // lblInitialHeight
            // 
            this.lblInitialHeight.AutoSize = true;
            this.lblInitialHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialHeight.Location = new System.Drawing.Point(102, 30);
            this.lblInitialHeight.Name = "lblInitialHeight";
            this.lblInitialHeight.Size = new System.Drawing.Size(163, 24);
            this.lblInitialHeight.TabIndex = 6;
            this.lblInitialHeight.Text = "Initial Height (feet):";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(165, 124);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(234, 38);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Create Pojectile";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLandingTime);
            this.groupBox2.Controls.Add(this.lblMaxHeight);
            this.groupBox2.Controls.Add(this.btnLandingTime);
            this.groupBox2.Controls.Add(this.btnMaxHeight);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Projectile Motion Info";
            // 
            // lblLandingTime
            // 
            this.lblLandingTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLandingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandingTime.Location = new System.Drawing.Point(244, 122);
            this.lblLandingTime.Name = "lblLandingTime";
            this.lblLandingTime.Size = new System.Drawing.Size(278, 71);
            this.lblLandingTime.TabIndex = 9;
            this.lblLandingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxHeight
            // 
            this.lblMaxHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxHeight.Location = new System.Drawing.Point(244, 32);
            this.lblMaxHeight.Name = "lblMaxHeight";
            this.lblMaxHeight.Size = new System.Drawing.Size(278, 77);
            this.lblMaxHeight.TabIndex = 8;
            this.lblMaxHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLandingTime
            // 
            this.btnLandingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLandingTime.Location = new System.Drawing.Point(37, 135);
            this.btnLandingTime.Name = "btnLandingTime";
            this.btnLandingTime.Size = new System.Drawing.Size(192, 38);
            this.btnLandingTime.TabIndex = 2;
            this.btnLandingTime.Text = "&Landing Time";
            this.btnLandingTime.UseVisualStyleBackColor = true;
            this.btnLandingTime.Click += new System.EventHandler(this.btnLandingTime_Click);
            // 
            // btnMaxHeight
            // 
            this.btnMaxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxHeight.Location = new System.Drawing.Point(37, 52);
            this.btnMaxHeight.Name = "btnMaxHeight";
            this.btnMaxHeight.Size = new System.Drawing.Size(192, 38);
            this.btnMaxHeight.TabIndex = 1;
            this.btnMaxHeight.Text = "&Max Height";
            this.btnMaxHeight.UseVisualStyleBackColor = true;
            this.btnMaxHeight.Click += new System.EventHandler(this.btnMaxHeight_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(160, 485);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 38);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(303, 485);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Projectile Calculations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program 12 - Projectile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialHeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudInitialVelocity;
        private System.Windows.Forms.NumericUpDown nudInitialHeight;
        private System.Windows.Forms.Label lblInitialVelocity;
        private System.Windows.Forms.Label lblInitialHeight;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLandingTime;
        private System.Windows.Forms.Label lblMaxHeight;
        private System.Windows.Forms.Button btnLandingTime;
        private System.Windows.Forms.Button btnMaxHeight;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

