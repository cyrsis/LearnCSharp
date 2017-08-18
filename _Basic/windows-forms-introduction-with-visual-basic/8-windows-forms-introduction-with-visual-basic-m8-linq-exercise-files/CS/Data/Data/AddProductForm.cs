using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public partial class AddProductForm : Form
    {
        private Category _category;

        public AddProductForm(Category category)
        {
            InitializeComponent();

            _category = category;
            CategoryTextBox.Text = _category.CategoryName;
        }

        public Product Product
        {
            get
            {
                var price = Decimal.Parse(PriceTextBox.Text);
                var stock = int.Parse(StockTextBox.Text);
                var onOrder = int.Parse(OrderTextBox.Text);

                var result = new Product(0, NameTextBox.Text, _category.CategoryID, QuantityTextBox.Text, price, stock, onOrder, DiscontinuedCheckBox.Checked);
                return result;
            }
        }
    }
}
