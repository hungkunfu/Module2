namespace QuanLiDanhSachProduct
{
    public class Product
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string desription;
        double price;
        public Product() { }
        public Product(string name, string desription, double price)
        {
            this.name = name;
            this.desription = desription;
            this.price = price;

        }
        public string ViewInfo()
        {
            return $"{name} \t\t\t {desription} \t\t\t {price}";
        }

    }
}