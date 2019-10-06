namespace Blackjack
{
    partial class BlackJack
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
            this.PanelMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pnlCardsDealer = new System.Windows.Forms.Panel();
            this.lblDealerPt = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.pnlCardsPlayer = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblCustomerPt = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.splitContainer1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(880, 450);
            this.PanelMain.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnRestart);
            this.splitContainer1.Panel2.Controls.Add(this.lblMsg);
            this.splitContainer1.Panel2.Controls.Add(this.btnHit);
            this.splitContainer1.Panel2.Controls.Add(this.btnStand);
            this.splitContainer1.Size = new System.Drawing.Size(880, 450);
            this.splitContainer1.SplitterDistance = 700;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pnlCardsDealer);
            this.splitContainer2.Panel1.Controls.Add(this.lblDealerPt);
            this.splitContainer2.Panel1.Controls.Add(this.lblDealer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pnlCardsPlayer);
            this.splitContainer2.Panel2.Controls.Add(this.lblCustomerPt);
            this.splitContainer2.Panel2.Controls.Add(this.lblCustomer);
            this.splitContainer2.Size = new System.Drawing.Size(700, 450);
            this.splitContainer2.SplitterDistance = 207;
            this.splitContainer2.TabIndex = 0;
            // 
            // pnlCardsDealer
            // 
            this.pnlCardsDealer.Location = new System.Drawing.Point(112, 29);
            this.pnlCardsDealer.Name = "pnlCardsDealer";
            this.pnlCardsDealer.Size = new System.Drawing.Size(560, 162);
            this.pnlCardsDealer.TabIndex = 5;
            // 
            // lblDealerPt
            // 
            this.lblDealerPt.AutoSize = true;
            this.lblDealerPt.BackColor = System.Drawing.Color.Gold;
            this.lblDealerPt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDealerPt.Location = new System.Drawing.Point(30, 126);
            this.lblDealerPt.Name = "lblDealerPt";
            this.lblDealerPt.Size = new System.Drawing.Size(56, 25);
            this.lblDealerPt.TabIndex = 4;
            this.lblDealerPt.Text = "Point";
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Noto Serif Lao", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDealer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDealer.Location = new System.Drawing.Point(24, 94);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(66, 22);
            this.lblDealer.TabIndex = 3;
            this.lblDealer.Text = "Dealer";
            // 
            // pnlCardsPlayer
            // 
            this.pnlCardsPlayer.Location = new System.Drawing.Point(112, 30);
            this.pnlCardsPlayer.Name = "pnlCardsPlayer";
            this.pnlCardsPlayer.Size = new System.Drawing.Size(560, 175);
            this.pnlCardsPlayer.TabIndex = 9;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMsg.ForeColor = System.Drawing.Color.Gold;
            this.lblMsg.Location = new System.Drawing.Point(25, 241);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(50, 25);
            this.lblMsg.TabIndex = 10;
            this.lblMsg.Text = "Msg";
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // lblCustomerPt
            // 
            this.lblCustomerPt.AutoSize = true;
            this.lblCustomerPt.BackColor = System.Drawing.Color.Gold;
            this.lblCustomerPt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerPt.Location = new System.Drawing.Point(30, 115);
            this.lblCustomerPt.Name = "lblCustomerPt";
            this.lblCustomerPt.Size = new System.Drawing.Size(56, 25);
            this.lblCustomerPt.TabIndex = 5;
            this.lblCustomerPt.Text = "Point";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Noto Serif Lao", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCustomer.Location = new System.Drawing.Point(31, 84);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(41, 22);
            this.lblCustomer.TabIndex = 4;
            this.lblCustomer.Text = "You";
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestart.Location = new System.Drawing.Point(30, 335);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(115, 37);
            this.btnRestart.TabIndex = 11;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHit.Location = new System.Drawing.Point(30, 94);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(115, 37);
            this.btnHit.TabIndex = 1;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStand.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStand.Image = global::Blackjack.Properties.Resources.hand24px;
            this.btnStand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStand.Location = new System.Drawing.Point(30, 154);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(115, 37);
            this.btnStand.TabIndex = 0;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.PanelMain);
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblDealerPt;
        private System.Windows.Forms.Label lblCustomerPt;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Panel pnlCardsPlayer;
        private System.Windows.Forms.Panel pnlCardsDealer;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnRestart;
    }
}

