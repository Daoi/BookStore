namespace BookStore
{
    partial class frmMain
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBNNumLookUp = new System.Windows.Forms.MaskedTextBox();
            this.btnISBNSearch = new System.Windows.Forms.Button();
            this.lblSelectATrans = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.lblCurrentBook = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblISBNumberText = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblOnHand = new System.Windows.Forms.Label();
            this.lblTransDate = new System.Windows.Forms.Label();
            this.txtISBNNumInfo = new System.Windows.Forms.MaskedTextBox();
            this.txtTitleInfo = new System.Windows.Forms.TextBox();
            this.txtAuthorInfo = new System.Windows.Forms.TextBox();
            this.txtOnHandInfo = new System.Windows.Forms.TextBox();
            this.txtPriceInfo = new System.Windows.Forms.TextBox();
            this.txtDateInfo = new System.Windows.Forms.TextBox();
            this.btnExitSys = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(276, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(294, 31);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Book Inventory System";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(47, 91);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(324, 25);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "Enter the ISBN for book (###-###):  ";
            // 
            // txtISBNNumLookUp
            // 
            this.txtISBNNumLookUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBNNumLookUp.Location = new System.Drawing.Point(377, 91);
            this.txtISBNNumLookUp.Name = "txtISBNNumLookUp";
            this.txtISBNNumLookUp.Size = new System.Drawing.Size(87, 29);
            this.txtISBNNumLookUp.TabIndex = 4;
            // 
            // btnISBNSearch
            // 
            this.btnISBNSearch.Location = new System.Drawing.Point(481, 92);
            this.btnISBNSearch.Name = "btnISBNSearch";
            this.btnISBNSearch.Size = new System.Drawing.Size(75, 23);
            this.btnISBNSearch.TabIndex = 5;
            this.btnISBNSearch.Text = "Search";
            this.btnISBNSearch.UseVisualStyleBackColor = true;
            this.btnISBNSearch.Click += new System.EventHandler(this.btnISBNSearch_Click);
            // 
            // lblSelectATrans
            // 
            this.lblSelectATrans.AutoSize = true;
            this.lblSelectATrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectATrans.Location = new System.Drawing.Point(325, 144);
            this.lblSelectATrans.Name = "lblSelectATrans";
            this.lblSelectATrans.Size = new System.Drawing.Size(183, 25);
            this.lblSelectATrans.TabIndex = 6;
            this.lblSelectATrans.Text = "Select a transaction";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(351, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(60, 24);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "label1";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(282, 172);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(267, 36);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "Add a New Book to Inventory";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.Location = new System.Drawing.Point(282, 215);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(267, 36);
            this.btnUpdateBook.TabIndex = 9;
            this.btnUpdateBook.Text = "Update a Book in Inventory";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Location = new System.Drawing.Point(282, 258);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(267, 36);
            this.btnDeleteBook.TabIndex = 10;
            this.btnDeleteBook.Text = "Delete a Book From Inventory";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // lblCurrentBook
            // 
            this.lblCurrentBook.AutoSize = true;
            this.lblCurrentBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBook.Location = new System.Drawing.Point(73, 359);
            this.lblCurrentBook.Name = "lblCurrentBook";
            this.lblCurrentBook.Size = new System.Drawing.Size(160, 24);
            this.lblCurrentBook.TabIndex = 11;
            this.lblCurrentBook.Text = "Current Book Info:";
            // 
            // lblISBNumberText
            // 
            this.lblISBNumberText.AutoSize = true;
            this.lblISBNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBNumberText.Location = new System.Drawing.Point(48, 412);
            this.lblISBNumberText.Name = "lblISBNumberText";
            this.lblISBNumberText.Size = new System.Drawing.Size(51, 20);
            this.lblISBNumberText.TabIndex = 11;
            this.lblISBNumberText.Text = "ISBN:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(48, 451);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 20);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title: ";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(48, 486);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(65, 20);
            this.lblAuthor.TabIndex = 13;
            this.lblAuthor.Text = "Author: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(393, 418);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 20);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price: ";
            // 
            // lblOnHand
            // 
            this.lblOnHand.AutoSize = true;
            this.lblOnHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnHand.Location = new System.Drawing.Point(393, 451);
            this.lblOnHand.Name = "lblOnHand";
            this.lblOnHand.Size = new System.Drawing.Size(77, 20);
            this.lblOnHand.TabIndex = 15;
            this.lblOnHand.Text = "On Hand:";
            // 
            // lblTransDate
            // 
            this.lblTransDate.AutoSize = true;
            this.lblTransDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransDate.Location = new System.Drawing.Point(393, 486);
            this.lblTransDate.Name = "lblTransDate";
            this.lblTransDate.Size = new System.Drawing.Size(135, 20);
            this.lblTransDate.TabIndex = 16;
            this.lblTransDate.Text = "Transaction Date:";
            // 
            // txtISBNNumInfo
            // 
            this.txtISBNNumInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBNNumInfo.Location = new System.Drawing.Point(125, 411);
            this.txtISBNNumInfo.Name = "txtISBNNumInfo";
            this.txtISBNNumInfo.Size = new System.Drawing.Size(100, 23);
            this.txtISBNNumInfo.TabIndex = 17;
            // 
            // txtTitleInfo
            // 
            this.txtTitleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleInfo.Location = new System.Drawing.Point(125, 450);
            this.txtTitleInfo.Name = "txtTitleInfo";
            this.txtTitleInfo.Size = new System.Drawing.Size(246, 23);
            this.txtTitleInfo.TabIndex = 18;
            // 
            // txtAuthorInfo
            // 
            this.txtAuthorInfo.Location = new System.Drawing.Point(125, 485);
            this.txtAuthorInfo.Name = "txtAuthorInfo";
            this.txtAuthorInfo.Size = new System.Drawing.Size(246, 20);
            this.txtAuthorInfo.TabIndex = 19;
            // 
            // txtOnHandInfo
            // 
            this.txtOnHandInfo.Location = new System.Drawing.Point(552, 452);
            this.txtOnHandInfo.Name = "txtOnHandInfo";
            this.txtOnHandInfo.Size = new System.Drawing.Size(100, 20);
            this.txtOnHandInfo.TabIndex = 21;
            // 
            // txtPriceInfo
            // 
            this.txtPriceInfo.Location = new System.Drawing.Point(552, 420);
            this.txtPriceInfo.Name = "txtPriceInfo";
            this.txtPriceInfo.Size = new System.Drawing.Size(100, 20);
            this.txtPriceInfo.TabIndex = 23;
            // 
            // txtDateInfo
            // 
            this.txtDateInfo.Location = new System.Drawing.Point(552, 485);
            this.txtDateInfo.Name = "txtDateInfo";
            this.txtDateInfo.Size = new System.Drawing.Size(100, 20);
            this.txtDateInfo.TabIndex = 24;
            // 
            // btnExitSys
            // 
            this.btnExitSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSys.Location = new System.Drawing.Point(336, 536);
            this.btnExitSys.Name = "btnExitSys";
            this.btnExitSys.Size = new System.Drawing.Size(75, 26);
            this.btnExitSys.TabIndex = 25;
            this.btnExitSys.Text = "Exit";
            this.btnExitSys.UseVisualStyleBackColor = true;
            this.btnExitSys.Click += new System.EventHandler(this.btnExitSys_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 625);
            this.Controls.Add(this.btnExitSys);
            this.Controls.Add(this.txtDateInfo);
            this.Controls.Add(this.txtPriceInfo);
            this.Controls.Add(this.txtOnHandInfo);
            this.Controls.Add(this.txtAuthorInfo);
            this.Controls.Add(this.txtTitleInfo);
            this.Controls.Add(this.txtISBNNumInfo);
            this.Controls.Add(this.lblTransDate);
            this.Controls.Add(this.lblOnHand);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblISBNumberText);
            this.Controls.Add(this.lblCurrentBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblSelectATrans);
            this.Controls.Add(this.btnISBNSearch);
            this.Controls.Add(this.txtISBNNumLookUp);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmMain";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.MaskedTextBox txtISBNNumLookUp;
        private System.Windows.Forms.Button btnISBNSearch;
        private System.Windows.Forms.Label lblSelectATrans;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Label lblCurrentBook;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblISBNumberText;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblOnHand;
        private System.Windows.Forms.Label lblTransDate;
        private System.Windows.Forms.MaskedTextBox txtISBNNumInfo;
        private System.Windows.Forms.TextBox txtTitleInfo;
        private System.Windows.Forms.TextBox txtAuthorInfo;
        private System.Windows.Forms.TextBox txtOnHandInfo;
        private System.Windows.Forms.TextBox txtPriceInfo;
        private System.Windows.Forms.TextBox txtDateInfo;
        private System.Windows.Forms.Button btnExitSys;
    }
}