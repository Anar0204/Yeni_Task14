using ConsoleApp1;

string text = "dasdad123k  adasd.asdadasdad";
int num = 20;



Console.WriteLine(ExtensionMethods.GetFirstSentence(text));
Console.WriteLine(ExtensionMethods.Capitalize(text));
Console.WriteLine(ExtensionMethods.GetSecondWord(text));
Console.WriteLine(ExtensionMethods.GetValueIndexes(text,'1').Length);
Console.WriteLine(ExtensionMethods.IsEven(num));
Console.WriteLine(ExtensionMethods.IsOdd(num));
Console.WriteLine(ExtensionMethods.IsContainsdigit(text));

Student student = new Student("Anar","P234",23);



Console.WriteLine(Student.CheckGroupNo("P234") );
Console.WriteLine(Student.CheckFullname("Anar Ismayilzade") );
