using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Initialize the car data.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Make some Cars.
            // Source: http://www.digitaltrends.com/cars/the-top-ten-most-expensive-cars-in-the-world/
            Car[] cars =
            {
                new Car("Ferrari LaFerrari", 1400000, 217, 1000),
                new Car("Zenvo ST1", 1200000, 233, 1104),
                new Car("Lamborghini Veneno", 4500000, 220, 740),
                new Car("Aston Martin One-77", 1400000, 220, 750),
                new Car("W Motors Lykan Hypersport", 3400000, 240, 770),
                new Car("Koenigsegg One:1", 2000000, 273, 1340),
                new Car("Ferrari F60 America", 2500000, 225, 730),
                new Car("Pagani Huayra", 1400000, 238, 620),
                new Car("Mansory Vivere Bugatti Veyron", 3400000, 254, 1200),
                new Car("Koenigsegg CCXR Trevita", 4800000, 254, 1004),
            };

            // Display the cars.
            foreach (Car car in cars)
                car.AddToListView(carListView);
            carListView.ListViewItemSorter =
                new CarNameComparer();
            nameRadioButton.Checked = true;
        }

        // Sort by name.
        private void nameRadioButton_Click(object sender, EventArgs e)
        {
            carListView.ListViewItemSorter =
                new CarNameComparer();
        }

        private void priceRadioButton_Click(object sender, EventArgs e)
        {
            carListView.ListViewItemSorter =
                new CarPriceComparer();
        }

        private void descendingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (descendingCheckBox.Checked)
                carListView.Sorting = SortOrder.Descending;
            else
                carListView.Sorting = SortOrder.Ascending;
            carListView.Sort();
        }
    }
}
