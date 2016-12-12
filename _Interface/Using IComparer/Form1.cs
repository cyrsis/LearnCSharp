using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_IComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Car[] Cars;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make some Cars.
            // Source: http://www.digitaltrends.com/cars/the-top-ten-most-expensive-cars-in-the-world/
            Cars = new Car[]
            {
                new Car("Ferrari LaFerrari\t", 1400000, 217, 1000),
                new Car("Zenvo ST1\t", 1200000, 233, 1104),
                new Car("Lamborghini Veneno", 4500000, 220, 740),
                new Car("Aston Martin One-77\t", 1400000, 220, 750),
                new Car("W Motors Lykan Hypersport", 3400000, 240, 770),
                new Car("Koenigsegg One:1\t", 2000000, 273, 1340),
                new Car("Ferrari F60 America\t", 2500000, 225, 730),
                new Car("Pagani Huayra\t", 1400000, 238, 620),
                new Car("Mansory Vivere Bugatti Veyron", 3400000, 254, 1200),
                new Car("Koenigsegg CCXR Trevita", 4800000, 254, 1004),
            };

            DisplayCars();
        }

        // Display the cars in the ListBox.
        private void DisplayCars()
        {
            carsListBox.Items.Clear();
            foreach (Car car in Cars)
                carsListBox.Items.Add(car.ToString());
        }

        // Sort by name.
        private void nameRadioButton_Click(object sender, EventArgs e)
        {
            CarNameComparer comparer = new CarNameComparer();
            Array.Sort(Cars, comparer);
            DisplayCars();
        }

        // Sort by price.
        private void priceRadioButton_Click(object sender, EventArgs e)
        {

        }
    }
}
