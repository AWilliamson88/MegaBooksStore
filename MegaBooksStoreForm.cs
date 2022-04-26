using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Andrew Williamson / P113357.
// Date Started: 09/06/2021.
// Date Finished: 17/06/2021.
namespace MegaBooksStore
{
    public partial class MegaBooksStoreForm : Form
    {

        public MegaBooksStoreForm()
        {
            InitializeComponent();
        }

        // Global variables.
        // 
        // The maximum size of the 3 arrays.
        static int arrayMax = 20;
        // The size of the second dimention of the transaction array.
        static int maxTData = 3;
        // The arrays for the transactions books and customers.
        Book[] bookArray = new Book[arrayMax];
        Customer[] customerArray = new Customer[arrayMax];
        string[,] transactionArray = new string[arrayMax, maxTData];
        // Counters to keep track of the next empty element for the arrays.
        private int bookPtr = 0;
        private int customerPtr = 0;
        private int transactionPtr = 0;
        // The file names to save the arrays to.
        string booksFile = "books.dat";
        string customersFile = "customers.dat";
        string transactionFile = "transactions.dat";


        // When the program starts it loads the three files into their respective arrays.
        private void MegaBooksStoreForm_Load(object sender, EventArgs e)
        {
            LoadBooksFile();
            LoadTransactionsFile();
            LoadCustomersFile();
        }
        // When the program ends it saves all the arrays into different binary files.
        private void MegaBooksStoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveBookArray();
            SaveCustomerArray();
            SaveTransactionArray();

        }

        #region Book

