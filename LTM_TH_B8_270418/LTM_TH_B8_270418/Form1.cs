using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace LTM_TH_B8_270418
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

        private void btn_Send_Click(object sender, EventArgs e)
        {
            SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
            mailclient.EnableSsl = true;
            mailclient.Credentials = new NetworkCredential(txt_Sender.Text, txt_Pass.Text);
            MailMessage message = new MailMessage(txt_Sender.Text, txt_To.Text);
            message.Subject = txt_Sub.Text;
            message.Body = txt_Body.Text;
            mailclient.Send(message);
            Console.WriteLine("Mail sent successfully!");
        }
    }
}
