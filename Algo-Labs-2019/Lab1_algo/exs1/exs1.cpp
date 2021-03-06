#include "pch.h"
#include <iostream>
#include <locale.h>
#include <time.h>
#pragma warning(disable : 4996)

struct Date
{
	unsigned char nHours : 5;
	unsigned char nMinutes : 6;
	unsigned char nSeconds : 6;
	unsigned char nMonthDay : 5;
	unsigned char nMonth : 5;
	unsigned char nYear : 8;
}date;

int main()
{
	setlocale(LC_ALL, "Rus");
	time_t Time = time(NULL);
	tm *aTime = localtime(&Time);
	date.nHours = aTime->tm_hour;
	date.nMinutes = aTime->tm_min;
	date.nSeconds = aTime->tm_sec;
	date.nMonthDay = aTime->tm_mday;
	date.nMonth = aTime->tm_mon;
	
	printf("Дата и время:\t%.2d/%.2d/2019    %.2d:%.2d:%.2d", date.nMonthDay, date.nMonth + 1, date.nHours, date.nMinutes, date.nSeconds);
	printf("\nРазмер: %d байт - %d байт\n\n\n", sizeof(Date), sizeof(tm));
	system("pause");
}