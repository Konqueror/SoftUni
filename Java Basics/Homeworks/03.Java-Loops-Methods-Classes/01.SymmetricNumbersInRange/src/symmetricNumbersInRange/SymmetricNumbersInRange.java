package symmetricNumbersInRange;

import java.util.Scanner;

public class SymmetricNumbersInRange {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int start = input.nextInt();
		int end = input.nextInt();

		for (int i = start; i <= end; i++) {
			char[] digits = Integer.toString(i).toCharArray();

			if (digits.length == 1) {
				System.out.print(i + " ");
			}
			if (digits.length == 2 && digits[0] == digits[1]) {
				System.out.print(i + " ");
			}
			if (digits.length == 3 && digits[0] == digits[2]) {
				System.out.print(i + " ");
			}
		}
	}
}
