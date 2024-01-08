namespace Ejercicio5Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[5];
            int[] vector2 = new int[5];
            int[] vector3 = new int[5];

            Console.WriteLine("Ingrese los valores que tendrá el vector 1:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vector1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese los valores que tendrá el vector 2:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vector2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }

            Console.WriteLine("El vector 3, es resultado de la suma de los vectores 1 y 2:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{vector3[i]} ");
            }

            Console.ReadLine(); 
        }


    }
}
