#define  _CRT_SECURE_NO_WARNINGS
#include <conio.h>
#include <windows.h>
#include <stdio.h>

void fill_blockMemory(int* blockMemory, size_t len, int heap_num) {
    for (int i = 0; i < len; i++)
        blockMemory[i] = i;

    printf( "\nHeap %d\n", heap_num);
    for (int i = 0; i < len; i++)
    {
        printf("%d ", blockMemory[i]);
    }

    printf("\n");
}

void main(void) {
    int len_1;
    int len_2;
    printf ("size 1: ");
    scanf_s(" %d", &len_1);
    printf ("size 2: ");
    scanf_s(" %d", &len_2);

    int size_1 = len_1 * sizeof(int);
    int size_2 = len_2 * sizeof(int);

    int* blockMemory1 = HeapAlloc(GetProcessHeap(), HEAP_ZERO_MEMORY, size_1);
    fill_blockMemory(blockMemory1, len_1, 1);

    HANDLE anotherHeap = HeapCreate(0, HEAP_GENERATE_EXCEPTIONS, 0);
    int* blockMemory2 = HeapAlloc(anotherHeap, 0, size_2);
    fill_blockMemory(blockMemory2, len_2, 2);

    HeapFree(GetProcessHeap(), 0, blockMemory1);
    HeapFree(anotherHeap, 0, blockMemory2);

    _getch();
}
