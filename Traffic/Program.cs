// See https://aka.ms/new-console-template for more information

using TrafficLIght;

TrafficLight tl = new();
new Car(tl, 1);
new Car(tl, 2);
new Car(tl, 3);
new Taxi(tl, 4);
new Taxi(tl, 5);
new Pedestrian(tl, 7);
new Pedestrian(tl, 8);
tl.RunTrafficLight();