namespace ConsoleApp1
{
    class Math
    {
        public static int abs(int i)
        {
            return 0;
        }
    }
    internal class FileClass
    {
        static void Main(string[] args)
        {
            Math.abs(-3);

            OtherClass oc = new OtherClass();

            Console.WriteLine("Hello World");

            List<Student> list = new List<Student>()
            {
                new Student() {name = "ddd", grade = 1},
                new Student() {name = "ccc", grade = 2},
                new Student() {name = "ddd", grade = 3},
                new Student() {name = "eee", grade = 4}
            };

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("====================");

            //foreach(var item in list)
            //{
            //    if(item.grade > 1)
            //    {
            //        list.Remove(item);
            //    }
            //}

            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            for(int i = 0; i< list.Count; i++)
            {
                if (list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }


            //Student student = new Student();
            //student.name = "무명";
            //student.grade = 1;
            //list.Add(student);

            //list.Add(new Student() { name = "무명", grade = 1});
            //list.Add(new Student() { grade = 1, name = "어쩌구" });
        }

        class ThridClass
        {

        }
    }
    internal class OtherClass
    {
        public OtherClass()
        {
        }
    }
}
