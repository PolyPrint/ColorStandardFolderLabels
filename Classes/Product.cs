using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolyPrintUtilities;

namespace Mold_Number_Folder_Labels.Classes
{
   public class Product
    {
        public string RecordNumber { get; set; }
        public string Customer { get; set; }
        public string Description { get; set; }
        public string Revision { get; set; }
        public string CustomerProductNumber { get; set; }
        public string MoldNumber { get; set; }
        public DateTime? LastRun { get; set; }
        public string JobNumber { get; set; }
        public Boolean FolderCreated { get; set; }

        public Product(string recordNumber, string customer, string description, string revision, string customerProductNumber, string moldNumber, DateTime? lastRun)
        {
            RecordNumber = recordNumber;
            Customer = customer;
            Description = description;
            Revision = revision;
            CustomerProductNumber = customerProductNumber;
            MoldNumber = moldNumber;
            LastRun = lastRun;
        }

        public Product(string recordNumber, string customer, string description, string moldNumber, string jobNumber, Boolean folderCreated)
        {
            RecordNumber = recordNumber;
            JobNumber = jobNumber;
            Customer = customer;
            Description = description;
            MoldNumber = moldNumber;
            FolderCreated = folderCreated;
        }

        public Product() { }

        public string setAsPrinted() 
        {
            string message = "";
            
            var SQL = "UPDATE Products SET Color_Standard_Folder_Created = 1 WHERE Record_Number = " + RecordNumber;
            if (!PPDataAccess.ExecuteNonQuery(SQL))
            {
                message = "Error connecting to Database!!!";
            }
            
            return message;
        }

        public void toggleFolderCreated()
        {
            var SQL = "UPDATE Products SET Color_Standard_Folder_Created = " + (FolderCreated ? "1" : "null") + " WHERE Record_Number = " + RecordNumber;
            PPDataAccess.ExecuteNonQuery(SQL);
        }
    }
}
