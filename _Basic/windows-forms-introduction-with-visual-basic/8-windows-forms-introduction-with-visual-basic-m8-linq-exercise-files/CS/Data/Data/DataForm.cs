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
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private BindingSource _categoriesBindingSource = new BindingSource();
        private BindingSource _productsBindingSource = new BindingSource();

        private ISource _currentSource;
        private ObjectSource _objectSource;
        private DataSetSource _dataSetSource;
        private LinqSource _linqSource;

        private void DataForm_Load(object sender, EventArgs e)
        {
            try
            {
                SourceToolStripComboBox.SelectedIndex = 0;
                SetSource();
                BindCategories();

                _categoriesBindingSource.DataSource = _currentSource.GetCategories();

                CategoryToolStripComboBox.ComboBox.DisplayMember = "CategoryName";
                CategoryToolStripComboBox.ComboBox.ValueMember = "CategoryID";
                CategoryToolStripComboBox.ComboBox.DataSource = _categoriesBindingSource;

                ProductsDataGridView.DataSource = _productsBindingSource;
                ProductsListBox.DisplayMember = "ProductName";
                ProductsListBox.ValueMember = "ProductID";
                ProductsListBox.DataSource = _productsBindingSource;

                NameTextBox.DataBindings.Add("Text", _productsBindingSource, "ProductName", true);
                QuantityTextBox.DataBindings.Add("Text", _productsBindingSource, "QuantityPerUnit", true);
                PriceTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitPrice", true);
                StockTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitsInStock", true);
                OrderTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitsOnOrder", true);
                DiscontinuedCheckBox.DataBindings.Add("Checked", _productsBindingSource, "Discontinued", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SourceToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSource();
            BindCategories();
            BindProducts();
        }

        private void CategoryToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindProducts();
        }

        private void SetSource()
        {
            switch (SourceToolStripComboBox.SelectedIndex)
            {
                case 0:
                    if (_objectSource == null)
                    {
                        _objectSource = new ObjectSource();
                    }
                    _currentSource = _objectSource;
                    break;
                case 1:
                    if (_dataSetSource == null)
                    {
                        _dataSetSource = new DataSetSource();
                    }
                    _currentSource = _dataSetSource;
                    break;
                case 2:
                    if (_linqSource == null)
                    {
                        _linqSource = new LinqSource();
                    }
                    _currentSource = _linqSource;
                    break;
            }
        }

        private void BindCategories()
        {
            _categoriesBindingSource.DataSource = _currentSource.GetCategories();
        }

        private void BindProducts()
        {
            var catId = Convert.ToInt32(CategoryToolStripComboBox.ComboBox.SelectedValue);
            _productsBindingSource.DataSource = _currentSource.GetProducts(catId);
        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(CategoryToolStripComboBox.ComboBox.SelectedValue);
            var name = CategoryToolStripComboBox.Text;
            var category = new Category(id, name);

            AddProductForm form = new AddProductForm(category);
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                var rebind = _currentSource.AddProduct(form.Product);
                if (rebind)
                {
                    BindProducts();
                }
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            var productId = Convert.ToInt32(ProductsListBox.SelectedValue);
            var rebind = _currentSource.DeleteProduct(productId);
            if (rebind)
            {
                BindProducts();
            }
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            _currentSource.Save();
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
