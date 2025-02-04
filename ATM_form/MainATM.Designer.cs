namespace ATM_form
{
    partial class MainATM
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
            this.buttonShowMoney = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSendMoney = new System.Windows.Forms.Button();
            this.buttonGiveMoney = new System.Windows.Forms.Button();
            this.buttonTakeMoney = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxCard = new System.Windows.Forms.TextBox();
            this.labelCard = new System.Windows.Forms.Label();
            this.labelSendPerson = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowMoney
            // 
            this.buttonShowMoney.BackColor = System.Drawing.Color.SlateGray;
            this.buttonShowMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShowMoney.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowMoney.Location = new System.Drawing.Point(34, 77);
            this.buttonShowMoney.Name = "buttonShowMoney";
            this.buttonShowMoney.Size = new System.Drawing.Size(157, 77);
            this.buttonShowMoney.TabIndex = 0;
            this.buttonShowMoney.Text = "Показати рахунок";
            this.buttonShowMoney.UseVisualStyleBackColor = false;
            this.buttonShowMoney.Click += new System.EventHandler(this.buttonShowMoney_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMessage.Location = new System.Drawing.Point(252, 440);
            this.labelMessage.MaximumSize = new System.Drawing.Size(500, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 44);
            this.labelMessage.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.SlateGray;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(698, 264);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(159, 68);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSendMoney
            // 
            this.buttonSendMoney.BackColor = System.Drawing.Color.SlateGray;
            this.buttonSendMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSendMoney.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendMoney.Location = new System.Drawing.Point(698, 77);
            this.buttonSendMoney.Name = "buttonSendMoney";
            this.buttonSendMoney.Size = new System.Drawing.Size(159, 77);
            this.buttonSendMoney.TabIndex = 7;
            this.buttonSendMoney.Text = "Переказ коштів";
            this.buttonSendMoney.UseVisualStyleBackColor = false;
            this.buttonSendMoney.Click += new System.EventHandler(this.buttonSendMoney_Click);
            // 
            // buttonGiveMoney
            // 
            this.buttonGiveMoney.BackColor = System.Drawing.Color.SlateGray;
            this.buttonGiveMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGiveMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGiveMoney.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGiveMoney.Location = new System.Drawing.Point(34, 480);
            this.buttonGiveMoney.Name = "buttonGiveMoney";
            this.buttonGiveMoney.Size = new System.Drawing.Size(157, 68);
            this.buttonGiveMoney.TabIndex = 8;
            this.buttonGiveMoney.Text = "Покласти на рахунок";
            this.buttonGiveMoney.UseVisualStyleBackColor = false;
            this.buttonGiveMoney.Click += new System.EventHandler(this.buttonGiveMoney_Click);
            // 
            // buttonTakeMoney
            // 
            this.buttonTakeMoney.BackColor = System.Drawing.Color.SlateGray;
            this.buttonTakeMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTakeMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTakeMoney.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTakeMoney.Location = new System.Drawing.Point(34, 264);
            this.buttonTakeMoney.Name = "buttonTakeMoney";
            this.buttonTakeMoney.Size = new System.Drawing.Size(157, 68);
            this.buttonTakeMoney.TabIndex = 9;
            this.buttonTakeMoney.Text = "Зняти гроші";
            this.buttonTakeMoney.UseVisualStyleBackColor = false;
            this.buttonTakeMoney.Click += new System.EventHandler(this.buttonTakeMoney_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.SlateGray;
            this.buttonContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContinue.Location = new System.Drawing.Point(698, 480);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(159, 68);
            this.buttonContinue.TabIndex = 10;
            this.buttonContinue.Text = "Продов-\r\nжити";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Visible = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold);
            this.labelAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAmount.Location = new System.Drawing.Point(317, 215);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(281, 50);
            this.labelAmount.TabIndex = 11;
            this.labelAmount.Text = "Введіть суму:";
            this.labelAmount.Visible = false;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.textBoxAmount.Location = new System.Drawing.Point(301, 310);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(297, 43);
            this.textBoxAmount.TabIndex = 12;
            this.textBoxAmount.Visible = false;
            // 
            // textBoxCard
            // 
            this.textBoxCard.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.textBoxCard.Location = new System.Drawing.Point(301, 310);
            this.textBoxCard.Name = "textBoxCard";
            this.textBoxCard.Size = new System.Drawing.Size(297, 43);
            this.textBoxCard.TabIndex = 13;
            this.textBoxCard.Visible = false;
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold);
            this.labelCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCard.Location = new System.Drawing.Point(197, 190);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(459, 100);
            this.labelCard.TabIndex = 14;
            this.labelCard.Text = "Введіть номер картки \r\nотримувача:";
            this.labelCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCard.Visible = false;
            // 
            // labelSendPerson
            // 
            this.labelSendPerson.AutoSize = true;
            this.labelSendPerson.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSendPerson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSendPerson.Location = new System.Drawing.Point(66, 190);
            this.labelSendPerson.Name = "labelSendPerson";
            this.labelSendPerson.Size = new System.Drawing.Size(775, 57);
            this.labelSendPerson.TabIndex = 15;
            this.labelSendPerson.Text = "Ви бажаєте перевести гроші для ";
            this.labelSendPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSendPerson.Visible = false;
            // 
            // buttonYes
            // 
            this.buttonYes.CausesValidation = false;
            this.buttonYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonYes.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.buttonYes.Location = new System.Drawing.Point(213, 440);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(178, 61);
            this.buttonYes.TabIndex = 16;
            this.buttonYes.Text = "Так";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Visible = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.CausesValidation = false;
            this.buttonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNo.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.buttonNo.Location = new System.Drawing.Point(506, 440);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(178, 61);
            this.buttonNo.TabIndex = 17;
            this.buttonNo.Text = "Ні";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Visible = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.SlateGray;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(698, 480);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(159, 68);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "Завершити";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MainATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(913, 627);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelSendPerson);
            this.Controls.Add(this.labelCard);
            this.Controls.Add(this.textBoxCard);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonTakeMoney);
            this.Controls.Add(this.buttonGiveMoney);
            this.Controls.Add(this.buttonSendMoney);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonShowMoney);
            this.Name = "MainATM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowMoney;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSendMoney;
        private System.Windows.Forms.Button buttonGiveMoney;
        private System.Windows.Forms.Button buttonTakeMoney;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxCard;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.Label labelSendPerson;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonClose;
    }
}