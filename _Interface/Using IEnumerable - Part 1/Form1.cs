using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Needed if you use a non-generic IEnumerator.
//using System.Collections;

namespace Using_IEnumerable___Part_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Build a small tree.
            TreeNode animals = new TreeNode("Animals");

            TreeNode mammals = new TreeNode("Mammals");
            animals.Children.Add(mammals);
            mammals.Children.Add(new TreeNode("Aardvark"));
            mammals.Children.Add(new TreeNode("Bat"));
            mammals.Children.Add(new TreeNode("Cat"));

            TreeNode birds = new TreeNode("Birds");
            animals.Children.Add(birds);
            birds.Children.Add(new TreeNode("Albatross"));
            birds.Children.Add(new TreeNode("Bluebird"));

            TreeNode fish = new TreeNode("Fish");
            animals.Children.Add(fish);
            fish.Children.Add(new TreeNode("Albacore"));
            fish.Children.Add(new TreeNode("Beluga"));
            fish.Children.Add(new TreeNode("Catfish"));

            // Enumerate the tree nodes.
            foreach (TreeNode node in animals)
                animalListBox.Items.Add(node.Data);

            // Use an enumerator to loop through the nodes.
            //IEnumerator<TreeNode> enumerator = animals.GetEnumerator();
            //while (enumerator.MoveNext())
            //    animalListBox.Items.Add(enumerator.Current.Data);
        }
    }
}
