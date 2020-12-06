using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLTest
{
    public class ProductRepositoryTest
    {

        public void Retrieve(int v)
        {

            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sunflower",
                ProductDescreption = "Bright yellow ",
                CurrentPrice = 15.99M,
            };

            var actual = productRepository.Retrieve(2);

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescreption, actual.ProductDescreption);
            Assert.AreEqual(expected.ProductName, actual.ProductName);



        }

        public void SaveTestMissingPrice()
        {
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescreption = " Bright yellow sunflower",
                ProductName = "sunflower",
                HasChanged = true,
            };
            var actual = productRepository.Save(updateProduct);
            Assert.AreEqual(false, actual);

        }
    }
}
