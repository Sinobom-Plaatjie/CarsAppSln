using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarsApp
{
    public partial class MainPage : ContentPage
    {
        private List<Car> _cars = new List<Car>();

       

        public List<Car> Cars
        {
            get { return _cars; }
            set { _cars = value; }
        }

        public MainPage()
        {
            InitializeComponent();
            CreateCars();
            BindingContext = this;
        }
        public void CreateCars()
        {
            Car mercedes = new Car(1999, "E-Class", 0, "bmw.png", Color.Red);
            //mercedes.Colour = "Red with navy";
            mercedes.DriveFaster(10);
            _cars.Add(mercedes);

            Car angelsCar = new Car(2022, "Porsche", 0, "porche.png", Color.Pink);
            //angelsCar.Colour = "Pink";
            angelsCar.DriveFaster(120);
            _cars.Add(angelsCar);

            Car cresida = new Car(2005, "CRESIDA", 0, "cresida.png", Color.DimGray);
             cresida.DriveFaster(45);
            _cars.Add(cresida);

            Car jazz = new Car(2015, "Jazz", 0, "jazz.png", Color.FloralWhite);
             jazz.DriveFaster(15);
            _cars.Add(jazz);

            Car toyota = new Car(2005, "Mazda", 0, "mazda.png", Color.DodgerBlue);
            toyota.DriveFaster(35);
           _cars.Add(toyota);
             


        }

        private async void CarsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Car car = e.Item as Car;
            if(car != null)
            {
                await Navigation.PushAsync(new CarDetailPage(car));
            }
            
        }
    }
}
