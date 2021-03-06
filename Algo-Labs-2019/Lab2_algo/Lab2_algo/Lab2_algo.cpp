#include "pch.h"
#include <iostream>
#include <math.h>
#include <Windows.h>

#define A 69069
#define C 1
#define MIN 0
#define MAX 300
#define N 1000
#define SIZE MAX - MIN + 1

int GetRand(int min, int max) {
	static int X = 1;
	long long M = pow(2, 32);
	X = abs((A * X + C) % M);
	return min + X % (max - min + 1);
}

void ClearConsole()
{
	system("@cls||clear");
}

static int DisplayMenu()
{
	int menu;
	printf("\n-------------Головне меню-------------\n");
	printf(" Виберiть одну iз запропонованих опцiй:\n");
	printf(" 1 - Згенерувати та вивести масив цілочислової послідовності псевдовипадкових значень\n");
	printf(" 2 - Розрахувати частоту інтервалів появи випадкових величин\n");
	printf(" 3 - Розрахувати статистичну імовірність появи випадкових величин\n");
	printf(" 4 - Розрахувати математичне сподівання випадкових величин\n");
	printf(" 5 - Розрахувати дисперсію випадкових величин\n");
	printf(" 6 - Розрахувати середньоквадратичне відхилення випадкових величин\n");
	printf(" 0 - Вихiд\n");
	printf("-> ");

	scanf_s("%d", &menu);
	return menu;
}

int main()
{
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	int arr[N];

	int frequency[SIZE];
	float staticProbability[SIZE];
	float mathExpectation = 0;
	float varianceOfRandNumbers = 0;

	int menu = 1;

	while (menu != 0)
	{
		getchar();
		ClearConsole();

		menu = DisplayMenu();
		switch (menu)
		{
			case 1:
			{
				ClearConsole();
				for (int i = 0; i < N; i++) {
					arr[i] = GetRand(MIN, MAX);
					printf("%d ", arr[i]);
				}

				printf("\nEnter any button...");
				getchar();
				break;
			}
			case 2:
			{
				ClearConsole();
				for (int i = 0; i < SIZE; i++)
					frequency[i] = 0;

				for (int i = 0; i < SIZE; i++)
					frequency[arr[i]]++;

				printf("\nЧастота інтервалів: \n");
				for (int i = 0; i < SIZE; i++) {
					printf(" %d => %d\n", i, frequency[i]);
				}

				printf("\nEnter any button...");
				getchar();
				break;
			}
			case 3:
			{
				ClearConsole();
				for (int i = 0; i < SIZE; i++)
					staticProbability[i] = 0;

				for (int i = 0; i < SIZE; i++)
					staticProbability[i] = (float)frequency[i] / N;

				printf("\nСтатистична імовірність: \n");
				for (int i = 0; i < SIZE; i++) {
					printf(" %d => %.3f\n", i, staticProbability[i]);
				}

				printf("\nEnter any button...");
				getchar();
				break;
			}
			case 4:
			{
				ClearConsole();
				for (int i = 0; i < SIZE; i++)
					mathExpectation += i * frequency[i];

				printf("\nМатематичне сподівання: \n");
				for (int i = 0; i < SIZE; i++) {
					printf(" %d => %.4f\n", i, staticProbability[i]);
				}
				printf("\nМатиматичне сподівання: %.3f\n", mathExpectation);

				printf("\nEnter any button...");
				getchar();
				break;
			}
			case 5:
			{
				ClearConsole();
				for (int i = 0; i < SIZE; i++)
					varianceOfRandNumbers += pow(i - mathExpectation, 2) * frequency[i];
				printf("\nДисперсія випадкової величини: %.3f\n", varianceOfRandNumbers);

				printf("\nEnter any button...");
				getchar();
				break;
			}
			case 6:
			{
				ClearConsole();
				float meanSquareDeviation = sqrt(mathExpectation);
				printf("\nСередньоквадратичне відхилення: %.3f\n", meanSquareDeviation);

				printf("\nEnter any button...");
				getchar();
				break;
			}
			case 0:
			{
				ClearConsole();
				printf("\n Вихiд...\n\n");
				exit(0);
				break;
			}
			default: 
			{
				printf("!!!Ви обрали неiснуючу опцiю!!!\n");
				printf("\nEnter any button...");
				getchar();
				break;
			}
		}
	}
}