using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace ColdEmailTracker
{
    public partial class Form1 : Form
    {
        String first_name = "";
        String last_name = "";
        String company = "";
        String position = "";
        String resumeFP = "";
        DateTime first_email;
        DateTime last_email;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Name_Text_Box_TextChanged(object sender, EventArgs e)
        {
            String name = Name_Text_Box.Text;
            Console.WriteLine(name);
            if (name.Contains(' '))
            {
                first_name = name.Split(' ')[0];
                last_name = name.Split(' ')[1];
                Console.WriteLine("First Name: ");
                Console.WriteLine(first_name);
                Console.WriteLine("Last Name: ");
                Console.WriteLine(last_name);
            } else
            {

            }

        }

        private void Company_Text_Box_TextChanged(object sender, EventArgs e)
        {
            company = Company_Text_Box.Text.ToLower();
            Console.WriteLine("Company Name :");
            Console.WriteLine(company);
        }

        private void EmailDatePicker_ValueChanged(object sender, EventArgs e)
        {
            first_email = EmailDatePicker.Value;
            Console.WriteLine("First email date: ");
            Console.WriteLine(first_email.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Position_Text_Box_TextChanged(object sender, EventArgs e)
        {
            position = Position_Text_Box.Text.ToLower();
            Console.WriteLine("Position :");
            Console.WriteLine(position);
        }

        private void FollowUpPicker_ValueChanged(object sender, EventArgs e)
        {
            last_email = FollowUpPicker.Value;
            Console.WriteLine("Last email date: ");
            Console.WriteLine(last_email.ToString());
        }

        private void Attach_Resume_Click(object sender, EventArgs e)
        {
            var resumeFileDialog = new OpenFileDialog();
            if (DialogResult.OK == resumeFileDialog.ShowDialog())
            {
                var file = resumeFileDialog.FileName;
                resumeFP = file.ToString();
                Console.WriteLine("Resume filepath is: ");
                Console.WriteLine(resumeFP);
                ResumeFileName.Text = Path.GetFileName(resumeFileDialog.FileName);

            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //MailMessage message = new MailMessage("testcoldemailersend@gmail.com", "testcoldemailerreciever@gmail.com", "Hi", "Hi There");
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Test Sender", "testcoldemailersend@gmail.com"));
            email.To.Add(new MailboxAddress("Test Reciever", "testcoldemailerreciever@gmail.com"));
            email.Subject = "Hai";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = "<b> Hello This is first email sent from C#! </b>"
            };
            using(var smtp = new SmtpClient()) {
               
                try
                {
                    smtp.Connect("smtp.gmail.com", 587, false);
                    smtp.Authenticate("testcoldemailersend@gmail.com", "ynqdtviedkvlidry");
                    smtp.Send(email);
                    smtp.Disconnect(true);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("FAILURE" + ex.Message);
                }
               
            }
            
        }
    }
}
