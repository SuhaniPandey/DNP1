// See https://aka.ms/new-console-template for more information


using BirdWatcher;

Bird bird= new ();
Observer observer= new Observer(bird,1);
Observer observer1= new Observer(bird,2);
Observer observer2= new Observer(bird,3);
bird.ChangeBehaviour();