        // Adds the data in the book textboxes into the array if the data is valid. Includes error trapping.
        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            // IF the book array has no room left show error message.
            // IF the array still has room check if all the text boxes have the correct data. Ref TextBox_KeyPress().
            // If the first two are true add book into the array.
            if (bookPtr >= arrayMax)
            {
                MessageBox.Show("You have reached the maximum number of books.");
                //ClearTextBoxes();
            }
            else if (string.IsNullOrEmpty(TextBoxISBN.Text) ||
                    string.IsNullOrEmpty(TextBoxAuthor.Text) ||
                    string.IsNullOrEmpty(TextBoxBookTitle.Text) ||
                    string.IsNullOrEmpty(TextBoxPublisher.Text) ||
                    string.IsNullOrEmpty(TextBoxPrice.Text) ||
                    string.IsNullOrEmpty(TextBoxDate.Text))
            {
                MessageBox.Show("Please fill in all the book details and try again.");
            }
            else
            {
                Book AddBook = new Book();
                AddBook.SetISBN(int.Parse(TextBoxISBN.Text));
                AddBook.SetAuthor(TextBoxAuthor.Text);
                AddBook.SetTitle(TextBoxBookTitle.Text);
                AddBook.SetPublisher(TextBoxPublisher.Text);
                AddBook.SetPrice(double.Parse(TextBoxPrice.Text));
                AddBook.SetDate(TextBoxDate.Text);
                bookArray[bookPtr] = AddBook;
                bookPtr++;
                ClearBookTextBoxes();
                SortBooks();
                DisplayBooks();
            }
        }

        // Display the books from the array in the Book listbox. 
        private void DisplayBooks()
        {
            // Clear the display.
            ListBoxBookDisplay.Items.Clear();
            
            // Iterate through the array and add them to the listbox.
            for (int i = 0; i < bookPtr; i++)
            {
                Book b = bookArray[i];
                ListBoxBookDisplay.Items.Add(b.DisplayBook());
            }
        }

        // Sorts the bookArray by titles in ascending order. Calls the SwapBooks().
        private void SortBooks()
        {
            // Variable for j + 1
            int jPlus;
            // Checks the the books in the array are in ascending order by title and calls the SwapBooks() if not.
            for (int i = 1; i < bookPtr; i++)
            {
                for (int j = 0; j < bookPtr - 1; j++)
                {
                    jPlus = j + 1;
                    if (bookArray[j] == null ||
                        (bookArray[jPlus] != null && bookArray[j].GetTitle().CompareTo(bookArray[jPlus].GetTitle()) > 0))
                    {
                        SwapBooks(j, jPlus);
                    }
                }
            }
        }
        // Swaps the book objects in the myBooks array as called by the SortBooks().
        private void SwapBooks(int j, int jPlus)
        {
            Book tempBook = bookArray[j];
            bookArray[j] = bookArray[jPlus];
            bookArray[jPlus] = tempBook;
        }

        // Clears the book text boxes and sets the focus to the isbn text box.
        private void ClearBookTextBoxes()
        {
            TextBoxISBN.Clear();
            TextBoxAuthor.Clear();
            TextBoxBookTitle.Clear();
            TextBoxPublisher.Clear();
            TextBoxPrice.Clear();
            TextBoxDate.Clear();
            TextBoxTransISBN.Clear();
            TextBoxISBN.Focus();
        }

        // Clears the book text boxes and the selected item in the display  when the ISBN text box is double clicked.
        private void TextBoxISBN_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClearBookTextBoxes();
            ListBoxBookDisplay.ClearSelected();
        }

        // When the item selected in the book list box changes add its detail into the text boxes.
        private void ListBoxBookDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the idex of the currently selected item.
            int index = ListBoxBookDisplay.SelectedIndex;

            // IF the index is valid add it's data into the text boxes.
            if (index >= 0)
            {
                TextBoxISBN.Text = bookArray[index].GetISBN().ToString();
                TextBoxTransISBN.Text = bookArray[index].GetISBN().ToString();
                TextBoxAuthor.Text = bookArray[index].GetAuthor();
                TextBoxBookTitle.Text = bookArray[index].GetTitle();
                TextBoxPublisher.Text = bookArray[index].GetPublisher();
                TextBoxPrice.Text = bookArray[index].GetPrice().ToString();
                TextBoxDate.Text = bookArray[index].GetDate();
            }
        }

        // Loads the file from the books.dat binary file into the array. Called by the Form_Load().
        private void LoadBooksFile()
        {
            // reset the book counter.
            bookPtr = 0;

            // Tries to read the binary books.dat file and load it into the books array.
            // On fail provide an error message.
            try
            {
                using (Stream stream = File.Open(booksFile, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    while (stream.Position < stream.Length)
                    {
                        bookArray[bookPtr] = (Book)bin.Deserialize(stream);
                        bookPtr++;
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Failed to open file.\nPlease contact technical support.");
            }
            // Display the books in the listbox.
            DisplayBooks();
        }

        // Saves the bookArray into a binary file when the program is closing. Called by the Form_Closing().
        private void SaveBookArray()
        {
            // tries to save the booksArray into a binary file and provides an error message if it fails.
            try
            {
                using (Stream stream = File.Open(booksFile, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    for (int i = 0; i < bookPtr; i++)
                    {
                        bin.Serialize(stream, bookArray[i]);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Failed to save file.\nPlease contact technical support.");
            }
        }

        // Method to limit the ISBN text box to numbers only.
        private void TextBoxISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Limit the Price text box to numbers and a single dot.
        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && TextBoxPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                !(e.KeyChar == (char) '.'))
            {
                e.Handled = true;
            }
        }

        // Double click a record in the book display to delete it.
        private void ListBoxBookDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListBoxBookDisplay.SelectedIndex != -1)
            {
                DialogResult delRecord = MessageBox.Show(
                "Delete Record?", "Delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (delRecord == DialogResult.OK)
                {
                    int curItem = ListBoxBookDisplay.SelectedIndex;
                    bookArray[curItem] = null;
                    ClearAllTextBoxes();
                    SortBooks();
                    bookPtr--;
                    DisplayBooks();
                }
            }

        }

        #endregion

        #region Customer

        // If the data in the customer Textboxes passes validation it gets added into the customersArray.
        private void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            // IF there is no room in the array, provides an error message.
            // IF any of the textboxes are not filled data, Ask if they want to enter a default.
            // Else add the data in the textboxes into the array.
            if (customerPtr > arrayMax)
            {
                MessageBox.Show("You have reached the maximum number of customerss.");
            }
            else if (string.IsNullOrEmpty(TextBoxCustID.Text) ||
                    string.IsNullOrEmpty(TextBoxName.Text) ||
                    string.IsNullOrEmpty(TextBoxLocation.Text) ||
                    string.IsNullOrEmpty(TextBoxEmail.Text))
            {
                DialogResult result = MessageBox.Show("Would you like to enter in a default customer?",
                                "No customer details",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Customer AddUnkownCustomer = new Customer();
                    customerArray[customerPtr] = AddUnkownCustomer;
                    customerPtr++;
                    ClearCustomerTextBoxes();
                }
            }
            else
            {
                Customer AddCustomer = new Customer(TextBoxCustID.Text,
                                                    TextBoxName.Text,
                                                    TextBoxLocation.Text,
                                                    TextBoxEmail.Text);
                customerArray[customerPtr] = AddCustomer;
                customerPtr++;
                ClearCustomerTextBoxes();
            }
            // Sort and display the array and clear the text boxes.
            SortCustomers();
            DisplayCustomers();
            

        }
        // Display all the customers in the customerArray in the customer listbox. 
        // Called by the AddCustomer() and LoadCustomersFile()
        private void DisplayCustomers()
        {
            // Clear the cutomers listbox.
            ListBoxCustomerDisplay.Items.Clear();

            // Iterate through the array and display the customers into the list box.
            for (int i = 0; i < customerPtr; i++)
            {
                ListBoxCustomerDisplay.Items.Add(customerArray[i].DisplayOneCustomer());
            }

        }

        // Checks IF the customers in the customerArray are in order and calls swapCustomers() if not.
        private void SortCustomers()
        {
            for (int i = 1; i < customerPtr; i++)
            {
                for (int j = 0; j < customerPtr - 1; j++)
                {

                    if (customerArray[j] == null || 
                        customerArray[j + 1] != null && 
                        (customerArray[j].GetCustID().CompareTo(customerArray[j + 1].GetCustID()) > 0))
                    {
                        int jPlus = j + 1;
                        SwapCustomers(j, jPlus);
                    }
                }
            }
        }
        // This method swaps the customer object in the customerArray. Called by SortCustomers().
        private void SwapCustomers(int j, int jPlus)
        {
            Customer tempCustomer = customerArray[j];
            customerArray[j] = customerArray[jPlus];
            customerArray[jPlus] = tempCustomer;
        }

        // Clears all customer textboxes and the transaction custID text box. Called by multiple methods.
        private void ClearCustomerTextBoxes()
        {
            TextBoxCustID.Clear();
            TextBoxName.Clear();
            TextBoxLocation.Clear();
            TextBoxEmail.Clear();
            TextBoxTransCustID.Clear();
            TextBoxCustID.Focus();
        }

        // Clears the customer text boxes and the listbox selected when the CustID text box is double clicked.
        private void TextBoxCustID_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClearCustomerTextBoxes();
            ListBoxCustomerDisplay.ClearSelected();
        }

        // IF the ID in the custID text box is valid searches for the customer in the customerArray. 
        // Provides error message if no match or no cust id to search for.
        private void ToolStripSearch_Click(object sender, EventArgs e)
        {
            // Get the id to search for.
            String search = TextBoxCustID.Text;

            // IF the id is not valid provide a error message. 
            // ELSE binary search the customerArray for the id.

            if (String.IsNullOrEmpty(search))
            {
                MessageBox.Show("Please fill in a customer ID to search for.",
                                "No Customer ID",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                int found = -1;
                int min = 0;
                int max = customerPtr - 1;
                while (min <= max)
                {
                    int mid = ((min + max) / 2);
                    if (search.CompareTo(customerArray[mid].GetCustID()) == 0)
                    {
                        found = mid;
                        break;
                    }
                    else if (search.CompareTo(customerArray[mid].GetCustID()) < 0)
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
                // IF the id is not found display message. If found select item in list box. Ref CustomerDisplay_SelectemIndexChanged().
                if (found == -1)
                {
                    MessageBox.Show("Customer was not found..",
                                "Search Result",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
                else
                {
                    ListBoxCustomerDisplay.ClearSelected();
                    ListBoxCustomerDisplay.SelectedIndex = found;
                }
            }
        }

        // When the item selected in the customer list box changes, add its detail into the text boxes.
        private void ListBoxCustomerDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the idex of the currently selected item.
            int index = ListBoxCustomerDisplay.SelectedIndex;

            // IF the index is valid add the data into the text boxes.
            if (index >= 0)
            {
                TextBoxCustID.Text = customerArray[index].GetCustID();
                TextBoxTransCustID.Text = customerArray[index].GetCustID();
                TextBoxName.Text = customerArray[index].GetName();
                TextBoxLocation.Text = customerArray[index].GetLocation();
                TextBoxEmail.Text = customerArray[index].GetEmail();
            }
        }

        // Saves the customerArray into a binary file "customers.dat", provides an error message on fail.
        // Called by the Form_Closing().
        private void SaveCustomerArray()
        {
            try
            {
                using (Stream stream = File.Open(customersFile, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    for (int i = 0; i < customerPtr; i++)
                    {
                        bin.Serialize(stream, customerArray[i]);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Failed to save Customers file.\nPlease contact technical support.");
            }
        }

        
        // Loads the customers.dat file into the customers array when the program starts. 
        // Provides an error message on fail. Called by Form_Load().
        private void LoadCustomersFile()
        {
            try
            {
                using (Stream stream = File.Open(customersFile, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    while (stream.Position < stream.Length)
                    {
                        customerArray[customerPtr] = (Customer)bin.Deserialize(stream);
                        customerPtr++;
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Failed to open customers file.\nPlease contact technical support.");
            }
            DisplayCustomers();
        }

        // Double click a record in the customer display to delete it.
        private void ListBoxCustomerDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListBoxCustomerDisplay.SelectedIndex != -1)
            {
                DialogResult delRecord = MessageBox.Show(
                "Are you sure you want to delete Record?", "Delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (delRecord == DialogResult.OK)
                {
                    int curItem = ListBoxCustomerDisplay.SelectedIndex;
                    customerArray[curItem] = null;
                    ClearCustomerTextBoxes();
                    SortCustomers();
                    customerPtr--;
                    DisplayCustomers();
                }
            }
        }

        #endregion

        #region Transaction

        // Method to add a new valid transaction into the transactionarray.
        private void ButtonAddTransaction_Click(object sender, EventArgs e)
        {
            // IF there is no room in the array provide error message.
            // IF the data in the textboxes is not valid, provide an error message.
            // ELSE add the transaction into the array. and call the sort, display and clear methods.
            if (transactionPtr >= arrayMax)
            {
                MessageBox.Show("Cannot hold anymore transactions", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (String.IsNullOrEmpty(TextBoxTransID.Text) ||
                    String.IsNullOrEmpty(TextBoxTransCustID.Text) ||
                    String.IsNullOrEmpty(TextBoxTransISBN.Text))
            {
                MessageBox.Show("Please make sure all text boxes have data", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                transactionArray[transactionPtr, 0] = TextBoxTransID.Text;
                transactionArray[transactionPtr, 1] = TextBoxTransCustID.Text;
                transactionArray[transactionPtr, 2] = TextBoxTransISBN.Text;
                transactionPtr++;
                SortTransactions();
                DisplayTransactions();
                ClearAllTextBoxes();
            }

        }

        // Checks if the transactionArray is ordered by transactionID. Calls the sortTransactions() if not.
        private void SortTransactions()
        {
            for (int i = 1; i < transactionPtr; i++)
            {
                for (int j = 0; j < transactionPtr - 1; j++)
                {
                    if (transactionArray[j, 0] == "" ||
                        transactionArray[j + 1, 0] != "" && 
                        String.Compare(transactionArray[j, 0], transactionArray[j + 1, 0]) > 0)
                    {
                        SwapTransactions(j);
                    }
                }
            }
        }
        // Swaps the transactions around to order them. Called by the SortTransactions().
        private void SwapTransactions(int row)
        {
            for (int col = 0; col < maxTData; col++)
            {
                String temp = transactionArray[row, col];
                transactionArray[row, col] = transactionArray[row + 1, col];
                transactionArray[row + 1, col] = temp;
            }
        }

        // Displays the transactions from the array in the listbox. Called by the AddTransaction and LoadTransactions methods.
        private void DisplayTransactions()
        {
            // Clear the transaction list box
            ListBoxTransactionDisplay.Items.Clear();

            // Iterate through the transactionArray and add them to the list box.
            for (int i = 0; i < transactionPtr; i++)
            {
                ListBoxTransactionDisplay.Items.Add(transactionArray[i, 0] + "\t"
                                                    + transactionArray[i, 1] + "\t"
                                                    + transactionArray[i, 2]);
            }
        }

        // Clears the transactions textboxes and selected index and puts focus onto the TransID textbox.
        private void ClearTransactionTextBoxes()
        {
            TextBoxTransID.Clear();
            TextBoxTransCustID.Clear();
            TextBoxTransISBN.Clear();
            TextBoxTransID.Focus();

            ListBoxTransactionDisplay.ClearSelected();
        }

        // Saves the transactionArray into a binary file called "transactions.dat". Provides an error message on fail.
        // Called by the Form_Closing().
        private void SaveTransactionArray()
        {
            try
            {
                using (Stream stream = File.Open(transactionFile, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    for (int i = 0; i < transactionPtr; i++)
                    {
                        string oneTransaction = transactionArray[i, 0] + "," +
                                                        transactionArray[i, 1] + "," +
                                                        transactionArray[i, 2];
                        bin.Serialize(stream, oneTransaction);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Failed to save transaction file.\nPlease contact technical support.");
            }
        }

        // Loads the transactions from the "transactions.dat" file into the transactionArray. 
        // Provides an error message on fail. Called by the Form_Loading().
        private void LoadTransactionsFile()
        {
            try
            {
                using (Stream stream = File.Open(transactionFile, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    while (stream.Position < stream.Length)
                    {
                        String oneTransaction = bin.Deserialize(stream).ToString();
                        String[] transRecord = oneTransaction.Split(',');
                        transactionArray[transactionPtr, 0] = transRecord[0];
                        transactionArray[transactionPtr, 1] = transRecord[1];
                        transactionArray[transactionPtr, 2] = transRecord[2];
                        transactionPtr++;
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Failed to open transaction file.\nPlease contact technical support.");
            }
            DisplayTransactions();
        }

        // Clears the Transaction text boxes and deselects any items in the list box when the transaction textbox is double clicked.
        private void TextBoxTransID_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClearAllTextBoxes();
            
        }

        // When a record in the tranaction listbox is clicked it populates the transaction textboxes with the appropriate data.
        // At the same time is highlights the correct book and customer in their list boxes and populates their text boxes. 
        private void ListBoxTransactionDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the index/location of the selected transaction.
            int index = ListBoxTransactionDisplay.SelectedIndex;

            // IF the index is valid select items and fill textboxes. 
            // Deselects and book and customer listbox items and calls ClearAllTextBoxes() on fail
            if (index >= 0)
            {
                // Fill tranascation text boxes.
                TextBoxTransID.Text = transactionArray[index, 0];
                TextBoxTransCustID.Text = transactionArray[index, 1];
                TextBoxTransISBN.Text = transactionArray[index, 2];

                // Get the index for the correct customer and book
                int custIndex = ListBoxCustomerDisplay.FindString(TextBoxTransCustID.Text);
                int bookIndex = ListBoxBookDisplay.FindString(TextBoxTransISBN.Text);

                // IF the customer index is valid select item in listBox. Ref CustomerDisplay_SelectedIndexChanged().
                if (custIndex >= 0)
                {
                    ListBoxCustomerDisplay.ClearSelected();
                    ListBoxCustomerDisplay.SelectedIndex = custIndex;
                }
                // IF the Book index is valid select item in the list box. Ref BookDisplay_SelectedIndexChanged().
                if (bookIndex >= 0)
                {
                    ListBoxBookDisplay.ClearSelected();
                    ListBoxBookDisplay.SelectedIndex = bookIndex;
                }
            }
            else
            {
                ClearAllTextBoxes();
                ListBoxCustomerDisplay.ClearSelected();
                ListBoxBookDisplay.ClearSelected();
            }

        }

        // Double click a record in the transaction display to delete it.
        private void ListBoxTransactionDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListBoxTransactionDisplay.SelectedIndex != -1)
            {
                DialogResult delRecord = MessageBox.Show(
                    "Delete Record?", "Delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (delRecord == DialogResult.OK)
                {
                    int curItem = ListBoxTransactionDisplay.SelectedIndex;
                    transactionArray[curItem, 0] = "";
                    transactionArray[curItem, 1] = "";
                    transactionArray[curItem, 2] = "";
                    ClearAllTextBoxes();
                    SortTransactions();
                    transactionPtr--;
                    DisplayTransactions();
                }
            }
        }

        #endregion

        // Clears all the text boxes and deselects any selected items in the book and customer list boxes.
        private void ClearAllTextBoxes()
        {
            ClearBookTextBoxes();
            ClearCustomerTextBoxes();
            ClearTransactionTextBoxes();

            ListBoxCustomerDisplay.ClearSelected();
            ListBoxBookDisplay.ClearSelected();
        }

        

        

        
    }
}
