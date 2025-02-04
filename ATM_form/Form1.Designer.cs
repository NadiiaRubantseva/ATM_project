namespace ATM_form
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
            this.buttonCard = new System.Windows.Forms.Button();
            this.buttonPin = new System.Windows.Forms.Button();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.textBoxCard = new System.Windows.Forms.TextBox();
            this.labelCard = new System.Windows.Forms.Label();
            this.labelPin = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCard
            // 
            this.buttonCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCard.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.buttonCard.Location = new System.Drawing.Point(348, 241);
            this.buttonCard.Name = "buttonCard";
            this.buttonCard.Size = new System.Drawing.Size(178, 61);
            this.buttonCard.TabIndex = 0;
            this.buttonCard.Text = "Перевірити";
            this.buttonCard.UseVisualStyleBackColor = true;
            this.buttonCard.Click += new System.EventHandler(this.buttonCard_Click);
            // 
            // buttonPin
            // 
            this.buttonPin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPin.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPin.Location = new System.Drawing.Point(348, 465);
            this.buttonPin.Name = "buttonPin";
            this.buttonPin.Size = new System.Drawing.Size(178, 59);
            this.buttonPin.TabIndex = 1;
            this.buttonPin.Text = "Перевірити";
            this.buttonPin.UseVisualStyleBackColor = true;
            this.buttonPin.Visible = false;
            this.buttonPin.Click += new System.EventHandler(this.buttonPin_Click);
            // 
            // textBoxPin
            // 
            this.textBoxPin.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F);
            this.textBoxPin.Location = new System.Drawing.Point(270, 400);
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.PasswordChar = '*';
            this.textBoxPin.Size = new System.Drawing.Size(366, 43);
            this.textBoxPin.TabIndex = 2;
            this.textBoxPin.Visible = false;
            // 
            // textBoxCard
            // 
            this.textBoxCard.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCard.Location = new System.Drawing.Point(270, 172);
            this.textBoxCard.Name = "textBoxCard";
            this.textBoxCard.Size = new System.Drawing.Size(366, 43);
            this.textBoxCard.TabIndex = 3;
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCard.Location = new System.Drawing.Point(239, 78);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(437, 50);
            this.labelCard.TabIndex = 4;
            this.labelCard.Text = "Введіть номер карти:";
            // 
            // labelPin
            // 
            this.labelPin.AutoSize = true;
            this.labelPin.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold);
            this.labelPin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPin.Location = new System.Drawing.Point(288, 316);
            this.labelPin.Name = "labelPin";
            this.labelPin.Size = new System.Drawing.Size(329, 50);
            this.labelPin.TabIndex = 5;
            this.labelPin.Text = "Введіть пінкод: ";
            this.labelPin.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(440, 541);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 30);
            this.labelError.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(913, 627);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelPin);
            this.Controls.Add(this.labelCard);
            this.Controls.Add(this.textBoxCard);
            this.Controls.Add(this.textBoxPin);
            this.Controls.Add(this.buttonPin);
            this.Controls.Add(this.buttonCard);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCard;
        private System.Windows.Forms.Button buttonPin;
        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.TextBox textBoxCard;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.Label labelPin;
        private System.Windows.Forms.Label labelError;
    }
}

