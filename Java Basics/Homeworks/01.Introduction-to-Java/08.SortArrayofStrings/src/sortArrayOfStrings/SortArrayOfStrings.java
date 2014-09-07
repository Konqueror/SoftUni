package sortArrayOfStrings;

import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfStrings {

	public static void main(String[] args) {
		
		Integer n=0;
		Scanner input = new Scanner(System.in);
		
		System.out.print("n=");
	    n = Integer.parseInt(input.nextLine());
	       
	    String[] strings = new String[n];
	    
	    for (Integer i=0; i<n; i++)
	    {
	       	//System.out.println("Enter string "+(i+1)+" of "+n+": ");
	    	strings[i] = input.nextLine();
	    }
	    
	    input.close();
	    
	    // sorting
	    Arrays.sort(strings);
	    
	    // printing sorted array
	    for (Integer i=0; i<n; i++)
	    {
	       	System.out.println(strings[i]);
	    }
	}
}
