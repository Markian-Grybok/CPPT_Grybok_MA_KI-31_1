import sys

rows_num = int(input("Введіть розмір квадратної матриці: "))
lst = []
filler = input("Введіть символ-заповнювач: ")

for i in range(0, rows_num, 1):
    lst.append([])
    for j in range(0, rows_num, 1):
        if len(filler) == 1:
            if i + j <= rows_num - 2:
                lst[i].append(ord(filler))
                print(chr(lst[i][j]), end=" ")
        elif len(filler) == 0:
            print("Не введено символ-заповнювач")
            sys.exit(1)
        else:
            print("Забагато символів-заповнювачів")
            sys.exit(1)
    print()