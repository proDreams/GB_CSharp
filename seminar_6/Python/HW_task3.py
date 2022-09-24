from random import randint


def spiral(matrix, row, column):
    result = ''
    last_row = 0
    last_column = len(matrix[0]) - 1

    while row >= last_row and column <= last_column:
        for i in range(column, last_column + 1):
            result += str(matrix[row][i]) + ' '
        row -= 1

        for i in range(row, last_row - 1, - 1):
            result += str(matrix[i][last_column]) + ' '
        last_column -= 1

        if row >= last_row and column <= last_column:
            for i in range(last_column, column - 1, - 1):
                result += str(matrix[last_row][i]) + ' '
            last_row += 1

            for i in range(last_row, row + 1):
                result += str(matrix[i][column]) + ' '
            column += 1

    return result


rows, columns = int(input('Введите количество строк: ')), int(
    input('Введите количество столбцов: '))
matrix_array = [[randint(1, 20) for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
start_row, start_column = rows - 1, 0
print(spiral(matrix_array, start_row, start_column))
