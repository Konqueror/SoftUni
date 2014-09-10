package pointsInsideFigure;

import java.util.Scanner;

public class PointsInsideFigure {
	
	public static void main(String[] args) 
	{
		
		Double x=0.0, y=0.0;
		
		Scanner input = new Scanner(System.in);
		
		System.out.println("x y (separated by space): ");
		x = Double.parseDouble(input.next());
		y = Double.parseDouble(input.next());
		
		input.close();
		
		// is the point in the box
		boolean isInBox = ( (x >= 12.5 && x <= 22.5) && (y >= 6 && y <= 13.5) ) &! ( (x > 17.5 && x < 20.0) && (y > 8.5 && y < 13.5) );
		
		if (isInBox) 
		{
			System.out.println("Inside");
		} 
		else 
		{
			System.out.println("Outside");
		}
	}
}