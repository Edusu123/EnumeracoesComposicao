namespace Exercicio1.Entities
{
    class Product
    {
        #region Propriedades

        public string Name { get; set; }
        public double Price { get; set; }

        #endregion

        #region Construtores

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        #endregion
    }
}
