#1

# #x = input('Введите число ')

#def summa(x):                            
#    if float(x) < 0:                            
#        x = float(x) * (-1)
#    number = 0
#
#    for i in str(x):
#        if i != '.':
#            number += int(i)
#    return number
  
#print(f'Сумма чисел равна {summa(x)}')

#2

#N = int(input('Введите число '))

#f = 1
#for i in range(N):
#    i = i + 1
#    f = i * f
#    
#    print(f, end=" ")

#3

#from msilib import sequence

#n = int(input('Введите число: ')) 

#def get_squerence(n):
#    return [round((1 + 1 / x)**x, 5) for x in range (1, n + 1)]
#
#nums = get_squerence(n)
#print(nums)
#print(round(sum(nums), 5))

#4

# from random import Random, randint

# N = int(input('Введите число: '))
# numbers = []
# for i in range(N):
#     numbers.append(randint(-N,N+1))
    
# print(numbers)
# print(numbers[1] * numbers[3])

#5

# import random
# lst = [random.randint(0,10) for i in range(random.randint(5,20))]
# print(f"исходный список:\n{lst}")
# random.shuffle(lst)
# print(f"список после перемешивания:\n{lst}")
