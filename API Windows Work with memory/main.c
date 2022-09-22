#define  _CRT_SECURE_NO_WARNINGS
#include <conio.h>
#include <windows.h>
#include <stdio.h>

void fill_blockMemory(int* blockMemory, size_t len) {
    for (int i = 0; i < len; i++)
        blockMemory[i] = i;

    printf("\nHeap\n");
    for (int i = 0; i < len; i++)
    {
        printf("%d\n", blockMemory[i]);
    }
}

void main(void) {
    int len_1;
    int len_2;
    printf ("len 1: ");
    scanf_s("%d", &len_1);
    printf ("len 2: ");
    scanf_s("%d", &len_2);

    printf("len_1 is %d\n", len_1);

    size_t size_1 = len_1 * sizeof(int);
    size_t size_2 = len_2 * sizeof(int);

    // Выделение необходимого блока памяти из первой основной кучи
    int* blockMemory1 = HeapAlloc(GetProcessHeap(), HEAP_ZERO_MEMORY, size_1);
    // Заполнение
    fill_blockMemory(blockMemory1, len_1);

    // Создание второй кучи и веделение памяти из нее
    HANDLE anotherHeap = HeapCreate(0, HEAP_GENERATE_EXCEPTIONS, 0);
    int* blockMemory2 = HeapAlloc(anotherHeap, 0, size_2);
    // Заполнение
    fill_blockMemory(blockMemory2, len_2);

    // Освобождение памяти
    HeapFree(GetProcessHeap(), 0, blockMemory1);
    HeapFree(anotherHeap, 0, blockMemory2);

    _getch();
}
