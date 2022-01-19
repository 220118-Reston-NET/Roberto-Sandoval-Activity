msg="Hello World" # Create variable and assign value
echo $msg # $ call a variable

ten=10
five=5
thirteen=13

echo "--- First If ---"
if [ "$ten" -ge "$five" ]
then
echo "greater"
echo "$ten > $five"
fi

echo "--- Second If ---"
if [ "$five" -ge "$ten" ]
then
echo "less"
echo "$five > $ten"
fi

echo "--- Third If ---"
if [ "$five" -ge "$ten" ]
then "less"
echo "$five > $ten"
elif [ "$ten" -ge "$five" ]
then
echo "greater"
echo "$ten > $five"
fi
