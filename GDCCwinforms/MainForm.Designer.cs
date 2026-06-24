namespace GDCCwinforms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtProgrammers;
        private TextBox txtArtists;
        private TextBox txtMonths;
        private Button btnCalculate;
        private Label lblResult;
        private Label lblProgrammers;
        private Label lblArtists;
        private Label lblMonths;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtProgrammers = new TextBox();
            txtArtists = new TextBox();
            txtMonths = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            lblProgrammers = new Label();
            lblArtists = new Label();
            lblMonths = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txtProgrammers
            // 
            txtProgrammers.Location = new Point(150, 67);
            txtProgrammers.Name = "txtProgrammers";
            txtProgrammers.Size = new Size(150, 23);
            txtProgrammers.TabIndex = 0;
            txtProgrammers.KeyPress += txtInput_KeyPress;
            // 
            // txtArtists
            // 
            txtArtists.Location = new Point(150, 102);
            txtArtists.Name = "txtArtists";
            txtArtists.Size = new Size(150, 23);
            txtArtists.TabIndex = 1;
            txtArtists.KeyPress += txtInput_KeyPress;
            // 
            // txtMonths
            // 
            txtMonths.Location = new Point(150, 137);
            txtMonths.Name = "txtMonths";
            txtMonths.Size = new Size(150, 23);
            txtMonths.TabIndex = 2;
            txtMonths.KeyPress += txtInput_KeyPress;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(30, 180);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(270, 35);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Рассчитать";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(30, 230);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(270, 40);
            lblResult.TabIndex = 7;
            lblResult.Text = "Ожидание ввода...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProgrammers
            // 
            lblProgrammers.AutoSize = true;
            lblProgrammers.Location = new Point(30, 70);
            lblProgrammers.Name = "lblProgrammers";
            lblProgrammers.Size = new Size(96, 15);
            lblProgrammers.TabIndex = 1;
            lblProgrammers.Text = "Программисты:";
            // 
            // lblArtists
            // 
            lblArtists.AutoSize = true;
            lblArtists.Location = new Point(30, 105);
            lblArtists.Name = "lblArtists";
            lblArtists.Size = new Size(72, 15);
            lblArtists.TabIndex = 3;
            lblArtists.Text = "Художники:";
            // 
            // lblMonths
            // 
            lblMonths.AutoSize = true;
            lblMonths.Location = new Point(30, 140);
            lblMonths.Name = "lblMonths";
            lblMonths.Size = new Size(58, 15);
            lblMonths.TabIndex = 5;
            lblMonths.Text = "Месяцев:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(349, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Калькулятор стоимости разработки";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 300);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtMonths);
            Controls.Add(lblMonths);
            Controls.Add(txtArtists);
            Controls.Add(lblArtists);
            Controls.Add(txtProgrammers);
            Controls.Add(lblProgrammers);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор стоимости";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
