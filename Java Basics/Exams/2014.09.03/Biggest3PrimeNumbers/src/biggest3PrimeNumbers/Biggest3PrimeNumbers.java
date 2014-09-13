package biggest3PrimeNumbers;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.Scanner;

public class Biggest3PrimeNumbers 
{
	// checks whether an integer is prime or not
	public static boolean isPrime(int n) 
	{
		if (n < 2) return false;
		if (n==2) return true;
	    if (n%2==0) return false;
	    
	    for(int i=3; i*i<=n; i+=2) 
	    {
	        if(n%i==0)
	            return false;
	    }
	    
	    return true;
	}
	
	public static void main(String[] args) 
	{
		
		String InputString = "";
		
		Scanner input = new Scanner(System.in);
		
		InputString = input.nextLine();
		
		input.close(); 
		
		// formating
		String tmp = InputString.replace("()", "");
		tmp = tmp.replace("(", "");
		tmp = tmp.replace(")", " ");
		
		// split formated string to array of numbers
		String[] numbers = tmp.split(" ",-1);
		ArrayList<Integer> primes = new ArrayList<Integer>();
		
		// loop the array of numbers
		for (Integer i=0; i<numbers.length; i++)
		{
			// check if is empty string
			if (numbers[i].equals("")) continue;
			
			// check if is prime number
			if (Biggest3PrimeNumbers.isPrime(Integer.parseInt(numbers[i])))
			{
				// add to list of primes
				primes.add(Integer.parseInt(numbers[i]));
			}
		}
		
		// remove duplicates
		HashSet hs = new HashSet();
		hs.addAll(primes);
		primes.clear();
		primes.addAll(hs);
		
		// sort in descending order
		Collections.sort(primes);
		Collections.reverse(primes);
		
		// if has at least 3
		if (primes.size() > 2)
		{
			Integer sum = 0;
			for (int i=0; i<3; i++)
			{
				sum += primes.get(i);
			}
			
			// print the sum of biggest 3
			System.out.println(sum);
		} 
		else 
		{
			// or else print No
			System.out.println("No");
		}
		
	}
	
};