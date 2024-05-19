namespace Task_4_Memory_Scramble_Game
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblTextLeft = new Label();
            btnRestart = new Button();
            GameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 103);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 0;
            label1.Text = "Match or MisMatch";
            // 
            // lblTextLeft
            // 
            lblTextLeft.AutoSize = true;
            lblTextLeft.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextLeft.Location = new Point(327, 162);
            lblTextLeft.Name = "lblTextLeft";
            lblTextLeft.Size = new Size(143, 28);
            lblTextLeft.TabIndex = 1;
            lblTextLeft.Text = "Time Left : 30";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = SystemColors.InactiveBorder;
            btnRestart.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(327, 26);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(143, 49);
            btnRestart.TabIndex = 2;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += RestartGameEvent;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += TimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(506, 367);
            Controls.Add(btnRestart);
            Controls.Add(lblTextLeft);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Memory-Scramble-Game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTextLeft;
        private Button btnRestart;
        private System.Windows.Forms.Timer GameTimer;
    }
}
