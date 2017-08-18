using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public class LinqSource : ISource
    {
        public object GetCategories()
        {
            object result = null;

            using (NorthwindDataContext context = new NorthwindDataContext())
            {
                result = context.LinqCategories.ToList();
            }

            return result;
        }

        public object GetProducts(int categoryId)
        {
            object result = null;

            using (NorthwindDataContext context = new NorthwindDataContext())
            {
                var query = from p in context.LinqProducts
                            where p.CategoryID == categoryId
                            select p;

                result = query.ToList();
            }

            return result;
        }

        public bool AddProduct(Product product)
        {
            using (NorthwindDataContext context = new NorthwindDataContext())
            {
                LinqProduct linqProduct = new LinqProduct();
                linqProduct.ProductName = product.ProductName;
                linqProduct.SupplierID = 1;
                linqProduct.CategoryID = product.CategoryId;
                linqProduct.QuantityPerUnit = product.QuantityPerUnit;
                linqProduct.UnitPrice = product.UnitPrice;
                linqProduct.UnitsInStock = Convert.ToInt16(product.UnitsInStock);
                linqProduct.UnitsOnOrder = Convert.ToInt16(product.UnitsOnOrder);
                linqProduct.ReorderLevel = 0;
                linqProduct.Discontinued = product.Discontinued;

                context.LinqProducts.InsertOnSubmit(linqProduct);
                Save(context);
            }

            return true;
        }

        public bool DeleteProduct(int productId)
        {
            using (NorthwindDataContext context = new NorthwindDataContext())
            {
                var query = from p in context.LinqProducts
                            where p.ProductID == productId
                            select p;
                var linqProduct = query.Single();

                context.LinqProducts.DeleteOnSubmit(linqProduct);
                Save(context);
            }

            return true;
        }

        public void Save()
        {
            using (NorthwindDataContext context = new NorthwindDataContext())
            {
                Save(context);
            }
        }

        private void Save(NorthwindDataContext context)
        {
            try
            {
                context.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
