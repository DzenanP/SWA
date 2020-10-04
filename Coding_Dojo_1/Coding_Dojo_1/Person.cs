namespace Coding_Dojo_1
{
    internal class Person
    {
        public int alter;
        public string name;

        public Person(int alter, string name)
        {
            this.alter = alter;
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name}, {alter} Jahre alt;";
        }
    }
}