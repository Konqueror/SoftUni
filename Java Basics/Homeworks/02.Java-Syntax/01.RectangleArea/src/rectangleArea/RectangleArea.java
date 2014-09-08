package rectangleArea;

import java.util.Scanner;

public class RectangleArea {
	
	public static void main(String[] args) {
		
		Integer a=0, b=0;
		
		Scanner input = new Scanner(System.in);
		
		System.out.println("width=");
		a = Integer.parseInt(input.nextLine());
		
		System.out.println("height=");
		b = Integer.parseInt(input.nextLine());
		
		input.close();
		
		// printing the area of the rectangle
		System.out.println("area="+(a*b));
	}
}