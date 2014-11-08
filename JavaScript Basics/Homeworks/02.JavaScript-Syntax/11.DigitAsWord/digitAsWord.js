convertDigitToWord(8);
convertDigitToWord(3);
convertDigitToWord(5);

function convertDigitToWord(value)
{
	var number;

	switch (value)
	{
		case 1:
			number = "one";
			break;
		case 2:
			number = "two";
			break;
		case 3:
			number = "three";
			break;
		case 4:
			number = "four";
			break;
		case 5:
			number = "five";
			break;
		case 6:
			number = "six";
			break;
		case 7:
			number = "seven";
			break;
		case 8:
			number = "eight";
			break;
		case 9:
			number = "nine";
			break;
		case 10:
			number = "ten";
			break;
	}

	console.log(number);

}