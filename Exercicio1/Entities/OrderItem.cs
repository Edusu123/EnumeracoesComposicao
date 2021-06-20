namespace Exercicio1.Entities
{
    class OrderItem
    {
        #region Propriedades

        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; } = new Product();

        #endregion

        #region Construtores

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        #endregion

        #region Métodos

        public double SubTotal()
        {
            Price = Quantity * Product.Price;
            return Price;
        }

        #endregion
    }
}
