using System;
using System.Collections.Generic;
namespace lab_1_2_3_4
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 1, 2, 3 i 4\n");
            ChristmasTree ct = new ChristmasTree("Jodła", 12);
            ct.AddBauble("Red", "Angel");
            ct.AddBauble("White", "Bauble");
            ct.AddBauble("Green", "Tree");
            ct.AddBauble("Blue", "Santa");
            ct.AddBauble("Red", "Stick");
            ct.AddBauble("White", "Star");
            ct.RemoveBauble(1);
            ct.print();
            Console.WriteLine("{0}", ct[2]);
            Console.WriteLine("{0}", ct["Black"]);
            Console.WriteLine("{0}", ct["Red"]);
            Console.WriteLine("{0}", ct["White"]);
            ct[2] = "Yellow";
            ct.print();
           // Cwiczenie 2
            ChristmasTreeA A = new ChristmasTreeA("Nie jodła", 3);
            A.AddBauble("Blue", "Santa");
            A.print();
            Console.WriteLine("\n{0} {1} {2}", A[0], ((ChristmasTree)A)[0], A.BaubleColor(0));
            // Cwiczenie 3
            ChristmasTreeB B = new ChristmasTreeB("A może jodła", 4);
            B.AddBauble("Black", "Bubble");
            B.print();
            Console.WriteLine("\n{0} {1} {2}", B[0], ((ChristmasTreeA)B)[0], B.BaubleColor(0));
            // Cwiczenie 4
            ChristmasTreeB C = new ChristmasTreeB("A jednak jodła", 4);
            C.AddBauble("Black", "Bubble");
            C.print();
            Console.WriteLine("\n{0} {1} {2}", C[0], ((ChristmasTreeA)C)[0], C.BaubleColor(0));
        }
    }
    public class Tree
    {
        public string Name;
        public int Age;
        public Tree(string _name, int _age)
        {
            this.Name = _name;
            this.Age = _age;
        }
    }
    public class Fir : Tree
    {
        public Fir(string _name, int _age) : base(_name, _age)
        {       }
    }
    public class ChristmasTree : Fir
    {
        protected Bauble Baubles;
        protected int indexer_count;
        public ChristmasTree(string _name, int _age) : base(_name, _age)
        {
            Baubles = new Bauble();
        }
        protected class Bauble
        {
            public List<string> Color;
            public List<string> Shape;
            public int Amount;
            public Bauble()
            {
                Color = new List<string>();
                Shape = new List<string>();
                Amount = 0;
            }
        }
        public void AddBauble(string _color, string _shape)
        {
            Baubles.Color.Add(_color);
            Baubles.Shape.Add(_shape);
            Baubles.Amount += 1;
        }
        public void RemoveBauble(int _index)
        {
            if ( Baubles.Amount == 0 )
            {
                Console.WriteLine("Nie ma bąbek :P");
                return;
            }
            if ( _index < Baubles.Amount )
            {
                Baubles.Color.RemoveAt(_index);
                Baubles.Shape.RemoveAt(_index);
                Baubles.Amount -= 1;
            }
            else
            {
                Console.WriteLine("Poza zakresem");
            }
        }
        virtual public string this[int _index]
        {
            get
            {
                return Baubles.Color[_index];
            }
            set
            {
                Baubles.Color[_index] = value;
            }
        }
        public int this[string _color]
        {
            get
            {
                indexer_count = 0;
                for ( int i = 0; i < Baubles.Amount; i++ )
                {
                    if ( Baubles.Color[i] == _color)
                    {
                        indexer_count += 1;
                    }
                }
                return indexer_count;
            }
        }
        public void print()
        {
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Age: {0}", this.Age);
            Console.WriteLine("Baubles:");
            for ( int i = 0; i < Baubles.Amount; i++ )
            {
                Console.WriteLine("\t{0} {1}", Baubles.Color[i], Baubles.Shape[i]);
            }
        }

    }
    public class ChristmasTreeA : ChristmasTree
    {
        public ChristmasTreeA(string _name, int _age) : base(_name, _age)
        { }
        override public string this[int _index]
        {
            get
            {
                return Baubles.Shape[_index];
            }
            set
            {
                Baubles.Color[_index] = value;
            }
        }
        public string BaubleColor(int _index)
        {
            return base[_index];
        }
    }
    public class ChristmasTreeB : ChristmasTreeA
    {
        public ChristmasTreeB(string _name, int _age) : base(_name, _age)
        {      }
        new public string this[int _index]
        {
            get
            {
                return Baubles.Color[_index] + "_" + Baubles.Shape[_index];
            }
            set
            {
                Baubles.Color[_index] = value;
            }
        }
    }
    public sealed class ChristmasTreeC : ChristmasTreeB
    {
        public ChristmasTreeC(string _name, int _age) : base(_name, _age)
        {   }
    }
}
