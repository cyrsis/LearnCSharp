using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SalesDashboard
{
    public partial class ProductsIndicatorControl : UserControl
    {
        public ProductsIndicatorControl()
        {
            InitializeComponent();

            this.LayoutRoot.DataContext = this;
        }

        public bool HasBikesProducts
        {
            get { return (bool)GetValue(HasBikesProductsProperty); }
            set { SetValue(HasBikesProductsProperty, value); }
        }

        public static readonly DependencyProperty HasBikesProductsProperty =
            DependencyProperty.Register("HasBikesProducts", typeof(bool), typeof(ProductsIndicatorControl), new PropertyMetadata(null));

        public bool HasComponentsProducts
        {
            get { return (bool)GetValue(HasComponentsProductsProperty); }
            set { SetValue(HasComponentsProductsProperty, value); }
        }

        public static readonly DependencyProperty HasComponentsProductsProperty =
            DependencyProperty.Register("HasComponentsProducts", typeof(bool), typeof(ProductsIndicatorControl), new PropertyMetadata(null));

        public bool HasClothingProducts
        {
            get { return (bool)GetValue(HasClothingProductsProperty); }
            set { SetValue(HasClothingProductsProperty, value); }
        }

        public static readonly DependencyProperty HasClothingProductsProperty =
            DependencyProperty.Register("HasClothingProducts", typeof(bool), typeof(ProductsIndicatorControl), new PropertyMetadata(null));

        public bool HasAccessoriesProducts
        {
            get { return (bool)GetValue(HasAccessoriesProductsProperty); }
            set { SetValue(HasAccessoriesProductsProperty, value); }
        }

        public static readonly DependencyProperty HasAccessoriesProductsProperty =
            DependencyProperty.Register("HasAccessoriesProducts", typeof(bool), typeof(ProductsIndicatorControl), new PropertyMetadata(null));

        public int ProductsEnum
        {
            get { return (int)GetValue(ProductsEnumProperty); }
            set { SetValue(ProductsEnumProperty, value); }
        }

        public static readonly DependencyProperty ProductsEnumProperty =
            DependencyProperty.Register("ProductsEnum", typeof(int), typeof(ProductsIndicatorControl), new PropertyMetadata(OnProductsEnumPropertyChanged));

        private static void OnProductsEnumPropertyChanged(object d, DependencyPropertyChangedEventArgs args)
        {
            var thisControl = (d as ProductsIndicatorControl);
            thisControl.HasBikesProducts = (thisControl.ProductsEnum & 0x1) != 0;
            thisControl.HasComponentsProducts = (thisControl.ProductsEnum & 0x2) != 0;
            thisControl.HasClothingProducts = (thisControl.ProductsEnum & 0x4) != 0;
            thisControl.HasAccessoriesProducts = (thisControl.ProductsEnum & 0x8) != 0;
        }
    }
}
