var n = int.Parse(Console.ReadLine());

for (var number = 1; number <= n; number++) {
    var sum = 0;
    for (var x = 1; x <= number / 2; x++) {
        if (number % x == 0) sum += x;
    }
    
    if (number == sum) {
        Console.WriteLine(number);
    }
}