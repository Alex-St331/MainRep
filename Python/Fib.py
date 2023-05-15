#This is a Fibonacci Script, it gives out the first 100 Fibonacci numbers.

x, y, Counter = 0, 1, 1
while Counter <= 100:
    print(x)
    x, y = y, x + y
    Counter += 1