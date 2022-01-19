# Shell code for displaying an option menu

echo "Welcome user!"
echo "What is your name?"
read name

continue="true"

while [ "$continue" != "false" ]
do
echo
echo "What calculation would you like to do today $name?"
echo "Type 1 for addition"
echo "Type 2 for subtraction"
echo "Type 3 for multiplication"
echo "Type 4 for division"
echo "Type 5 to exit program"
read calc

# Calculation number 1
if [ "$calc" -eq 1 ]
then
echo
echo "What two numbers would you like to add?"
read num1
read num2
echo "The result is $(($num1+$num2))"
echo "Press ENTER to do another calculation"
read enter

# Calcuation number 2
elif [ "$calc" -eq 2 ]
then
echo
echo "What two numbers would you like to subtract?"
read num1
read num2
echo "The result is $(($num1-$num2))"
echo "Press ENTER to do another calculation"
read enter

# Calculation number 3
elif [ "$calc" -eq 3 ]
then
echo
echo "What two numbers would you like to multiply?"
read num1
read num2
echo "The result is $(($num1*$num2))"
echo "Press ENTER to do another calculation"
read enter

# Calculation number 3
elif [ "$calc" -eq 4 ]
then
echo
echo "What two numbers would you like to dive?"
read num1
read num2
echo "The result is $(($num1/$num2))"
echo "Press ENTER to do another calculation"
read enter

# Instance where user types quit
elif [ "$calc" -eq 5 ]
then
continue="false"

# Case where user enters incorrect choice
else "You have entered an incorrect choice. Please try again..."

fi
done


