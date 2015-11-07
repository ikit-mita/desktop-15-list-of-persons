using ListOfPersons.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace ListOfPersons.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Persons = new ObservableCollection<Person>()
            {
                new Person { Age = 10, Name = "Eve" },
                new Person { Age = 11, Name = "Adam" },
                new Person { Age = 100, Name = "Sauron" },
                new Person { Age = 42, Name = "Marty" },
            };
        }

        public ObservableCollection<Person> Persons { get; }

        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { _selectedPerson = value; }
        }

        public void AddNewPerson(string name, int age)
        {
            var newPerson = new Person
            {
                Name = name,
                Age = age
            };

            Persons.Add(newPerson);
        }

        public void RemovePerson()
        {
            if(SelectedPerson != null)
            {
                Persons.Remove(SelectedPerson);
            }
        }
    }
}
