
package p3a2;

import java.util.Scanner;
/**
 * Purpose of class is to test the methods created in the ITMQueue Class
 *
 * @author Paul Beggan BEG14086215
 * 
 * Libraries used:java.util.Scanner 
 * 
 * @version 1.0 09.12.2014
 */
public class P3A2 {

  
    static Scanner input = new Scanner(System.in);
    
    public static void main(String[] args) {
       
        //creating a new ITMQueue object
        ITMQueue myQ= new ITMQueue();
        
        //testing to see if ToString works while empty
         System.out.println(myQ.ToString());

       //Adding four "trains" to Queue
        myQ.enqueue("tr001",4,"Virgin","Belfast",100);
        myQ.enqueue("tr002",6,"UK Rail","Dublin",200);
        myQ.enqueue("tr003",7,"Virgin","Lisburn",300);
        myQ.enqueue("tr004",1,"UK Rail","Belfast",200);
   
        
        //printing out details of queue with trains
        System.out.println(myQ.ToString());
        //performing a dequeue
        myQ.dequeue();
        

        //ensuring that the dequeue was successfull by printing out details 
        System.out.println(myQ.ToString());
        
        //user input
        System.out.println("Please enter your departed city ");
        //passes input into getCity()
        System.out.println(myQ.getCity("Belfast"));
        
        System.out.println("Please enter your departed city ");
        //passes input into getCity()
        System.out.println(myQ.getCity("Limerick"));
        
        System.out.println("Please enter your departed city ");
        //passes input into getCity()
        System.out.println(myQ.getCity("111"));
       
         System.out.println("Please enter your desired train company ");
        //passes invalid data into getOwnedTrainCompany()
        System.out.println(myQ.getOwnedTrainCompany("Virgin"));
        
        System.out.println("Please enter your desired train company ");
        //passes invalid data into getOwnedTrainCompany()
        System.out.println(myQ.getOwnedTrainCompany("Belfast Rail"));
        
        System.out.println("Please enter your desired train company ");
        //passes invalid data into getOwnedTrainCompany()
        System.out.println(myQ.getOwnedTrainCompany("111"));
      
         System.out.println("Please enter your desired train number ");
         //passes valid data into getSpecificTrainNum()
        System.out.println(myQ.getSpecificTrainNum("tr002"));
        
        System.out.println("Please enter your desired train number ");
         //passes invalid data into getSpecificTrainNum()
        System.out.println(myQ.getSpecificTrainNum("tr100"));
        
        System.out.println("Please enter your desired train number ");
         //passes invalid data into getSpecificTrainNum()
        System.out.println(myQ.getSpecificTrainNum("sfsfs"));
      
         System.out.println("Please enter your desired minimum no. of carriages ");
        //passes in data in getCarriageNum()
        System.out.println(myQ.getCarriageNum(5));
        //passes in data in getCarriageNum()
        System.out.println(myQ.getCarriageNum(1000));
        //passes in data in getCarriageNum()
        System.out.println(myQ.getCarriageNum(0));
        //passes in data in getCarriageNum()
        System.out.println(myQ.getCarriageNum(-1000));
        //passes in data in getCarriageNum()
        System.out.println(myQ.getPassengerTotal());
        
        
        
    }//end of main method   
    
    
}//end of class
