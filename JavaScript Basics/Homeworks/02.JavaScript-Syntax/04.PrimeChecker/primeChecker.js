isPrime(7);
//isPrime(254);
//isPrime(587);

function isPrime(number)
{
	var isPrime = 1;
	var i;

	for (i = 2; i < number; i++)
	{
		if (number % i == 0 && i != number)
		{
			isPrime = 0;
		}
	}

	if (isPrime == 1)
	{
		console.log("true");
	}
	else
	{
		console.log("false");
	}

}