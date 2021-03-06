#include "pch.h"
#include <iostream>
#include <locale.h>

union Num {
	struct {
		unsigned char n1 : 1;
		unsigned char n2 : 1;
		unsigned char n3 : 1;
		unsigned char n4 : 1;
		unsigned char n5 : 1;
		unsigned char n6 : 1;
		unsigned char n7 : 1;
		unsigned char n8 : 1;
		unsigned char n9 : 1;
		unsigned char n10 : 1;
		unsigned char n11 : 1;
		unsigned char n12 : 1;
		unsigned char n13 : 1;
		unsigned char n14 : 1;
		unsigned char n15 : 1;
		unsigned char sign : 1;
	}bit;
	signed short wholeNum;
}num;

int main()
{
	setlocale(LC_ALL, "Rus");
	printf("Введите число: ");
	scanf_s("%d", &num.wholeNum);
	printf("\n Значение: %d", num.wholeNum);
	printf("\n Битовый код: %d%d%d%d %d%d%d%d %d%d%d%d %d%d%d%d", num.bit.sign, num.bit.n15, num.bit.n14, num.bit.n13, num.bit.n12, num.bit.n11, num.bit.n10, num.bit.n9, num.bit.n8, num.bit.n7, num.bit.n6, num.bit.n5, num.bit.n4, num.bit.n3, num.bit.n2, num.bit.n1);
	printf("\n Знак: (%d) ", num.bit.sign);
	if(num.bit.sign == 0)
		printf("\"+\"");
	else
		printf("\"-\"");
	printf("\n\n\n");
}
