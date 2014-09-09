package smallestOf3Numbers;

import java.text.DecimalFormat;
import java.util.Scanner;

public class SmallestOf3Numbers 
{
	
	public static void main(String[] args) 
	{
		Double a=0.0, b=0.0, c=0.0, smallest=0.0;
		DecimalFormat df = new DecimalFormat("###.#");
		
		Scanner input = new Scanner(System.in);
		
		System.out.println("Enter number: ");
		a = Double.parseDouble(input.nextLine());
		
		System.out.println("Enter number: ");
		b = Double.parseDouble(input.nextLine());
		
		System.out.println("Enter number: ");
		c = Double.parseDouble(input.nextLine());
		
		input.close();
		
		if (a <= b && a <= c)
		{
			smallest = a;
		} 
		else if (b <= a && b <= c)
		{
			smallest = b;
		}
		else
		{
			smallest = c;
		}
		
		// printing the smallest number
		System.out.println("smallest="+df.format(smallest));
	}
}