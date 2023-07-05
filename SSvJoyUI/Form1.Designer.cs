namespace SSvJoyUI
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
            LudderScroll = new HScrollBar();
            EngineRightScroll = new VScrollBar();
            EngineLeftScroll = new VScrollBar();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ServerIPTextBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            ServerPortTextBox = new TextBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            LudderLabel = new Label();
            EngineLeftLabel = new Label();
            EngineRightLabel = new Label();
            ConnectionButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LudderScroll
            // 
            LudderScroll.Dock = DockStyle.Fill;
            LudderScroll.Location = new Point(0, 0);
            LudderScroll.Name = "LudderScroll";
            LudderScroll.Size = new Size(295, 72);
            LudderScroll.TabIndex = 0;
            LudderScroll.Value = 50;
            LudderScroll.Scroll += LudderScroll_Scroll;
            // 
            // EngineRightScroll
            // 
            EngineRightScroll.Dock = DockStyle.Fill;
            EngineRightScroll.Location = new Point(0, 0);
            EngineRightScroll.Name = "EngineRightScroll";
            EngineRightScroll.Size = new Size(72, 273);
            EngineRightScroll.TabIndex = 1;
            EngineRightScroll.Value = 50;
            EngineRightScroll.Scroll += EngineRightScroll_Scroll;
            // 
            // EngineLeftScroll
            // 
            EngineLeftScroll.Dock = DockStyle.Fill;
            EngineLeftScroll.Location = new Point(0, 0);
            EngineLeftScroll.Name = "EngineLeftScroll";
            EngineLeftScroll.Size = new Size(72, 273);
            EngineLeftScroll.TabIndex = 2;
            EngineLeftScroll.Value = 50;
            EngineLeftScroll.Scroll += EngineLeftScroll_Scroll;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(EngineLeftScroll);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(306, 83);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 3);
            panel1.Size = new Size(74, 275);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(EngineRightScroll);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(386, 83);
            panel2.Name = "panel2";
            tableLayoutPanel1.SetRowSpan(panel2, 3);
            panel2.Size = new Size(74, 275);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(LudderScroll);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 284);
            panel3.Name = "panel3";
            panel3.Size = new Size(297, 74);
            panel3.TabIndex = 5;
            // 
            // ServerIPTextBox
            // 
            ServerIPTextBox.Location = new Point(112, 23);
            ServerIPTextBox.Name = "ServerIPTextBox";
            ServerIPTextBox.PlaceholderText = "127.0.0.1";
            ServerIPTextBox.Size = new Size(161, 29);
            ServerIPTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 7;
            label1.Text = "서버 주소";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(386, 40);
            label3.Name = "label3";
            label3.Size = new Size(74, 40);
            label3.TabIndex = 9;
            label3.Text = "Right";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(306, 40);
            label4.Name = "label4";
            label4.Size = new Size(74, 40);
            label4.TabIndex = 10;
            label4.Text = "Left";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            tableLayoutPanel1.SetColumnSpan(label5, 2);
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(306, 0);
            label5.Name = "label5";
            label5.Size = new Size(154, 40);
            label5.TabIndex = 11;
            label5.Text = "Engine";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 241);
            label2.Name = "label2";
            label2.Size = new Size(297, 40);
            label2.TabIndex = 12;
            label2.Text = "Ludder";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 62);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 13;
            label6.Text = "포트 번호";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ServerPortTextBox
            // 
            ServerPortTextBox.Location = new Point(112, 60);
            ServerPortTextBox.Name = "ServerPortTextBox";
            ServerPortTextBox.PlaceholderText = "80";
            ServerPortTextBox.Size = new Size(161, 29);
            ServerPortTextBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ConnectionButton);
            groupBox1.Controls.Add(EngineRightLabel);
            groupBox1.Controls.Add(LudderLabel);
            groupBox1.Controls.Add(EngineLeftLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ServerPortTextBox);
            groupBox1.Controls.Add(ServerIPTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            tableLayoutPanel1.SetRowSpan(groupBox1, 3);
            groupBox1.Size = new Size(297, 235);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "설정";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 3, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(panel2, 3, 2);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(463, 361);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // LudderLabel
            // 
            LudderLabel.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LudderLabel.Location = new Point(9, 97);
            LudderLabel.Name = "LudderLabel";
            LudderLabel.Size = new Size(280, 23);
            LudderLabel.TabIndex = 16;
            LudderLabel.Text = "Ludder : ";
            LudderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EngineLeftLabel
            // 
            EngineLeftLabel.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EngineLeftLabel.Location = new Point(9, 128);
            EngineLeftLabel.Name = "EngineLeftLabel";
            EngineLeftLabel.Size = new Size(280, 23);
            EngineLeftLabel.TabIndex = 17;
            EngineLeftLabel.Text = "Engine L :";
            EngineLeftLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EngineRightLabel
            // 
            EngineRightLabel.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EngineRightLabel.Location = new Point(9, 159);
            EngineRightLabel.Name = "EngineRightLabel";
            EngineRightLabel.Size = new Size(280, 23);
            EngineRightLabel.TabIndex = 19;
            EngineRightLabel.Text = "Engine R : ";
            EngineRightLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ConnectionButton
            // 
            ConnectionButton.Location = new Point(7, 190);
            ConnectionButton.Name = "ConnectionButton";
            ConnectionButton.Size = new Size(282, 37);
            ConnectionButton.TabIndex = 21;
            ConnectionButton.Text = "접속";
            ConnectionButton.UseVisualStyleBackColor = true;
            ConnectionButton.Click += ConnectionButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 361);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "STR 가상 조이스틱";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private HScrollBar LudderScroll;
        private VScrollBar EngineRightScroll;
        private VScrollBar EngineLeftScroll;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox ServerIPTextBox;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label6;
        private TextBox ServerPortTextBox;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label EngineRightLabel;
        private Label LudderLabel;
        private Label EngineLeftLabel;
        private Button ConnectionButton;
    }
}