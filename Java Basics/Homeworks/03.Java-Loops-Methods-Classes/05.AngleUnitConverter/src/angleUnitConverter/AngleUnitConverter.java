package angleUnitConverter;

import java.util.Scanner;

public class AngleUnitConverter {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		double[] value = new double[n];
		String[] type = new String[n];

		for (int i = 0; i < n; i++) {
			value[i] = input.nextDouble();
			type[i] = input.next();
		}

		for (int i = 0; i < n; i++) {
			convert(value[i], type[i]);
		}
	}

	public static void convert(double value, String type) {
		if (type.equals("rad")) {
			double result = Math.toDegrees(value);
			System.out.printf("%.6f deg\n", result);
		} else {
			double result = Math.toRadians(value);
			Math.toDegrees(value);
			System.out.printf("%.6f rad\n", result);
		}
	}
}