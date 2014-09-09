package dec2Hex;

import java.util.Scanner;

public class Dec2Hex {
	
	public static void main(String[] args) 
	{
		
		Integer dec=0;
		
		Scanner input = new Scanner(System.in);
		
		System.out.println("decimal=");
		dec = Integer.parseInt(input.nextLine());
		
		input.close();
		
		// printing the dec number converted in hex
		System.out.println("hexdecimal="+Integer.toHexString(dec).toUpperCase());
	}
}