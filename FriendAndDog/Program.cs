//Console.Write("Введите дистанцию между друзьями - ");
//int distance = Convert.ToInt32(Console.ReadLine());

int distance = 10000;
int firstFrienSpeed = 1;
int secondFrienSpeed = 2;
int dogSpeed = 5;

int count = 0;
int friend = 2;
int time;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFrienSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFrienSpeed + dogSpeed);
        friend = 1;
    }

    distance = distance - (firstFrienSpeed + secondFrienSpeed) * time;
    count = count + 1;

}

Console.WriteLine(count);