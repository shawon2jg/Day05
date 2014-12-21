using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<int, string> citizenDictionary = new Dictionary<int, string>(); 
        private void saveButton_Click(object sender, EventArgs e)
        {
            citizenDictionary.Add(Convert.ToInt16(idToSaveTextBox.Text), detailsTextBox.Text);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            idToSearchTextBox.Text = citizenDictionary[Convert.ToInt16(idToSearchTextBox.Text)];
        }
    }
}
