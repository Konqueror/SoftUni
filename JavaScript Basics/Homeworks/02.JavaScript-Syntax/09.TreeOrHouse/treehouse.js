treeHouseCompare(3,2);
treeHouseCompare(3,3);
treeHouseCompare(4,5);

function treeHouseCompare(a,b)
{
	var houseArea = 4*Math.pow(a,2)/3;
	var treeArea = Math.pow(b,2)*(4*Math.PI+3)/9;

	if(treeArea > houseArea)
	{
		console.log('tree/' + treeArea.toFixed(2));
	}
	else
	{
		console.log('house/' + houseArea.toFixed(2));
	}
}