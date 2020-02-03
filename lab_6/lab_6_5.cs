using System; 
namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeA A = new HomeA(20);
            Console.WriteLine(A.Price());
        }

        abstract public class Home
        {
            protected int price;
            public Home(int _price)
            {
                this.price = _price;
            }
            abstract public void SetPrice(int _price);
            abstract public int Price();
        }
        public class HomeA : Home
        {
            public HomeA(int _price) : base(_price)
            {           }
            override public void SetPrice(int _price)
            {
                this.price = _price;
            }
            override public int Price()
            {
                return this.price;
            }
        }
    }
}
