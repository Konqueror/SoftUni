checkDigit(1235);
checkDigit(25368);
checkDigit(123456);

function checkDigit(number)
{

	var str = number.toString();
	var pos = str.charAt(str.length-3);

	if (pos == '3')
	{
		console.log("true");
	}
	else
	{
		console.log("false");
	}

}