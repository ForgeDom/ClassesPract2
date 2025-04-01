namespace ClassesPract2.Class
{
    internal class Matrix
    {
        private int[,] _matrix;
        private int _rows;
        private int _columns;

        public int Rows
        {
            get { return _rows; }
            set { _rows = value; }
        }

        public int Columns
        {
            get { return _columns; }
            set { _columns = value; }
        }

        public int this[int row, int column]
        {
            get { return _matrix[row, column]; }
            set { _matrix[row, column] = value; }
        }

        public Matrix()
        {
            _rows = 0;
            _columns = 0;
            _matrix = new int[0, 0];
        }

        public Matrix(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            _matrix = new int[rows, columns];
        }

        public void Input()
        {
            Console.WriteLine("Enter the number of rows:");
            _rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns:");
            _columns = Convert.ToInt32(Console.ReadLine());

            _matrix = new int[_rows, _columns];

            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    _matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Input(int rows, int columns, int minValue, int maxValue)
        {
            _rows = rows;
            _columns = columns;
            _matrix = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    _matrix[i, j] = random.Next(minValue, maxValue + 1);
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write($"{_matrix[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        public int GetMaximum()
        {
            int max = _matrix[0, 0];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (_matrix[i, j] > max)
                        max = _matrix[i, j];
                }
            }
            return max;
        }

        public int GetMinimum()
        {
            int min = _matrix[0, 0];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (_matrix[i, j] < min)
                        min = _matrix[i, j];
                }
            }
            return min;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a._rows != b._rows || a._columns != b._columns)
                throw new InvalidOperationException("Matrices must have the same dimensions for addition.");

            Matrix result = new Matrix(a._rows, a._columns);
            for (int i = 0; i < a._rows; i++)
            {
                for (int j = 0; j < a._columns; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a._rows != b._rows || a._columns != b._columns)
                throw new InvalidOperationException("Matrices must have the same dimensions for subtraction.");

            Matrix result = new Matrix(a._rows, a._columns);
            for (int i = 0; i < a._rows; i++)
            {
                for (int j = 0; j < a._columns; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a._columns != b._rows)
                throw new InvalidOperationException("Number of columns in the first matrix must be equal to the number of rows in the second matrix.");

            Matrix result = new Matrix(a._rows, b._columns);
            for (int i = 0; i < a._rows; i++)
            {
                for (int j = 0; j < b._columns; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < a._columns; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix a, int scalar)
        {
            Matrix result = new Matrix(a._rows, a._columns);
            for (int i = 0; i < a._rows; i++)
            {
                for (int j = 0; j < a._columns; j++)
                {
                    result[i, j] = a[i, j] * scalar;
                }
            }
            return result;
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a._rows != b._rows || a._columns != b._columns)
                return false;

            for (int i = 0; i < a._rows; i++)
            {
                for (int j = 0; j < a._columns; j++)
                {
                    if (a[i, j] != b[i, j])
                        return false;
                }
            }
            return true;
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Matrix other)
            {
                return this == other;
            }
            return false;
        }
    }
}