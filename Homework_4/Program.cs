using Homework_4;

class Program
{
    static void Main()
    {
        //List<Person> people = new List<Person>();

        //for (int i = 0; i < 6; i++)
        //{
        //    Person person = new Person();
        //    person.Input();
        //    people.Add(person);
        //}

        List<Person> people = new List<Person>()
        {
            new Person("Nastya", new DateTime(2005, 4, 3)),
            new Person("Liza", new DateTime(2004, 5, 6)),
            new Person("Vova", new DateTime(2009, 9, 2)),
            new Person("Nazar", new DateTime(2005, 7, 8)),
            new Person("Nika", new DateTime(2008, 3, 6)),
            new Person("Jeni", new DateTime(2012, 2, 1)),
        };

        foreach (Person person in people)
        {
            Console.WriteLine(person.ToString());
        }
        Console.WriteLine("\nЗмiнити iм'я осiб, вiк яких менше 16 рокiв, на 'Дуже молодий':");

        foreach (var person in people)
        {
            if (person.Age() < 16)
            {
                person.ChangeName("Дуже молодий");
            }
        }

        Console.WriteLine("\nIнформацiя про всiх людей пiсля змiни iмен:");

        foreach (var person in people)
        {
            person.Output();
        }

        Console.WriteLine("\nОсоби з однаковими iменами:");
        for (int i = 0; i < people.Count; i++)
        {
            for (int j = i + 1; j < people.Count; j++)
            {
                if (people[i].Name == people[j].Name)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Особа {i + 1}: {people[i].Name}, Вiк: {people[i].Age()}");
                    Console.WriteLine($"Особа {j + 1}: {people[j].Name}, Вiк: {people[j].Age()}");
                }   // перевіряє усі пари повторюваних осіб
            }
        }

    }
}


























