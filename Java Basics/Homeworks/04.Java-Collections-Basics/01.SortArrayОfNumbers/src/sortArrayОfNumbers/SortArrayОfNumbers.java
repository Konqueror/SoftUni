package sortArrayÎfNumbers;

import java.util.Arrays;
import java.util.Scanner;

public class SortArrayÎfNumbers {
	
	@SuppressWarnings("resource")
	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		
		int[] numbers = new int[n];
		
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = input.nextInt();
		}
		
		// sorting
		Arrays.sort(numbers);
		
		for (int number : numbers) {
			System.out.print(number + " ");
		}
	}

}