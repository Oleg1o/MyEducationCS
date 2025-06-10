Console.WriteLine("This program is designed to compare three numbers. The output is always from smaller to larger.");
Console.WriteLine("Enter first int number: ");
    var numberOne = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Enter second int number: ");
    var numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third int number: ");
    var numberThree = Convert.ToInt32(Console.ReadLine());


if (numberThree > numberTwo)
{
    if (numberOne < numberTwo)
    {
        if (numberOne > numberThree)
        {
            Console.WriteLine($"num3 = {numberThree} > num2 = {numberTwo} > num1 = {numberOne}");
        }
    }
    else if (numberOne > numberTwo)
    {
        if (numberOne < numberThree)
        {
            Console.WriteLine($"num3 = {numberThree} > num1 = {numberOne} > num2 = {numberTwo}");
        }
        else
        {
            Console.WriteLine($"num1 = {numberOne} > num3 = {numberThree} > num2 = {numberTwo}");
        }
    }
}
else if (numberThree < numberTwo)
{
    if (numberOne < numberTwo)
    {
        if (numberOne > numberThree)
        {
            Console.WriteLine($"num2 = {numberTwo} > num1 = {numberOne} > num3 = {numberThree}");
        }
        else
        {
            Console.WriteLine($"num2 = {numberTwo} > num3 = {numberThree} > num1 = {numberOne}");
        }
    }
    else if (numberOne > numberTwo)
    {
        if (numberOne > numberThree)
        {
            Console.WriteLine($"num1 = {numberOne} > num2 = {numberTwo} > num3 = {numberThree}");
        }
    }
}



// Логику сравнения чисел вынести в функцию которая принимает три числа в виде массива
// Возможно можно упростить логику ифов потому что выглядит страшно много, подумай как
// Доп задания:
// Функция CompareNumbers которая будет возвращать true если числа идут по возрастанию или false если нет, принмать функция будет массив чисел которые ты считал с консоли
// Еще можно написать функцию которая берет три числа и возвращает их в отсортированном порядке, если найдешь как написать в одну строку то будет круто (подсказка LINQ)
// Если будешь делать задачу выше то сделай два варианта, метод который изменяет исходный массив и метод который возвращает новый массив а старый остается как был