using System;
namespace Tests
{
	using NUnit.Framework;
	using ColaDefinitiva;

    [TestFixture] //Clase que contiene metodos de pruebas
    public class TestCola
    {
		[Test] //metodo de test
		public void TestCreaCola()
        {
			var cola = new Cola<int>();

			cola.Add(1);
			cola.Add(2);

			Assert.AreEqual( 2, cola.Longitud );

			while(!cola.EstaVacia){
				cola.Elimina();
			}

			Assert.AreEqual(0, cola.Longitud);
        
		}

        [Test]
		public void TestFinal(){
			var cola = new Cola<int>();

            cola.Add(1);
			Assert.AreEqual(1, cola.Final);
            cola.Add(2);
			Assert.AreEqual(2, cola.Final);
		}
    }
}
