package p3a2;

/**
 * A class which allows for the creation of a basic "ITMQueue" object which
 * represents a queue of trains in the inbound train management program(ITM).
 *
 * Methods allow for the adding of a train to the queue, the removal of train
 * from the queue, the details of the queue to be displayed,and the details of
 * specific trains/destinations/ companies etc.
 *
 *
 * @author Paul Beggan BEG14086215
 * @version 1.0
 * @since 07/12/2014
 */
public class ITMQueue {

    //declaring start and end properties
    private TrainNode start;
    private TrainNode end;

    //creates an empty ITMQueue
    /**
     * Constructor- creates an ITMQueue object
     *
     * @since 07/12/2014
     */
    public ITMQueue() {

        //ensures that both start and end point at nothing or null
        start = null;
        end = null;

    }//end of constructor

    /**
     * Method for adding a TrainNode to the queue
     *
     * @param enTrainNum- int
     * @param enCarriages- int
     * @param enCompany- string
     * @param enDepartCity - String
     * @param enPassengers- int
     *
     * @since 07/12/2014
     */
    public void enqueue(String enTrainNum, int enCarriages, String enCompany, String enDepartCity, int enPassengers) {

        if (isEmpty()) {

            //creates a new start node and passes in all relevant properties
            start = new TrainNode(enTrainNum, enCarriages, enCompany, enDepartCity, enPassengers);
            //sets before and after to null and makes the end of the Queue- ie the only item 
            //in the queue equal to the node created above
            start.setBefore(null);
            start.setAfter(null);
            end = start;
            //if queue is not empty 
        } else {

            //creates a new TrainNode called temp to insert at end of queue
            TrainNode temp = new TrainNode(enTrainNum, enCarriages, enCompany, enDepartCity, enPassengers);
            end.setAfter(temp);
            temp.setBefore(end);
//        end.setAfter(temp);
            end = temp;
        }//end of if else

    }//end of enqueue

    /**
     * Method for removing a TrainNode from the queue
     *
     * returns temp - TrainNode
     *
     * @since 07/12/2014
     */
    public TrainNode dequeue() {

        TrainNode temp;
        //queue is empty 
        if (isEmpty()) {

            return null;

        } else if (start.getAfter() == null) {//if there is only one object( as it points nothing after)
            //temp becomes equal to start
            temp = start;
            start = null;
            end = null;
            return temp;

        } else {//if more than one item in queue
            //stores temp,start then gets pointed to the node behind, new start the points to null
            //as no object is in front of it 
            temp = start;
            start = start.getAfter();
            start.setBefore(null);
            return temp;

        }//end of if else

    }//end of dequeue

    //displays the queue
    /**
     * Method for displaying the details of a queue
     *
     * returns output - String
     *
     * @since 07/12/2014
     */
    public String ToString() {

        String output = "\n******************************Details of Current Trains within Queue******************************\n";
        output += "\nTrain #\t\tTrain Company\t\tDeparture\t\tCarriages\t\tPassengers\n\n";
        if (isEmpty()) {

            output += "\nNo Trains Currently in Queue\n";
            return output;
        }//end of if 

        TrainNode temp;
        temp = start;
        while (temp != null) {

//           output+="\nTrain #\tTrain Company\tDeparture\tCarriages\tPassengers\n";
            output += temp.getTrainNum() + "\t\t" + temp.getCompany() + "\t\t\t" + temp.getDepartCity() + "\t\t\t\t" + temp.getCarriages() + "\t\t\t" + temp.getPassengers() + "\n";
            temp = temp.getAfter();
        }//end of while 

        return output;



    }//end of ToString 

    /**
     * Method for checking whether or not the queue is empty
     *
     * returns boolean
     *
     * @since 07/12/2014
     */
    public boolean isEmpty() {
        if (start == null) {
            return true;
        } else {
            return false;
        }//end of if else
    }//end of isEmpty

    /**
     * Method for checking if a queue contains a specific string ( departure city)
     *
     * @param find- string
     *
     * returns - boolean
     *
     * @since 07/12/2014
     */
    public boolean Contains(String find) {

        if (isEmpty()) {
            return false;
        } else {
            TrainNode temp;
            temp = start;

            while (temp != null) {

                if (temp.getDepartCity().equalsIgnoreCase(find)) {
                    return true;
                }//end of if

                //moves temp reference along to next QNode in queue if previous one doesnt match whatever name is put in  
                temp = temp.getAfter();


            }//end of while

            return false;
        }//end of if else

    }//end of contains method

    /**
     * Method for checking if a queue contains a specific string ( a company name)
     *
     * @param find- string
     *
     * returns - boolean
     *
     * @since 07/12/2014
     */
    public boolean Contains2(String find) {

        if (isEmpty()) {
            return false;
        } else {
            TrainNode temp;
            temp = start;

            while (temp != null) {

                if (temp.getCompany().equalsIgnoreCase(find)) {
                    return true;
                }//end of if

                //moves temp reference along to next QNode in queue if previous one doesnt match whatever name is put in  
                temp = temp.getAfter();


            }//end of while

            return false;
        }//end of if else

    }//end of contains method

     /**
     *Method for checking if a queue contains a specific String( train number) 
     * 
     * @param find- string
     * 
     * returns - boolean
     * 
     * @since 07/12/2014
     */
    public boolean Contains3(String find) {

        if (isEmpty()) {
            return false;
        } else {
            TrainNode temp;
            temp = start;

            while (temp != null) {

                if (temp.getTrainNum().equalsIgnoreCase(find)) {
                    return true;
                }//end of if

                //moves temp reference along to next QNode in queue if previous one doesnt match whatever name is put in  
                temp = temp.getAfter();


            }//end of while

            return false;
        }//end of if else

    }//end of contains method

