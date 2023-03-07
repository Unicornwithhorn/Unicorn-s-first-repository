int count = 0, distance = 10000, FirstFriendSpeed = 1, SecondFriendSpeed = 2, DogSpeed = 5, friends = 2, time = 0;
while (distance > 10)
{
  if (friends == 1)
  {
    time=distance/(FirstFriendSpeed+DogSpeed);
    friends=2;
  }
  if (friends == 2)
  {
    time=distance/(SecondFriendSpeed+DogSpeed);
    friends=1;
  }
  distance=distance-(FirstFriendSpeed+SecondFriendSpeed)*time;
  count++;
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");