namespace ListOfPersons.Model
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string.Format("{0} ({1})", Name, Age);
            return $"{Name} ({Age})";
        }
    }
}
