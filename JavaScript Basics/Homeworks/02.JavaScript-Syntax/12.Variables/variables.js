variablesTypes('Pesho', 22, true, ['fries', 'banana', 'cake']);

function variablesTypes(name, age, isMale, foods)
{
	console.log('My name: ' + name + ' //type is ' + typeof(name));
	console.log('My age: ' + age + ' //type is ' + typeof(age));
	console.log('I am male: ' + isMale + ' //type is ' + typeof(isMale));
	console.log('My favorite foods are: ' + foods[0] + ', ' + foods[1] + ', ' + foods[2] + ' //type is ' + typeof(foods));
}