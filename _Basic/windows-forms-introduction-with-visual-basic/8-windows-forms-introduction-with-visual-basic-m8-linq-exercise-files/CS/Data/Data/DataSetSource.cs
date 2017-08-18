using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public class DataSetSource : ISource
    {
        private DataSet _dataSet;
        private SqlDataAdapter _productsAdapater;
        private int _nextId = int.MaxValue;

        public DataSetSource()
        {
            _dataSet = new DataSet();

            var cn = new SqlConnection(Properties.Settings.Default.NorthwindConnection);
            var cda = new SqlDataAdapter("Select CategoryID, CategoryName From Categories", cn);
            cda.Fill(_dataSet, "Categories");

            _productsAdapater = new SqlDataAdapter("Select * From Products", cn);
            var builder = new SqlCommandBuilder(_productsAdapater);
            _productsAdapater.Fill(_dataSet, "Products");
        }

        public object GetCategories()
        {
            var table = _dataSet.Tables["Categories"];
            return table;
        }

        public object GetProducts(int categoryId)
        {
            var table = _dataSet.Tables["Products"];
            table.DefaultView.RowFilter = "CategoryID = " + categoryId;
            return table;
        }

        public bool AddProduct(Product product)
        {
            var table = _dataSet.Tables["Products"];
            _nextId -= 1;

            var row = table.NewRow();
            row["ProductId"] = _nextId;
            row["ProductName"] = product.ProductName;
            row["SupplierID"] = 1;
            row["CategoryID"]= product.CategoryId;
            row["QuantityPerUnit"] = product.QuantityPerUnit;
            row["UnitPrice"] = product.UnitPrice;
            row["UnitsInStock"] = product.UnitsInStock;
            row["UnitsOnOrder"] = product.UnitsOnOrder;
            row["ReorderLevel"] = 0;
            row["Discontinued"] = product.Discontinued;

            table.Rows.Add(row);

            return false;
        }

        public bool DeleteProduct(int productId)
        {
            var table = _dataSet.Tables["Products"];
            var query = from p in table.AsEnumerable()
                        where p.RowState != DataRowState.Deleted && p.Field<int>("ProductID") == productId
                        select p;
            var row = query.Single();

            row.Delete();

            return false;
        }

        public void Save()
        {
            try
            {
                var cn = new SqlConnection(Properties.Settings.Default.NorthwindConnection);
                cn.Open();
                _productsAdapater.Update(_dataSet, "Products");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    
    
    
    }
}
