namespace Cars
{
    class Car
    {
        private string _carModel;
        private string _carBrand;
        private int _carYear;
        public Car(string carModel,string carBrand,int carYear)
        {
            _carModel = carModel;
            _carBrand = carBrand;
            _carYear = carYear;
        }
        public void CarInfo()
        {
            System.Console.WriteLine("Car Model`{0},Car Brand`{1},Car Year`{2}",_carModel,_carBrand,_carYear);
        }
    }
}
