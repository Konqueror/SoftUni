package logsAggregator;

import java.util.Map.Entry;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.TreeSet;


public class LogsAggregator {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		input.nextLine();
		
		TreeMap<String, Integer> userDuration = new TreeMap<>();
		TreeMap<String, TreeSet<String>> userIP = new TreeMap<>();
		
		for (int i = 0; i < n; i++) {
			
			String[] data = input.nextLine().split("\\s+");
			int duration = Integer.parseInt(data[2]);
			
			Integer count = userDuration.get(data[1]);
			if (count == null) {
				count = 0;
			} 
			
			userDuration.put(data[1], duration + count);
			
			if (!userIP.containsKey(data[1])) {
				userIP.put(data[1], new TreeSet<>());
			}
			
			userIP.get(data[1]).add(data[0]);
			
		}
		
		for (Entry<String, Integer> userD : userDuration.entrySet()) {
			
			System.out.print(userD.getKey() + ": " + userD.getValue() + " ");
			System.out.println(userIP.get(userD.getKey()));

		}

	}

}