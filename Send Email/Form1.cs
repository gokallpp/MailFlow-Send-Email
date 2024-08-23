using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;


namespace Send_Email
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOpenFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // OpenFileDialog ayarlar�n� yap�land�r�yoruz.
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true, // �oklu dosya se�imine izin veriyoruz.
                Filter = "All Files (*.*)|*.*", // Dosya t�r� filtresi ayarlanabilir.
                Title = "Dosya Se�"
            };

            // Kullan�c� dosya se�imini onaylad�ysa...
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Se�ilen t�m dosya isimlerini TxtFileName.Text i�inde g�r�nt�lemek i�in birle�tiriyoruz.
                TxtFileName.Text = string.Join(", ", openFileDialog.FileNames);
            }
        }




        private void BtnSend_Click(object sender, EventArgs e)
        {
            
                using (MailMessage mail = new("gokalppabdullah@gmail.com", TxtTo.Text, txtSub.Text, TxtBody.Text))
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    foreach (var fileName in openFileDialog.FileNames)
                        if (File.Exists(fileName))
                            mail.Attachments.Add(new Attachment(fileName));


                    smtp.Credentials = new NetworkCredential("gokalppabdullah@gmail.com", "waqvziypyrmckulr");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    
                    FRM_Alert alert = new();
                    alert.ShowDialog();
                    TxtTo.Text = txtSub.Text = TxtBody.Text = TxtFileName.Text = "";
                  



                }
            
        }
    } 
}
