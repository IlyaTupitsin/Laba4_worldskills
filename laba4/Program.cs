using reader;
using student;
class Program
{
    static void Main()
    {
        Student[] students = new Student[3];
        students[0] = new("Иванов И.И.", "22ит35", 19);
        students[1] = new("Петров П.П.", "22ит35", 20);
        students[2] = new("Алёшин А.А.", "22ит35", 22);

        Reader[] readers = new Reader[3];
        readers[0] = new("Иванов И.И.", 3425, "Иформационные технологии", new DateTime(2022, 2, 22), "+88005553535");
        readers[1] = new("Петров П.П.", 3426, "Иформационные технологии", new DateTime(2022, 2, 23), "+88035554536");
        readers[2] = new("Алёшин А.А.", 3427, "Иформационные технологии", new DateTime(2022, 2, 22), "+88035555556");

        string[] books = { "Приключения", "Словарь", "Энциклопедия" };

        readers[0].takeBook(books);
        readers[0].takeBook(students[0].name, 3);
        readers[1].returnBook(books);
        readers[1].returnBook(students[1].name, 2);
    }
}