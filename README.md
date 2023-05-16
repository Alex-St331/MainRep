# MainRep
All my little Code Scraps and little Projects
# Explanations:  
# Python:

    # Fibonacci Sequence:

    This script calculates the nth number in the Fibonacci sequence, 
    which is a series of numbers in which each number is the sum of the two preceding ones, usually starting with 0 and 1. 
    The function fibonacci(n) takes an integer n and returns the nth Fibonacci number. 
    This function first checks if n is positive, then if n is 1 or 2 it returns 0 or 1, 
    respectively. For larger n, it uses a loop to calculate the nth Fibonacci number.

    # Prime Number Checker:

    This script checks if a number is a prime number. 
    A prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself. 
    The function is_prime(n) takes an integer n and returns True if n is a prime number, 
    and False otherwise. It does this by checking if n is divisible by any number up to the square root of n.

    # Bubble Sort Algorithm:

    This script implements the bubble sort algorithm,
    which is a simple sorting algorithm that repeatedly steps through the list, 
    compares adjacent elements and swaps them if they are in the wrong order. 
    The pass through the list is repeated until the list is sorted. 
    The function bubble_sort(lst) takes a list of numbers lst and returns the sorted list.

    # Binary Search Algorithm:

    This script implements the binary search algorithm, which is used to find the position of a specific value in a sorted array. 
    The function binary_search(lst, low, high, x) takes a sorted list lst, the starting index low, the ending index high, 
    and the value to search for x. It returns the index of x if x is in lst, 
    and -1 otherwise. Binary search works by repeatedly dividing the search interval in half. 
    If the value of the search key is less than the item in the middle of the interval, 
    the next interval will be the lower half. Otherwise, the next interval will be the upper half.

    # Palindromic String Checker:

    This script checks if a string is a palindrome. A palindrome is a word, phrase, number, 
    or other sequences of characters that reads the same forward and backward (ignoring spaces, punctuation, and capitalization).
     The function is_palindrome(s) takes a string s and returns True if s is a palindrome, 
     and False otherwise. It does this by checking if the string s is the same as its reverse.


# C#

    # Factorial of a number:

    This script calculates the factorial of a number. 
    The factorial of a non-negative integer n is the product of all positive integers less than or equal to n. 
    The function Factorial(int n) accomplishes this by using a recursive approach where the function is called within itself. 
    In the case where n equals 0, it will return 1 (as 0! equals 1), 
    otherwise, it calls itself with the argument n - 1 and multiplies the result by n.

    # Check for Armstrong number:

    This script checks whether a number is an Armstrong number. 
    An Armstrong number of three digits is an integer such that the sum of the cubes of its digits is equal to the number itself. 
    The function IsArmstrong(int num) accomplishes this by taking a number as input, 
    looping through each digit in the number, cubing it, and summing it. 
    If the resulting sum is equal to the original number, the function returns true; otherwise, it returns false.

    # Linear Search Algorithm:

    This script implements a linear search algorithm, which is a simple search method used to find a value within an array (or list). 
    It works by sequentially checking each element in the list for the target value until a match is found or until all the elements have been searched. 
    The function LinearSearch(int[] arr, int x) accomplishes this by iterating over the array arr until it finds the element x and then returns its index. 
    If the element is not found, the function returns -1.

    # Selection Sort Algorithm:

    This script implements a selection sort algorithm. 
    Selection sort is a simple sorting algorithm that improves on the bubble sort by making only one exchange for every pass through the list.
    The function SelectionSort(int[] arr) accomplishes this by repeatedly finding 
    the minimum element from the unsorted part of the array and swapping it with the beginning of the unsorted part.

    # Palindrome Checker for a Sentence:

    This script checks whether a sentence (or word) is a palindrome. 
    A palindrome is a string that reads the same backward as forward, ignoring spaces, punctuation, and word boundaries. 
    The function IsPalindrome(string s) accomplishes this by first 
    removing all non-alphanumeric characters from the input string and converting it to lowercase to standardize it. 
    It then reverses the cleaned string and checks if it is equal to the original cleaned string. If so, it returns true; otherwise, it returns false.

# Java

    Will come later

# TypeScript

    Will come later

# Rust

    Will come later
