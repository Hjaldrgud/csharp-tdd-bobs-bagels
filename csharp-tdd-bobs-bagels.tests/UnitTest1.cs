using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{

    [Test, Order(1)]
    [TestCase("Egg", 3, true)]
    [TestCase("Sourdough", 3, true)]
    [TestCase("Blueberry", 3, true)]
    [TestCase("Failberry", 2, false)]
    public void Test_01_addBagel(string type, int amount, bool actualResult)
    {
        //Arrange
        Basket basket = new Basket();


        //Act
        bool expectedResult = basket.addBagel(type, amount);

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test, Order(2)]
    [TestCase("Egg", 3, 7)]
    [TestCase("Sourdough", 2, 5)]
    [TestCase("Blueberry", 1, 4)]
    public void Test_02_removeBagel(string type, int amount, int actualResult)
    {
        //Arrange
        Basket basket = new Basket();


        //Act
        basket.removeBagel(type, amount);

        int expectedResult = basket.checkCurrentBasketCapacity();

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test, Order(2)]
    public void Test_03_removeAllBagels()
    {
        //Arrange
        Basket basket = new Basket();


        //Act
        basket.removeAllBagels();
        int expectedResult = basket.checkCurrentBasketCapacity();

        int actualResult = 0;
        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }


    [Test, Order(3)]
    public void Test_04_checkCurrentBasketCapacity()
    {
        //Arrange
        Basket basket = new Basket();
        basket.addBagel("Egg", 3);
        basket.addBagel("Sourdough", 2);

        //Act
        int currentSize = basket.checkCurrentBasketCapacity();

        int totalSize = basket.checkTotalBasketCapacity();

        int expectedResult = totalSize - currentSize;
        //Assert
        Assert.That(expectedResult, Is.EqualTo(5));
    }


    [Test, Order(5)]
    public void Test_05_checkTotalBasketCapacity()
    {
        //Arrange
        Basket basket = new Basket();
        basket.addBagel("Egg", 3);
        basket.addBagel("Sourdough", 2);

        //Act
        int expectedResult = basket.checkTotalBasketCapacity();

        //Assert
        Assert.That(expectedResult, Is.EqualTo(10));
    }

    [Test, Order(6)]
    [TestCase(10)]
    [TestCase(5)]
    public void Test_06_changeBasketSize(int newSize)
    {
        //Arrange
        Basket basket = new Basket();

        //Act
        basket.changeBasketSize(newSize)
        int expectedResult = basket.checkTotalBasketCapacity();

        //Assert
        Assert.That(expectedResult, Is.EqualTo(newSize);
    }

    [Test, Order(7)]
    [TestCase("", true)]
    [TestCase("", true)]
    [TestCase("", false)]
    public void Test_07_checkIfBagelIsInBasket(string type, bool actualResult)
    {
        //Arrange
        Basket basket = new Basket();

        //Act
        bool expectedResult = basket.checkIfBagelIsInBasket(type);

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }
}