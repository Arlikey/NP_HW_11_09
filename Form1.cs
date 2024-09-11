using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace NP_HW_11_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void sendEmailButton_Click(object sender, EventArgs e)
        {
            if (recipientsListBox.Items.Count > 0)
            {
                Credentials.Message message = new Credentials.Message()
                {
                    Subject = subjectTextBox.Text,
                    Body = messageTextBox.Text,
                    Credentials = new Credentials()
                    {
                        Port = (int)credentialPortNumeric.Value,
                        SMTP = credentialSMTPTextBox.Text,
                        Email = emailTextBox.Text,
                        Password = passwordTextBox.Text
                    }
                };
                foreach (var attachment in attachmentsListBox.Items)
                {
                    message.Attachments.Add(new Attachment(attachment.ToString()));
                }
                foreach (var recipient in recipientsListBox.Items)
                {
                    message.Recipients.Add(recipient.ToString());
                }

                var results = new List<ValidationResult>();
                var context = new ValidationContext(message);
                if (!Validator.TryValidateObject(message, context, results, true))
                {
                    var st = new StringBuilder();
                    foreach (var errors in results)
                    {
                        st.AppendLine(errors.ToString() + Environment.NewLine);
                    }
                    MessageBox.Show(st.ToString());
                    return;
                }

                context = new ValidationContext(message.Credentials);
                if (!Validator.TryValidateObject(message.Credentials, context, results, true))
                {
                    var st = new StringBuilder();
                    foreach (var errors in results)
                    {
                        st.AppendLine(errors.ToString() + Environment.NewLine);
                    }
                    MessageBox.Show(st.ToString());
                    return;
                }

                await SendMessage(message);
            }
            else
            {
                MessageBox.Show("Add recipients!");
            }
        }

        private async Task SendMessage(Credentials.Message message)
        {
            MailAddress from = new MailAddress(message.Credentials.Email, message.Credentials.Email);
            MailMessage msg = new MailMessage();
            msg.From = from;
            foreach (var recipient in message.Recipients)
            {
                msg.To.Add(recipient);
            }

            msg.Subject = message.Subject;
            msg.Body = message.Body;
            msg.IsBodyHtml = message.isBodyHtml;

            foreach (var attachment in message.Attachments)
            {
                msg.Attachments.Add(attachment);
            }

            SmtpClient smtp = new SmtpClient(message.Credentials.SMTP, message.Credentials.Port);
            smtp.Credentials = new NetworkCredential(message.Credentials.Email, message.Credentials.Password);
            smtp.EnableSsl = true;

            try
            {
                sendEmailButton.Enabled = false;
                sendEmailButton.Text = "Sending...";

                await smtp.SendMailAsync(msg);
                MessageBox.Show("The message was successfully sent.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sendEmailButton.Enabled = true;
            sendEmailButton.Text = "Send";
        }

        private void addRecipientButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(recipientEmailTextBox.Text))
            {
                recipientsListBox.Items.Add(recipientEmailTextBox.Text);
                recipientEmailTextBox.Clear();
            }
        }

        private void removeRecipientButton_Click(object sender, EventArgs e)
        {
            if (recipientsListBox.SelectedIndex != -1)
            {
                recipientsListBox.Items.Remove(recipientsListBox.SelectedIndex);
            }
        }

        private void clearRecipientsButton_Click(object sender, EventArgs e)
        {
            recipientsListBox.Items.Clear();
        }

        private void addAttachmentButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = fileDialog.FileName;
                    attachmentsListBox.Items.Add(fileName);
                }
            }
        }

        private void removeAttachmentButton_Click(object sender, EventArgs e)
        {
            if (attachmentsListBox.SelectedIndex != -1)
            {
                attachmentsListBox.Items.Remove(attachmentsListBox.SelectedIndex);
            }
        }
    }
    public class Credentials
    {
        [Required]
        public string SMTP { get; set; } = "smtp.gmail.com";

        [Required]
        [Range(1, 10_000)]
        public int Port { get; set; } = 587;

        [Required]
        [RegularExpression("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$")]
        public string Email { get; set; }

        [Required]

        public string Password { get; set; }
        public class Message
        {
            public Credentials Credentials { get; set; }

            [Required]
            [MinLength(5)]
            public string Subject { get; set; }

            [Required]
            [StringLength(1000, MinimumLength = 5)]

            public string Body { get; set; }
            public bool isBodyHtml { get; set; }
            public List<string> Recipients { get; set; }
            public List<Attachment> Attachments { get; set; }

            public Message()
            {
                Recipients = new List<string>();
                Attachments = new List<Attachment>();
            }

        }
    }
}