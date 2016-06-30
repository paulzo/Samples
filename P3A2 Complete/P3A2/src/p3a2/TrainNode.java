
package p3a2;

/**
 * A class which allows for the creation of a basic "TrainNode" object which represents
 * a single train in the inbound train management program(ITM). The Object will then presumably 
 * be used within another "Queue" class.
 * 
 * Methods allow for : the creation of a TrainNode object and the various getters and setters
 * associated with its properties ie get trainNum, set trainNum etc.
 *
 * @author Paul Beggan BEG14086215
 * @version 1.0 
 * @since 04/12/2014
 */
public class TrainNode {

    //declaring Properties
    private String trainNum;
    private int carriages;
    private String company;
    private String departCity;
    private int passengers;
    private TrainNode before;//node before this node in queue
    private TrainNode after;//node after this node in queue
    
    /** creating an instance of TrainNode object */
//    default Constructor 
//    public TrainNode(){
////         
////    
//    }//end of TRainNode Constructor 
    
    
    
    
    /**
     *Constructor- creates a TrainNode object 
     * 
     * @param trainNum- int
     * @param carriages- int
     * @param company- string
     * @param departCity - String
     * @param passengers- int
     * 
     * @since 07/12/2014
     */
    
    public TrainNode(String trainNum, int carriages,String company,String departCity,int passengers){
        
        this.trainNum=trainNum;
        this.carriages=carriages;
        this.company=company;
        this.departCity=departCity;
        this.passengers=passengers;
        before=null;
        after=null;
    
    }//end of constructors

    /**
     *Method returns the TrainNum
     * 
     * @return TrainNum - String
     * 
     * @since 04/12/2014
     */
    public String getTrainNum() {
        return trainNum;
    }//end of getTrainNum()

    
     /**
     *Method returns the number of carriages
     * 
     * @return carriages - int
     * 
     * @since 04/12/2014
     */
    public int getCarriages() {
        return carriages;
    }//end of getCarriages()

    
     /**
     *Method returns the company name 
     * 
     * @return company - String
     * 
     * @since 04/12/2014
     */
    public String getCompany() {
        return company;
    }//end of getCompany()

    
     /**
     *Method returns the departCity
     * 
     * @return departCity - String
     * 
     * @since 04/12/2014
     */
    public String getDepartCity() {
        return departCity;
    }//end of getDepartCity

    
     /**
     *Method returns the number of passengers
     * 
     * @return passengers - int
     * 
     * @since 04/12/2014
     */
    public int getPassengers() {
        return passengers;
    }//end of getPassengers()

    
     /**
     *Method returns the before pointer
     * 
     * @return before - TrainNode
     * 
     * @since 04/12/2014
     */
    public TrainNode getBefore() {
        return before;
    }//end of getBefore()

    
    
     /**
     *Method returns the after pointer
     * 
     * @return after- TrainNode
     * 
     * @since 04/12/2014
     */
    public TrainNode getAfter() {
        return after;
    }//end of getAfter()
    
    
    /**
     *method- sets trainName as passed in parameter
     * 
     * @param trainName- String
     * 
     * @since 04/12/2014
     */
    public void setTrainNum(String trainNum) {
        this.trainNum = trainNum;
    }//end of setTrainNum

    
    /**
     *method- sets number of carriages as passed in parameter
     * 
     * @param carriages- int
     * 
     * @since 04/12/2014
     */
    public void setCarriages(int carriages) {
        this.carriages = carriages;
    }//end of setCarriages

    
    /**
     *method- sets the companyName as passed in parameter
     * 
     * @param company- String
     * 
     * @since 04/12/2014
     */
    public void setCompany(String company) {
        this.company = company;
    }//end of set company 

    
    /**
     *method- sets the departed city as passed in parameter
     * 
     * @param departedCity- String
     * 
     * @since 04/12/2014
     */
    public void setDepartCity(String departCity) {
        this.departCity = departCity;
    }//end of setDepartedCity

    
    /**
     *method- sets the number of passengers as passed in parameter
     * 
     * @param passengers- int
     * 
     * @since 04/12/2014
     */
    public void setPassengers(int passengers) {
        this.passengers = passengers;
    }//end of setPassengers

    
    /**
     *method- sets before as passed in parameter
     * 
     * @param before- TrainNode
     * 
     * @since 04/12/2014
     */
    public void setBefore(TrainNode before) {
        this.before = before;
    }//end of setBefore

    
    /**
     *method- sets After as passed in parameter
     * 
     * @param setAfter- TrainNode
     * 
     * @since 04/12/2014
     */
    public void setAfter(TrainNode after) {
        this.after = after;
    }//end of setAfter
    
    
    
    
    
    
    
    
}//end of TrainNode class
