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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ObjectSource _source = new ObjectSource();
        private BindingSource _categoriesBindingSource = new BindingSource();
        private BindingSource _productsBindingSource = new BindingSource();

        private void DataForm_Load(object sender, EventArgs e)
        {
            _categoriesBindingSource.DataSource = _source.GetCategories();

            CategoryToolStripComboBox.ComboBox.DisplayMember = "CategoryName";
            CategoryToolStripComboBox.ComboBox.ValueMember = "CategoryID";
            CategoryToolStripComboBox.ComboBox.DataSource = _categoriesBindingSource;

            ProductsDataGridView.DataSource = _productsBindingSource;
            ProductsListBox.DataSource = _productsBindingSource;
            ProductsListBox.DisplayMember = "ProductName";

            NameTextBox.DataBindings.Add("Text", _productsBindingSource, "ProductName");
            QuantityTextBox.DataBindings.Add("Text", _productsBindingSource, "QuantityPerUnit");
            PriceTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitPrice");
            StockTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitsInStock");
            OrderTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitsOnOrder");
            DiscontinuedCheckBox.DataBindings.Add("Checked", _productsBindingSource, "Discontinued");
        }

        private void CategoryToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var catId = Convert.ToInt32(CategoryToolStripComboBox.ComboBox.SelectedValue);
            _productsBindingSource.DataSource = _source.GetProducts(catId);
        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            var category = (Category)CategoryToolStripComboBox.SelectedItem;
            AddProductForm form = new AddProductForm(category);
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                // _source.AddProduct(form.Product)
                _productsBindingSource.Add(form.Product);
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            var product = (Product)ProductsListBox.SelectedItem;
            // _source.DeleteProduct(product)
            _productsBindingSource.Remove(product);
        }

        private void BackToolStripButton_Click(object sender, EventArgs e)
        {
            _productsBindingSource.MovePrevious();
        }

        private void ForwardToolStripButton_Click(object sender, EventArgs e)
        {
            _productsBindingSource.MoveNext();
        }
    }
}
