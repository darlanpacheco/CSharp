class Program
{
    enum Frutas { abacaxi = 10, banana, tomate, caju, laranja };

    static void outArg()
    {
        int result;

        // Chamando o método com argumento out
        outArgFunc(out result);

        Console.WriteLine(result);
    }

    static void outArgFunc(out int sum)
    {
        // Calcula a soma e preenche a variável out com o resultado
        sum = 5 + 10;
    }

    static void enumFunction()
    {
        Frutas frutaFavorita = Frutas.banana;

        Console.WriteLine($"Fruta favorita: {frutaFavorita}\n\"Index\" fruta favorita: {(int)frutaFavorita}\n\"Index\" 12 fruta: {(Frutas)12}");
    }

    static void listsFunction()
    {
        List<float> numerosFavoritos = new List<float>() { 25, 75, 7.5f, 50, 2.5f };
        // List<float> pioresNumeros = new List<float>(){32, 41, 36, 88, 66, 34};
        float[] pioresNumeros = { 32, 41, 36, 88, 66, 34 };

        numerosFavoritos.Add(100);

        Console.WriteLine($"Index do valor 100: {numerosFavoritos.IndexOf(100)}");
        Console.WriteLine($"Contém o valor 30: {numerosFavoritos.Contains(30)}");
        numerosFavoritos.Clear();
        numerosFavoritos.AddRange(pioresNumeros);
        Console.WriteLine($"Contém o valor 30: {numerosFavoritos.Contains(30)}");

        foreach (int i in numerosFavoritos)
        {
            Console.WriteLine(i);
        }
    }

    static void ternary()
    {
        bool b = 5 > 10 ? true : false;
        Console.WriteLine(b);
    }

    static void bitwise()
    {
        int i = 5 << 3;
        int i2 = 10 >> 3;
        Console.WriteLine($"[Left: {i}]\n[Right: {i2}]");
    }

    static void bArrays()
    {
        int[,] bArray = new int[3, 5];

        ////3
        //5// 25,50,100,200,400
        // 10,20,40,80,160
        // 15,30,60,120,240

        bArray[0, 0] = 25;
        bArray[0, 1] = 50;
        bArray[0, 2] = 100;
        bArray[0, 3] = 200;
        bArray[0, 4] = 400;

        bArray[1, 0] = 10;
        bArray[1, 1] = 20;
        bArray[1, 2] = 40;
        bArray[1, 3] = 80;
        bArray[1, 4] = 160;

        bArray[2, 0] = 15;
        bArray[2, 1] = 30;
        bArray[2, 2] = 60;
        bArray[2, 3] = 120;
        bArray[2, 4] = 240;

        int[,] bArray2 =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {1, 5, 2}
        };

        Console.WriteLine($"{bArray2[3, 1]}, {bArray[0, 3]}");
    }

    static void refPass()
    {
        int num = 50;
        refPassFunc(ref num);
        Console.WriteLine(num);
    }

    static void refPassFunc(ref int value)
    {
        value = value * 2;
    }

    static void paramsFunction(params int[] numbers)
    {
        Console.WriteLine(numbers[1]);
    }

    /*
    static void Main()
    {
        enumFunction();
        listsFunction();
        ternary();
        bitwise();
        bArrays();
        refPass();
        outArg();
        paramsFunction(5, 3, 15, 8, 58);
    }
    */
}
