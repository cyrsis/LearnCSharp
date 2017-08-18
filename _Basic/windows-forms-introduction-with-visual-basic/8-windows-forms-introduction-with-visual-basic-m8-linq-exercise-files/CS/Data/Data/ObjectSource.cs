using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public class ObjectSource : ISource
    {
        private List<Category> _categories;
        private List<Product> _products;

        public ObjectSource()
        {
            _categories = new List<Category>();
            _categories.Add(new Category(1, "Beverages"));
            _categories.Add(new Category(2, "Condiments"));
            _categories.Add(new Category(3, "Confections"));
            _categories.Add(new Category(4, "Dairy Products"));
            _categories.Add(new Category(5, "Grains/Cereals"));
            _categories.Add(new Category(6, "Meat/Poultry"));
            _categories.Add(new Category(7, "Produce"));
            _categories.Add(new Category(8, "Seafood"));

            _products = new List<Product>();
            _products.Add(new Product(1, "Chai", 1, "10 boxes x 20 bags", 18.0m, 39, 0, false));
            _products.Add(new Product(2, "Chang", 1, "24 - 12 oz bottles", 19.0m, 17, 40, false));
            _products.Add(new Product(3, "Aniseed Syrup", 2, "12 - 550 ml bottles", 10.0m, 13, 70, false));
            _products.Add(new Product(4, "Chef Anton's Cajun Seasoning", 2, "48 - 6 oz jars", 22.0m, 53, 0, false));
            _products.Add(new Product(5, "Chef Anton's Gumbo Mix", 2, "36 boxes", 21.35m, 0, 0, true));
            _products.Add(new Product(6, "Grandma's Boysenberry Spread", 2, "12 - 8 oz jars", 25.0m, 120, 0, false));
            _products.Add(new Product(7, "Uncle Bob's Organic Dried Pears", 7, "12 - 1 lb pkgs.", 30.0m, 15, 0, false));
            _products.Add(new Product(8, "Northwoods Cranberry Sauce", 2, "12 - 12 oz jars", 40.0m, 6, 0, false));
            _products.Add(new Product(9, "Mishi Kobe Niku", 6, "18 - 500 g pkgs.", 97.0m, 29, 0, true));
            _products.Add(new Product(10, "Ikura", 8, "12 - 200 ml jars", 31.0m, 31, 0, false));
            _products.Add(new Product(11, "Queso Cabrales", 4, "1 kg pkg.", 21.0m, 22, 30, false));
            _products.Add(new Product(12, "Queso Manchego La Pastora", 4, "10 - 500 g pkgs.", 38.0m, 86, 0, false));
            _products.Add(new Product(13, "Konbu", 8, "2 kg box", 6.0m, 24, 0, false));
            _products.Add(new Product(14, "Tofu", 7, "40 - 100 g pkgs.", 23.25m, 35, 0, false));
            _products.Add(new Product(15, "Genen Shouyu", 2, "24 - 250 ml bottles", 15.5m, 39, 0, false));
            _products.Add(new Product(16, "Pavlova", 3, "32 - 500 g boxes", 17.45m, 29, 0, false));
            _products.Add(new Product(17, "Alice Mutton", 6, "20 - 1 kg tins", 39.0m, 0, 0, true));
            _products.Add(new Product(18, "Carnarvon Tigers", 8, "16 kg pkg.", 62.5m, 42, 0, false));
            _products.Add(new Product(19, "Teatime Chocolate Biscuits", 3, "10 boxes x 12 pieces", 9.2m, 25, 0, false));
            _products.Add(new Product(20, "Sir Rodney's Marmalade", 3, "30 gift boxes", 81.0m, 40, 0, false));
            _products.Add(new Product(21, "Sir Rodney's Scones", 3, "24 pkgs. x 4 pieces", 10.0m, 3, 40, false));
            _products.Add(new Product(22, "Gustaf's Knäckebröd", 5, "24 - 500 g pkgs.", 21.0m, 104, 0, false));
            _products.Add(new Product(23, "Tunnbröd", 5, "12 - 250 g pkgs.", 9.0m, 61, 0, false));
            _products.Add(new Product(24, "Guaraná Fantástica", 1, "12 - 355 ml cans", 4.5m, 20, 0, true));
            _products.Add(new Product(25, "NuNuCa Nuß-Nougat-Creme", 3, "20 - 450 g glasses", 14.0m, 76, 0, false));
            _products.Add(new Product(26, "Gumbär Gummibärchen", 3, "100 - 250 g bags", 31.23m, 15, 0, false));
            _products.Add(new Product(27, "Schoggi Schokolade", 3, "100 - 100 g pieces", 43.9m, 49, 0, false));
            _products.Add(new Product(28, "Rössle Sauerkraut", 7, "25 - 825 g cans", 45.6m, 26, 0, true));
            _products.Add(new Product(29, "Thüringer Rostbratwurst", 6, "50 bags x 30 sausgs.", 123.79m, 0, 0, true));
            _products.Add(new Product(30, "Nord-Ost Matjeshering", 8, "10 - 200 g glasses", 25.89m, 10, 0, false));
            _products.Add(new Product(31, "Gorgonzola Telino", 4, "12 - 100 g pkgs", 12.5m, 0, 70, false));
            _products.Add(new Product(32, "Mascarpone Fabioli", 4, "24 - 200 g pkgs.", 32.0m, 9, 40, false));
            _products.Add(new Product(33, "Geitost", 4, "500 g", 2.5m, 112, 0, false));
            _products.Add(new Product(34, "Sasquatch Ale", 1, "24 - 12 oz bottles", 14.0m, 111, 0, false));
            _products.Add(new Product(35, "Steeleye Stout", 1, "24 - 12 oz bottles", 18.0m, 20, 0, false));
            _products.Add(new Product(36, "Inlagd Sill", 8, "24 - 250 g  jars", 19.0m, 112, 0, false));
            _products.Add(new Product(37, "Gravad lax", 8, "12 - 500 g pkgs.", 26.0m, 11, 50, false));
            _products.Add(new Product(38, "Côte de Blaye", 1, "12 - 75 cl bottles", 263.5m, 17, 0, false));
            _products.Add(new Product(39, "Chartreuse verte", 1, "750 cc per bottle", 18.0m, 69, 0, false));
            _products.Add(new Product(40, "Boston Crab Meat", 8, "24 - 4 oz tins", 18.4m, 123, 0, false));
            _products.Add(new Product(41, "Jack's New England Clam Chowder", 8, "12 - 12 oz cans", 9.65m, 85, 0, false));
            _products.Add(new Product(42, "Singaporean Hokkien Fried Mee", 5, "32 - 1 kg pkgs.", 14.0m, 26, 0, true));
            _products.Add(new Product(43, "Ipoh Coffee", 1, "16 - 500 g tins", 46.0m, 17, 10, false));
            _products.Add(new Product(44, "Gula Malacca", 2, "20 - 2 kg bags", 19.45m, 27, 0, false));
            _products.Add(new Product(45, "Rogede sild", 8, "1k pkg.", 9.5m, 5, 70, false));
            _products.Add(new Product(46, "Spegesild", 8, "4 - 450 g glasses", 12.0m, 95, 0, false));
            _products.Add(new Product(47, "Zaanse koeken", 3, "10 - 4 oz boxes", 9.5m, 36, 0, false));
            _products.Add(new Product(48, "Chocolade", 3, "10 pkgs.", 12.75m, 15, 70, false));
            _products.Add(new Product(49, "Maxilaku", 3, "24 - 50 g pkgs.", 20.0m, 10, 60, false));
            _products.Add(new Product(50, "Valkoinen suklaa", 3, "12 - 100 g bars", 16.25m, 65, 0, false));
            _products.Add(new Product(51, "Manjimup Dried Apples", 7, "50 - 300 g pkgs.", 53.0m, 20, 0, false));
            _products.Add(new Product(52, "Filo Mix", 5, "16 - 2 kg boxes", 7.0m, 38, 0, false));
            _products.Add(new Product(53, "Perth Pasties", 6, "48 pieces", 32.8m, 0, 0, true));
            _products.Add(new Product(54, "Tourtière", 6, "16 pies", 7.45m, 21, 0, false));
            _products.Add(new Product(55, "Pâté chinois", 6, "24 boxes x 2 pies", 24.0m, 115, 0, false));
            _products.Add(new Product(56, "Gnocchi di nonna Alice", 5, "24 - 250 g pkgs.", 38.0m, 21, 10, false));
            _products.Add(new Product(57, "Ravioli Angelo", 5, "24 - 250 g pkgs.", 19.5m, 36, 0, false));
            _products.Add(new Product(58, "Escargots de Bourgogne", 8, "24 pieces", 13.25m, 62, 0, false));
            _products.Add(new Product(59, "Raclette Courdavault", 4, "5 kg pkg.", 55.0m, 79, 0, false));
            _products.Add(new Product(60, "Camembert Pierrot", 4, "15 - 300 g rounds", 34.0m, 19, 0, false));
            _products.Add(new Product(61, "Sirop d'érable", 2, "24 - 500 ml bottles", 28.5m, 113, 0, false));
            _products.Add(new Product(62, "Tarte au sucre", 3, "48 pies", 49.3m, 17, 0, false));
            _products.Add(new Product(63, "Vegie-spread", 2, "15 - 625 g jars", 43.9m, 24, 0, false));
            _products.Add(new Product(64, "Wimmers gute Semmelknödel", 5, "20 bags x 4 pieces", 33.25m, 22, 80, false));
            _products.Add(new Product(65, "Louisiana Fiery Hot Pepper Sauce", 2, "32 - 8 oz bottles", 21.05m, 76, 0, false));
            _products.Add(new Product(66, "Louisiana Hot Spiced Okra", 2, "24 - 8 oz jars", 17.0m, 4, 100, false));
            _products.Add(new Product(67, "Laughing Lumberjack Lager", 1, "24 - 12 oz bottles", 14.0m, 52, 0, false));
            _products.Add(new Product(68, "Scottish Longbreads", 3, "10 boxes x 8 pieces", 12.5m, 6, 10, false));
            _products.Add(new Product(69, "Gudbrandsdalsost", 4, "10 kg pkg.", 36.0m, 26, 0, false));
            _products.Add(new Product(70, "Outback Lager", 1, "24 - 355 ml bottles", 15.0m, 15, 10, false));
            _products.Add(new Product(71, "Flotemysost", 4, "10 - 500 g pkgs.", 21.5m, 26, 0, false));
            _products.Add(new Product(72, "Mozzarella di Giovanni", 4, "24 - 200 g pkgs.", 34.8m, 14, 0, false));
            _products.Add(new Product(73, "Röd Kaviar", 8, "24 - 150 g jars", 15.0m, 101, 0, false));
            _products.Add(new Product(74, "Longlife Tofu", 7, "5 kg pkg.", 10.0m, 4, 20, false));
            _products.Add(new Product(75, "Rhönbräu Klosterbier", 1, "24 - 0.5 l bottles", 7.75m, 125, 0, false));
            _products.Add(new Product(76, "Lakkalikööri", 1, "500 ml", 18.0m, 57, 0, false));
            _products.Add(new Product(77, "Original Frankfurter grüne Soße", 2, "12 boxes", 13.0m, 32, 0, false));
        }

        public object GetCategories()
        {
            return _categories;
        }

        public object GetProducts(int categoryId)
        {
            var result = from p in _products
                         where p.CategoryId == categoryId
                         select p;

            return result.ToList();
        }

        public bool DeleteProduct(int productId)
        {
            var query = from p in _products
                        where p.ProductID == productId
                        select p;
            var product = query.Single();

            _products.Remove(product);

            return true;
        }

        public bool AddProduct(Product product)
        {
            var maxId = (
                from p in _products
                select p).Max(p => p.ProductID);
            product.ProductID = maxId + 1;

            _products.Add(product);

            return true;
        }
        public void Save()
        {
            //Nothing to do
        }
    }
}
