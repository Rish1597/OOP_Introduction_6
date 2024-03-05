using System;


namespace ClassActivity_Inheritence
{
    public class Vehicle
    {
        //two properties of class vehicles
        public string Vehicle_Registration_Number { get; set; }
        public string Vehicle_Owner { get; set; }

        // Constructor
        public Vehicle(string Vehicle_Registration_Number, string Vehicle_Owner)
        {
            this.Vehicle_Registration_Number = Vehicle_Registration_Number;
            this.Vehicle_Owner = Vehicle_Owner;
        }

        //2 behaviors of class vehicles

    }

    public class Car : Vehicle
    {
        // 2 properties of class car
        public string Car_Manufacturer { get; set; }
        public string Car_Color { get; set; }

        //constructor

        public Car(string Vehicle_Registration_Number, string Vehicle_Owner, string Car_Manufacturer, string Car_Color) : base(Vehicle_Registration_Number, Vehicle_Owner)
        {
            this.Car_Manufacturer = Car_Manufacturer;
            this.Car_Color = Car_Color;
        }

    }
}
