def fibonacci(n):
    if n <= 0:
        print("Input should be a positive integer.")
    else:
        a, b = 0, 1
        print(a, end=' ')
        if n > 1:
            print(b, end=' ')
        for _ in range(2, n):
            a, b = b, a + b
            print(b, end=' ')
        print()

fibonacci(10)
