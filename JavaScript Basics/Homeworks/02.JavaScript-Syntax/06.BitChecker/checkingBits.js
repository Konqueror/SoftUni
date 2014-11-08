bitChecker(333);
bitChecker(425);
bitChecker(2567564754);

function bitChecker(number)
{
    var mask = 1 << 3;
    var check = mask & number;

    if(check == 8)
    {
      console.log("true");
    }
    else
    {
        console.log("false");
    }
}

// DONT WORK
/*function bitChecker(number)
{
	var bits = number.toString(2);

	if (bits.charAt(2) == '1')
	{
		console.log("true");
	}
	else
	{
		console.log("false");
	}
}*/