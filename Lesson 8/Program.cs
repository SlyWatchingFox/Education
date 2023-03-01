using Lesson_8;

Person person = new Person();
person.Firstname = "Вадим";
person.Lastname = "Шванов";

Person person2 = new Person();
person2.Firstname = "Иван";
person2.Lastname = "Иванов";

var d = new Doctor();
d.Firstname = "Роман";
d.Lastname = "Романов";
d.Specia = "sgdg";

Console.WriteLine(d.Firstname);
Console.WriteLine(d.Lastname);
Console.WriteLine(d.Specia);

Person p = d;

Console.WriteLine(p.Firstname);
Console.WriteLine(p.Lastname);
// Console.WriteLine(p.Specia);  // ошибка. не наследует специлизацию

Doctor dd = (Doctor)p;

Console.WriteLine(dd.Firstname);
Console.WriteLine(dd.Lastname);
Console.WriteLine(dd.Specia);