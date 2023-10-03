// Итоговая контрольная работа
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
//   [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//   [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//   [“Russia”, “Denmark”, “Kazan”] → []
string [] stringArrayInput = new string [4]; // Первый массив
int count = 0; // счетчик 1
for (int i = 0; i < stringArrayInput.Length; i++)  // Выесняем длинну 2-го массива. Длина 2-го массива ровна count
{
    Console.WriteLine("Введите название строки: ");
    stringArrayInput[i] = Convert.ToString(Console.ReadLine());   // Вводим  названия для массива
    if (stringArrayInput[i].Length <= 3)   // Проверяем чтобы длинна строки была меньше или ровна 3
        {
            count++ ;
        }
}
int count2 = 0;     // счетчик 2, нужен для переноса нужных строк массива из 1-го во 2-ой массив(т.е. строк <= 3)
string [] stringArrayOutput = new string [count];    // Второй массив
for (int i = 0; i < stringArrayInput.Length; i++)    // Подставляем нужные строки из 1-го во 2-ой массив
{
    if (stringArrayInput[i].Length <= 3)
    {
        count2++ ;
        stringArrayOutput[count2 - 1] = stringArrayInput[i];
    }
}