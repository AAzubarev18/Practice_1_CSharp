using System;
using System.Diagnostics.Metrics;
using System.Linq;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* (1) Объявите переменную следующего вида: */

            int age = 18;

            string name = "John";

            string company = "Apple";

            bool IsActive = false;

            double bodyWeight = 69.55;

            /* (2) Объявите и инициализируйте переменную следующего вида: */

            int myAge = 39;

            string myName = "Alexander";

            int currentTemp = 9;

            bool IsFemale = false;

            /* (3) Напишите цикл следующего вида: */

            //a
            for (int ia = 1; ia <= 5; ia++)
                Console.WriteLine(ia);

            //b
            int ib = 0;
            while (ib < 10)
            {
                ib++;
                Console.WriteLine(ib);
            }

            //c
            int ic = 1;
            do
            {
                Console.WriteLine(ic);
                ic++;
            }
            while (ic <= 10);


            //цикл for, в котором у пользователя запрашиваются слова, затем выводится полная фраза, слова в которой разделены пробелами.

            //d         -for-
            string fullSentenceD = "";
            for (int i = 0; i < 5; i++)
            {
                string wordD = Console.ReadLine();
                fullSentenceD = fullSentenceD + " " + wordD;
            }

            Console.WriteLine(fullSentenceD);

            //e            -while-
            string fullSentenceE = "";
            int _whileCondE = 0;

            while (_whileCondE <  6)
            {
                string wordE = Console.ReadLine();
                fullSentenceE = fullSentenceE + " " + wordE;
                _whileCondE++;
            }

            Console.WriteLine(fullSentenceE);

            //f           -do while-
            string fullSentenceF = "";
            int _whileCondF = 1;
            do
            {
                string wordF = Console.ReadLine();
                fullSentenceF = fullSentenceF + " " + wordF;
                _whileCondF++;
            }
            while (_whileCondF <= 5);
            Console.WriteLine(fullSentenceF);

            /* (4) Напишите программу, которая переводит: */

            double meter = 0;
            double km = 0;
            double cm = 0;

            double mps = 0;
            double kmph = 0;

            double cels = 0;
            double far = 0;

            //a m => km
            Console.Write("Введите кол-во метров : ");
            meter = double.Parse(Console.ReadLine());
            km = meter/1000;
            Console.WriteLine("\n" + meter + "(м) = " + km + "(км)");

            //b km => cm
            Console.Write("Введите кол-во километров : ");
            km = double.Parse(Console.ReadLine());
            cm = km * 100_000;
            Console.WriteLine("\n" + km + "(км) = " + cm + "(см)");

            //c m/s => km/h
            Console.Write("Введите кол-во м/c : ");
            mps = double.Parse(Console.ReadLine());
            kmph = mps * (60*60)/1000;
            Console.WriteLine("\n" + mps + "(м/c) = " + kmph + "(км/ч)");

            //d C => F
            Console.Write("Введите кол-во градусов Цельсия : ");
            cels = double.Parse(Console.ReadLine());
            far = (cels * 9) / 5 + 32;
            Console.WriteLine("\n" + cels + "(гр.С) = " + far + "(гр.F)");



            /* (5) Напишите программу для вычисления теоремы Пифагора для разных вариаций: */
            //a дано два катета найти гип. с? a^2+b^2=c^2
            double a;
            double b;
            double c;

            //4,0
            Console.WriteLine("Укажите первый катет");
            a = double.Parse(Console.ReadLine());

            //5,0
            Console.WriteLine("Укажите второй катет");
            b = double.Parse(Console.ReadLine());

            //6,4
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            c = Math.Round(c, 2);
            Console.WriteLine("Гипотенуза равна {0}", c);

            //b дано кат. и гип. найти a^2 = c^2-b^2
            //a = 4,0
            Console.WriteLine("Укажите первый катет");
            a = double.Parse(Console.ReadLine());

            //c = 8,0
            Console.WriteLine("Укажите гиппотенузу");
            c = double.Parse(Console.ReadLine());

            //b = 6,9
            b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
            b = Math.Round(b, 2);
            Console.WriteLine("Второй катет равен {0}", b);


            /* (6) Напишите программу для вычисления выражения (а + b — f / а) + f * a * a — (a + b). 
             * Все переменные задаются пользователем. Учтите деление на 0. */
            double a6;
            double b6;
            double f6;
            double res6;

            Console.WriteLine("Укажите значение a: ");
            a6 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nУкажите значение b: ");
            b6 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nУкажите значение f: ");
            f6 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nПроизводится вычисление: ");

            if (a6 != 0)
            {
                res6  = (a6 + b6 - f6 / a6) + f6 * a6 * a6 - (a6 + b6);
                Console.WriteLine("\nОтвет: {0}", Math.Round(res6, 2));
            }
            else
                Console.WriteLine(@"Внимание! Значение операнда 'a' = 0, деление на 0 не предусмотрено!");


            /* (7) Нарисуйте прямоугольный треугольник звёздочками. Чтобы высоту треугольника можно было задавать программно. 
             Дайте возможность задавать символ для отрисовки программно. Т.е. вместо звёздочки может быть любой символ. */

            char direction;
            int height;
            char customChar;

            Console.WriteLine("Укажите сторону отрисовки : r - справа, l - слева,  ");
            direction = char.Parse(Console.ReadLine());

            Console.WriteLine("\nУкажите высоту треугольника: ");
            height = int.Parse(Console.ReadLine());

            Console.WriteLine("\nУкажите используемый символ: ");
            customChar = char.Parse(Console.ReadLine());

            if (direction == 'l')
            {
                Console.WriteLine("\n-----------------------------");
                for (int i = 1; i <= height; i++)
                {
                    //пробелы для каждой строки
                    for (int j = height - i; j >= 1; j--)
                    {
                        Console.Write(" ");
                    }

                    //символ для каждой строки
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("{0}", customChar);
                    }
                    Console.WriteLine("\n");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n-----------------------------");
                for (int i = 0; i <= height; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("{0}", customChar);
                    }
                    Console.WriteLine("\n");
                }
                Console.ReadKey();
            }


            /* (8) Напишите программу для сравнения двух целых чисел. Ввод осуществляйте через консоль. */
            int _int_a_8;
            int _int_b_8;

            Console.WriteLine("\nВведите число А: ");
            _int_a_8 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите число B: ");
            _int_b_8 = int.Parse(Console.ReadLine());

            if (_int_a_8 > _int_b_8)
            {
                Console.WriteLine("\n A({0}) > B({1}): ", _int_a_8, _int_b_8);
            }
            else if (_int_a_8 < _int_b_8)
            {
                Console.WriteLine("\n A({0}) < B({1}): ", _int_a_8, _int_b_8);
            }
            else
                Console.WriteLine("\n A({0}) = B({1}): ", _int_a_8, _int_b_8);

            /* (9) Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения заданного символа в строку. */
            //a  строка и символ указываются программно
            //b  строка и символ указываются пользователем в консоли <- текущая вариация
            //c  строка и символ указываются через аргументы командной строки

            double _proc;

            Console.WriteLine("Введите строку :");

            //A string _anyText = "MamaMylaRamu";
            //A char _anyText = "m";
            string _anyText = Console.ReadLine();

            //C args /Practice.exe MamaMylaRamu m
            //args = new string[] { "arg1", "arg2" };
            //string _anyText = args[0];
            //char _charInText = args[1];


            Console.WriteLine("Введите символ для нахождения процента его вхождения в выше указанную строку:");
            char _charInText = Console.ReadKey().KeyChar;

            int _anyTextLength = _anyText.Length;
            char[] _strArr = _anyText.ToCharArray();
            int _occur = 0;

            for (int i = 0; i < _anyTextLength; i++)
            {
                if (_strArr[i] == _charInText)
                {
                    _occur++;
                }
            }

            _proc = (Convert.ToDouble(_occur) / Convert.ToDouble(_anyTextLength) * 100);

            Console.WriteLine("\nПроцент вхождения символа {0} равен {1}%", _charInText, _proc);



            /* (10) Напишите программу, которая переводит строку в разные регистры */
            Console.WriteLine("Введите строку:");
            string _halo = "привет";
            string _InputText10 = Console.ReadLine();
            Console.WriteLine(_InputText10.ToLower());
            Console.WriteLine(_InputText10.ToUpper());

            Console.WriteLine($"{_halo.FirstOrDefault().ToString().ToUpper()}{_halo.Substring(1)}");



            /* (11) Составить алгоритм увеличения всех трех, введенных с клавиатуры, переменных на 5,если среди них есть хотя бы две равные. 
             * В противном случае выдать ответ «равных нет». */

            double a11;
            double b11;
            double c11;


            Console.WriteLine("Первая переменная: ");
            a11 = double.Parse(Console.ReadLine());

            Console.WriteLine("Вторая переменная: ");
            b11 = double.Parse(Console.ReadLine());

            Console.WriteLine("Третья переменная: ");
            c11 = double.Parse(Console.ReadLine());

            double[] _coll = new[] { a11, b11, c11 };

            var anyDuplicate = _coll.GroupBy(x => ((decimal)x)).Any(z => z.Count() > 1);

            if (anyDuplicate)
            {
                var _colX5 = _coll.Select(x => x * 5).ToList();

                Console.WriteLine("\nИтоговые значения : a={0}, b={1}, c={2}", _colX5[0], _colX5[1], _colX5[2]);
            }
            else
            {
                Console.WriteLine("Равных нет");
            }

            Console.ReadKey();

            /* (12) Напишите метод, который создаёт массив целых чисел и возвращает его.
            Размер массива нужно передавать в качестве аргумента.
            Вдобавок напишите метод, который выводит переданный массив на экран консоли. */


            int arrayLength = Convert.ToInt32(args[0]);

            int[] array12 = new int[arrayLength];

            Random randNum = new Random();

            for (int i = 0; i < array12.Length; i++)
            {
                array12[i] = randNum.Next(0, 20);
            }

            //(13) Без метода ShowArray, сразу идем на 370 строку
            ShowArray(array12);

            void ShowArray(int[] _array12)
            {
                foreach (var item in _array12)
                {
                    Console.WriteLine($"{item}");
                }
            }

            Console.ReadKey();

            /* (14) Напишите программу, в которой создаётся массив и выводится на экран консоли.
            Размер массива передавайте в качестве первого аргумента командной строки.
            Число, которым будет заполняться массив передайте через второй аргумент командной строки. */

            int arrayLength14 = Convert.ToInt32(args[0]);
            int numberToFill = Convert.ToInt32(args[1]);

            int[] array14 = new int[arrayLength14];

            Random randNum = new Random();

            for (int i = 0; i < array14.Length; i++)
            {
                array14[i] = numberToFill;
                Console.WriteLine($"{array14[i]}");
            }

            Console.ReadKey();

            /* (15) Напишите программу, в которой создаётся массив строк, который заполняется пользователем через консоль. 
               Затем этот массив должен быть выведен на экран консоли.
            */

            Console.Write("Введите 5 элементов массива: ");

            string[] _arr15 = new string[5];

            for (int i = 0; i < _arr15.Length; i++)
            {
                _arr15[i]= Console.ReadLine();
            }

            string _output = string.Join(" ", _arr15);

            Console.WriteLine("Итоговый массив: {0}", _output);

            Console.ReadKey();

            /* (16) 
             * a)Напишите метод, который создаёт двумерный массив (не зубчатый). Размеры массива передавайте через аргументы метода.
             * b)Также напишите отдельный метод для вывода двумерного массива в виде матрицы на экран консоли. 
             * Массив заполните случайными числами. */

            CreateArray16(5, 5);

            void CreateArray16(int row, int col)
            {
                int _row = row;
                int _col = col;

                int[,] _arr16 = new int[_row, _col];

                Random rn = new Random();

                for (int i = 0; i < _row; i++)
                    for (int j = 0; j < _col; j++)
                        _arr16[i, j] = rn.Next(1, 10);

                PrintOut16(_arr16);
            }

            void PrintOut16(int[,] inArray)
            {
                int _row = inArray.GetLength(0);
                int _col = inArray.GetLength(1);

                for (int i = 0; i < _row; i++)
                {
                    for (int j = 0; j < _col; j++)
                        Console.Write(String.Format("{0,3}", inArray[i, j]));
                    Console.WriteLine();
                }
            }

            Console.ReadKey();

            /* (17) Создайте одномерный массив целых чисел произвольной длины и заполните случайными числами от 1 до 100. 
             * Выведите на экран разницу максимального и минимального значений в нём.
             */

            int diff;

            Random rn = new Random();

            int _arSize17 = rn.Next(1, 10);

            int[] _arr17 = new int[_arSize17];

            for (int i = 0; i < _arSize17; i++)
                _arr17[i] = rn.Next(1, 101);

            diff = _arr17.Max() - _arr17.Min();

            Console.Write("Max значение: {0} - Min значение {1} = {2}", _arr17.Max(), _arr17.Min(), diff);

            Console.ReadKey();

            /* (18) Создайте двумерный массив целых чисел произвольной длины и заполните случайными числами от 1 до 100. 
             * Выведите на экран разницу максимального и минимального значений в каждой строке массива.
             */

            Random rn = new Random();
            int _diff;

            int _arSize18Row = rn.Next(1, 10);
            int _arSize18Col = rn.Next(2, 10);

            int[,] _arr18 = new int[_arSize18Row, _arSize18Col];

            for (int i = 0; i < _arSize18Row; i++)
                for (int j = 0; j < _arSize18Col; j++)
                    _arr18[i, j] = rn.Next(1, 100);


            for (int i = 0; i < _arSize18Row; i++)
            {
                for (int j = 0; j < _arSize18Col; j++)
                {
                    Console.Write(String.Format("{0,3}", _arr18[i, j] + " "));

                }
                Console.WriteLine();
            }

            for (int i = 0; i < _arSize18Row; i++)
            {
                int rowMin = _arr18[i, 0];
                int rowMax = _arr18[i, 0];

                for (int j = 1; j < _arSize18Col; j++)
                {
                    if (_arr18[i, j] < rowMin)
                    {
                        rowMin = _arr18[i, j];
                    }
                    if (_arr18[i, j] > rowMax)
                    {
                        rowMax = _arr18[i, j];
                    }
                }

                Console.WriteLine("Разница между Max и Min значениями в строке " + (i+1) + ": " + (rowMax - rowMin));
            }

            Console.ReadKey();

            /* (19) Напишите игру Угадай число. Программа случайно генерирует число от 1 до 100, а пользователь пытается угадать это число. 
            При успешной догадке выводите поздравление пользователя.
            */

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            int inputNumber = 0;
            while (inputNumber != randomNumber)
            {
                Console.Write("Введите число от 1 до 100: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out inputNumber))
                {
                    Console.WriteLine("Ошибка ввода. Попробуйте снова.");
                    continue;
                }
                if (inputNumber < 1 || inputNumber > 100)
                {
                    Console.WriteLine("Число должно быть от 1 до 100. Попробуйте снова.");
                    continue;
                }
                if (inputNumber != randomNumber)
                {
                    Console.WriteLine("К сожалению вы не угадали. Попробуйте снова.");
                    continue;
                }

            }

            Console.WriteLine("Поздравляем! Загаданное число угадано : " + randomNumber);
            Console.ReadKey();

            /* (20) Напишите игру Угадай число. Программа случайно генерирует число от 1 до 100, а пользователь пытается угадать это число. 
            При успешной догадке выводите поздравление пользователя. Также покажите количество попыток, принятых пользователем.
            Сделайте ограничение по попыткам. Например, если попыток больше 10, то пользователь проиграл
            Сделайте подсказки для пользователя. Если предположенное число больше загаданного, то писать в консоль об этом. Аналогично и для меньшего числа.
            */

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            int maxAttempts = 10;
            int attempts = 0;
            int userInput = 0;

            Console.WriteLine("Угадайте число от 1 до 100 за " + maxAttempts + " попыток");

            while (userInput != randomNumber && attempts < maxAttempts)
            {
                // запрашиваем ввод пользователем и проверяем его
                Console.Write("Попытка " + (attempts + 1) + ": Введите число от 1 до 100: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out userInput))
                {
                    Console.WriteLine("Ошибка ввода. Попробуйте снова.");
                    continue;
                }
                if (userInput < 1 || userInput > 100)
                {
                    Console.WriteLine("Число должно быть от 1 до 100. Попробуйте снова.");
                    continue;
                }

                attempts++; // увеличиваем количество попыток

                if (userInput < randomNumber)
                {
                    Console.WriteLine("Загаданное число больше. Попробуйте снова.");
                }
                else if (userInput > randomNumber)
                {
                    Console.WriteLine("Загаданное число меньше. Попробуйте снова.");
                }
            }

            if (userInput == randomNumber)
            {
                Console.WriteLine("Поздравляем! Загаданное число " + randomNumber + " за  угадано" + attempts + " попыток");
            }
            else
            {
                Console.WriteLine("К сожалению, вы проиграли. Загаданное число было " + randomNumber);
            }
            Console.ReadKey();

            /* (21) 
              Напишите программу для вычисления високосного года. 
                год, номер которого кратен 400, — високосный;
                остальные годы, номер которых кратен 100, — невисокосные
                остальные годы, номер которых кратен 4, — високосный;
                все остальные годы — невисокосные.
            */

            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine(year + " год - високосный");
            }
            else
            {
                Console.WriteLine(year + " год - не високосный");
            }

            Console.ReadKey();


            /* (22) Создайте перечисление (enum) для дней недели. Напишите программу, которая выводит на экран дни недели по названиям */
            Console.WriteLine("Дни недели:");
            foreach (string day in Enum.GetNames(typeof(DayOfWeek)))
            {
                Console.WriteLine(day);
            }
            Console.ReadKey();

            /* (23) Создайте перечисление (enum) для дней недели. Напишите программу, которая считывает ввод пользователя и 
             * в зависимости от его ввода (число от 1 до 7) будет выводиться на экран консоли соответствующий день недели.
            */

            Console.Write("Введите число от 1 до 7: ");
            int input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 7)
            {
                DayOfWeek day = (DayOfWeek)input;
                Console.WriteLine("День недели: " + (day - 1));
            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
            }

            Console.ReadKey();

  
        }

        enum DayOfWeek
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }

        /* (24) Создайте класс Person. Добавьте в него свойства
            FirstName, LastName, Age
            Добавьте свойство Gender - перечисление (enum) с двумя значениями
            Добавьте в класс метод для приветствия.
            Добавьте в класс статическое свойство - счётчик созданных людей. Свойство должно быть доступно только для чтения.
        */
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public GenderType Gender { get; set; }

            private static int count = 0;
            public static int Count
            {
                get { return count; }
            }

            public Person()
            {
                count++;
            }

            public enum GenderType
            {
                Male,
                Female
            }

            public void Greet()
            {
                Console.WriteLine("Приветсвуем вас, {0} !", LastName);
            }

            Animal duck = new Animal("Дональд", "Кря", "Хлебные крошки");
            Animal lion = new Animal("Симба", "Рррр", "Мясо");
            Animal owl = new Animal("Сова", "Уууу", "Мыши и насекомые");
        }

        /* (25) Создайте класс Animal. Добавьте в него свойства, соответствующие атрибутам животных (кличка, голос, предпочитаемая еда и тд). 
         * Создайте несколько экземпляров класса Animal, соответствующие разным животным.
        Добавьте в класс Animal конструктор с параметрами, которые соответствуют созданным свойствам.
        Сделайте все свойства только для чтения.
        */
        class Animal
        {
            public string NickName { get; }
            public string Sound { get; }
            public string Food { get; }


            public Animal(string name, string sound, string food)
            {
                NickName = name;
                Sound = sound;
                Food = food; 
            }
        }
    }
}