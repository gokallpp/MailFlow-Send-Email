namespace Send_Email
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            TxtTo = new TextBox();
            txtSub = new TextBox();
            TxtBody = new RichTextBox();
            pictureBox1 = new PictureBox();
            BtnOpenFile = new LinkLabel();
            TxtFileName = new Label();
            openFileDialog = new OpenFileDialog();
            BtnSend = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(120, 43);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(135, 37);
            label1.TabIndex = 0;
            label1.Text = "MailFlow";
            // 
            // TxtTo
            // 
            TxtTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTo.ForeColor = Color.FromArgb(60, 161, 125);
            TxtTo.Location = new Point(29, 155);
            TxtTo.Margin = new Padding(0);
            TxtTo.Name = "TxtTo";
            TxtTo.Size = new Size(366, 34);
            TxtTo.TabIndex = 1;
            TxtTo.Tag = "";
            TxtTo.Text = "E-Posta";
            // 
            // txtSub
            // 
            txtSub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSub.ForeColor = Color.FromArgb(60, 161, 125);
            txtSub.Location = new Point(29, 209);
            txtSub.Margin = new Padding(0);
            txtSub.Name = "txtSub";
            txtSub.Size = new Size(366, 34);
            txtSub.TabIndex = 2;
            txtSub.Tag = "";
            txtSub.Text = "Konu";
            // 
            // TxtBody
            // 
            TxtBody.Location = new Point(29, 272);
            TxtBody.Name = "TxtBody";
            TxtBody.Size = new Size(515, 182);
            TxtBody.TabIndex = 4;
            TxtBody.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 25);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // BtnOpenFile
            // 
            BtnOpenFile.AutoSize = true;
            BtnOpenFile.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOpenFile.LinkColor = Color.FromArgb(60, 161, 125);
            BtnOpenFile.Location = new Point(647, 164);
            BtnOpenFile.Name = "BtnOpenFile";
            BtnOpenFile.Size = new Size(120, 25);
            BtnOpenFile.TabIndex = 7;
            BtnOpenFile.TabStop = true;
            BtnOpenFile.Text = "Dosya Yükle";
            BtnOpenFile.LinkClicked += BtnOpenFile_LinkClicked;
            // 
            // TxtFileName
            // 
            TxtFileName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TxtFileName.ForeColor = Color.White;
            TxtFileName.Location = new Point(561, 217);
            TxtFileName.Margin = new Padding(0);
            TxtFileName.Name = "TxtFileName";
            TxtFileName.Size = new Size(230, 60);
            TxtFileName.TabIndex = 8;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // BtnSend
            // 
            BtnSend.ForeColor = Color.DarkSlateGray;
            BtnSend.Image = (Image)resources.GetObject("BtnSend.Image");
            BtnSend.Location = new Point(605, 400);
            BtnSend.Margin = new Padding(0);
            BtnSend.Name = "BtnSend";
            BtnSend.Size = new Size(95, 54);
            BtnSend.TabIndex = 9;
            BtnSend.Text = "Gönder";
            BtnSend.UseVisualStyleBackColor = true;
            BtnSend.Click += BtnSend_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(398, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(51, 67, 94);
            ClientSize = new Size(800, 500);
            Controls.Add(pictureBox2);
            Controls.Add(BtnSend);
            Controls.Add(TxtFileName);
            Controls.Add(BtnOpenFile);
            Controls.Add(pictureBox1);
            Controls.Add(TxtBody);
            Controls.Add(txtSub);
            Controls.Add(TxtTo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtTo;
        private TextBox txtSub;
        private RichTextBox TxtBody;
        private PictureBox pictureBox1;
        private LinkLabel BtnOpenFile;
        private Label TxtFileName;
        private OpenFileDialog openFileDialog;
        private Button BtnSend;
        private PictureBox pictureBox2;
    }
}
