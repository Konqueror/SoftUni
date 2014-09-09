package formatingNumbers;

import java.util.Scanner;

public class FormatingNumbers 
{
	
	public static void main(String[] args) 
	{
		Integer a=0;
		Double b=0.0, c=0.0;
		
		Scanner input = new Scanner(System.in);
		
		a = Integer.parseInt(input.nextLine());
		
		b = Double.parseDouble(input.nextLine());
		
		c = Double.parseDouble(input.nextLine());
		
		input.close();
		
		String aHex = Integer.toHexString(a).toUpperCase();
        String aBin = String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0');
        
        // printing formated numbers
        System.out.printf("|%-10s|%s|%10.2f|%-10.3f|", aHex, aBin, b, c);
		
	}
}