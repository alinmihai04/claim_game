namespace Claim_Game
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDropCards = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nullCardPicture = new Claim_Game.Custom_Picture_Box();
            this.droppedCardPicture = new Claim_Game.Custom_Picture_Box();
            this.lastCardPictureBox = new Claim_Game.Custom_Picture_Box();
            this.drawCardsPicture = new Claim_Game.Custom_Picture_Box();
            this.pictureBox5 = new Claim_Game.Custom_Picture_Box();
            this.pictureBox4 = new Claim_Game.Custom_Picture_Box();
            this.pictureBox3 = new Claim_Game.Custom_Picture_Box();
            this.pictureBox2 = new Claim_Game.Custom_Picture_Box();
            this.pictureBox1 = new Claim_Game.Custom_Picture_Box();
            this.firstCardPicture = new Claim_Game.Custom_Picture_Box();
            ((System.ComponentModel.ISupportInitialize)(this.nullCardPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droppedCardPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastCardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawCardsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Random Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDropCards
            // 
            this.buttonDropCards.Enabled = false;
            this.buttonDropCards.Location = new System.Drawing.Point(22, 52);
            this.buttonDropCards.Name = "buttonDropCards";
            this.buttonDropCards.Size = new System.Drawing.Size(120, 41);
            this.buttonDropCards.TabIndex = 8;
            this.buttonDropCards.Text = "Drop Selected Card(s)";
            this.buttonDropCards.UseVisualStyleBackColor = true;
            this.buttonDropCards.Click += new System.EventHandler(this.buttonDropCards_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dropped Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(745, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cartea nula";
            // 
            // nullCardPicture
            // 
            this.nullCardPicture.Clicked = false;
            this.nullCardPicture.Location = new System.Drawing.Point(821, 222);
            this.nullCardPicture.Name = "nullCardPicture";
            this.nullCardPicture.SelectedCardIndex = 0;
            this.nullCardPicture.Size = new System.Drawing.Size(120, 194);
            this.nullCardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nullCardPicture.TabIndex = 13;
            this.nullCardPicture.TabStop = false;
            // 
            // droppedCardPicture
            // 
            this.droppedCardPicture.Clicked = false;
            this.droppedCardPicture.Location = new System.Drawing.Point(821, 14);
            this.droppedCardPicture.Name = "droppedCardPicture";
            this.droppedCardPicture.SelectedCardIndex = 0;
            this.droppedCardPicture.Size = new System.Drawing.Size(120, 194);
            this.droppedCardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.droppedCardPicture.TabIndex = 11;
            this.droppedCardPicture.TabStop = false;
            // 
            // lastCardPictureBox
            // 
            this.lastCardPictureBox.Clicked = false;
            this.lastCardPictureBox.Location = new System.Drawing.Point(457, 14);
            this.lastCardPictureBox.Name = "lastCardPictureBox";
            this.lastCardPictureBox.SelectedCardIndex = 0;
            this.lastCardPictureBox.Size = new System.Drawing.Size(120, 194);
            this.lastCardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lastCardPictureBox.TabIndex = 9;
            this.lastCardPictureBox.TabStop = false;
            // 
            // drawCardsPicture
            // 
            this.drawCardsPicture.Clicked = false;
            this.drawCardsPicture.Location = new System.Drawing.Point(594, 13);
            this.drawCardsPicture.Name = "drawCardsPicture";
            this.drawCardsPicture.SelectedCardIndex = 0;
            this.drawCardsPicture.Size = new System.Drawing.Size(120, 195);
            this.drawCardsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drawCardsPicture.TabIndex = 7;
            this.drawCardsPicture.TabStop = false;
            this.drawCardsPicture.Click += new System.EventHandler(this.drawCardsPicture_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Clicked = false;
            this.pictureBox5.Location = new System.Drawing.Point(594, 213);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.SelectedCardIndex = 0;
            this.pictureBox5.Size = new System.Drawing.Size(120, 203);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Clicked = false;
            this.pictureBox4.Location = new System.Drawing.Point(457, 213);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.SelectedCardIndex = 0;
            this.pictureBox4.Size = new System.Drawing.Size(120, 203);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Clicked = false;
            this.pictureBox3.Location = new System.Drawing.Point(321, 213);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.SelectedCardIndex = 0;
            this.pictureBox3.Size = new System.Drawing.Size(120, 203);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Clicked = false;
            this.pictureBox2.Location = new System.Drawing.Point(180, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.SelectedCardIndex = 0;
            this.pictureBox2.Size = new System.Drawing.Size(120, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Clicked = false;
            this.pictureBox1.Location = new System.Drawing.Point(41, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.SelectedCardIndex = 0;
            this.pictureBox1.Size = new System.Drawing.Size(120, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // firstCardPicture
            // 
            this.firstCardPicture.Clicked = false;
            this.firstCardPicture.Location = new System.Drawing.Point(180, 12);
            this.firstCardPicture.Name = "firstCardPicture";
            this.firstCardPicture.SelectedCardIndex = 0;
            this.firstCardPicture.Size = new System.Drawing.Size(120, 194);
            this.firstCardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstCardPicture.TabIndex = 14;
            this.firstCardPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 450);
            this.Controls.Add(this.firstCardPicture);
            this.Controls.Add(this.nullCardPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.droppedCardPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastCardPictureBox);
            this.Controls.Add(this.buttonDropCards);
            this.Controls.Add(this.drawCardsPicture);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nullCardPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droppedCardPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastCardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawCardsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCardPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Picture_Box pictureBox1;
        private System.Windows.Forms.Button button1;
        private Custom_Picture_Box pictureBox2;
        private Custom_Picture_Box pictureBox3;
        private Custom_Picture_Box pictureBox4;
        private Custom_Picture_Box pictureBox5;
        private Custom_Picture_Box drawCardsPicture;
        private System.Windows.Forms.Button buttonDropCards;
        private Custom_Picture_Box lastCardPictureBox;
        private System.Windows.Forms.Label label1;
        private Custom_Picture_Box droppedCardPicture;
        private System.Windows.Forms.Label label2;
        private Custom_Picture_Box nullCardPicture;
        private Custom_Picture_Box firstCardPicture;
    }
}

