﻿namespace ChessLibrary
{
    partial class SidePanel
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
            this.lstMoves = new System.Windows.Forms.ListBox();
            this.lbSelected = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbP2Pic = new System.Windows.Forms.PictureBox();
            this.lbP2Username = new System.Windows.Forms.Label();
            this.lbP2Rating = new System.Windows.Forms.Label();
            this.lbP1Username = new System.Windows.Forms.Label();
            this.lbP1Rating = new System.Windows.Forms.Label();
            this.pbP1Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbP2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbP1Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMoves
            // 
            this.lstMoves.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMoves.FormattingEnabled = true;
            this.lstMoves.ItemHeight = 20;
            this.lstMoves.Location = new System.Drawing.Point(1, 489);
            this.lstMoves.Name = "lstMoves";
            this.lstMoves.Size = new System.Drawing.Size(391, 144);
            this.lstMoves.TabIndex = 0;
            // 
            // lbSelected
            // 
            this.lbSelected.AutoSize = true;
            this.lbSelected.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelected.ForeColor = System.Drawing.Color.White;
            this.lbSelected.Location = new System.Drawing.Point(20, 193);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(96, 30);
            this.lbSelected.TabIndex = 4;
            this.lbSelected.Text = "Selected:";
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTurn.ForeColor = System.Drawing.Color.White;
            this.lbTurn.Location = new System.Drawing.Point(20, 235);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(60, 30);
            this.lbTurn.TabIndex = 4;
            this.lbTurn.Text = "Turn:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(282, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 31);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbP2Pic
            // 
            this.pbP2Pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbP2Pic.Location = new System.Drawing.Point(36, 43);
            this.pbP2Pic.Name = "pbP2Pic";
            this.pbP2Pic.Size = new System.Drawing.Size(50, 50);
            this.pbP2Pic.TabIndex = 6;
            this.pbP2Pic.TabStop = false;
            // 
            // lbP2Username
            // 
            this.lbP2Username.AutoSize = true;
            this.lbP2Username.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbP2Username.ForeColor = System.Drawing.Color.White;
            this.lbP2Username.Location = new System.Drawing.Point(92, 43);
            this.lbP2Username.Name = "lbP2Username";
            this.lbP2Username.Size = new System.Drawing.Size(86, 30);
            this.lbP2Username.TabIndex = 4;
            this.lbP2Username.Text = "Player 2";
            // 
            // lbP2Rating
            // 
            this.lbP2Rating.AutoSize = true;
            this.lbP2Rating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbP2Rating.ForeColor = System.Drawing.Color.Gray;
            this.lbP2Rating.Location = new System.Drawing.Point(92, 76);
            this.lbP2Rating.Name = "lbP2Rating";
            this.lbP2Rating.Size = new System.Drawing.Size(42, 17);
            this.lbP2Rating.TabIndex = 4;
            this.lbP2Rating.Text = "rating";
            // 
            // lbP1Username
            // 
            this.lbP1Username.AutoSize = true;
            this.lbP1Username.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbP1Username.ForeColor = System.Drawing.Color.White;
            this.lbP1Username.Location = new System.Drawing.Point(92, 131);
            this.lbP1Username.Name = "lbP1Username";
            this.lbP1Username.Size = new System.Drawing.Size(86, 30);
            this.lbP1Username.TabIndex = 4;
            this.lbP1Username.Text = "Player 1";
            // 
            // lbP1Rating
            // 
            this.lbP1Rating.AutoSize = true;
            this.lbP1Rating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbP1Rating.ForeColor = System.Drawing.Color.Gray;
            this.lbP1Rating.Location = new System.Drawing.Point(92, 164);
            this.lbP1Rating.Name = "lbP1Rating";
            this.lbP1Rating.Size = new System.Drawing.Size(42, 17);
            this.lbP1Rating.TabIndex = 4;
            this.lbP1Rating.Text = "rating";
            // 
            // pbP1Pic
            // 
            this.pbP1Pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbP1Pic.Location = new System.Drawing.Point(36, 131);
            this.pbP1Pic.Name = "pbP1Pic";
            this.pbP1Pic.Size = new System.Drawing.Size(50, 50);
            this.pbP1Pic.TabIndex = 6;
            this.pbP1Pic.TabStop = false;
            // 
            // SidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.pbP1Pic);
            this.Controls.Add(this.pbP2Pic);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbP1Rating);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.lbP1Username);
            this.Controls.Add(this.lbP2Rating);
            this.Controls.Add(this.lbP2Username);
            this.Controls.Add(this.lbSelected);
            this.Controls.Add(this.lstMoves);
            this.Name = "SidePanel";
            this.Size = new System.Drawing.Size(394, 635);
            ((System.ComponentModel.ISupportInitialize)(this.pbP2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbP1Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstMoves;
        private Label lbSelected;
        private Label lbTurn;
        private Button btnReset;
        private PictureBox pbP2Pic;
        private Label lbP2Username;
        private Label lbP2Rating;
        private Label lbP1Username;
        private Label lbP1Rating;
        private PictureBox pbP1Pic;
    }
}
