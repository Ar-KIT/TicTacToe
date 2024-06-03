namespace TictacToe
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.TIcTacToe_Board = new System.Windows.Forms.FlowLayoutPanel();
            this.cell_00 = new System.Windows.Forms.PictureBox();
            this.cell_01 = new System.Windows.Forms.PictureBox();
            this.cell_02 = new System.Windows.Forms.PictureBox();
            this.cell_10 = new System.Windows.Forms.PictureBox();
            this.cell_11 = new System.Windows.Forms.PictureBox();
            this.cell_12 = new System.Windows.Forms.PictureBox();
            this.cell_20 = new System.Windows.Forms.PictureBox();
            this.cell_21 = new System.Windows.Forms.PictureBox();
            this.cell_22 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.playerName_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.O_Score = new System.Windows.Forms.Label();
            this.X_Score = new System.Windows.Forms.Label();
            this.back_Button = new System.Windows.Forms.PictureBox();
            this.TIcTacToe_Board.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cell_00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_22)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // TIcTacToe_Board
            // 
            this.TIcTacToe_Board.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TIcTacToe_Board.Controls.Add(this.cell_00);
            this.TIcTacToe_Board.Controls.Add(this.cell_01);
            this.TIcTacToe_Board.Controls.Add(this.cell_02);
            this.TIcTacToe_Board.Controls.Add(this.cell_10);
            this.TIcTacToe_Board.Controls.Add(this.cell_11);
            this.TIcTacToe_Board.Controls.Add(this.cell_12);
            this.TIcTacToe_Board.Controls.Add(this.cell_20);
            this.TIcTacToe_Board.Controls.Add(this.cell_21);
            this.TIcTacToe_Board.Controls.Add(this.cell_22);
            this.TIcTacToe_Board.Location = new System.Drawing.Point(15, 162);
            this.TIcTacToe_Board.Name = "TIcTacToe_Board";
            this.TIcTacToe_Board.Size = new System.Drawing.Size(468, 469);
            this.TIcTacToe_Board.TabIndex = 1;
            // 
            // cell_00
            // 
            this.cell_00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.cell_00.InitialImage = null;
            this.cell_00.Location = new System.Drawing.Point(3, 3);
            this.cell_00.Name = "cell_00";
            this.cell_00.Padding = new System.Windows.Forms.Padding(25);
            this.cell_00.Size = new System.Drawing.Size(150, 150);
            this.cell_00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cell_00.TabIndex = 0;
            this.cell_00.TabStop = false;
            // 
            // cell_01
            // 
            this.cell_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.cell_01.Location = new System.Drawing.Point(159, 3);
            this.cell_01.Name = "cell_01";
            this.cell_01.Padding = new System.Windows.Forms.Padding(25);
            this.cell_01.Size = new System.Drawing.Size(150, 150);
            this.cell_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cell_01.TabIndex = 1;
            this.cell_01.TabStop = false;
            // 
            // cell_02
            // 
            this.cell_02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.cell_02.Location = new System.Drawing.Point(315, 3);
            this.cell_02.Name = "cell_02";
            this.cell_02.Padding = new System.Windows.Forms.Padding(25);
            this.cell_02.Size = new System.Drawing.Size(150, 150);
            this.cell_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cell_02.TabIndex = 2;
            this.cell_02.TabStop = false;
            // 
            // cell_10
            // 
            this.cell_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.cell_10.Location = new System.Drawing.Point(3, 159);
            this.cell_10.Name = "cell_10";
            this.cell_10.Padding = new System.Windows.Forms.Padding(25);
            this.cell_10.Size = new System.Drawing.Size(150, 150);
            this.cell_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cell_10.TabIndex = 3;
            this.cell_10.TabStop = false;
            // 
            // cell_11
            // 
            this.cell_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.cell_11.Location = new System.Drawing.Point(159, 159);
            this.cell_11.Name = "cell_11";
            this.cell_11.Padding = new System.Windows.Forms.Padding(25);
            this.cell_11.Size = new System.Drawing.Size(150, 150);
            this.cell_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cell_11.TabIndex = 4;
            this.cell_11.TabStop = false;
            // 
            // cell_12
            // 
            this.cell_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.cell_12.Location = new System.Drawing.Point(315, 159);
            this.cell_12.Name = "cell_12";
            this.cell_12.Padding = new System.Windows.Forms.Padding(25);
            this.cell_12.Size = new System.Drawing.Size(150, 150);
            this.cell_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cell_12.TabIndex = 5;
            this.cell_12.TabStop = false;
            // 
            // cell_20
            // 
            this.cell_20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.cell_20.Location = new System.Drawing.Point(3, 315);
            this.cell_20.Name = "cell_20";
            this.cell_20.Padding = new System.Windows.Forms.Padding(25);
            this.cell_20.Size = new System.Drawing.Size(150, 150);
            this.cell_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cell_20.TabIndex = 6;
            this.cell_20.TabStop = false;
            // 
            // cell_21
            // 
            this.cell_21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.cell_21.Location = new System.Drawing.Point(159, 315);
            this.cell_21.Name = "cell_21";
            this.cell_21.Padding = new System.Windows.Forms.Padding(25);
            this.cell_21.Size = new System.Drawing.Size(150, 150);
            this.cell_21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cell_21.TabIndex = 7;
            this.cell_21.TabStop = false;
            // 
            // cell_22
            // 
            this.cell_22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.cell_22.Location = new System.Drawing.Point(315, 315);
            this.cell_22.Name = "cell_22";
            this.cell_22.Padding = new System.Windows.Forms.Padding(25);
            this.cell_22.Size = new System.Drawing.Size(150, 150);
            this.cell_22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cell_22.TabIndex = 8;
            this.cell_22.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.playerName_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.O_Score);
            this.panel1.Controls.Add(this.X_Score);
            this.panel1.Location = new System.Drawing.Point(15, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 71);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Computer";
            // 
            // playerName_label
            // 
            this.playerName_label.AutoSize = true;
            this.playerName_label.Location = new System.Drawing.Point(12, 9);
            this.playerName_label.Name = "playerName_label";
            this.playerName_label.Size = new System.Drawing.Size(57, 16);
            this.playerName_label.TabIndex = 4;
            this.playerName_label.Text = "Player X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            // 
            // O_Score
            // 
            this.O_Score.AutoSize = true;
            this.O_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O_Score.Location = new System.Drawing.Point(278, 9);
            this.O_Score.Name = "O_Score";
            this.O_Score.Size = new System.Drawing.Size(50, 54);
            this.O_Score.TabIndex = 1;
            this.O_Score.Text = "0";
            // 
            // X_Score
            // 
            this.X_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.X_Score.AutoSize = true;
            this.X_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_Score.Location = new System.Drawing.Point(150, 9);
            this.X_Score.Name = "X_Score";
            this.X_Score.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.X_Score.Size = new System.Drawing.Size(50, 54);
            this.X_Score.TabIndex = 0;
            this.X_Score.Text = "0";
            this.X_Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // back_Button
            // 
            this.back_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.back_Button.Image = ((System.Drawing.Image)(resources.GetObject("back_Button.Image")));
            this.back_Button.Location = new System.Drawing.Point(15, 12);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(60, 50);
            this.back_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_Button.TabIndex = 3;
            this.back_Button.TabStop = false;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(25)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(494, 646);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TIcTacToe_Board);
            this.Name = "Game";
            this.Text = "AZIL ROTONI - 10 Hands-on Activity 2";
            this.TIcTacToe_Board.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cell_00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell_22)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TIcTacToe_Board;
        private System.Windows.Forms.PictureBox cell_00;
        private System.Windows.Forms.PictureBox cell_01;
        private System.Windows.Forms.PictureBox cell_02;
        private System.Windows.Forms.PictureBox cell_10;
        private System.Windows.Forms.PictureBox cell_11;
        private System.Windows.Forms.PictureBox cell_12;
        private System.Windows.Forms.PictureBox cell_20;
        private System.Windows.Forms.PictureBox cell_21;
        private System.Windows.Forms.PictureBox cell_22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label X_Score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label O_Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerName_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox back_Button;
    }
}

