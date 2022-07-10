// Дополнительная задача 74*: 4 друга должны посетить 12 пабов, в котором выпить 
// по британской пинте пенного напитка. До каждого бара идти примерно 15-20 минут, 
// каждый пьет пинту за 15 минут. У первого друга лимит выпитого 1.1 литра, у 
// второго 1.5, у третьего 2.2 литра, у 4 - 3.3 литра, это их максимум. Необходимо 
// выяснить, до скольки баров смогут дойти каждый из друзей(Пройденное расстояние 
// (в барах)), пока не упадет. И сколько всего времени будет потрачено на выпивку.

Console.Clear();

// 1 английская пинта = 0,568261 литра

double englishPint = 0.568261;
double averageTravelTime = (15 + 20) / 2;
double timeForADrink = 15;
double firstFriendDrinkLimit = 1.1;
double secondFriendDrinkLimit = 1.5;
double thirdFriendDrinkLimit = 2.2;
double fourthFriendDrinkLimit = 3.3;
string firstFriend = "Первый друг";
string secondFriend = "Второй друг";
string thirdFriend = "Третий друг";
string fourthFriend = "Четвертый друг";

PubsCount(firstFriendDrinkLimit, firstFriend);
PubsCount(secondFriendDrinkLimit, secondFriend);
PubsCount(thirdFriendDrinkLimit, thirdFriend);
PubsCount(fourthFriendDrinkLimit, fourthFriend);

void PubsCount(double drinkLimit, string friend)
{
    double pubsCount = Math.Floor(drinkLimit / englishPint);
    double timeCount = Math.Round((averageTravelTime + timeForADrink) * 
    (pubsCount + 1) + (drinkLimit / englishPint - pubsCount) * timeForADrink);
    if (pubsCount == 1)
    {
        Console.Write($"{friend} осилил {pubsCount} паб и на {pubsCount + 1}-м УПАЛ!!! ");
        Console.WriteLine($"При этом потратил на выпивку около {timeCount} минут!"); 
        Console.WriteLine();
    }
    else if (pubsCount > 1 && pubsCount < 5)
    {   
        Console.Write($"{friend} осилил {pubsCount} паба и на {pubsCount + 1}-м УПАЛ!!! ");
        Console.WriteLine($"При этом потратил на выпивку около {timeCount} минут!"); 
        Console.WriteLine();
    }
    else
    {
        Console.Write($"{friend} осилил {pubsCount} пабов и на {pubsCount + 1}-м УПАЛ!!! ");
        Console.WriteLine($"При этом потратил на выпивку около {timeCount} минут!"); 
        Console.WriteLine();
    }
}

