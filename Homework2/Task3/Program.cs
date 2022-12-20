using static System.Console;

Clear();

Write("Введите номер дня недели: ");
int day = Convert.ToInt32(ReadLine());

WriteLine(day >= 1 && day <= 7 ? day == 6 || day == 7 ? "Выходной день" : "Будний день" : "Несуществующий день недели");
