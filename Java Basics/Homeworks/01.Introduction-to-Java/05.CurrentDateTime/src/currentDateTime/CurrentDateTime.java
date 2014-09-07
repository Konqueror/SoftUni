package currentDateTime;

import java.time.LocalDateTime;

public class CurrentDateTime {

    public static void main(String[] args) {
    	
    	// print current date time 
        //System.out.println(LocalDateTime.now());
        
        // print current date time (formated)
        System.out.printf("%1$td/%1$tm/%1$tY %1$tH:%1$tM", LocalDateTime.now());
    }

}
