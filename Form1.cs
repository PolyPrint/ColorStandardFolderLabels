using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolyPrintUtilities;
using SortOrder = System.Windows.Forms.SortOrder;

namespace Mold_Number_Folder_Labels.Classes
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private Product productToPrint = new Product();
        private List<Product> productList = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            PPDataAccess.SetToProduction();
            SelectPrinter();
            LoadProductList();
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        public void SelectPrinter()
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                MessageBox.Show("Printer not selected.");
            }
        }

        public static List<Product> GetProductList()
        {
            List<Product> productList = new List<Product>();

            var SQL = "SELECT P.Record_Number AS 'Record Number'," +
                      "A.Company AS Customer," +
                      "P.Description," +
                      "P.Revision," +
                      "P.Customer_Product_Number as 'Customer Product Number'," +
                      "P.mold_Number as 'Mold #'," +
                      "LastRun as 'Last Run'" +
                      "FROM ProductsLatestRevision PL " +
                      "INNER JOIN ProductsExpandedView P ON PL.Record_Number = P.Record_Number " +
                      "INNER JOIN Address A ON P.Company_Code = A.Mold_Code " +
                      "LEFT OUTER JOIN(SELECT Customer_Code, Job_Item_Number, Max(Order_Date) AS LastRun FROM Jobs WHERE Status NOT IN ('CC', 'AB') GROUP BY Customer_Code, Job_Item_Number) LastJob ON P.Company_Code = LastJob.Customer_Code AND P.Customer_Product_Number = LastJob.Job_Item_NUmber " +
                      "WHERE P.Is_Active = 1 " +
                      "AND ISNULL(P.Color_Standard_Folder_Created, 0) = 0 " +
                      "AND P.Colors > 0 " +
                      "ORDER BY 'Last Run' DESC, Customer, Description, Revision ASC";

            SqlDataReader reader = PPDataAccess.ExecuteDataReader(SQL);

            string recordNumber = "";
            string customer = "";
            string description = "";
            string revision = "";
            string customerProductNumber = "";
            string moldNumber = "";
            DateTime? lastRun = null;

            while (reader.Read())
            {
                recordNumber = reader["Record Number"].ToString();
                customer = reader["Customer"].ToString();
                description = reader["Description"].ToString();
                revision = reader["Revision"].ToString();
                customerProductNumber = reader["Customer Product Number"].ToString();
                moldNumber = reader["Mold #"].ToString();
                lastRun = reader["Last Run"].Equals(DBNull.Value) ? (DateTime?)null : DateTime.Parse(reader["Last Run"].ToString());

                productList.Add(new Product(recordNumber, customer, description, revision, customerProductNumber, moldNumber, lastRun));
            }

            return productList;
        }

        public static List<Product> GetProductListByJob(string jobNumber)
        {
            List<Product> productList = new List<Product>();

            var SQL = "SELECT P.Record_Number AS 'Record Number', J.job_Number AS 'Job Number', J.Description AS 'Description', p.Mold_Number AS 'Mold #', A.Company AS 'Customer', P.Color_Standard_Folder_Created AS 'Folder Created'" +
                      "FROM jobs J " +
                      "INNER JOIN Address A ON J.Customer_Code = A.Mold_Code " +
                      "INNER JOIN JobLayout JL ON J.Job_Number = JL.Job_Number " +
                      "INNER JOIN ProductsExpandedView P ON JL.Product_And_Revision_Number = P.Record_Number " +
                      "WHERE J.job_Number = " + jobNumber;

            SqlDataReader reader = PPDataAccess.ExecuteDataReader(SQL);

            string recordNumber = "";
            string queryJobNumber = "";
            string customer = "";
            string description = "";
            string moldNumber = "";
            Boolean folderCreated = false;

            while (reader.Read())
            {
                recordNumber = reader["Record Number"].ToString();
                queryJobNumber = reader["Job Number"].ToString();
                customer = reader["Customer"].ToString();
                description = reader["Description"].ToString();
                moldNumber = reader["Mold #"].ToString();
                folderCreated = reader["Folder Created"].Equals(DBNull.Value) ? false : true;

                productList.Add(new Product(recordNumber, customer, description, moldNumber, queryJobNumber, folderCreated));
            }

            return productList;
        }

        public void LoadProductList()
        {
            productList = GetProductList();
            dataGridView1.DataSource = bindingSource;
            bindingSource.DataSource = productList;

            dataGridView1.Columns["Customer"].DisplayIndex = 0;

            dataGridView1.Columns["Description"].DisplayIndex = 1;
            dataGridView1.Columns["Description"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns["Revision"].DisplayIndex = 2;

            dataGridView1.Columns["CustomerProductNumber"].HeaderText = "Customer Product Number";
            dataGridView1.Columns["CustomerProductNumber"].DisplayIndex = 3;

            dataGridView1.Columns["MoldNumber"].HeaderText = "Mold Number";
            dataGridView1.Columns["MoldNumber"].DisplayIndex = 4;
            dataGridView1.Columns["MoldNumber"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns["LastRun"].HeaderText = "Last Run";
            dataGridView1.Columns["LastRun"].DisplayIndex = 5;

            dataGridView1.Columns["RecordNumber"].Visible = false;
            dataGridView1.Columns["JobNumber"].Visible = false;
            dataGridView1.Columns["FolderCreated"].Visible = false;

            dataGridView1.Rows[0].Selected = true;

        }

        public void LoadProductListByJob(string jobNumber)
        {
            productList = GetProductListByJob(jobNumber);
            dataGridView2.DataSource = bindingSource;
            bindingSource.DataSource = productList;

            dataGridView2.Columns["JobNumber"].HeaderText = "Job Number";
            dataGridView2.Columns["JobNumber"].DisplayIndex = 0;

            dataGridView2.Columns["Customer"].DisplayIndex = 1;

            dataGridView2.Columns["Description"].DisplayIndex = 2;
            dataGridView2.Columns["Description"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;


            dataGridView2.Columns["MoldNumber"].HeaderText = "Mold Number";
            dataGridView2.Columns["MoldNumber"].DisplayIndex = 3;
            dataGridView2.Columns["MoldNumber"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView2.Columns["FolderCreated"].HeaderText = "Folder Created";
            dataGridView2.Columns["FolderCreated"].DisplayIndex = 4;

            dataGridView2.Columns["RecordNumber"].Visible = false;
            dataGridView2.Columns["Revision"].Visible = false;
            dataGridView2.Columns["CustomerProductNumber"].Visible = false;
            dataGridView2.Columns["LastRun"].Visible = false;

            dataGridView2.Columns["JobNumber"].ReadOnly = true;
            dataGridView2.Columns["Customer"].ReadOnly = true;
            dataGridView2.Columns["Description"].ReadOnly = true;
            dataGridView2.Columns["MoldNumber"].ReadOnly = true;

            dataGridView2.Rows[0].Selected = true;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected) / 6;//6 = number of columns

            short copies = cbx_copies.SelectedItem == null ? (short)-1 : Convert.ToInt16(cbx_copies.SelectedItem.ToString());

            try
            {
                if (selectedCellCount == 1)
                {
                    productToPrint = (Product)dataGridView1.CurrentRow.DataBoundItem;
                    PrintLabel(copies);
                    RemovePrintedLabelFromList();
                }
                else
                {
                    var answer = MessageBox.Show("Do you want to print " + selectedCellCount + " labels?", "Print Multiple Labels", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                        for (int i = 0; i < selectedCellCount; i++)
                        {
                            productToPrint = (Product)selectedRows[i].DataBoundItem;
                            PrintLabel(copies);
                            RemovePrintedLabelFromList();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please select a row and try again");
            }
        }

        private void PrintLabel(short copies)
        {   
            if(copies == -1)
            {
                printDocument1.PrinterSettings.Copies = 2;
            }
            else
            {
                printDocument1.PrinterSettings.Copies = copies;
            }
            printDocument1.DocumentName = productToPrint.MoldNumber;
            printDocument1.DefaultPageSettings.Landscape = false;
            printDocument1.Print();
            productToPrint.setAsPrinted();
        }

        private void RemovePrintedLabelFromList()
        {
            bindingSource.Remove(productToPrint);
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var smallFont = new Font("Arial", 24, FontStyle.Bold);

            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            float x = 2.0F;
            float y = 2.0F;

            e.Graphics.DrawString(productToPrint.MoldNumber, smallFont, drawBrush, x, y);
        }

        private void Sort<T>(List<T> compareList, DataGridViewCellMouseEventArgs e)
        {
            string strColumnName = dataGridView1.Columns[e.ColumnIndex].Name;
            SortOrder strSortOrder = GetSortOrder(e.ColumnIndex);

            if (strSortOrder == SortOrder.Ascending)
            {
                compareList = compareList.OrderBy(x => typeof(T).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            else
            {
                compareList = compareList.OrderByDescending(x => typeof(T).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            dataGridView1.DataSource = compareList;
            dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }

        private SortOrder GetSortOrder(int columnIndex)
        {
            if (dataGridView1.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.None ||
                dataGridView1.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending)
            {
                dataGridView1.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                return SortOrder.Ascending;
            }
            else
            {
                dataGridView1.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                return SortOrder.Descending;
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Sort<Product>(productList, e);
        }

        private void Search(List<Product> compareList)
        {

            var customerSearchResult = compareList.Where(x =>
            x.Customer.ToString().Contains(tbx_search.Text)).ToList();

            var descriptionSearchResult = compareList.Where(x =>
            x.Description.ToString().Contains(tbx_search.Text)).ToList();

            var moldNumberSearchResult = compareList.Where(x =>
            x.MoldNumber.Contains(tbx_search.Text.ToUpper())).ToList();

            var lastRunSearchResult = compareList.Where(x =>
            x.LastRun.ToString().Contains(tbx_search.Text)).ToList();

            dataGridView1.DataSource = customerSearchResult.Concat(descriptionSearchResult).Concat(moldNumberSearchResult).Concat(lastRunSearchResult).ToList();
        }

        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            Search(productList);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string jobNumber = tbx_job_input.Text.ToString();
            LoadProductListByJob(jobNumber);
        }

        private void btn_print2_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridView2.GetCellCount(DataGridViewElementStates.Selected) / 6;//6 = number of columns

            short copies = cbx_copies2.SelectedItem == null ? (short)-1 : Convert.ToInt16(cbx_copies2.SelectedItem.ToString());

            try
            {
                if (selectedCellCount == 1)
                {
                    productToPrint = (Product)dataGridView2.CurrentRow.DataBoundItem;
                    PrintLabel(copies);
                    RemovePrintedLabelFromList();
                }
                else
                {
                    var answer = MessageBox.Show("Do you want to print " + selectedCellCount + " labels?", "Print Multiple Labels", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                        for (int i = 0; i < selectedCellCount; i++)
                        {
                            productToPrint = (Product)selectedRows[i].DataBoundItem;
                            PrintLabel(copies);
                            RemovePrintedLabelFromList();
                        }
                    }
                }
            }
            catch(System.NullReferenceException ex)
            {
                MessageBox.Show("Please select a row and try again");
            }
        }

        private void tab_by_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabName = tab_by_list.SelectedTab.Text.ToString();
            if(tabName == "By List")
            {
                LoadProductList();
            }
            else if(tabName == "By Job Number")
            {
                LoadProductListByJob("0");
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //When checkbox for folder created is checked or unchecked
            if (e.ColumnIndex == 8 && e.RowIndex != -1)
            {
                Product product = (Product)dataGridView1.CurrentRow.DataBoundItem;
                //Toggle folder checked
                product.toggleFolderCreated();
            }

        }

        private void dataGridView2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // End of edition on each click on column of checkbox
            if (e.ColumnIndex == 8 && e.RowIndex != -1)
            {
                dataGridView2.EndEdit();
            }
        }
    }
}
