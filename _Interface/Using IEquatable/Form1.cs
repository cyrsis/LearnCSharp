using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_IEquatable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Author> authors = new List<Author>();

            Author author1 = new Author("Rod", "Stephens");
            if (!authors.Contains(author1)) authors.Add(author1);

            Author author2 = new Author("Rod", "Stephens");
            if (!authors.Contains(author2)) authors.Add(author2);

            if (author1 == author2)
                label1.Text = "The authors are the same";
            else
                label1.Text = "The authors are different";

            //Dictionary<Author, string> dict = new Dictionary<Author, string>();
            //Author author1 = new Author("Rod", "Stephens");
            //Author author2 = new Author("Rod", "Stephens");
            //Author author3 = new Author("Ann", "Archer");
            //dict.Add(author1, "1");
            //dict.Add(author3, "1");
            //dict.Add(author2, "1");
        }
    }
}
