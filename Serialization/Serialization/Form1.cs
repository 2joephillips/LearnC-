using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
         List<Car> cars = new List<Car>();

        //the car list has been saved to outputFile.txt
        //read the file back from outputFile.txt
         ObjectToSerialize objectToSerialize = new ObjectToSerialize();
         Serializer serializer = new Serializer();

        objectToSerialize = serializer.DeSerializeObject("outputFile.txt");
        cars = objectToSerialize.Cars;

        Car car = cars[0];
        car.Model = "Car";
        objectToSerialize.Cars = cars;
        serializer.SerializeObject("outputFile.txt", objectToSerialize);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Car> cars = new List<Car>();
            Car car = new Car() { Make = "Jeep", Model = "Wrangler", Year = 2013, Owner = new Owner() { FirstName = "Eddie", LastName = "West" } };
            Car car1 = new Car() { Make = "Mazda", Model = "CX-9", Year = 2007, Owner = new Owner() { FirstName = "Joseph", LastName = "Phillips" } };
            cars.Add(car);
            cars.Add(car1);

            //save the car list to a file
            ObjectToSerialize objectToSerialize = new ObjectToSerialize();
            objectToSerialize.Cars = cars;

            Serializer serializer = new Serializer();
            serializer.SerializeObject("outputFile.txt", objectToSerialize);

           
            this.OLVCars.SetObjects(cars);
           
        }

        private void OLVCars_BeforeCreatingGroups(object sender, BrightIdeasSoftware.CreateGroupsEventArgs e)
        {
            this.olvColumn1.MakeGroupies(new string[] { "Jeep", "Mazda" }, new string[] { "Car", "Cool Car", "Dumb Car" },
                new string[] { "not", "hamburger", "toast" },
                new string[] { "Pay good money -- or flee the house -- rather than eat their homecooked food",
                                "Offer to buy takeaway rather than risk what may appear on your plate",
                                "Neither spectacular nor dangerous" },
                new string[] { "", "Open calendar", "Check bank balance" });

            OLVCars.UseAlternatingBackColors = true;
            OLVCars.ShowItemCountOnGroups = true;
        }

        private void OLVCars_AfterCreatingGroups(object sender, BrightIdeasSoftware.CreateGroupsEventArgs e)
        {
         
        }
    }
}
