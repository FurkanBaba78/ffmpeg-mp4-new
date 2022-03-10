namespace ffmpeg_mp4
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
            this.resolutionBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codeclabel = new System.Windows.Forms.Label();
            this.codecBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qualityBox = new System.Windows.Forms.ComboBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resolutionBox
            // 
            this.resolutionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.resolutionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolutionBox.ForeColor = System.Drawing.Color.White;
            this.resolutionBox.FormattingEnabled = true;
            this.resolutionBox.Location = new System.Drawing.Point(106, 11);
            this.resolutionBox.Name = "resolutionBox";
            this.resolutionBox.Size = new System.Drawing.Size(121, 21);
            this.resolutionBox.TabIndex = 0;
            this.resolutionBox.SelectedIndexChanged += new System.EventHandler(this.resolutionBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resolutions:";
            // 
            // codeclabel
            // 
            this.codeclabel.AutoSize = true;
            this.codeclabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeclabel.ForeColor = System.Drawing.Color.White;
            this.codeclabel.Location = new System.Drawing.Point(33, 47);
            this.codeclabel.Name = "codeclabel";
            this.codeclabel.Size = new System.Drawing.Size(67, 18);
            this.codeclabel.TabIndex = 3;
            this.codeclabel.Text = "Codecs:";
            // 
            // codecBox
            // 
            this.codecBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.codecBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codecBox.ForeColor = System.Drawing.Color.White;
            this.codecBox.FormattingEnabled = true;
            this.codecBox.Location = new System.Drawing.Point(106, 44);
            this.codecBox.Name = "codecBox";
            this.codecBox.Size = new System.Drawing.Size(121, 21);
            this.codecBox.TabIndex = 2;
            this.codecBox.SelectedIndexChanged += new System.EventHandler(this.codecBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quality:";
            // 
            // qualityBox
            // 
            this.qualityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.qualityBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qualityBox.ForeColor = System.Drawing.Color.White;
            this.qualityBox.FormattingEnabled = true;
            this.qualityBox.Location = new System.Drawing.Point(106, 77);
            this.qualityBox.Name = "qualityBox";
            this.qualityBox.Size = new System.Drawing.Size(121, 21);
            this.qualityBox.TabIndex = 4;
            this.qualityBox.SelectedIndexChanged += new System.EventHandler(this.qualityBox_SelectedIndexChanged);
            // 
            // selectButton
            // 
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectButton.ForeColor = System.Drawing.Color.White;
            this.selectButton.Location = new System.Drawing.Point(253, 11);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(152, 32);
            this.selectButton.TabIndex = 8;
            this.selectButton.Text = "Select a Video";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(325, 69);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(80, 29);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(417, 110);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qualityBox);
            this.Controls.Add(this.codeclabel);
            this.Controls.Add(this.codecBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resolutionBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox resolutionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label codeclabel;
        private System.Windows.Forms.ComboBox codecBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox qualityBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button startButton;
    }
}

