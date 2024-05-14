using ReadersNamespace;
using StudentsNamespace;
class Program
{
    static void Main()
    {
        Student[] student = new Student[3];
        student[0] = new Student("Иванов И.И.", "101", 20);
        student[1] = new Student("Петров П.П.", "102", 21);
        student[2] = new Student("Сидоров С.С.", "103", 22);

        Reader[] reader = new Reader[3];
        reader[0] = new Reader("Иванов И.И.", 1001, "Информатика", new DateTime(1995, 5, 10), "123456789");
        reader[1] = new Reader("Петров П.П.", 1002, "Филология", new DateTime(1993, 9, 20), "987654321");
        reader[2] = new Reader("Сидоров С.С.", 1003, "Биология", new DateTime(1997, 3, 15), "555555555");

        // Пример использования методов
        reader[1].TakeBook("Приключения", "Словарь");
        reader[1].TakeBook(2);
        reader[2].ReturnBook("Приключения", "Словарь", "Энциклопедия");
        reader[2].ReturnBook(3);
    }
}