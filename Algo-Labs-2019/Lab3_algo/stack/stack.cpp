#include "pch.h"
#include <iostream>
#include <conio.h>
#include <stdio.h>
#include <stdlib.h>

typedef int type;

struct elem
{
	type value;
	struct elem* next;
};

struct Stack
{
	struct elem* head;
	size_t size;
};

// Создание пустого стека
Stack* createStack(void)
{
	Stack* stack = (Stack*)malloc(sizeof(Stack));
	if (stack) {
		stack->size = 0;
		stack->head = NULL;
	}
	else
		printf("\nError, can't create a stack!!!\n");
	return stack;
}

// Проверка стека на пустоту
bool isEmptyStack(Stack* stack) {
	if (stack == NULL)
	{
		printf("\nCreate stack firstly!!!\n");
		return false;
	}

	if (!stack->head)
		return true;
	else
		return false;
}

// Удаление стека
void deleteStack(Stack *stack) {
	elem* head = stack->head;
	elem* next = NULL;
	while (head) {
		next = head->next;
		free(head);
		head = next;
	}
	free(stack);
	stack = NULL;
}

// Добавление нового узла в стек
int push(Stack* stack, type* data) {
	if (!stack)
	{
		printf("\nFirstly create a stack\n");
		return -1;
	}
	elem* node = (elem*)malloc(sizeof(elem));
	if (!node) {
		printf("\nError, can't create a node\n");
		return -1;
	}
	node->value = *data;
	node->next = stack->head;
	stack->head = node;
	stack->size++;
	return(0);
}

// Извлечение узла из стека
int pop(Stack* stack, type* data) {
	if (!stack || isEmptyStack(stack))
	{
		printf("\nFirstly create a stack\n");
		return -1;
	}

	elem* node;
	node = stack->head;
	stack->head = stack->head->next;
	*data = node->value;
	stack->size--;
	free(node);
	return(0);
}

// Вывод стека в консоль
int printList(Stack* stack) {
	elem* node = stack->head;

	if (isEmptyStack(stack)) {
		printf("\nError, stack is empty\n");
		return -1;
	}

	for (int i = 0; node; i++) {
		printf("%d) %d\n", i + 1, node->value);
		node = node->next;
	}
}

void showMenu() {
	printf("\n---------------Menu:---------------\n");
	printf("\nChoose one of following options:\n");
	printf("\n 1) Create stack;");
	printf("\n 2) Push;");
	printf("\n 3) Pop;");
	printf("\n 4) Print list;");
	printf("\n 5) Delete list;");
}

int main()
{
	int ch;
	Stack* stack = NULL;
	type value;
	int i;
	do {
		_getch();
		system("pause");
		system("@cls||clear");
		showMenu();
		printf("\nEnter number:");
		scanf_s("%d", &ch);
		if (ch < 1 || ch > 9)
			printf("\nError, wrong value, try again!!!\n");
		switch (ch) {
		case 1:
			stack = createStack();
			break;
		case 2:
			printf("\nEnter value:");
			scanf_s("%d", &value);
			push(stack, &value);
			break;
		case 3:
			if (!pop(stack, &value));
			printf("\n%d\n", value);
			break;
		case 4:
			printList(stack);
			break;
		case 5:
			deleteStack(stack);
			break;
		}
	} while (true);
}