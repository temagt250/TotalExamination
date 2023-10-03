# Итоговая контрольная работа
## Задача
### Написать программу, которая из имеющегося массива строк формирует новый массив из строк,длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
### Примеры:
    [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
    [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
    [“Russia”, “Denmark”, “Kazan”] → []
### 1.
    Выесняем длинну 2-го массива. Длина 2-го массива ровна count
    Вводим  названия для массива
    Проверяем чтобы длинна строки была меньше или ровна 3
### 2.
    Добавляем счетчик 2, нужен для переноса нужных строк массива из 1-го во 2-ой массив (т.е. строк <= 3)
    Добавляем второй массив
### 3.
    Подставляем нужные строки из 1-го во 2-ой массив