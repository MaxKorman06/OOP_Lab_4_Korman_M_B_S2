using System;
using System.Collections;

namespace OOP_Lab_3_Korman_M_B_S2
{
    class Program
    {
        public enum Computer
        {
            Laptop,
            PersonalComputer,
            Tablet
        }
        public class Person
        {
            private string name;
            private string surname;
            private System.DateTime dataBirth;
            public Person(string name, string surname, System.DateTime dataBirth)
            {
                this.dataBirth = dataBirth;
                this.name = name;
                this.surname = surname;
            }
            public Person()
            {
                this.dataBirth = new DateTime();
                this.name = "NONE";
                this.surname = "NONE";
            }
            public void setName(string name)
            {
                this.name = name;
            }
            public void setSurname(string surname)
            {
                this.surname = surname;
            }
            public void setDataBirth(System.DateTime dataBirth)
            {
                this.dataBirth = dataBirth;
            }
            public string getName()
            {
                return name;
            }
            public string getSurname()
            {
                return surname;
            }
            public System.DateTime getDataBirth()
            {
                return dataBirth;
            }
            public void setYearBirth(int Year)
            {
                dataBirth = dataBirth.AddYears(-dataBirth.Year + 1);
                dataBirth = dataBirth.AddYears(Year - 1);
            }
            public int getYearBirth()
            {
                return dataBirth.Year;
            }
            public override string ToString()
            {
                return "Name: " + getName() + " Surname: " + getSurname() + "\n" + dataBirth;
            }
            virtual public string ToShortString()
            {
                return "Name: " + getName() + " Surname: " + getSurname();
            }
            public override bool Equals(object obj)
            {
                if (obj is Person != true)
                {
                    return false;
                }

                var team = (Person)obj;
                if (team.GetHashCode() == this.GetHashCode())
                {
                    return true;
                }
                return false;
            }
            public static bool operator ==(Person p1, Person p2)
            {
                return p1.Equals(p2);
            }

            public static bool operator !=(Person p1, Person p2)
            {
                return !p1.Equals(p2);
            }

            public override int GetHashCode()
            {
                return Convert.ToInt32(name) * Convert.ToInt32(surname) * Convert.ToInt32(dataBirth);
            }
            public object DeepCopy()
            {
                var copy = new Person(name, surname, dataBirth);
                return copy;
            }
        }

        public class Specifications
        {
            public Person person;
            public string operatingSystem;
            public double screenSize;

            public Specifications(Person person, string operatingSystem, double screenSize)
            {
                this.person = person;
                this.operatingSystem = operatingSystem;
                this.screenSize = screenSize;
            }
            public Specifications()
            {
                person = new Person();
                operatingSystem = "Bandera OS";
                screenSize = 17;
            }
            public Person getPerson()
            {
                return person;
            }
            public string getOperationSystem()
            {
                return operatingSystem;
            }
            public double getScreenSize()
            {
                return screenSize;
            }
            public void setPerson(Person person)
            {
                this.person = person;
            }
            public void setOperationSystem(string operatingSystem)
            {
                this.operatingSystem = operatingSystem;
            }
            public void setScreenSize(double screenSize)
            {
                this.screenSize = screenSize;
            }
            public override string ToString()
            {
                return "\nPerson:\n" + getPerson() + "\n\nOperating System: " + getOperationSystem() + "\n\nScreen Size; " + getScreenSize();
            }
            public object DeepCopy()
            {
                var copy = new Specifications(person, operatingSystem, screenSize);
                return copy;
            }
        }
        public class Settings
        {
            protected string descriptionOfTheTechnique;
            protected DateTime dateRelease;
            protected uint versionRelease;
            private ArrayList listdetails;
            public void AddDetails(ArrayList details)
            {
                listdetails.AddRange(details);
            }
            public ArrayList Listdetails
            {
                get
                {
                    return listdetails;
                }
            }
            public Settings(string descriptionOfTheTechnique, DateTime dateRelease, uint versionRelease)
            {
                this.descriptionOfTheTechnique = descriptionOfTheTechnique;
                this.dateRelease = dateRelease;
                this.versionRelease = versionRelease;
            }
            public Settings()
            {
                descriptionOfTheTechnique = "Файна нова";
                dateRelease = DateTime.MinValue;
                versionRelease = 1;
                listdetails = new ArrayList();
            }
            public void setDescriptionOfTheTechnique(string descriptionOfTheTechnique)
            {
                this.descriptionOfTheTechnique = descriptionOfTheTechnique;
            }
            public string getDescriptionOfTheTechnique()
            {
                return descriptionOfTheTechnique;
            }
            public DateTime getDateRelease()
            {
                return dateRelease;
            }
            public void setDateRelease(DateTime dateRelease)
            {
                this.dateRelease = dateRelease;
            }
            public override bool Equals(object obj)
            {
                if (obj is Settings != true)
                {
                    return false;
                }

                var team = (Settings)obj;
                if (team.GetHashCode() == this.GetHashCode())
                {
                    return true;
                }
                return false;
            }
            public void setVersionRelease(uint versionRelease)
            {
                this.versionRelease = versionRelease;
            }
            public uint getVersionRelease()
            {
                return versionRelease;
            }
            public static bool operator ==(Settings p1, Settings p2)
            {
                return p1.Equals(p2);
            }

            public static bool operator !=(Settings p1, Settings p2)
            {
                return !p1.Equals(p2);
            }

