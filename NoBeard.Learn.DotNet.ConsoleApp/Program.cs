int broj = 10;

//Nullable<int> slobodni = null;
int? slobodni = null;

broj = slobodni ?? 0;

slobodni += 2;

broj = slobodni.GetValueOrDefault();

if (!slobodni.HasValue)
{
    Console.Write("to je null");
}

Console.ReadLine();



