# CalcTimerAssignment
For this assignment I chose the first choices given. i did a multiplication and addition of doubles and integers of equivalent arrays. I also chose to do direct multiplication of doubles and the Math.Pow function along with the Math.Sqrt function.
## Results for part A:
for the multiplication and addition of integers and doubles, it was found that overall, the integers were faster than the doubles. This would make sense since integers have less bytes than the doubles do. Ints having 4 bytes and doubles having 8. 
I believe this would be the reson since the more bytes you have the more time needed during calculations due to the space that the bytes took up for doubles.
In terms of comparing addition and multiplication of integers, The results were relatively the same. However, after running the code a few times I found that the addition of integers was faster than the multiplication of them. 
This makes sense addition of numbers in general is easier than multiplying them. But overall the time and ticks were pretty close.
For doubles, the results were longer time than integers, but again the time taken was similar for addition and multiplication. for some reason from the same trials as for integers, the multiplication was faster with the ticks.
## Results for part B:
The Math.Pow function actually took longer to compute than direct multiplication by a significant amount of time. For direct multiplication I got results of around 12 ms but for the Math.Pow function, I got around 54 ms.
I think since it is directly multiplying the numbers rather than putting the number in a built in function and then calculating is the reason why. I think the Math.Pow function would be useful if the doubles needed to powered with a higher exponent than 2.
It would be a hassle to have to write the direct multiplication function out for something that is to the power of 6 than just adding the number 6 into the Math.Pow function. So while the Math.Pow function is slower in this case, I believe that it has its uses for other scenarios.
The Math.Sqrt funtion had times much faster than the Math.Pow function however. I believe this is due to the fact that it did not have to find out what the exponent was for the function since it is already labeled as the squareroot rather than the Math.Pow that needed the
user to put what the exponent was in the function. However it still took longer than the multiplication and addition of doubles. This would again make sense since the square root naturally takes longer to calculate than both multiplication and addition.
