namespace TicTacToe
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
            ticTacToeBoard1 = new Board.TicTacToeBoard();
            SuspendLayout();
            // 
            // ticTacToeBoard1
            // 
            ticTacToeBoard1.Location = new Point(264, 101);
            ticTacToeBoard1.Margin = new Padding(0);
            ticTacToeBoard1.MaximumSize = new Size(231, 231);
            ticTacToeBoard1.MinimumSize = new Size(231, 231);
            ticTacToeBoard1.Name = "ticTacToeBoard1";
            ticTacToeBoard1.Size = new Size(231, 231);
            ticTacToeBoard1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ticTacToeBoard1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Board.TicTacToeBoard ticTacToeBoard1;
    }
}
