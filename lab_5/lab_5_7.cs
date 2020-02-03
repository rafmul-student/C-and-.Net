using System;
namespace lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[] { 1, 2, 3, 4, 5 };
            Matrix macierz = new Matrix(2, 3, tablica);
            int[] dimensions;        
            macierz.print();
            macierz.AddElem(9, 1, 2);
            Console.WriteLine();
            macierz.print();
            Console.WriteLine();
            macierz.GetDimensions(out dimensions);
            Console.WriteLine("Wymiary: {0}, {1}", dimensions[0], dimensions[1]);
            int val = macierz.GetValue(0, 1);
            Console.WriteLine("Pobrana Wartość: {0}", val);
            int[] tablica1 = new int[] { 1, 1, 1, 1, 1, 1 };
            Matrix macierz1 = new Matrix(2, 3, tablica1);
            int[] tablica2 = new int[] { 2, 2, 2, 2, 2, 2 };
            Matrix macierz2 = new Matrix(3, 2, tablica2);
            Matrix macierz3 = macierz1.AddMatrix(macierz2);
            Console.WriteLine();
            macierz1.print();
            Console.WriteLine();
            macierz2.print();
            Console.WriteLine();
            macierz3.print();
        }
    }

    public class Matrix
    {
        int[] _matrix;
        int c;
        int r;
        public Matrix(int columns, int rows, int[] tablica = null)
        {
            this.c = columns;
            this.r = rows;
            int min_wymiar;
            _matrix = new int[columns * rows];
            for(int i = 0; i < (columns * rows); i++)
            {
                _matrix[i] = 0;
            }
            if(tablica != null)
            {
                min_wymiar = tablica.Length > (columns * rows) ? columns * rows : tablica.Length;
                for(int i = 0; i < min_wymiar; i++)
                {
                    _matrix[i] = tablica[i];
                }
            }
        }
        public void print()
        {
            for(int i = 0; i < this.r; i++)
            {
                for(int j = 0; j < this.c; j++)
                {
                    Console.Write("[{0, 2}]", _matrix[j + i * c]);
                }
                Console.WriteLine();
            }
        }
        public void AddElem(int el, int col, int row)
        {
            _matrix[col + row * this.c] = el;
        }
        public void GetDimensions(out int[] wymiar)
        {
            wymiar = new int[] { this.c, this.r };
        }
        public int GetValue(int col, int row)
        {
            int val = _matrix[col + row * this.c];
            return val;
        }
        public Matrix AddMatrix(Matrix m)
        {
            int[] wymiar;
            int[] max_wymiar = new int[2];
            int[] min_wymiar = new int[2];
            m.GetDimensions(out wymiar);
            max_wymiar[0] = wymiar[0] > this.c ? wymiar[0] : this.c;
            max_wymiar[1] = wymiar[1] > this.r ? wymiar[1] : this.r;
            min_wymiar[0] = wymiar[0] < this.c ? wymiar[0] : this.c;
            min_wymiar[1] = wymiar[1] < this.r ? wymiar[1] : this.r;
            int[] tablica = new int[max_wymiar[0] * max_wymiar[1]];
            for(int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = 0;
            }
            for(int i = 0; i < wymiar[1]; i++)
            {
                for(int j = 0; j < wymiar[0]; j++)
                {
                    tablica[j + i * max_wymiar[1]] += m.GetValue(j, i);
                }
            }
            for (int i = 0; i < this.r; i++)
            {
                for (int j = 0; j < this.c; j++)
                {
                    tablica[j + i * max_wymiar[1]] += _matrix[j + i * c];
                }
            }

            return new Matrix(max_wymiar[0], max_wymiar[1], tablica);
        }
    }
}
