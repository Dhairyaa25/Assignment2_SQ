using NUnit.Framework;
using SQ_Assignment2_G13;

namespace SQ_Assignment2_G13.Tests
{
    [TestFixture]
    public class ProductTests
    {// Product ID Tests
        [Test]
        public void ProductID_ValidID_SetsCorrectly()
        {
            // Arrange
            int productId = 1000;
            string productName = "Diamond";
            decimal price = 1000.59m;
            int stock = 10;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Assert
            Assert.AreEqual(productId, product.ProductID);
        }

        [Test]
        public void ProductID_MinimumID_Valid()
        {
            // Arrange
            int productId = 4;
            string productName = "Diamond";
            decimal price = 1000.59m;
            int stock = 10;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Assert
            Assert.AreEqual(productId, product.ProductID);
        }

        [Test]
        public void ProductID_MaximumID_Valid()
        {
            // Arrange
            int productId = 40000;
            string productName = "Diamond";
            decimal price = 1000.59m;
            int stock = 10;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Assert
            Assert.AreEqual(productId, product.ProductID);
        }

        // Product Name Tests
        [Test]
        public void ProductName_ValidName_SetsCorrectly()
        {
            // Arrange
            int productId = 1000;
            string productName = "Gold";
            decimal price = 1000.59m;
            int stock = 10;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Assert
            Assert.AreEqual(productName, product.ProductName);
        }

        [Test]
        public void ProductName_EmptyName_AllowCreation()
        {
            // Arrange
            int productId = 1000;
            string productName = "Platinum";
            decimal price = 1000.59m;
            int stock = 10;

            // Act & Assert
            Assert.DoesNotThrow(() => new Product(productId, productName, price, stock));
        }

        [Test]
        public void ProductName_NullName_AllowCreation()
        {
            // Arrange
            int productId = 1000;
            string productName = null;
            decimal price = 1000.59m;
            int stock = 10;

            // Act & Assert
            Assert.DoesNotThrow(() => new Product(productId, productName, price, stock));
        }

        // Price Tests
        [Test]
        public void Price_ValidPrice_SetsCorrectly()
        {
            // Arrange
            int productId = 1000;
            string productName = "Diamond";
            decimal price = 1000.59m;
            int stock = 10;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Assert
            Assert.AreEqual(price, product.Price);
        }

        [Test]
        public void Price_MinimumPrice_Valid()
        {
            // Arrange
            int productId = 1000;
            string productName = "Diamond";
            decimal price = 4.00m;
            int stock = 10;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Assert
            Assert.AreEqual(price, product.Price);
        }

        [Test]
        public void Price_MaximumPrice_Valid()
        {
            // Arrange
            int productId = 1000;
            string productName = "Diamond";
            decimal price = 4000.00m;
            int stock = 10;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Assert
            Assert.AreEqual(price, product.Price);
        }

        // Stock Tests
        [Test]
        public void Stock_ValidStock_SetsCorrectly()
        {
            // Arrange
            int productId = 1000;
            string productName = "Diamond";
            decimal price = 1000.59m;
            int stock = 10;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Assert
            Assert.AreEqual(stock, product.Stock);
        }

        [Test]
        public void Stock_MinimumStock_Valid()
        {
            // Arrange
            int productId = 1000;
            string productName = "Diamond";
            decimal price = 1000.59m;
            int stock = 4;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Assert
            Assert.AreEqual(stock, product.Stock);
        }

        [Test]
        public void Stock_MaximumStock_Valid()
        {
            // Arrange
            int productId = 1000;
            string productName = "Diamond";
            decimal price = 1000.59m;
            int stock = 400000;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Assert
            Assert.AreEqual(stock, product.Stock);
        }

        // Increase Stock Tests
        [Test]
        public void IncreaseStock_PositiveAmount_StockIncreased()
        {
            // Arrange
            int productId = 1000;
            string productName = "Diamond";
            decimal price = 1000.59m;
            int stock = 400000;
            int amountToAdd = 50;

            // Act
            Product product = new Product(productId, productName, price, stock);
            product.IncreaseStock(amountToAdd);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(stock + amountToAdd));
        }

        [Test]
        public void IncreaseStock_NegativeAmount_StockNotChanged()
        {
            // Arrange
            int productId = 1000;
            string productName = "Diamond";
            decimal price = 1000.59m;
            int stock = 400000;
            int amountToAdd = -50;

            // Act
            Product product = new Product(productId, productName, price, stock);
            product.IncreaseStock(amountToAdd);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(stock));
        }

        [Test]
        public void IncreaseStock_ZeroAmount_StockNotChanged()
        {
            // Arrange

            int productId = 1000;
            string productName = "Diamond";
            decimal price = 1000.59m;
            int stock = 400000;
            int amountToAdd = 0;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Act
            product.IncreaseStock(amountToAdd);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(stock));
        }
        //Remove 
        [Test]
        public void DecreaseStock_PositiveAmount_StockDecreased()
        {
            // Arrange
            int productId = 1000;
            string productName = "Diamond";
            decimal price = 1000.59m;
            int stock = 400000;
            int stockRemove = 4000;


            // Act
            Product product = new Product(productId, productName, price, stock);
            product.DecreaseStock(stockRemove);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(stock - stockRemove));
        }

        [Test]
        public void DecreaseStock_NegativeAmount_StockNotChanged()
        {
            // Arrange
            int productId = 1000;
            string productName = "Diamond";
            decimal price = 1000.59m;
            int stock = 400000;
            int stockRemove = -450;
            int expectedvalue = 400000;


            // Act
            Product product = new Product(productId, productName, price, stock);
            product.DecreaseStock(stockRemove);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(expectedvalue));
        }
        [Test]
        public void DecreaseStock_ZeroAmount_StockNotChanged()
        {
            // Arrange
            int productId = 1000;
            string productName = "Diamond";
            decimal price = 1000.59m;
            int stock = 400000;
            int stockRemove = 0;
            int expectedvalue = 400000;

            // Act
            Product product = new Product(productId, productName, price, stock);
            product.DecreaseStock(stockRemove);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(expectedvalue));
        }


    }


}
