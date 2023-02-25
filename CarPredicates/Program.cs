// See https://aka.ms/new-console-template for more information

using CarPredicates;

Car car= new Car("Green","20",300,true);
Car car1= new Car("Green","50",700,true);
Car car2= new Car("Red","5000",200,false);


List<Car> cars = new List<Car>();
cars.Add(car);
cars.Add(car1);
cars.Add(car2);
car.GetListOfType(cars,"Green");



//Console.WriteLine(car.ToString());
