namespace SimpleChart
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.scaleBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelScaleValue = new System.Windows.Forms.Label();
            this.buttonResetScale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 259);
            this.panel1.TabIndex = 0;
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUp.Location = new System.Drawing.Point(61, 277);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(43, 23);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.TabStop = false;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDown.Location = new System.Drawing.Point(61, 306);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(43, 23);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.TabStop = false;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLeft.Location = new System.Drawing.Point(12, 293);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(43, 23);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.TabStop = false;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRight.Location = new System.Drawing.Point(110, 293);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(43, 23);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.TabStop = false;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // scaleBar
            // 
            this.scaleBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleBar.AutoSize = false;
            this.scaleBar.LargeChange = 1;
            this.scaleBar.Location = new System.Drawing.Point(172, 284);
            this.scaleBar.Maximum = 8;
            this.scaleBar.Minimum = 1;
            this.scaleBar.Name = "scaleBar";
            this.scaleBar.Size = new System.Drawing.Size(300, 31);
            this.scaleBar.TabIndex = 3;
            this.scaleBar.TabStop = false;
            this.scaleBar.Value = 4;
            this.scaleBar.Scroll += new System.EventHandler(this.scaleBar_Scroll);
            this.scaleBar.ValueChanged += new System.EventHandler(this.scaleBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Масштаб";
            // 
            // labelScaleValue
            // 
            this.labelScaleValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScaleValue.AutoSize = true;
            this.labelScaleValue.Location = new System.Drawing.Point(228, 319);
            this.labelScaleValue.Name = "labelScaleValue";
            this.labelScaleValue.Size = new System.Drawing.Size(33, 13);
            this.labelScaleValue.TabIndex = 4;
            this.labelScaleValue.Text = "100%";
            // 
            // buttonResetScale
            // 
            this.buttonResetScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetScale.Location = new System.Drawing.Point(380, 317);
            this.buttonResetScale.Name = "buttonResetScale";
            this.buttonResetScale.Size = new System.Drawing.Size(92, 20);
            this.buttonResetScale.TabIndex = 5;
            this.buttonResetScale.TabStop = false;
            this.buttonResetScale.Text = "Reset";
            this.buttonResetScale.UseVisualStyleBackColor = true;
            this.buttonResetScale.Click += new System.EventHandler(this.buttonResetScale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.buttonResetScale);
            this.Controls.Add(this.labelScaleValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scaleBar);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(500, 380);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.TrackBar scaleBar;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScaleValue;
        private System.Windows.Forms.Button buttonResetScale;
    }
}

