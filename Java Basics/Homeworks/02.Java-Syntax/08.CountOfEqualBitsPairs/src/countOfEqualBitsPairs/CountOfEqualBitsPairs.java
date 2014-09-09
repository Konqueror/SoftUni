package countOfEqualBitsPairs;

import java.util.Scanner;

public class CountOfEqualBitsPairs
{
	
	public static void main(String[] args) 
	{
		
		Integer n=0, count=0;
		
		Scanner input = new Scanner(System.in);
		
		System.out.println("n=");
		n = Integer.parseInt(input.nextLine());
		
		input.close();
		
		String bits = Integer.toBinaryString(n);
		
        for (int i = 0; i < bits.length()-1; i++) 
        {
                if (bits.charAt(i) == bits.charAt(i + 1)) 
                {
                        count++;
                }

        }
        
        System.out.println(count);
	}
}