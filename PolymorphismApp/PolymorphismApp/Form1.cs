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
        
        
        public Form1()
        {
            InitializeComponent();
        }

        //Variables
        OpenFileDialog fileGet = new OpenFileDialog();

        private void fileButton_Click(object sender, EventArgs e)
        {
            fileGet.Title = "Choose text file";
            fileGet.Filter = "Text files|*.txt|All files|*.*";
            fileGet.ShowDialog();
            fileBox.Text = fileGet.FileName;
        }//end of choosing file

        private void runQuery_Click(object sender, EventArgs e)
        {
            //reset label
            profitLabel.Text = "0";
            //initialize Utilities
            try
            {
                Utilities.cowMilkPrice = double.Parse(cowMilkPriceBox.Text);
                Utilities.goatMilkPrice = double.Parse(goatMilkPriceBox.Text);
                Utilities.cowVacc = double.Parse(cowVaccBox.Text);
                Utilities.jCowVacc = double.Parse(jCowVaccBox.Text);
                Utilities.goatVacc = double.Parse(goatVaccBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid values");
            }

            //read file into array 
            string file = fileBox.Text;
            //create an array with object creation parameters
            try
            {
                string[] lines = System.IO.File.ReadAllLines(file);
                //create blank array of objects
                LiveStock[] stock = new LiveStock[lines.Length];
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
                        //for each object created run the allocated claculateProfit method
                        stock[i].calculateProfit();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid object reference in text file");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //display profit
            profitLabel.Text = Convert.ToString(Utilities.profit);

            //reset profit for re-run
            Utilities.profit = 0;
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runQuery.PerformClick();
        }//end of run query from menu

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
//need to add good error checking
//need to resort textboxes so when you tab it tabs in order
//maybe add a textbox for number of live stock to initialize the stock array with?
