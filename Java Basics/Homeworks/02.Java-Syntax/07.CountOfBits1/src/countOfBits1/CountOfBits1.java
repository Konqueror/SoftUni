package countOfBits1;

import java.util.Scanner;

public class CountOfBits1 
{
	
	public static void main(String[] args) 
	{
		
		Integer n=0;
		
		Scanner input = new Scanner(System.in);
		
		System.out.println("n=");
		n = Integer.parseInt(input.nextLine());
		
		input.close();
		
		// printing the number of bits 1 in n
		System.out.println(Integer.bitCount(n));
	}
}