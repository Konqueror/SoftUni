package sumTwoNumbers;

import java.util.Scanner;

public class SumTwoNumbers {

	public static void main(String[] args) {
		
		Integer a=0, b=0;
		Scanner input = new Scanner(System.in);
		
		System.out.println("a=");
	    a = Integer.parseInt(input.nextLine());
	       
	    System.out.println("b=");
	    b = Integer.parseInt(input.nextLine());
	 
	    input.close();
	    
	    // printing the sum of two integers
	    System.out.println("a+b="+(a+b));
	}
}
