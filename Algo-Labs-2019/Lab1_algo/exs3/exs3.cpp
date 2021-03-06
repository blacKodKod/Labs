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
	short wholeNum;
}num;

void printInBites(int number) {
	num.wholeNum = number;

	printf("\n   %d", num.wholeNum);
	printf("\t\t %d%d%d%d %d%d%d%d %d%d%d%d %d%d%d%d", num.bit.sign, num.bit.n15, num.bit.n14, num.bit.n13, num.bit.n12, num.bit.n11, num.bit.n10, num.bit.n9, num.bit.n8, num.bit.n7, num.bit.n6, num.bit.n5, num.bit.n4, num.bit.n3, num.bit.n2, num.bit.n1);
}

int main()
{
	setlocale(LC_ALL, "Rus");
	printf(" Значение: \t Битовый код:");
	printInBites((signed char)(5 + 127));
	printInBites((signed char)(2 - 3));
	printInBites((signed char)(-120 - 34));
	printInBites((unsigned char)((signed char)(-5)));
	printInBites((signed char)(56 & 38));
	printInBites((signed char)(56 | 38));

	printf("\n\n\n");
}
