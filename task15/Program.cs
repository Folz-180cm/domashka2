// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int inputnum = Convert.ToInt32(Console.ReadLine());
if(inputnum>0&&inputnum<8){
    if(inputnum == 1){
        Console.WriteLine("Нет");
    }
    else if(inputnum == 2){
        Console.WriteLine("Нет");
    }
    else if(inputnum == 3){
        Console.WriteLine("Нет");
    }
    else if(inputnum == 4){
        Console.WriteLine("Нет");
    }
    else if(inputnum == 5){
        Console.WriteLine("Нет");
    }
    else if(inputnum == 6){
        Console.WriteLine("Да");
    }
    else{
        Console.WriteLine("Да");
    }
}
else{
    Console.WriteLine("Введите другое число");
}