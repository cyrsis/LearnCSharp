using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using WPFComponents;

namespace WPFDataSamples
{
  /// <summary>
  /// Interaction logic for frmListBoxSelectModify.xaml
  /// </summary>
  public partial class frmListBoxSelectModify : Window
  {
    public frmListBoxSelectModify()
    {
      InitializeComponent();
    }

    bool mIsAddMode = false;
    // A BindingListCollectionView is needed for data binding
    private BindingListCollectionView CustomerView;
    // The LINQ to SQL data context
    AdvWorksDataContext dc = new AdvWorksDataContext();
    
    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      // Create a collection of Customers
      var items = from item in dc.Customers
                  orderby item.LastName
                  select item;

      // Set this form's DataContext with collection
      this.DataContext = items;

      // Turn Collection of Customers into BindingListCollectionView
      // This is needed for the add/edit/delete of data binding
      this.CustomerView = (BindingListCollectionView)
        (CollectionViewSource.GetDefaultView(items));
    }

    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
      // Commit the changes to the database
      this.dc.SubmitChanges();
      mIsAddMode = false;
    }

    private void btnDelete_Click(object sender, RoutedEventArgs e)
    {
      if (MessageBox.Show("Delete this Customer?", "Delete",
        MessageBoxButton.YesNo, 
        MessageBoxImage.Question) == MessageBoxResult.Yes)
      {
        // Remove the customer from the view
        this.CustomerView.RemoveAt(this.CustomerView.CurrentPosition);
        // Commit the delete to the database
        this.dc.SubmitChanges();
      }
      mIsAddMode = false;
    }

    private void btnAdd_Click(object sender, RoutedEventArgs e)
    {
      // Set Add Flag
      mIsAddMode = true;
      // Create New Customer Record
      Customer newCust = 
        (Customer)(this.CustomerView.AddNew());
      // Fill in any default values
      newCust.FirstName = "<new>";
      newCust.ModifiedDate = DateTime.Now;
      newCust.NameStyle = false;
      newCust.PasswordHash = string.Empty;
      newCust.PasswordSalt = string.Empty;
      newCust.rowguid = System.Guid.NewGuid();
      // Commit it to the View
      this.CustomerView.CommitNew();
      // Display it in the ListBox
      this.lstCustomers.ScrollIntoView(newCust);
      txtFirst.Focus();
      txtFirst.SelectAll();
    }

    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
      if (mIsAddMode)
      {
        // If we were adding, then cancel it
        this.CustomerView.CancelNew();
        // Remove the new item from the Customer view
        this.CustomerView.Remove(this.CustomerView.CurrentItem);
      }
      else
      {
        // Cancel the edit
        this.CustomerView.CancelEdit();
        // Refresh the DataContext with the old values
        dc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, dc.GetChangeSet().Updates);
        // Refresh the CustomerView
        this.CustomerView.Refresh();
      }
      mIsAddMode = false;     
    }
  }
}
