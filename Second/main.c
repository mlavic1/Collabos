#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num, factor,i=0,j;
    int primeFactors[50];
    printf("Enter a number: ");
    scanf ("%d", &num);
    factor = 2;
    while (num > 1)
      {
           while (num % factor == 0)
          {
                primeFactors[i]=factor;
                i++;
                num /= factor;
          }
                 factor++;
      }
      printf("Array is: \n");
      for(j=0;j<i;j++)
        printf("%d,", primeFactors[j]);
    return 0;
}
