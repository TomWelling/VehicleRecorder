using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRecorder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Vehicle[] listOfCars = new Vehicle[50];

        public int vehicount = 0;

        public void addVehicle()
        {
            // add vehicle class
            int vehid = vehicount + 1000;
            listOfCars[vehicount] = new Vehicle(vehid,textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            listBox1.Items.Add(vehid);
            listBox2.Items.Add(vehid);
            vehicount++;

            //add them to listboxes
            listBox1.SelectedIndex = vehid - 1000;
            listBox2.SelectedIndex = vehid - 1000;
            refreshboxs();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            addVehicle();
            
        }


        //refresh the data in listBoxes
        private void refreshboxs()
        {
            //get item
            string curItem = listBox1.SelectedItem.ToString();
            int indexnum = Int32.Parse(curItem) - 1000;

            //update text
            Brand_Label.Text = listOfCars[indexnum].brand.ToString();
            Model_Label.Text = listOfCars[indexnum].model.ToString();
            Year_Label.Text = listOfCars[indexnum].year.ToString();
            Reg_Label.Text = listOfCars[indexnum].reg.ToString();
            TOTKM_Label.Text = listOfCars[indexnum].journey.kmtravelled.ToString();
            Services_Label.Text = listOfCars[indexnum].service.TotalServices.ToString();
            if (listOfCars[indexnum].service.NeedsService)
            {
                reqServ_Label.Text = "Yes";
            }else
            {
                reqServ_Label.Text = "No";
            }
            Fuel_Label.Text = listOfCars[indexnum].fuelPurchase.Economy.ToString();
            Revenue_Label.Text = "$" + listOfCars[indexnum].perKmRental.revenue.ToString();
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshboxs();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshboxs();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            string curItem = listBox2.SelectedItem.ToString();
            int indexnum = Int32.Parse(curItem) - 1000;
            

       
            int km;
  

            if (Int32.TryParse(Mod_Kms.Text, out km))
            {
                listOfCars[indexnum].addjourney(km);
            }


            int t;

     

            if (Int32.TryParse(Fuel_Box.Text, out t))
            {
                Console.WriteLine(t.ToString());
                Console.WriteLine(listOfCars[indexnum].journey.kmtravelled.ToString());

                double fe = Convert.ToDouble(t) / Convert.ToDouble(listOfCars[indexnum].journey.kmtravelled);
                fe = Math.Round(fe, 5);
                listOfCars[indexnum].addfuel(fe);
                Console.WriteLine("adding " + fe.ToString());

            }


            refreshboxs();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            string curItem = listBox2.SelectedItem.ToString();
            int indexnum = Int32.Parse(curItem) - 1000;

            LastServ_Label.Text = listOfCars[indexnum].journey.kmtravelled.ToString();

            bool s = Mod_Radio.Checked;
            if (s)
            {
                listOfCars[indexnum].addservices(1);
            }

            refreshboxs();
        }
    }
}
