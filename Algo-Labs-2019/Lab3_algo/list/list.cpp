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
	struct elem* prev;
};

struct myList
{
	struct elem* head;
	struct elem* tail;
	int size;
};

typedef struct myList List;

// Создание пустого списка
List* createList(void)
{
	List* list = (List*)malloc(sizeof(List));
	if (list) {
		list->size = 0;
		list->head = list->tail = NULL;
	}
	else
		printf("\nError, can't create a list!!!\n");
	return list;
}

// Проверка списка на пустоту
bool isEmptyList(List* list) {
	if (list == NULL)
	{
		printf("\nCreate list firstly!!!\n");
		return false;
	}

	if (!list->head && !list->tail)
		return true;
	else
		return false;
}

// Удаление списка
void deleteList(List *list) {
	elem* head = list->head;
	elem* next = NULL;
	while (head) {
		next = head->next;
		free(head);
		head = next;
	}
	free(list);
	list = NULL;
}

// Добавление нового узла в начало списка
int pushFront(List* list, type* data) {
	if (!list)
	{
		printf("\nFirstly create a list!!!\n");
		return -1;
	}

	elem* node = (elem*)malloc(sizeof(elem));

	if (!node) {
		printf("\nError, can't create a node!!!\n");
		return -1;
	}
	node->value = *data;
	node->next = list->head;
	node->prev = NULL;

	if (!isEmptyList(list)) {
		list->head->prev = node;
	}
	else {
		list->tail = node;
	}
	list->head = node;
	list->size++;
	return 0;
}

// Извлечение узла из начала списка
int popFront(List* list, type* data) {
	if (!list || isEmptyList(list))
	{
		printf("\nFirstly create a list!!!\n");
		return -1;
	}
	elem* node;
	node = list->head;
	list->head = list->head->next;

	if (!isEmptyList(list)) {
		list->head->prev = NULL;
	}
	else {
		list->tail = NULL;
	}

	*data = node->value;
	list->size--;
	free(node);
	return 0;
}

// Добавление нового узла в конец списка
int pushBack(List* list, type* data) {
	if (!list) {
		printf("\nFirstly create a list!!!\n");
		return -1;
	}

	elem* node = (elem*)malloc(sizeof(elem));

	if (!node) {
		printf("\nError, can't create a node!!!\n");
		return -1;
	}
	node->value = *data;
	node->next = NULL;
	node->prev = list->tail;

	if (!isEmptyList(list)) {
		list->tail->next = node;
	}
	else {
		list->head = node;
	}
	list->tail = node;
	list->size++;
	return 0;
}

// Извлечение узла из конца списка
int popBack(List* list, type* data) {
	if (!list || isEmptyList(list))
	{
		printf("\nFirstly create a list!!!\n");
		return -1;
	}

	elem *node = NULL;

	if (isEmptyList(list)) {
		return -1;
	}

	node = list->tail;
	list->tail = list->tail->prev;
	if (!isEmptyList(list)) {
		list->tail->next = NULL;
	}
	else {
		list->head = NULL;
	}

	*data = node->value;
	list->size--;
	free(node);
	return 0;
}

// Чтение произвольного узла списка
elem* getNode(List* list, int index) {
	elem *node = NULL;
	int i;

	if (index >= list->size || index < 0) {
		return (NULL);
	}

	if (index < list->size / 2) {
		i = 0;
		node = list->head;
		while (node && i < index) {
			node = node->next;
			i++;
		}
	}
	else {
		i = list->size - 1;
		node = list->tail;
		while (node && i > index) {
			node = node->prev;
			i--;
		}
	}
	printf("\n%d) %d\n", index, node->value);
	return node;
}

// Вывод списка в консоль
int printList(List* list) {
	if (list == NULL)
	{
		printf("\nCreate list firstly!!!\n");
		return -1;
	}

	elem* node = list->head;

	if (isEmptyList(list)) {
		printf("\nError, list is empty!!!\n");
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
	printf("\n 1) Create list;");
	printf("\n 2) Add element to head;");
	printf("\n 3) Add element to tail;");
	printf("\n 4) Get element from head;");
	printf("\n 5) Get element from tail;");
	printf("\n 6) Get element...;");
	printf("\n 7) Print list;");
	printf("\n 8) Delete list;");
}

int main()
{
	int ch;
	List* list = NULL;
	type value;
	int i;
	do {
		_getch();
		system("pause");
		system("@cls||clear");
		showMenu();
		printf("\nEnter number:");
		scanf_s("%d", &ch);
		if (ch < 1 || ch > 8)
			printf("\nError, wrong value, try again!!!\n");

		switch (ch) {
		case 1:
			list = createList();
			break;
		case 2:
			printf("\nEnter value:");
			scanf_s("%d", &value);
			pushFront(list, &value);
			break;
		case 3:
			printf("\nEnter value:");
			scanf_s("%d", &value);
			pushBack(list, &value);
			break;
		case 4:
			popFront(list, &value);
			printf("\n%d\n", value);
			break;
		case 5:
			popBack(list, &value);
			printf("\n%d\n", value);
			break;
		case 6:
			elem * node;
			printf("\nEnter index:");
			scanf_s("%d", &i);
			if (i < 0 || i > list->size)
				printf("\nError, wrong value, try again!!!\n");
			node = getNode(list, i);
			break;
		case 7:
			printList(list);
			break;
		case 8:
			deleteList(list);
			break;
		}
	} while (true);
}