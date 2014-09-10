package pointInsideHouse;

import java.util.Scanner;

public class PointInsideHouse {
	
	public static void main(String[] args) 
	{
		
        Double pX=0.0, pY=0.0, aX=12.5, aY=8.5, bX=17.5, bY=3.5, cX=22.5, cY=8.5;
		
		Scanner input = new Scanner(System.in);
		
		System.out.println("pX pY (separated by space): ");
		pX = Double.parseDouble(input.next());
		pY = Double.parseDouble(input.next());
		
		input.close();
		
		double ABC = Math.abs((aX * (bY - cY) + bX * (cY - aY) + cX * (aY - bY)));
		double ABP = Math.abs((aX * (bY - pY) + bX * (pY - aY) + pX * (aY - bY)));
		double APC = Math.abs((aX * (pY - cY) + pX * (cY - aY) + cX * (aY - pY)));
		double PBC = Math.abs((pX * (bY - cY) + bX * (cY - pY) + cX * (pY - bY)));
		
		// is the point in the triangle
		boolean isInTriangle = ABP + APC + PBC == ABC;
		
		// is the point in the box
		boolean isInBox = ( (pX >= 12.5 && pX <= 22.5) && (pY >= 6 && pY <= 13.5) ) &! ( (pX > 17.5 && pX < 20.0) && (pY > 8.5 && pY < 13.5) );
		
		if (isInBox || isInTriangle) 
		{
			System.out.println("Inside");
		} 
		else 
		{
			System.out.println("Outside");
		}
	}
}