     /**
     *Method for checking if a queue contains a specific int
     * 
     * @param find- int
     * 
     * returns - boolean
     * 
     * @since 07/12/2014
     */
    public boolean Contains4(int find) {

        if (isEmpty()||find<0) {
            return false;
        } else {
            TrainNode temp;
            temp = start;

            while (temp != null) {

                if (temp.getCarriages() >= find) {
                    return true;
                }//end of if

                //moves temp reference along to next QNode in queue if previous one doesnt match whatever name is put in  
                temp = temp.getAfter();


            }//end of while

            return false;
        }//end of if else

    }//end of contains method

    
     /**
     *Method for displaying the details of trains departing from a specified city
     * 
     * @param city- string
     * 
     * returns output - String
     * 
     * @since 07/12/2014
     */
    public String getCity(String city) {

        String output;
        output = "\n******************************Details of Current Trains travelling from :" + city + "******************************\n";
        output += "\nTrain #\t\tTrain Company\t\tDeparture\t\tCarriages\t\tPassengers\n\n";
        if (isEmpty() || !Contains(city)) {
            output += "No Trains travelling from : " + city;
            return output;
        } else {

            TrainNode temp;
            temp = start;

            while (temp != null) {

                if (temp.getDepartCity().equalsIgnoreCase(city)) {

                    output += temp.getTrainNum() + "\t\t" + temp.getCompany() + "\t\t\t" + temp.getDepartCity() + "\t\t\t\t" + temp.getCarriages() + "\t\t\t" + temp.getPassengers() + "\n";

                }//end of inner if
                temp = temp.getAfter();

            }//end of while 
            return output;
        }//end of if else

    }//end of getCity 

      /**
     *Method for displaying the details of trains departing from a specified company
     * 
     * @param company- string
     * 
     * returns output - String
     * 
     * @since 07/12/2014
     */
    public String getOwnedTrainCompany(String company) {

        String output;
        output = "\n******************************Details of Current Trains owned by :" + company + "******************************\n";
        output += "\nTrain #\t\tTrain Company\t\tDeparture\t\tCarriages\t\tPassengers\n\n";
        if (isEmpty() || !Contains2(company)) {
            output += "No Trains owned by : " + company;
            return output;
        } else {

            TrainNode temp;
            temp = start;

            while (temp != null) {

                if (temp.getCompany().equalsIgnoreCase(company)) {

                    output += temp.getTrainNum() + "\t\t" + temp.getCompany() + "\t\t\t" + temp.getDepartCity() + "\t\t\t\t" + temp.getCarriages() + "\t\t\t" + temp.getPassengers() + "\n";

                }//end of inner if
                temp = temp.getAfter();

            }//end of while 
            return output;
        }//end of if else

    }//end of getCity 

      /**
     *Method for displaying the details of trains departing from a specified train number
     * 
     * @param trainNum- string
     * 
     * returns output - String
     * 
     * @since 07/12/2014
     */
    public String getSpecificTrainNum(String trainNum) {

        String output;
        output = "\n******************************Details of Current Train with train Number :" + trainNum + "******************************\n";
        output += "\nTrain #\t\tTrain Company\t\tDeparture\t\tCarriages\t\tPassengers\n\n";
        if (isEmpty() || !Contains3(trainNum)) {
            output += "No Trains with the train number : " + trainNum;
            return output;
        } else {

            TrainNode temp;
            temp = start;

            while (temp != null) {

                if (temp.getTrainNum().equalsIgnoreCase(trainNum)) {

                    output += temp.getTrainNum() + "\t\t" + temp.getCompany() + "\t\t\t" + temp.getDepartCity() + "\t\t\t\t" + temp.getCarriages() + "\t\t\t" + temp.getPassengers() + "\n";

                }//end of inner if
                temp = temp.getAfter();

            }//end of while 
            return output;
        }//end of if else

    }//end of getCity 

      /**
     *Method for displaying the details of trains with more than a specified number of carraiges
     * 
     * @param CarriageNum- int
     * 
     * returns output - String
     * 
     * @since 07/12/2014
     */
    public String getCarriageNum(int CarriageNum) {

        String output;
        output = "\n******************************Details of Current Train(s) with at least :" + CarriageNum + " Carriages******************************\n";
        output += "\nTrain #\t\tTrain Company\t\tDeparture\t\tCarriages\t\tPassengers\n\n";
        if (isEmpty() || !Contains4(CarriageNum)) {
            output += "No Trains with : " + CarriageNum + " Carriages";
            return output;
        } else {

            TrainNode temp;
            temp = start;

            while (temp != null) {

                if (temp.getCarriages() >= CarriageNum) {

                    output += temp.getTrainNum() + "\t\t" + temp.getCompany() + "\t\t\t" + temp.getDepartCity() + "\t\t\t\t" + temp.getCarriages() + "\t\t\t" + temp.getPassengers() + "\n";

                }//end of inner if
                temp = temp.getAfter();

            }//end of while 
            return output;
        }//end of if else

    }//end of getCity

    /**
     *Method for displaying the total number of passengers within a queue
     * 
     * returns output - String
     * 
     * @since 07/12/2014
     */
    public String getPassengerTotal() {

        String output;
        output = "\n******************************Details of total number of passengers in Queue******************************\n";
        int passNum = 0;
        if (isEmpty()) {
            output += "No Passengers in Queue";
            return output;
        } else {

            TrainNode temp;
            temp = start;

            while (temp != null) {

                passNum += temp.getPassengers();

                temp = temp.getAfter();

            }//end of while
            output += "total number of passengers : " + passNum;
            return output;
        }//end of if else

    }//end of getPassengerTotal
}//end of ITMQueue
