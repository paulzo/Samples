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
 * @since 07/12/2014
 */
public class LOCO {

    static Scanner inputNum = new Scanner(System.in);
    static Scanner input = new Scanner(System.in);

    public static void main(String[] args) {

        String[] menuItems = {"\n1.add a train to queue", "\n2.Remove a train from the queue", "\n3.Print details of trains currently in queue", "\n4.Find trains departing from specified city", "\n5.Find trains owned by specified company", "\n6.Find trains with at least a specified number of carriages", "\n7.Details of Specfied train", "\n8.Display total number of passengers within train queue", "\n9.Exit"};
        //creating a new ITMQueue object 
        ITMQueue myQ = new ITMQueue();
        //creating a menu object 
        Menu menuObject = new Menu("\n*****LOCO ITMQueue Menu*****", menuItems);

        //variables to user hold values
        int option = 0;

        while (option != 9) {



            //option is equal to the returned value from the menuObject.getChoice() method in menu Class

            option = menuObject.getChoice();

            switch (option) {

                case 1:

                    try {

                        String trainNum;
                        int carr;
                        String comp;
                        String dept;
                        int pass;
                        System.out.println("please add a train to the Queue\n");
                        System.out.println("please input train number\n");
                        trainNum = input.next();
                        System.out.println("please input the number of carriages\n");
                        carr = inputNum.nextInt();
                        System.out.println("Please input the train Company\n");
                        comp = input.next();
                        System.out.println("please input the departure city\n");
                        dept = input.next();
                        System.out.println("please input the number of passengers\n");
                        pass = inputNum.nextInt();
                        myQ.enqueue(trainNum, carr, comp, dept, pass);

                    } catch (Exception e) {
                        System.out.println("Input Error please try again");
                        input.nextLine();
                        inputNum.nextLine();
                    }//end of try catch

                    break;
                case 2:
                    myQ.dequeue();
                    break;
                case 3:
                    System.out.println(myQ.ToString());

                    break;
                case 4:
                    try {
                        String userInput;
                        System.out.println("Please enter your specfied city of depature");
                        userInput = input.next();
                        System.out.println(myQ.getCity(userInput));
                    } catch (Exception e) {
                        input.nextLine();
                        inputNum.nextLine();
                    }
                    break;
                case 5:
                    System.out.println("Please enter your specfied Company");
                    System.out.println(myQ.getOwnedTrainCompany(input.next()));

                    break;
                case 6:
                    try {
                        System.out.println("Please enter minimum number of carriages");
                        System.out.println(myQ.getCarriageNum(inputNum.nextInt()));
                    } catch (Exception e) {
                        System.out.println("Input Error please try again");
//                        input.nextLine();
                        inputNum.nextLine();
                        
                    }//end of try catch
                    break;
                case 7:
                    System.out.println("Please enter specfic train number for details ");
                    System.out.println(myQ.getSpecificTrainNum(input.next()));
                    break;
                case 8:
                    System.out.println("total number of passengers : " + myQ.getPassengerTotal());
                    break;
                case 9:
                    break;
                default:
                    break;



            }//end of switch




        }//end of while





    }//end of main method
}//end of LOCO class
