calcSupply(38,118,"chocolate",0.5);
//calcSupply(20,87,"fruits",2);

function calcSupply(age, maxAge, food, foodPerDay)
{
	var amount = (maxAge-age)*365*foodPerDay;

	console.log(amount + 'kg of '+ food +' would be enough until I am ' + maxAge + ' years old.');
}