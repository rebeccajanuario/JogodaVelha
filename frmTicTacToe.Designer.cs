namespace TicTacToe
{
    partial class frmTicTacToe
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
            this.btn00 = new System.Windows.Forms.Button();
            this.rbtnX = new System.Windows.Forms.RadioButton();
            this.rbtn0 = new System.Windows.Forms.RadioButton();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNotAnyWinner = new System.Windows.Forms.Label();
            this.lblGamesX = new System.Windows.Forms.Label();
            this.lblGames0 = new System.Windows.Forms.Label();
            this.lblWonGames = new System.Windows.Forms.Label();
            this.lblPlayerX = new System.Windows.Forms.Label();
            this.lblPlayer0 = new System.Windows.Forms.Label();
            this.lblWhoPlay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn00
            // 
            this.btn00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn00.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn00.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.ForeColor = System.Drawing.Color.Black;
            this.btn00.Location = new System.Drawing.Point(85, 140);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(104, 84);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // rbtnX
            // 
            this.rbtnX.AutoSize = true;
            this.rbtnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnX.Location = new System.Drawing.Point(446, 187);
            this.rbtnX.Name = "rbtnX";
            this.rbtnX.Size = new System.Drawing.Size(87, 21);
            this.rbtnX.TabIndex = 1;
            this.rbtnX.TabStop = true;
            this.rbtnX.Text = "Player X";
            this.rbtnX.UseVisualStyleBackColor = true;
            // 
            // rbtn0
            // 
            this.rbtn0.AutoSize = true;
            this.rbtn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn0.Location = new System.Drawing.Point(447, 220);
            this.rbtn0.Name = "rbtn0";
            this.rbtn0.Size = new System.Drawing.Size(86, 21);
            this.rbtn0.TabIndex = 2;
            this.rbtn0.TabStop = true;
            this.rbtn0.Text = "Player 0";
            this.rbtn0.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            this.btn02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn02.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btn02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn02.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn02.Location = new System.Drawing.Point(293, 140);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(104, 84);
            this.btn02.TabIndex = 3;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btn02_Click);
            // 
            // btn01
            // 
            this.btn01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn01.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btn01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn01.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn01.Location = new System.Drawing.Point(189, 140);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(104, 84);
            this.btn01.TabIndex = 4;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btn11
            // 
            this.btn11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn11.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(189, 224);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(104, 84);
            this.btn11.TabIndex = 7;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn12
            // 
            this.btn12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn12.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(293, 224);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(104, 84);
            this.btn12.TabIndex = 6;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn10
            // 
            this.btn10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn10.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(85, 224);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(104, 84);
            this.btn10.TabIndex = 5;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn21
            // 
            this.btn21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn21.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.Location = new System.Drawing.Point(189, 308);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(104, 84);
            this.btn21.TabIndex = 10;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.btn21_Click);
            // 
            // btn22
            // 
            this.btn22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn22.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.Location = new System.Drawing.Point(293, 308);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(104, 84);
            this.btn22.TabIndex = 9;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.btn22_Click);
            // 
            // btn20
            // 
            this.btn20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn20.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.Location = new System.Drawing.Point(85, 308);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(104, 84);
            this.btn20.TabIndex = 8;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(148, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(214, 36);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Jogo da velha";
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Location = new System.Drawing.Point(322, 439);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 36);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Resetar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNotAnyWinner
            // 
            this.lblNotAnyWinner.AutoSize = true;
            this.lblNotAnyWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotAnyWinner.ForeColor = System.Drawing.Color.Red;
            this.lblNotAnyWinner.Location = new System.Drawing.Point(80, 442);
            this.lblNotAnyWinner.Name = "lblNotAnyWinner";
            this.lblNotAnyWinner.Size = new System.Drawing.Size(249, 26);
            this.lblNotAnyWinner.TabIndex = 14;
            this.lblNotAnyWinner.Text = "Nenhum vencedor   →";
            this.lblNotAnyWinner.Visible = false;
            // 
            // lblGamesX
            // 
            this.lblGamesX.AutoSize = true;
            this.lblGamesX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamesX.Location = new System.Drawing.Point(528, 335);
            this.lblGamesX.Name = "lblGamesX";
            this.lblGamesX.Size = new System.Drawing.Size(16, 17);
            this.lblGamesX.TabIndex = 15;
            this.lblGamesX.Text = "0";
            // 
            // lblGames0
            // 
            this.lblGames0.AutoSize = true;
            this.lblGames0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames0.Location = new System.Drawing.Point(528, 368);
            this.lblGames0.Name = "lblGames0";
            this.lblGames0.Size = new System.Drawing.Size(16, 17);
            this.lblGames0.TabIndex = 16;
            this.lblGames0.Text = "0";
            // 
            // lblWonGames
            // 
            this.lblWonGames.AutoSize = true;
            this.lblWonGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWonGames.ForeColor = System.Drawing.Color.Black;
            this.lblWonGames.Location = new System.Drawing.Point(442, 290);
            this.lblWonGames.Name = "lblWonGames";
            this.lblWonGames.Size = new System.Drawing.Size(209, 26);
            this.lblWonGames.TabIndex = 17;
            this.lblWonGames.Text = "Vitórias contagens";
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.AutoSize = true;
            this.lblPlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerX.Location = new System.Drawing.Point(443, 335);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(79, 17);
            this.lblPlayerX.TabIndex = 18;
            this.lblPlayerX.Text = "Player X :";
            // 
            // lblPlayer0
            // 
            this.lblPlayer0.AutoSize = true;
            this.lblPlayer0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer0.Location = new System.Drawing.Point(444, 368);
            this.lblPlayer0.Name = "lblPlayer0";
            this.lblPlayer0.Size = new System.Drawing.Size(78, 17);
            this.lblPlayer0.TabIndex = 19;
            this.lblPlayer0.Text = "Player 0 :";
            // 
            // lblWhoPlay
            // 
            this.lblWhoPlay.AutoSize = true;
            this.lblWhoPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhoPlay.ForeColor = System.Drawing.Color.Black;
            this.lblWhoPlay.Location = new System.Drawing.Point(441, 141);
            this.lblWhoPlay.Name = "lblWhoPlay";
            this.lblWhoPlay.Size = new System.Drawing.Size(147, 26);
            this.lblWhoPlay.TabIndex = 20;
            this.lblWhoPlay.Text = "Quem Joga?";
            this.lblWhoPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWhoPlay.Click += new System.EventHandler(this.lblWhoPlay_Click);
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 532);
            this.Controls.Add(this.lblWhoPlay);
            this.Controls.Add(this.lblPlayer0);
            this.Controls.Add(this.lblPlayerX);
            this.Controls.Add(this.lblWonGames);
            this.Controls.Add(this.lblGames0);
            this.Controls.Add(this.lblGamesX);
            this.Controls.Add(this.lblNotAnyWinner);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.rbtn0);
            this.Controls.Add(this.rbtnX);
            this.Controls.Add(this.btn00);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.RadioButton rbtnX;
        private System.Windows.Forms.RadioButton rbtn0;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNotAnyWinner;
        private System.Windows.Forms.Label lblGamesX;
        private System.Windows.Forms.Label lblGames0;
        private System.Windows.Forms.Label lblWonGames;
        private System.Windows.Forms.Label lblPlayerX;
        private System.Windows.Forms.Label lblPlayer0;
        private System.Windows.Forms.Label lblWhoPlay;
    }
}

