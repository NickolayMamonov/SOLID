using Dependency_Inversion;

var car = new Car("Skoda","Octavia","Engine",new PaintingBox());
car.CheckProblem();
car.Repair();

var car2 = new Car("Skoda","Octavia","Engine",new RepairBox());
car2.CheckProblem();
car2.Repair();