#include "pch.h"
#include <iostream>
#include <locale.h>

union num {

	struct {
		struct {
			unsigned char n1 : 1;
			unsigned char n2 : 1;
			unsigned char n3 : 1;
			unsigned char n4 : 1;
			unsigned char n5 : 1;
			unsigned char n6 : 1;
			unsigned char n7 : 1;
			unsigned char n8 : 1;
		}b1;
		struct {
			unsigned char n9 : 1;
			unsigned char n10 : 1;
			unsigned char n11 : 1;
			unsigned char n12 : 1;
			unsigned char n13 : 1;
			unsigned char n14 : 1;
			unsigned char n15 : 1;
			unsigned char n16 : 1;
		}b2;
		struct {
			unsigned char n17 : 1;
			unsigned char n18 : 1;
			unsigned char n19 : 1;
			unsigned char n20 : 1;
			unsigned char n21 : 1;
			unsigned char n22 : 1;
			unsigned char n23 : 1;
			unsigned char n24 : 1;
		}b3;
		struct {
			unsigned char n25 : 1;
			unsigned char n26 : 1;
			unsigned char n27 : 1;
			unsigned char n28 : 1;
			unsigned char n29 : 1;
			unsigned char n30 : 1;
			unsigned char n31 : 1;
			unsigned char n32 : 1;
		}b4;
	} bit;
	float wholeNum;
}Num;

int main()
{
	setlocale(LC_ALL, "Rus");
	Num.wholeNum = -37501;

	printf(" %d%d%d%d%d%d%d%d", Num.bit.b4.n32, Num.bit.b4.n31, Num.bit.b4.n30, Num.bit.b4.n29, Num.bit.b4.n28, Num.bit.b4.n27, Num.bit.b4.n26, Num.bit.b4.n25);
	printf("\t%d%d%d%d%d%d%d%d", Num.bit.b3.n24, Num.bit.b3.n23, Num.bit.b3.n22, Num.bit.b3.n21, Num.bit.b3.n20, Num.bit.b3.n19, Num.bit.b3.n18, Num.bit.b3.n17);
	printf("\t%d%d%d%d%d%d%d%d", Num.bit.b2.n16, Num.bit.b2.n15, Num.bit.b2.n14, Num.bit.b2.n13, Num.bit.b2.n12, Num.bit.b2.n11, Num.bit.b2.n10, Num.bit.b2.n9);
	printf("\t%d%d%d%d%d%d%d%d\n", Num.bit.b1.n8, Num.bit.b1.n7, Num.bit.b1.n6, Num.bit.b1.n5, Num.bit.b1.n4, Num.bit.b1.n3, Num.bit.b1.n2, Num.bit.b1.n1);

	printf(" 1байт - %d \t2байт - %d \t3байт - %d \t4байт - %d\n", Num.bit.b4, Num.bit.b3, Num.bit.b2, Num.bit.b1);

	printf(" Мантисса - %d%d%d%d%d%d%d", Num.bit.b3.n23, Num.bit.b3.n22, Num.bit.b3.n21, Num.bit.b3.n20, Num.bit.b3.n19, Num.bit.b3.n18, Num.bit.b3.n17);
	printf(" %d%d%d%d%d%d%d%d", Num.bit.b2.n16, Num.bit.b2.n15, Num.bit.b2.n14, Num.bit.b2.n13, Num.bit.b2.n12, Num.bit.b2.n11, Num.bit.b2.n10, Num.bit.b2.n9);
	printf(" %d%d%d%d%d%d%d%d\n", Num.bit.b1.n8, Num.bit.b1.n7, Num.bit.b1.n6, Num.bit.b1.n5, Num.bit.b1.n4, Num.bit.b1.n3, Num.bit.b1.n2, Num.bit.b1.n1);

	printf(" Знак - %d \n Размер - %dбайт", Num.bit.b4.n32, sizeof(num));
	printf("\n\n");
}
