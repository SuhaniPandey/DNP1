// See https://aka.ms/new-console-template for more information

using DoctorsWaitingRoom;

WaitingRoom waitingRoom= new WaitingRoom();

Patient patient=new Patient(waitingRoom);
Patient patient1= new Patient(waitingRoom);
Patient patient2=new Patient(waitingRoom);

waitingRoom.RunWaitingRoom();
