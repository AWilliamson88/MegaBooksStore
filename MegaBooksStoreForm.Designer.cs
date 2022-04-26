
namespace MegaBooksStore
{
    partial class MegaBooksStoreForm
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
            this.components = new System.ComponentModel.Container();
            this.LabelISBN = new System.Windows.Forms.Label();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.LabelBookTitle = new System.Windows.Forms.Label();
            this.LabelPublisher = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.TextBoxISBN = new System.Windows.Forms.TextBox();
            this.TextBoxAuthor = new System.Windows.Forms.TextBox();
            this.TextBoxBookTitle = new System.Windows.Forms.TextBox();
            this.TextBoxPublisher = new System.Windows.Forms.TextBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.TextBoxDate = new System.Windows.Forms.TextBox();
            this.GroupBoxBookInfo = new System.Windows.Forms.GroupBox();
            this.ListBoxBookDisplay = new System.Windows.Forms.ListBox();
            this.ButtonAddBook = new System.Windows.Forms.Button();
            this.GroupBoxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxLocation = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxCustID = new System.Windows.Forms.TextBox();
            this.ContextMenuStripSearch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelCity = new System.Windows.Forms.Label();
            this.LabelFullName = new System.Windows.Forms.Label();
            this.LabelCustID = new System.Windows.Forms.Label();
            this.GroupBoxTransactionInfo = new System.Windows.Forms.GroupBox();
            this.TextBoxTransISBN = new System.Windows.Forms.TextBox();
            this.TextBoxTransCustID = new System.Windows.Forms.TextBox();
            this.TextBoxTransID = new System.Windows.Forms.TextBox();
            this.LabelTransISBN = new System.Windows.Forms.Label();
            this.LabelTransCustID = new System.Windows.Forms.Label();
            this.LabelTransID = new System.Windows.Forms.Label();
            this.LabelBooks = new System.Windows.Forms.Label();
            this.LabelCustomers = new System.Windows.Forms.Label();
            this.LabelTransactions = new System.Windows.Forms.Label();
            this.ListBoxCustomerDisplay = new System.Windows.Forms.ListBox();
            this.ButtonAddCustomer = new System.Windows.Forms.Button();
            this.ButtonAddTransaction = new System.Windows.Forms.Button();
            this.ListBoxTransactionDisplay = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBoxBookInfo.SuspendLayout();
            this.GroupBoxCustomerInfo.SuspendLayout();
            this.ContextMenuStripSearch.SuspendLayout();
            this.GroupBoxTransactionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelISBN
            // 
            this.LabelISBN.AutoSize = true;
            this.LabelISBN.Location = new System.Drawing.Point(24, 30);
            this.LabelISBN.Name = "LabelISBN";
            this.LabelISBN.Size = new System.Drawing.Size(35, 13);
            this.LabelISBN.TabIndex = 0;
            this.LabelISBN.Text = "ISBN:";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.Location = new System.Drawing.Point(18, 56);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(41, 13);
            this.LabelAuthor.TabIndex = 1;
            this.LabelAuthor.Text = "Author:";
            // 
            // LabelBookTitle
            // 
            this.LabelBookTitle.AutoSize = true;
            this.LabelBookTitle.Location = new System.Drawing.Point(1, 82);
            this.LabelBookTitle.Name = "LabelBookTitle";
            this.LabelBookTitle.Size = new System.Drawing.Size(58, 13);
            this.LabelBookTitle.TabIndex = 2;
            this.LabelBookTitle.Text = "Book Title:";
            // 
            // LabelPublisher
            // 
            this.LabelPublisher.AutoSize = true;
            this.LabelPublisher.Location = new System.Drawing.Point(6, 109);
            this.LabelPublisher.Name = "LabelPublisher";
            this.LabelPublisher.Size = new System.Drawing.Size(53, 13);
            this.LabelPublisher.TabIndex = 3;
            this.LabelPublisher.Text = "Publisher:";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(24, 135);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(34, 13);
            this.LabelPrice.TabIndex = 4;
            this.LabelPrice.Text = "Price:";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(24, 161);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(33, 13);
            this.LabelDate.TabIndex = 5;
            this.LabelDate.Text = "Date:";
            // 
            // TextBoxISBN
            // 
            this.TextBoxISBN.Location = new System.Drawing.Point(70, 27);
            this.TextBoxISBN.Name = "TextBoxISBN";
            this.TextBoxISBN.Size = new System.Drawing.Size(100, 20);
            this.TextBoxISBN.TabIndex = 6;
            this.toolTip1.SetToolTip(this.TextBoxISBN, "Double click to clear all book information fields.");
            this.TextBoxISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxISBN_KeyPress);
            this.TextBoxISBN.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxISBN_MouseDoubleClick);
            // 
            // TextBoxAuthor
            // 
            this.TextBoxAuthor.Location = new System.Drawing.Point(70, 53);
            this.TextBoxAuthor.Name = "TextBoxAuthor";
            this.TextBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.TextBoxAuthor.TabIndex = 7;
            this.toolTip1.SetToolTip(this.TextBoxAuthor, "First initial(dot)last name as the format. Eg: A.Cob");
            // 
            // TextBoxBookTitle
            // 
            this.TextBoxBookTitle.Location = new System.Drawing.Point(70, 79);
            this.TextBoxBookTitle.Name = "TextBoxBookTitle";
            this.TextBoxBookTitle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxBookTitle.TabIndex = 8;
            // 
            // TextBoxPublisher
            // 
            this.TextBoxPublisher.Location = new System.Drawing.Point(70, 106);
            this.TextBoxPublisher.Name = "TextBoxPublisher";
            this.TextBoxPublisher.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPublisher.TabIndex = 9;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(70, 132);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPrice.TabIndex = 10;
            this.toolTip1.SetToolTip(this.TextBoxPrice, "The Price will not accept the $ symbol.");
            this.TextBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrice_KeyPress);
            // 
            // TextBoxDate
            // 
            this.TextBoxDate.Location = new System.Drawing.Point(70, 158);
            this.TextBoxDate.Name = "TextBoxDate";
            this.TextBoxDate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDate.TabIndex = 11;
            this.toolTip1.SetToolTip(this.TextBoxDate, "Use this format: 12/05/1998 include the \'/\'.");
            // 
            // GroupBoxBookInfo
            // 
            this.GroupBoxBookInfo.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxBookInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupBoxBookInfo.Controls.Add(this.TextBoxBookTitle);
            this.GroupBoxBookInfo.Controls.Add(this.LabelDate);
            this.GroupBoxBookInfo.Controls.Add(this.TextBoxISBN);
            this.GroupBoxBookInfo.Controls.Add(this.LabelPrice);
            this.GroupBoxBookInfo.Controls.Add(this.TextBoxAuthor);
            this.GroupBoxBookInfo.Controls.Add(this.LabelPublisher);
            this.GroupBoxBookInfo.Controls.Add(this.TextBoxDate);
            this.GroupBoxBookInfo.Controls.Add(this.LabelBookTitle);
            this.GroupBoxBookInfo.Controls.Add(this.TextBoxPublisher);
            this.GroupBoxBookInfo.Controls.Add(this.LabelAuthor);
            this.GroupBoxBookInfo.Controls.Add(this.TextBoxPrice);
            this.GroupBoxBookInfo.Controls.Add(this.LabelISBN);
            this.GroupBoxBookInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupBoxBookInfo.Location = new System.Drawing.Point(31, 69);
            this.GroupBoxBookInfo.Name = "GroupBoxBookInfo";
            this.GroupBoxBookInfo.Size = new System.Drawing.Size(189, 194);
            this.GroupBoxBookInfo.TabIndex = 12;
            this.GroupBoxBookInfo.TabStop = false;
            this.GroupBoxBookInfo.Text = "Book Information";
            // 
            // ListBoxBookDisplay
            // 
            this.ListBoxBookDisplay.FormattingEnabled = true;
            this.ListBoxBookDisplay.Location = new System.Drawing.Point(256, 79);
            this.ListBoxBookDisplay.Name = "ListBoxBookDisplay";
            this.ListBoxBookDisplay.Size = new System.Drawing.Size(215, 316);
            this.ListBoxBookDisplay.TabIndex = 13;
            this.toolTip1.SetToolTip(this.ListBoxBookDisplay, "Click to see book data, double click to delete record.");
            this.ListBoxBookDisplay.SelectedIndexChanged += new System.EventHandler(this.ListBoxBookDisplay_SelectedIndexChanged);
            this.ListBoxBookDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxBookDisplay_MouseDoubleClick);
            // 
            // ButtonAddBook
            // 
            this.ButtonAddBook.Location = new System.Drawing.Point(256, 44);
            this.ButtonAddBook.Name = "ButtonAddBook";
            this.ButtonAddBook.Size = new System.Drawing.Size(215, 23);
            this.ButtonAddBook.TabIndex = 14;
            this.ButtonAddBook.Text = "Add Book";
            this.toolTip1.SetToolTip(this.ButtonAddBook, "All book fields are required.");
            this.ButtonAddBook.UseVisualStyleBackColor = true;
            this.ButtonAddBook.Click += new System.EventHandler(this.ButtonAddBook_Click);
            // 
            // GroupBoxCustomerInfo
            // 
            this.GroupBoxCustomerInfo.Controls.Add(this.TextBoxEmail);
            this.GroupBoxCustomerInfo.Controls.Add(this.TextBoxLocation);
            this.GroupBoxCustomerInfo.Controls.Add(this.TextBoxName);
            this.GroupBoxCustomerInfo.Controls.Add(this.TextBoxCustID);
            this.GroupBoxCustomerInfo.Controls.Add(this.LabelEmail);
            this.GroupBoxCustomerInfo.Controls.Add(this.LabelCity);
            this.GroupBoxCustomerInfo.Controls.Add(this.LabelFullName);
            this.GroupBoxCustomerInfo.Controls.Add(this.LabelCustID);
            this.GroupBoxCustomerInfo.Location = new System.Drawing.Point(496, 62);
            this.GroupBoxCustomerInfo.Name = "GroupBoxCustomerInfo";
            this.GroupBoxCustomerInfo.Size = new System.Drawing.Size(211, 143);
            this.GroupBoxCustomerInfo.TabIndex = 15;
            this.GroupBoxCustomerInfo.TabStop = false;
            this.GroupBoxCustomerInfo.Text = "Customer Information";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(86, 94);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(110, 20);
            this.TextBoxEmail.TabIndex = 7;
            // 
            // TextBoxLocation
            // 
            this.TextBoxLocation.Location = new System.Drawing.Point(86, 68);
            this.TextBoxLocation.Name = "TextBoxLocation";
            this.TextBoxLocation.Size = new System.Drawing.Size(110, 20);
            this.TextBoxLocation.TabIndex = 6;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(86, 42);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(110, 20);
            this.TextBoxName.TabIndex = 5;
            this.toolTip1.SetToolTip(this.TextBoxName, "First initial(dot)last name as the format. Eg: A.Cob");
            // 
            // TextBoxCustID
            // 
            this.TextBoxCustID.ContextMenuStrip = this.ContextMenuStripSearch;
            this.TextBoxCustID.Location = new System.Drawing.Point(86, 19);
            this.TextBoxCustID.Name = "TextBoxCustID";
            this.TextBoxCustID.Size = new System.Drawing.Size(110, 20);
            this.TextBoxCustID.TabIndex = 4;
            this.toolTip1.SetToolTip(this.TextBoxCustID, "Right click to search, double click to clear.");
            this.TextBoxCustID.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxCustID_MouseDoubleClick);
            // 
            // ContextMenuStripSearch
            // 
            this.ContextMenuStripSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSearch});
            this.ContextMenuStripSearch.Name = "ContextMenuStripSearch";
            this.ContextMenuStripSearch.Size = new System.Drawing.Size(179, 26);
            // 
            // ToolStripSearch
            // 
            this.ToolStripSearch.Name = "ToolStripSearch";
            this.ToolStripSearch.Size = new System.Drawing.Size(180, 22);
            this.ToolStripSearch.Text = "Search Customer ID";
            this.ToolStripSearch.Click += new System.EventHandler(this.ToolStripSearch_Click);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(42, 98);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(35, 13);
            this.LabelEmail.TabIndex = 3;
            this.LabelEmail.Text = "Email:";
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.Location = new System.Drawing.Point(50, 72);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(27, 13);
            this.LabelCity.TabIndex = 2;
            this.LabelCity.Text = "City:";
            // 
            // LabelFullName
            // 
            this.LabelFullName.AutoSize = true;
            this.LabelFullName.Location = new System.Drawing.Point(20, 46);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.Size = new System.Drawing.Size(57, 13);
            this.LabelFullName.TabIndex = 1;
            this.LabelFullName.Text = "Full Name:";
            // 
            // LabelCustID
            // 
            this.LabelCustID.AutoSize = true;
            this.LabelCustID.Location = new System.Drawing.Point(32, 23);
            this.LabelCustID.Name = "LabelCustID";
            this.LabelCustID.Size = new System.Drawing.Size(45, 13);
            this.LabelCustID.TabIndex = 0;
            this.LabelCustID.Text = "Cust ID:";
            // 
            // GroupBoxTransactionInfo
            // 
            this.GroupBoxTransactionInfo.Controls.Add(this.TextBoxTransISBN);
            this.GroupBoxTransactionInfo.Controls.Add(this.TextBoxTransCustID);
            this.GroupBoxTransactionInfo.Controls.Add(this.TextBoxTransID);
            this.GroupBoxTransactionInfo.Controls.Add(this.LabelTransISBN);
            this.GroupBoxTransactionInfo.Controls.Add(this.LabelTransCustID);
            this.GroupBoxTransactionInfo.Controls.Add(this.LabelTransID);
            this.GroupBoxTransactionInfo.Location = new System.Drawing.Point(492, 269);
            this.GroupBoxTransactionInfo.Name = "GroupBoxTransactionInfo";
            this.GroupBoxTransactionInfo.Size = new System.Drawing.Size(200, 126);
            this.GroupBoxTransactionInfo.TabIndex = 16;
            this.GroupBoxTransactionInfo.TabStop = false;
            this.GroupBoxTransactionInfo.Text = "Transaction Information";
            // 
            // TextBoxTransISBN
            // 
            this.TextBoxTransISBN.Location = new System.Drawing.Point(94, 83);
            this.TextBoxTransISBN.Name = "TextBoxTransISBN";
            this.TextBoxTransISBN.ReadOnly = true;
            this.TextBoxTransISBN.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTransISBN.TabIndex = 5;
            this.toolTip1.SetToolTip(this.TextBoxTransISBN, "Click on a book in the book display to fill.");
            // 
            // TextBoxTransCustID
            // 
            this.TextBoxTransCustID.Location = new System.Drawing.Point(94, 57);
            this.TextBoxTransCustID.Name = "TextBoxTransCustID";
            this.TextBoxTransCustID.ReadOnly = true;
            this.TextBoxTransCustID.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTransCustID.TabIndex = 4;
            this.toolTip1.SetToolTip(this.TextBoxTransCustID, "Click on a customer in the customer display to fill.");
            // 
            // TextBoxTransID
            // 
            this.TextBoxTransID.Location = new System.Drawing.Point(94, 31);
            this.TextBoxTransID.Name = "TextBoxTransID";
            this.TextBoxTransID.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTransID.TabIndex = 3;
            this.toolTip1.SetToolTip(this.TextBoxTransID, "Double click to clear all.");
            this.TextBoxTransID.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxTransID_MouseDoubleClick);
            // 
            // LabelTransISBN
            // 
            this.LabelTransISBN.AutoSize = true;
            this.LabelTransISBN.Location = new System.Drawing.Point(44, 87);
            this.LabelTransISBN.Name = "LabelTransISBN";
            this.LabelTransISBN.Size = new System.Drawing.Size(35, 13);
            this.LabelTransISBN.TabIndex = 2;
            this.LabelTransISBN.Text = "ISBN:";
            // 
            // LabelTransCustID
            // 
            this.LabelTransCustID.AutoSize = true;
            this.LabelTransCustID.Location = new System.Drawing.Point(34, 61);
            this.LabelTransCustID.Name = "LabelTransCustID";
            this.LabelTransCustID.Size = new System.Drawing.Size(45, 13);
            this.LabelTransCustID.TabIndex = 1;
            this.LabelTransCustID.Text = "Cust ID:";
            // 
            // LabelTransID
            // 
            this.LabelTransID.AutoSize = true;
            this.LabelTransID.Location = new System.Drawing.Point(28, 35);
            this.LabelTransID.Name = "LabelTransID";
            this.LabelTransID.Size = new System.Drawing.Size(51, 13);
            this.LabelTransID.TabIndex = 0;
            this.LabelTransID.Text = "Trans ID:";
            // 
            // LabelBooks
            // 
            this.LabelBooks.AutoSize = true;
            this.LabelBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBooks.Location = new System.Drawing.Point(260, 9);
            this.LabelBooks.Name = "LabelBooks";
            this.LabelBooks.Size = new System.Drawing.Size(90, 31);
            this.LabelBooks.TabIndex = 17;
            this.LabelBooks.Text = "Books";
            // 
            // LabelCustomers
            // 
            this.LabelCustomers.AutoSize = true;
            this.LabelCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomers.Location = new System.Drawing.Point(530, 28);
            this.LabelCustomers.Name = "LabelCustomers";
            this.LabelCustomers.Size = new System.Drawing.Size(146, 31);
            this.LabelCustomers.TabIndex = 18;
            this.LabelCustomers.Text = "Customers";
            // 
            // LabelTransactions
            // 
            this.LabelTransactions.AutoSize = true;
            this.LabelTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTransactions.Location = new System.Drawing.Point(505, 230);
            this.LabelTransactions.Name = "LabelTransactions";
            this.LabelTransactions.Size = new System.Drawing.Size(171, 31);
            this.LabelTransactions.TabIndex = 19;
            this.LabelTransactions.Text = "Transactions";
            // 
            // ListBoxCustomerDisplay
            // 
            this.ListBoxCustomerDisplay.FormattingEnabled = true;
            this.ListBoxCustomerDisplay.Location = new System.Drawing.Point(747, 71);
            this.ListBoxCustomerDisplay.Name = "ListBoxCustomerDisplay";
            this.ListBoxCustomerDisplay.Size = new System.Drawing.Size(230, 134);
            this.ListBoxCustomerDisplay.TabIndex = 20;
            this.toolTip1.SetToolTip(this.ListBoxCustomerDisplay, "Click to see customer data, double click to delete record.");
            this.ListBoxCustomerDisplay.SelectedIndexChanged += new System.EventHandler(this.ListBoxCustomerDisplay_SelectedIndexChanged);
            this.ListBoxCustomerDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxCustomerDisplay_MouseDoubleClick);
            // 
            // ButtonAddCustomer
            // 
            this.ButtonAddCustomer.Location = new System.Drawing.Point(747, 35);
            this.ButtonAddCustomer.Name = "ButtonAddCustomer";
            this.ButtonAddCustomer.Size = new System.Drawing.Size(230, 23);
            this.ButtonAddCustomer.TabIndex = 21;
            this.ButtonAddCustomer.Text = "Add Customer";
            this.toolTip1.SetToolTip(this.ButtonAddCustomer, "Leave any cutomer fields blank to create default customer.");
            this.ButtonAddCustomer.UseVisualStyleBackColor = true;
            this.ButtonAddCustomer.Click += new System.EventHandler(this.ButtonAddCustomer_Click);
            // 
            // ButtonAddTransaction
            // 
            this.ButtonAddTransaction.Location = new System.Drawing.Point(747, 227);
            this.ButtonAddTransaction.Name = "ButtonAddTransaction";
            this.ButtonAddTransaction.Size = new System.Drawing.Size(230, 23);
            this.ButtonAddTransaction.TabIndex = 22;
            this.ButtonAddTransaction.Text = "Add Transaction";
            this.toolTip1.SetToolTip(this.ButtonAddTransaction, "All transaction fields are required.");
            this.ButtonAddTransaction.UseVisualStyleBackColor = true;
            this.ButtonAddTransaction.Click += new System.EventHandler(this.ButtonAddTransaction_Click);
            // 
            // ListBoxTransactionDisplay
            // 
            this.ListBoxTransactionDisplay.FormattingEnabled = true;
            this.ListBoxTransactionDisplay.Location = new System.Drawing.Point(747, 262);
            this.ListBoxTransactionDisplay.Name = "ListBoxTransactionDisplay";
            this.ListBoxTransactionDisplay.Size = new System.Drawing.Size(229, 147);
            this.ListBoxTransactionDisplay.TabIndex = 23;
            this.toolTip1.SetToolTip(this.ListBoxTransactionDisplay, "Click to see transaction data, double click to delete record.");
            this.ListBoxTransactionDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxTransactionDisplay_MouseClick);
            this.ListBoxTransactionDisplay.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxTransactionDisplay_MouseDoubleClick);
            // 
            // MegaBooksStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.ListBoxTransactionDisplay);
            this.Controls.Add(this.ButtonAddTransaction);
            this.Controls.Add(this.ButtonAddCustomer);
            this.Controls.Add(this.ListBoxCustomerDisplay);
            this.Controls.Add(this.LabelTransactions);
            this.Controls.Add(this.LabelCustomers);
            this.Controls.Add(this.LabelBooks);
            this.Controls.Add(this.GroupBoxTransactionInfo);
            this.Controls.Add(this.GroupBoxCustomerInfo);
            this.Controls.Add(this.ButtonAddBook);
            this.Controls.Add(this.ListBoxBookDisplay);
            this.Controls.Add(this.GroupBoxBookInfo);
            this.Name = "MegaBooksStoreForm";
            this.Text = "MegaBooks Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MegaBooksStoreForm_FormClosing);
            this.Load += new System.EventHandler(this.MegaBooksStoreForm_Load);
            this.GroupBoxBookInfo.ResumeLayout(false);
            this.GroupBoxBookInfo.PerformLayout();
            this.GroupBoxCustomerInfo.ResumeLayout(false);
            this.GroupBoxCustomerInfo.PerformLayout();
            this.ContextMenuStripSearch.ResumeLayout(false);
            this.GroupBoxTransactionInfo.ResumeLayout(false);
            this.GroupBoxTransactionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelISBN;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.Label LabelBookTitle;
        private System.Windows.Forms.Label LabelPublisher;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.TextBox TextBoxISBN;
        private System.Windows.Forms.TextBox TextBoxAuthor;
        private System.Windows.Forms.TextBox TextBoxBookTitle;
        private System.Windows.Forms.TextBox TextBoxPublisher;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.TextBox TextBoxDate;
        private System.Windows.Forms.GroupBox GroupBoxBookInfo;
        private System.Windows.Forms.ListBox ListBoxBookDisplay;
        private System.Windows.Forms.Button ButtonAddBook;
        private System.Windows.Forms.GroupBox GroupBoxCustomerInfo;
        private System.Windows.Forms.GroupBox GroupBoxTransactionInfo;
        private System.Windows.Forms.Label LabelBooks;
        private System.Windows.Forms.Label LabelCustomers;
        private System.Windows.Forms.Label LabelTransactions;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxLocation;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxCustID;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelCity;
        private System.Windows.Forms.Label LabelFullName;
        private System.Windows.Forms.Label LabelCustID;
        private System.Windows.Forms.TextBox TextBoxTransISBN;
        private System.Windows.Forms.TextBox TextBoxTransCustID;
        private System.Windows.Forms.TextBox TextBoxTransID;
        private System.Windows.Forms.Label LabelTransISBN;
        private System.Windows.Forms.Label LabelTransCustID;
        private System.Windows.Forms.Label LabelTransID;
        private System.Windows.Forms.ListBox ListBoxCustomerDisplay;
        private System.Windows.Forms.Button ButtonAddCustomer;
        private System.Windows.Forms.Button ButtonAddTransaction;
        private System.Windows.Forms.ListBox ListBoxTransactionDisplay;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripSearch;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSearch;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

