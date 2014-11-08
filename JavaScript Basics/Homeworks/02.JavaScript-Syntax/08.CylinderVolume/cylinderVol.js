calcCylinderVol(2, 4);
calcCylinderVol(5, 8);
calcCylinderVol(12, 3);

function calcCylinderVol(r, h)
{
	var volume = Math.PI*Math.pow(r,2)*h;

	console.log(volume.toFixed(3));
}
