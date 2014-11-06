var radius = prompt("radius?");

document.getElementById("res").innerHTML = "r ="+radius+"; area = "+calcCircleArea(radius)+";";

function calcCircleArea(r)
{
	return Math.PI*Math.pow(r,2);
}