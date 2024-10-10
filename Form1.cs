using System.Diagnostics;

namespace GraafoczmaWersa
{


    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Liczba_Losowa()
            {
                Random Losowe = new Random(); //Randomizacija
                int min = 1;//od 1
                int max = 10;//do 9
                int rand = Losowe.Next(min, max);
                double randomValueInRange = (Convert.ToDouble(rand));
                return randomValueInRange;
            }

        string MatrixToString(double[,] matrix, int size)
            {
                string result = "";
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        result += $"{matrix[i, j]:F2}\t";
                    }
                    result += Environment.NewLine;
                }
                return result;
            }

            Stopwatch stopwatch = new Stopwatch();


            int Size = 3; // Zmienna do testów, mo¿esz zmieniæ na potrzebn¹ wartoœæ

            double[,] MatrixA = new double[Size, Size]; // Tworzenie macierzy A
            double[,] MatrixL = new double[Size, Size]; // Tworzenie macierzy L
            double[,] MatrixU = new double[Size, Size]; // Tworzenie macierzy U


            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {

                    MatrixA[i, j] = Liczba_Losowa(); //Wype³nianie Macierzy A wartoœciami losowymi
                }
            }
            stopwatch.Start();//Pocz¹tek Zegara
            for (int i = 0; i < Size; i++)
            {
                MatrixL[i, i] = 1; //Ustawianie przk¹tnej w Macierzy L //Mo¿e zadzia³ac bez tego
                for (int j = 0; j < Size; j++)
                {
                    MatrixU[i, j] = MatrixA[i, j]; // Przekopowywanie Macierzy A do Macierzu U
                }
            }

            for (int i = 0; i < Size - 1; i++)
            {
                for (int j = i + 1; j < Size; j++)
                {
                    if (MatrixU[i, i] != 0.0)
                    {
                        MatrixL[j, i] = MatrixU[j, i] / MatrixU[i, i]; // lji = aji / aii //Czarna Magia
                    }
                    else
                    {
                        MatrixL[j, i] = 0.0;
                    }

                    for (int k = i; k < Size; k++)
                    {
                        MatrixU[j, k] -= MatrixL[j, i] * MatrixU[i, k]; // ajk = ajk - lji * aik //Czarna Magia ci¹g dalczy
                    }
                }
            }


            stopwatch.Stop();//Zatrzymanie Stopera
            textBox1.Text = MatrixToString(MatrixA, Size);
            textBox2.Text = MatrixToString(MatrixL, Size);
            textBox3.Text = MatrixToString(MatrixU, Size);

        }

    }

}
