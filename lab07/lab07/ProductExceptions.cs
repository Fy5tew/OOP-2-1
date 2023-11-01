using System;

namespace lab07 {
    public class ProductException : Exception {
        public ProductException() : base() { }

        public ProductException(string message) : base(message) { }
    }


    public class ProductPriceException : ProductException {
        public decimal? InvalidPrice = null;

        public ProductPriceException() : base("Invalid product price") { }

        public ProductPriceException(string message) : base(message) { }

        public ProductPriceException(decimal price) : this($"Invalid product price: {price}") {
            InvalidPrice = price;
        }

        public ProductPriceException(string message, decimal price) : this(message) {
            InvalidPrice = price;
        }
    }


    public class ProductWeightException : ProductException {
        public decimal? InvalidWeight = null;

        public ProductWeightException() : base("Invalid product weight") { }

        public ProductWeightException(string message) : base(message) { }

        public ProductWeightException(decimal weight) : this($"Invalid product weight: {weight}") {
            InvalidWeight = weight;
        }

        public ProductWeightException(string message, decimal weight) : this(message) {
            InvalidWeight = weight;
        }
    }
}