            public override int GetHashCode()
            {
                return descriptionOfTheTechnique.Length * dateRelease.Year * dateRelease.Day * dateRelease.Month * versionRelease.GetHashCode();
            }
            public override string ToString()
            {
                return "Description Of The Technique: " + getDescriptionOfTheTechnique() + "\nDate Release: " + getDateRelease();
            }
        }
        public class ExtendedSpecifications : Settings
        {
            private Computer typeComputer;
            private Specifications[] listOfManufacturersOfParts;
            public ExtendedSpecifications(string descriptionOfTheTechnique, Computer typeComputer, DateTime dateRelease, uint versionRelease)
            {
                this.descriptionOfTheTechnique = descriptionOfTheTechnique;
                this.typeComputer = typeComputer;
                this.dateRelease = dateRelease;
                this.versionRelease = versionRelease;
            }
            public ExtendedSpecifications()
            {
                descriptionOfTheTechnique = "Файна нова";
                typeComputer = Computer.PersonalComputer;
                dateRelease = DateTime.MinValue;
                versionRelease = 1;
            }
            public Computer getTypeComputer()
            {
                return typeComputer;
            }
            public Specifications[] getListOfManufacturersOfParts()
            {
                return listOfManufacturersOfParts;
            }
            public void setTypeComputer(Computer typeComputer)
            {
                this.typeComputer = typeComputer;
            }

            public void setListOfManufacturersOfParts(Specifications[] listOfManufacturersOfParts)
            {
                this.listOfManufacturersOfParts = listOfManufacturersOfParts;
            }
            public bool indexator(Computer arr)
            {
                if (arr == typeComputer)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void AddSpecifications(params Specifications[] arr)
            {
                listOfManufacturersOfParts = arr;
            }
            public override string ToString()
            {
                return "Description Of The Technique: " + getDescriptionOfTheTechnique() + "\nType Computer: " + getTypeComputer() + "\nDate Release: " + getDateRelease() + "\nVersion Release: " + getVersionRelease() + "\nList Of Manufacturers Of Parts: " + getListOfManufacturersOfParts();
            }
            virtual public string ToShortString()
            {
                return "Description Of The Technique: " + getDescriptionOfTheTechnique() + "\nType Computer: " + getTypeComputer() + "\nDate Release: " + getDateRelease() + "\nVersion Release: " + getVersionRelease();
            }
            public object DeepCopy()
            {
                var copy = new ExtendedSpecifications(descriptionOfTheTechnique, typeComputer, dateRelease, versionRelease);
                return copy;
            }
        }
        interface IRateAndCopy
        {
            Double Rating
            {
                get;
            }
            object DeepCopy();
        }

        static void Main(string[] args)
        {
            // Підпункт 1
            Console.WriteLine("Підпункт 1\n");
            Settings a1 = new Settings();
            Settings b1 = new Settings();
            Console.WriteLine(a1.GetType());
            Console.WriteLine(a1.GetHashCode() == b1.GetHashCode());
            Console.WriteLine(a1 == b1);

            // Підпункт 2
            Console.WriteLine("\nПідпункт 2\n");
            Settings a2 = new Settings();
            uint b2;
            Console.WriteLine("Введіть занчення зерійгоного номера: ");
            try
            {
                
                b2 = Convert.ToUInt32(Console.ReadLine());
                a2.setVersionRelease(b2);
            }
            catch (Exception)
            {
                Console.WriteLine("Значення серіного номера відємне!");
            }


            // Підпункт 3
            Console.WriteLine("\nПідпункт 3\n");
            ExtendedSpecifications сClass = new ExtendedSpecifications();
            Specifications[] spec = new Specifications[1];
            spec[0] = new Specifications();
            сClass.AddSpecifications(spec[0]);
            Console.WriteLine(spec[0]);

            // Підпункт 4
            ExtendedSpecifications a4 = new ExtendedSpecifications();
            Console.WriteLine("\nПідпункт 4\n" + "\nОпис: " + a4.getDescriptionOfTheTechnique() + "\nЧас релізу: " + a4.getDateRelease() + "\nВерсія " + a4.getVersionRelease());

            // Підпункт 5
            ExtendedSpecifications original = new ExtendedSpecifications();
            Console.WriteLine("\nПідпункт 5\n" + "\nОригінальний клас:\n" + original);
            ExtendedSpecifications copy = (ExtendedSpecifications)original.DeepCopy();
            original.setDescriptionOfTheTechnique("Глянц нове");
            Console.WriteLine("\nКопійований клас:\n" + copy);
            Console.WriteLine("\nОригіннальний змінений клас:\n" + original);

            // Підпункт 6 
            Console.WriteLine("\nПідпункт 6\n");
            Settings a6 = new Settings();
            ArrayList temp = new ArrayList()
            {
                "1",
                "2",
                "3"
            };

            a6.AddDetails(temp);
            string players = string.Empty;

            foreach (var item in a6.Listdetails)
            {
                if (Convert.ToInt32(item) > 1)
                {
                    players += "\n" + item;
                }
            }
            Console.WriteLine($"Players: {players}");
            temp.Clear();

            // Підпункт 7
            Console.WriteLine("\nПідпункт 7\n");
            Settings a7 = new Settings();
            temp.Add("detail 1");
            temp.Add("detail 2");
            temp.Add("detail 3");

            a7.AddDetails(temp);
            string players7 = string.Empty;

            foreach (var item in a7.Listdetails)
            {
                if (Convert.ToString(item) == "detail 1")
                {
                    players7 += "\n" + item;
                }
            }
            Console.WriteLine($"Players: {players7}");
        }
    }
}
