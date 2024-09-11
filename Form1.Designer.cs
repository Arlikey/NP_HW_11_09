namespace NP_HW_11_09
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            recipientsListBox = new ListBox();
            subjectTextBox = new TextBox();
            messageTextBox = new TextBox();
            attachmentsListBox = new ListBox();
            recipientEmailTextBox = new TextBox();
            credentialSMTPTextBox = new TextBox();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            credentialPortNumeric = new NumericUpDown();
            addRecipientButton = new Button();
            removeRecipientButton = new Button();
            clearRecipientsButton = new Button();
            sendEmailButton = new Button();
            addAttachmentButton = new Button();
            removeAttachmentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)credentialPortNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Recipients:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 427);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 375);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 324);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 3;
            label4.Text = "Credential PORT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 272);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 4;
            label5.Text = "Credential SMTP:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(293, 334);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 5;
            label6.Text = "Attachments:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(293, 86);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 6;
            label7.Text = "Message:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(293, 23);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 7;
            label8.Text = "Subject:";
            // 
            // recipientsListBox
            // 
            recipientsListBox.FormattingEnabled = true;
            recipientsListBox.ItemHeight = 15;
            recipientsListBox.Location = new Point(21, 44);
            recipientsListBox.Name = "recipientsListBox";
            recipientsListBox.Size = new Size(228, 154);
            recipientsListBox.TabIndex = 8;
            // 
            // subjectTextBox
            // 
            subjectTextBox.Location = new Point(293, 44);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(516, 23);
            subjectTextBox.TabIndex = 9;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(293, 115);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(516, 201);
            messageTextBox.TabIndex = 10;
            // 
            // attachmentsListBox
            // 
            attachmentsListBox.FormattingEnabled = true;
            attachmentsListBox.ItemHeight = 15;
            attachmentsListBox.Location = new Point(293, 359);
            attachmentsListBox.Name = "attachmentsListBox";
            attachmentsListBox.Size = new Size(516, 109);
            attachmentsListBox.TabIndex = 11;
            // 
            // recipientEmailTextBox
            // 
            recipientEmailTextBox.Location = new Point(21, 208);
            recipientEmailTextBox.Name = "recipientEmailTextBox";
            recipientEmailTextBox.Size = new Size(228, 23);
            recipientEmailTextBox.TabIndex = 12;
            // 
            // credentialSMTPTextBox
            // 
            credentialSMTPTextBox.Location = new Point(21, 293);
            credentialSMTPTextBox.Name = "credentialSMTPTextBox";
            credentialSMTPTextBox.Size = new Size(228, 23);
            credentialSMTPTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(21, 395);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(228, 23);
            emailTextBox.TabIndex = 14;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(21, 445);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(228, 23);
            passwordTextBox.TabIndex = 15;
            // 
            // credentialPortNumeric
            // 
            credentialPortNumeric.Location = new Point(21, 344);
            credentialPortNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            credentialPortNumeric.Name = "credentialPortNumeric";
            credentialPortNumeric.Size = new Size(114, 23);
            credentialPortNumeric.TabIndex = 16;
            // 
            // addRecipientButton
            // 
            addRecipientButton.Location = new Point(21, 237);
            addRecipientButton.Name = "addRecipientButton";
            addRecipientButton.Size = new Size(66, 23);
            addRecipientButton.TabIndex = 17;
            addRecipientButton.Text = "Add";
            addRecipientButton.UseVisualStyleBackColor = true;
            addRecipientButton.Click += addRecipientButton_Click;
            // 
            // removeRecipientButton
            // 
            removeRecipientButton.Location = new Point(93, 237);
            removeRecipientButton.Name = "removeRecipientButton";
            removeRecipientButton.Size = new Size(87, 23);
            removeRecipientButton.TabIndex = 18;
            removeRecipientButton.Text = "Remove";
            removeRecipientButton.UseVisualStyleBackColor = true;
            removeRecipientButton.Click += removeRecipientButton_Click;
            // 
            // clearRecipientsButton
            // 
            clearRecipientsButton.Location = new Point(186, 237);
            clearRecipientsButton.Name = "clearRecipientsButton";
            clearRecipientsButton.Size = new Size(63, 23);
            clearRecipientsButton.TabIndex = 19;
            clearRecipientsButton.Text = "Clear";
            clearRecipientsButton.UseVisualStyleBackColor = true;
            clearRecipientsButton.Click += clearRecipientsButton_Click;
            // 
            // sendEmailButton
            // 
            sendEmailButton.Location = new Point(21, 485);
            sendEmailButton.Name = "sendEmailButton";
            sendEmailButton.Size = new Size(228, 23);
            sendEmailButton.TabIndex = 20;
            sendEmailButton.Text = "Send";
            sendEmailButton.UseVisualStyleBackColor = true;
            sendEmailButton.Click += sendEmailButton_Click;
            // 
            // addAttachmentButton
            // 
            addAttachmentButton.Location = new Point(293, 485);
            addAttachmentButton.Name = "addAttachmentButton";
            addAttachmentButton.Size = new Size(228, 23);
            addAttachmentButton.TabIndex = 21;
            addAttachmentButton.Text = "Add";
            addAttachmentButton.UseVisualStyleBackColor = true;
            addAttachmentButton.Click += addAttachmentButton_Click;
            // 
            // removeAttachmentButton
            // 
            removeAttachmentButton.Location = new Point(581, 485);
            removeAttachmentButton.Name = "removeAttachmentButton";
            removeAttachmentButton.Size = new Size(228, 23);
            removeAttachmentButton.TabIndex = 22;
            removeAttachmentButton.Text = "Remove";
            removeAttachmentButton.UseVisualStyleBackColor = true;
            removeAttachmentButton.Click += removeAttachmentButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 520);
            Controls.Add(removeAttachmentButton);
            Controls.Add(addAttachmentButton);
            Controls.Add(sendEmailButton);
            Controls.Add(clearRecipientsButton);
            Controls.Add(removeRecipientButton);
            Controls.Add(addRecipientButton);
            Controls.Add(credentialPortNumeric);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(credentialSMTPTextBox);
            Controls.Add(recipientEmailTextBox);
            Controls.Add(attachmentsListBox);
            Controls.Add(messageTextBox);
            Controls.Add(subjectTextBox);
            Controls.Add(recipientsListBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)credentialPortNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox recipientsListBox;
        private TextBox subjectTextBox;
        private TextBox messageTextBox;
        private ListBox attachmentsListBox;
        private TextBox recipientEmailTextBox;
        private TextBox credentialSMTPTextBox;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private NumericUpDown credentialPortNumeric;
        private Button addRecipientButton;
        private Button removeRecipientButton;
        private Button clearRecipientsButton;
        private Button sendEmailButton;
        private Button addAttachmentButton;
        private Button removeAttachmentButton;
    }
}
