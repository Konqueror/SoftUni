convertKWtoHP(75);
//convertKWtoHP(150);
//convertKWtoHP(1000);

function convertKWtoHP(number)
{
	var hp = 1.34102209 * number;

	console.log(hp.toFixed(2));
}