#include <stdio.h>
#include <stdlib.h>
int factorial_fun(int number)
{
    int i;
    int factorial=1;
    for(i=1;i<=number;i++)
    factorial =factorial*i;

    return factorial;
}

int main()
{
    int number, fac;
    printf("Pass the number:\n");
    scanf("%d", &number);
    fac = factorial_fun(number);

    printf("Factorial of that number is: %d", fac);
    return 0;
}
