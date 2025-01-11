

using DependencyInjection;

Teacher1 teacher=new Teacher1("İrem","Kaya");

ClassRoom classRoom=new ClassRoom(teacher);


Console.WriteLine(classRoom.GetInfoTeacher());

Teacher2 teacher2 = new Teacher2("Alaattin", "Kaya",25);

ClassRoom classRoom2 = new ClassRoom(teacher2);
Console.WriteLine("-------------");

Console.WriteLine(classRoom2.GetInfoTeacher());



Console.ReadKey();
