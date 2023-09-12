namespace MARS.TestTask
{
    partial class AutorizationForm
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
            label_welcome = new Label();
            textbox_connectionString = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button_connection = new Button();
            SuspendLayout();
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label_welcome.Location = new Point(192, 116);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(416, 70);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "Авторизация";
            // 
            // textbox_connectionString
            // 
            textbox_connectionString.Location = new Point(257, 189);
            textbox_connectionString.Name = "textbox_connectionString";
            textbox_connectionString.PlaceholderText = "Наименование базы данных";
            textbox_connectionString.Size = new Size(260, 27);
            textbox_connectionString.TabIndex = 1;
            textbox_connectionString.TextAlign = HorizontalAlignment.Center;
            textbox_connectionString.TextChanged += textbox_connectionString_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(291, 222);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Логин";
            textBox2.Size = new Size(193, 27);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(291, 255);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Пароль";
            textBox3.Size = new Size(193, 27);
            textBox3.TabIndex = 3;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button_connection
            // 
            button_connection.Location = new Point(291, 315);
            button_connection.Name = "button_connection";
            button_connection.Size = new Size(193, 29);
            button_connection.TabIndex = 4;
            button_connection.Text = "Подключиться!";
            button_connection.UseVisualStyleBackColor = true;
            button_connection.Click += button_connection_Click;
            // 
            // AutorizationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_connection);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textbox_connectionString);
            Controls.Add(label_welcome);
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "AutorizationForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_welcome;
        private TextBox textbox_connectionString;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button_connection;
    }
}