using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person Martin;

        [SetUp]
        public void Setup()
        {
            Martin = new Person("Martin Perciante","5.216.698-7");
        }

        [Test]
        public void Nombre_No_Valido() // Verifica que el nombre se cambie cuando este es valido
        {
            string ExpectedName = "Alfredo Galvan";
            Martin.Name = ExpectedName;
            Assert.AreEqual(Martin.Name,ExpectedName);
        }
        [Test]
        public void Nombre_Vacio() // Verifica que el nombre no se cambie cuando este es vacio
        {
            string ExpectedName = Martin.Name;
            Martin.Name = "";
            Assert.AreEqual(Martin.Name,ExpectedName);
        }
        [Test]
        public void ID_Valido() // Verifica que el id se cambie cuando este es valido
        {
            string ExpectedID = "1.234.567-8";
            Martin.ID = ExpectedID;
            Assert.AreEqual(Martin.ID,ExpectedID);
        }
        [Test]
        public void ID_No_Valido() // Verifica que el id no se cambie cuando este no es valido
        {
            string ExpectedID = Martin.ID;
            Martin.ID = "5.216.698-8";
            Assert.AreEqual(Martin.ID,ExpectedID);
        }
    }
}