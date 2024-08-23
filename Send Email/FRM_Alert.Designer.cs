namespace Send_Email
{
    partial class FRM_Alert
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Alert));
            timer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 3000;
            timer.Tick += timer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 18);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(79, 55);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(226, 23);
            label2.TabIndex = 7;
            label2.Text = "E-Posta Başarıyla Gönderildi.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(79, 32);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(163, 23);
            label1.TabIndex = 8;
            label1.Text = "E-Posta Gönderildi.";
            // 
            // FRM_Alert
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightGreen;
            ClientSize = new Size(400, 100);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            ForeColor = Color.SeaGreen;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Alert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_Alert";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}