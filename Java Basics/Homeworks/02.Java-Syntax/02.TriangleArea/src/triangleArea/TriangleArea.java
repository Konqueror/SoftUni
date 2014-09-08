package triangleArea;

import java.util.Scanner;

public class TriangleArea {
	
	public static void main(String[] args) {
		
		Integer aX=0, aY=0, bX=0, bY=0, cX=0, cY=0;
		
		Scanner input = new Scanner(System.in);
		
		System.out.println("aX aY (separated by space): ");
		aX = Integer.parseInt(input.next());
		aY = Integer.parseInt(input.next());
		input.nextLine();
		
		System.out.println("bX bY (separated by space): ");
		bX = Integer.parseInt(input.next());
		bY = Integer.parseInt(input.next());
		input.nextLine();
		
		System.out.println("cX cY (separated by space): ");
		cX = Integer.parseInt(input.next());
		cY = Integer.parseInt(input.next());
		input.nextLine();
		
		input.close();
		
		// printing the area of the triangle
		System.out.println("area="+(Integer)Math.abs((aX*(bY-cY) + bX*(cY-aY) + cX*(aY-bY))/2));
	}
}