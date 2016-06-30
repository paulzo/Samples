
package p3a2;

import java.util.Scanner;

/**
 * A class which allows for the creation of a basic menu display object based on
 * information passed into various methods by user input in the program class.
 *
 * Libraries used- util.Scanner
 *
 * @author Paul Beggan BEG14086215
 * 
 * @version 1.0
 * 
 * @since 04/12/2014
 */

public class Menu {
    
    
    //creation of a new scanner object to take input from user
    static Scanner input = new Scanner(System.in);
    private String title;
    private String[] menuItems;
//creates a new menu object
    public Menu(String aTitle, String[] aMenuItems) {

        title = aTitle;
        menuItems = aMenuItems;

    }//end of constructor

    
    /**
     *Method returns the users choice
     * 
     * @return option - int
     * 
     * @since 04/12/2014
     */
    public  int getChoice() {


        int option = 0;
        
        try{
           
            displayMenu();
            
            System.out.println("\n\nPlease enter a valid option");
            option=input.nextInt();
            
            
//            return option;  
            
        }catch(Exception e){
            System.out.println("an error has occured");
            input.nextLine();
        }//
        
        return option; 

    }//end of getChoice

    /**
     *Void Method to display menu
     * 
     * @since 04/12/2014
     */
    private void displayMenu() {

        System.out.print(title);
        for (int loopVal = 0; loopVal < menuItems.length; loopVal++) {

            System.out.print(menuItems[loopVal]);

        }//end of for




    }//end of displayMenu
    
}//end of Menu Class
