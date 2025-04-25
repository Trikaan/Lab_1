namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Обов’язкова змінна конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Елементи управління форми
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;

        /// <summary>
        ///  Вивільнення всіх використовуваних ресурсів.
        /// </summary>
        /// <param name="disposing">true, якщо керовані ресурси слід видалити; інакше, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматично створений конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            LabelModel = new System.Windows.Forms.Label();
            LabelDescription = new System.Windows.Forms.Label();
            LabelSerial = new System.Windows.Forms.Label();
            LabelSize = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(18, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(176, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new System.Drawing.Point(210, 19);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(158, 28);
            button1.TabIndex = 1;
            button1.Text = "Додати накопичувач";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Модель:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(18, 94);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Опис:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(18, 122);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(101, 15);
            label5.TabIndex = 4;
            label5.Text = "Серійний номер:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(18, 150);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(48, 15);
            label11.TabIndex = 5;
            label11.Text = "Розмір:";
            // 
            // LabelModel
            // 
            LabelModel.AutoSize = true;
            LabelModel.Location = new System.Drawing.Point(125, 66);
            LabelModel.Name = "LabelModel";
            LabelModel.Size = new System.Drawing.Size(29, 15);
            LabelModel.TabIndex = 6;
            LabelModel.Text = "N/A";
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.Location = new System.Drawing.Point(125, 94);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new System.Drawing.Size(29, 15);
            LabelDescription.TabIndex = 7;
            LabelDescription.Text = "N/A";
            // 
            // LabelSerial
            // 
            LabelSerial.AutoSize = true;
            LabelSerial.Location = new System.Drawing.Point(125, 122);
            LabelSerial.Name = "LabelSerial";
            LabelSerial.Size = new System.Drawing.Size(29, 15);
            LabelSerial.TabIndex = 8;
            LabelSerial.Text = "N/A";
            // 
            // LabelSize
            // 
            LabelSize.AutoSize = true;
            LabelSize.Location = new System.Drawing.Point(125, 150);
            LabelSize.Name = "LabelSize";
            LabelSize.Size = new System.Drawing.Size(29, 15);
            LabelSize.TabIndex = 9;
            LabelSize.Text = "N/A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(385, 199);
            Controls.Add(LabelSize);
            Controls.Add(LabelSerial);
            Controls.Add(LabelDescription);
            Controls.Add(LabelModel);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label11);
            Text = "Захист програми";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label LabelSerial;
        private System.Windows.Forms.Label LabelSize;

        private System.Windows.Forms.Label LabelDescription;

        private System.Windows.Forms.Label LabelModel;

        #endregion
    }
}
