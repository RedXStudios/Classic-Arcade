namespace ClassicArcade
{
    partial class gameSelect
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
            this.gamesGrid = new System.Windows.Forms.TableLayoutPanel();
            this.stackBlocks = new System.Windows.Forms.Button();
            this.sudoku = new System.Windows.Forms.Button();
            this.quitB = new System.Windows.Forms.Button();
            this.gamesGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamesGrid
            // 
            this.gamesGrid.ColumnCount = 5;
            this.gamesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gamesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gamesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gamesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gamesGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gamesGrid.Controls.Add(this.stackBlocks, 0, 0);
            this.gamesGrid.Controls.Add(this.sudoku, 1, 0);
            this.gamesGrid.Location = new System.Drawing.Point(12, 12);
            this.gamesGrid.Name = "gamesGrid";
            this.gamesGrid.RowCount = 5;
            this.gamesGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gamesGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gamesGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gamesGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gamesGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.gamesGrid.Size = new System.Drawing.Size(476, 476);
            this.gamesGrid.TabIndex = 0;
            // 
            // stackBlocks
            // 
            this.stackBlocks.Location = new System.Drawing.Point(3, 3);
            this.stackBlocks.Name = "stackBlocks";
            this.stackBlocks.Size = new System.Drawing.Size(89, 89);
            this.stackBlocks.TabIndex = 0;
            this.stackBlocks.UseVisualStyleBackColor = true;
            this.stackBlocks.Click += new System.EventHandler(this.StackBlocks_Click);
            // 
            // sudoku
            // 
            this.sudoku.Location = new System.Drawing.Point(98, 3);
            this.sudoku.Name = "sudoku";
            this.sudoku.Size = new System.Drawing.Size(89, 89);
            this.sudoku.TabIndex = 1;
            this.sudoku.UseVisualStyleBackColor = true;
            this.sudoku.Click += new System.EventHandler(this.Sudoku_Click);
            // 
            // quitB
            // 
            this.quitB.Location = new System.Drawing.Point(413, 494);
            this.quitB.Name = "quitB";
            this.quitB.Size = new System.Drawing.Size(75, 26);
            this.quitB.TabIndex = 1;
            this.quitB.Text = "&Quit";
            this.quitB.UseVisualStyleBackColor = true;
            this.quitB.Click += new System.EventHandler(this.quitB_Click);
            // 
            // gameSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 532);
            this.Controls.Add(this.quitB);
            this.Controls.Add(this.gamesGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gameSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gamesGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gamesGrid;
        private System.Windows.Forms.Button stackBlocks;
        private System.Windows.Forms.Button sudoku;
        private System.Windows.Forms.Button quitB;
    }
}

