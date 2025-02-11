namespace TicTacToe.Board
{
    partial class TicTacToeBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelButtons = new FlowLayoutPanel();
            button5 = new Button();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            labelPlayer1 = new Label();
            labelPlayer2 = new Label();
            labelPlayer1Points = new Label();
            labelPlayer2Points = new Label();
            panelPoints = new Panel();
            flowLayoutPanelButtons.SuspendLayout();
            panelPoints.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanelButtons.BackColor = SystemColors.AppWorkspace;
            flowLayoutPanelButtons.Controls.Add(button5);
            flowLayoutPanelButtons.Controls.Add(button0);
            flowLayoutPanelButtons.Controls.Add(button1);
            flowLayoutPanelButtons.Controls.Add(button2);
            flowLayoutPanelButtons.Controls.Add(button3);
            flowLayoutPanelButtons.Controls.Add(button4);
            flowLayoutPanelButtons.Controls.Add(button6);
            flowLayoutPanelButtons.Controls.Add(button7);
            flowLayoutPanelButtons.Controls.Add(button8);
            flowLayoutPanelButtons.Dock = DockStyle.Fill;
            flowLayoutPanelButtons.Location = new Point(0, 25);
            flowLayoutPanelButtons.Margin = new Padding(0);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Size = new Size(231, 232);
            flowLayoutPanelButtons.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(1, 1);
            button5.Margin = new Padding(1);
            button5.Name = "button5";
            button5.Size = new Size(75, 75);
            button5.TabIndex = 6;
            button5.Tag = "0";
            button5.UseVisualStyleBackColor = false;
            button5.Click += BoardButtons_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.White;
            button0.FlatAppearance.BorderSize = 0;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Location = new Point(78, 1);
            button0.Margin = new Padding(1);
            button0.Name = "button0";
            button0.Size = new Size(75, 75);
            button0.TabIndex = 1;
            button0.Tag = "1";
            button0.UseVisualStyleBackColor = false;
            button0.Click += BoardButtons_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(155, 1);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 2;
            button1.Tag = "2";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BoardButtons_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1, 78);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(75, 75);
            button2.TabIndex = 3;
            button2.Tag = "3";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BoardButtons_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(78, 78);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 4;
            button3.Tag = "4";
            button3.UseVisualStyleBackColor = false;
            button3.Click += BoardButtons_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(155, 78);
            button4.Margin = new Padding(1);
            button4.Name = "button4";
            button4.Size = new Size(75, 75);
            button4.TabIndex = 5;
            button4.Tag = "5";
            button4.UseVisualStyleBackColor = false;
            button4.Click += BoardButtons_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(1, 155);
            button6.Margin = new Padding(1);
            button6.Name = "button6";
            button6.Size = new Size(75, 75);
            button6.TabIndex = 7;
            button6.Tag = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += BoardButtons_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(78, 155);
            button7.Margin = new Padding(1);
            button7.Name = "button7";
            button7.Size = new Size(75, 75);
            button7.TabIndex = 8;
            button7.Tag = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += BoardButtons_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(155, 155);
            button8.Margin = new Padding(1);
            button8.Name = "button8";
            button8.Size = new Size(75, 75);
            button8.TabIndex = 9;
            button8.Tag = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += BoardButtons_Click;
            // 
            // labelPlayer1
            // 
            labelPlayer1.AutoSize = true;
            labelPlayer1.ForeColor = Color.Blue;
            labelPlayer1.Location = new Point(0, 5);
            labelPlayer1.Margin = new Padding(0);
            labelPlayer1.Name = "labelPlayer1";
            labelPlayer1.Size = new Size(52, 15);
            labelPlayer1.TabIndex = 9;
            labelPlayer1.Text = "Player X:";
            // 
            // labelPlayer2
            // 
            labelPlayer2.AutoSize = true;
            labelPlayer2.Location = new Point(164, 5);
            labelPlayer2.Margin = new Padding(0);
            labelPlayer2.Name = "labelPlayer2";
            labelPlayer2.Size = new Size(54, 15);
            labelPlayer2.TabIndex = 10;
            labelPlayer2.Text = "Player O:";
            // 
            // labelPlayer1Points
            // 
            labelPlayer1Points.AutoSize = true;
            labelPlayer1Points.Location = new Point(52, 5);
            labelPlayer1Points.Margin = new Padding(0);
            labelPlayer1Points.Name = "labelPlayer1Points";
            labelPlayer1Points.Size = new Size(13, 15);
            labelPlayer1Points.TabIndex = 11;
            labelPlayer1Points.Text = "0";
            // 
            // labelPlayer2Points
            // 
            labelPlayer2Points.AutoSize = true;
            labelPlayer2Points.Location = new Point(218, 5);
            labelPlayer2Points.Margin = new Padding(0);
            labelPlayer2Points.Name = "labelPlayer2Points";
            labelPlayer2Points.Size = new Size(13, 15);
            labelPlayer2Points.TabIndex = 12;
            labelPlayer2Points.Text = "0";
            // 
            // panelPoints
            // 
            panelPoints.Controls.Add(labelPlayer2Points);
            panelPoints.Controls.Add(labelPlayer1Points);
            panelPoints.Controls.Add(labelPlayer2);
            panelPoints.Controls.Add(labelPlayer1);
            panelPoints.Dock = DockStyle.Top;
            panelPoints.Location = new Point(0, 0);
            panelPoints.Name = "panelPoints";
            panelPoints.Size = new Size(231, 25);
            panelPoints.TabIndex = 1;
            // 
            // TicTacToeBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelButtons);
            Controls.Add(panelPoints);
            Margin = new Padding(0);
            MaximumSize = new Size(231, 257);
            MinimumSize = new Size(231, 257);
            Name = "TicTacToeBoard";
            Size = new Size(231, 257);
            flowLayoutPanelButtons.ResumeLayout(false);
            panelPoints.ResumeLayout(false);
            panelPoints.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelButtons;
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label labelPlayer1;
        private Label labelPlayer2;
        private Label labelPlayer1Points;
        private Label labelPlayer2Points;
        private Panel panelPoints;
    }
}
