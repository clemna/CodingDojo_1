using System;

namespace CodingDojo1
{
    internal class TestObj
    {
        public int Age { get; set; }
        public string Name { get; set; }


        public TestObj(int age, string name)
        {
            this.Age = age;

            this.Name = name;
        }

        public override string ToString()
        {
            return String.Format("{0} : {1}", Name, Age);
        }
    }
}