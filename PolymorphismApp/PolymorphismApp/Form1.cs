using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolymorphismApp
{
    public partial class Form1 : Form
    {
        OpenFileDialog fileGet = new OpenFileDialog();
        LiveStock[] stock;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            fileGet.Title = "Choose text file";
            fileGet.Filter = "Text files|*.txt|All files|*.*";
            fileGet.ShowDialog();
            fileBox.Text = fileGet.FileName;
        }//end of choosing file

        private void runQuery_Click(object sender, EventArgs e)
        {
            //initialize Utilities
            Utilities.cowMilkPrice = double.Parse(cowMilkPriceBox.Text);
            Utilities.goatMilkPrice = double.Parse(goatMilkPriceBox.Text);
            Utilities.cowVacc = double.Parse(cowVaccBox.Text);
            Utilities.jCowVacc = double.Parse(jCowVaccBox.Text);
            Utilities.goatVacc = double.Parse(goatVaccBox.Text);

            //read file into array 
            string file = fileBox.Text;
            string[] lines = System.IO.File.ReadAllLines(file);
            //loop to create an array of 3 elements that hold id, milk, type
            for (int i = 0; i < lines.Length; i++)
            {
                string[] obj = lines[i].Split(',');
                try
                {
                    switch (obj[2])
                    {
                        //based on type create a new object
                        case "cow":
                            stock[i] = new Cow(Int32.Parse(obj[0]), Double.Parse(obj[1]), obj[2]);
                            break;
                        case "jersey_cow":
                            stock[i] = new JerseyCow(Int32.Parse(obj[0]), Double.Parse(obj[1]), obj[2]);
                            break;
                        case "goat":
                            stock[i] = new JerseyCow(Int32.Parse(obj[0]), Double.Parse(obj[1]), obj[2]);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    
                }
                //for each object created run the allocated claculateProfit method
                stock[i].calculateProfit();
            }
            profitLabel.Text = Convert.ToString(Utilities.profit);
        }//end of full query

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runQuery.PerformClick();
        }//end of run query from menu
    }
}
//need to add good error checking
//need to resort textboxes so when you tab it tabs in order
//maybe add a textbox for number of live stock to initialize the stock array with?
