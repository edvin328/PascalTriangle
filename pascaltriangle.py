#!/bin/python3.8

n=int(input("Please enter how many rows in Pascal's triangle you want to count:"))
# creating empty array
array=[]

# i is variable for rows
for i in range(n):
    temp_array=[]
# j is variable for columns
    for j in range(i+1):
        if j==0 or j==i:
            # we are adding "1" in the beginning and ending of the row
            temp_array.append(1)
        else:
            # adding values between "1" ...."1"
            temp_array.append(array[i-1][j-1] + array[i-1][j])
# adding temp_array to main array
    array.append(temp_array)

# for triangle printing use cycle "for"
for i in range(n):

# first "for" cycle using for printing empty spaces
    for j in range(n-i-1):
        print(format(" ","<2"),end="")
# second "for" cycle using for printing values
    for j in range(i+1):
        print(format(array[i][j],"<4"),end="")
    print()
