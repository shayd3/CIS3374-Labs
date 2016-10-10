/*
Name: Ryan Ross
Class: CIS3374 - QA and Testing
Assignment: Lab 1
 */
package lab1;

import java.io.*;
import java.time.*;
import java.util.*;

public class Lab1 {
    static String fileName = "..\\Lab1\\src\\lab1\\input.txt";
    static String line = null;
    public static void main(String[] args)  {

        Scanner console = new Scanner(System.in);
        
        System.out.println("=== Welcome to the Student Profile Program ===\n");
        
        while(true){
            System.out.println("Select an option: "
                  + "\n\t1 - Create new student entry"
                  + "\n\t2 - View student entries"
                  + "\n\t3 - Exit");
            System.out.print("> ");
            try{
                int userChoice = console.nextInt();
        
                switch (userChoice) {
                    case 1:
                        //call createEntry method
                        entryQuestions();
                        break;
                    case 2:
                        //Read and write to console input.txt
                        break;
                    case 3:
                        System.out.println("Thank you for using Student Profile Program");
                        System.exit(0);
                        break;
                    default:
                        break;
                } //End of Switch
            } catch (InputMismatchException e){
                System.out.println("Invalid entry. Please select options 1-3.");
                console.next();
            }
        }//End of while loop
    }//End of Main
    
    public static void entryQuestions(){
        Scanner console = new Scanner(System.in);
        
        //Make sure user cannot enter in numbers
        System.out.print("What is your Last Name?\n>");
        String lastName = console.next();
        System.out.print("What is your First Name?\n>");
        String firstName = console.next();
        System.out.print("What is your Middle Name?\n>");
        String middleName = console.next();
        
        String fullName = firstName + " " + middleName + " " + lastName;
        
        //Make sure user is inputting YYYY, between 1-13, or between 1-31
        System.out.print("What year were you born? (YYYY)\n>");
        int birthYear = console.nextInt();
        System.out.print("What month were you born? (1-12)\n>");
        int birthMonth = console.nextInt();
        System.out.print("What day of the month were you born? (1-31)\n>");
        int birthDay = console.nextInt();
        
        int age =  calculateAge(birthYear, birthMonth, birthDay);
        
        //Be sure to validate phone number entry
        System.out.print("What is your phone number?\n>");
        String phoneNumber = console.next();
        
        while(validatePhoneNumber(phoneNumber) == false){
         //Checks format //if false
            System.out.print("Invalid entry. Please try to enter your phone number again.\n>");
            phoneNumber = console.next();
        }
        
        //Grad date - Grab month/year (MM/YYYY)--Make sure MM is 1-12, year is 4 characters and are numbers
        System.out.print("What is your expected graduation date? (MM/YYYY)\n>");
        String gradDate = console.next();
        
        //Make sure 9 characters and are all numbers
        System.out.print("What is your TUID?\n>");
        int tuID = console.nextInt();
        
        //Make sure you have correct email extensions so @gmail.com, @temple.edu, @live.com
        System.out.print("What is your email address?\n>");
        String email = console.next();
        
        //Major - Check to see this is all letters
        System.out.print("What is your major?\n>");
        String major = console.next();
        
        //make sure input is either yes, no, y, or n. *IGNORE CASE*
        System.out.print("Are you an undergraduate? (y/n)\n>");
        String isUndergraduate = console.next();
        System.out.println("\n");
        
        createEntry(fullName, age, tuID, email, phoneNumber, major, gradDate, isUndergraduate);
    }//End of entryQuestions()
    
    public static void createEntry(String fullName, int age, int tuID, String email, String phoneNumber, String major, String gradDate, String isUndergraduate){
        try {
            //assuming default encoding
            FileWriter fW = new FileWriter(fileName);
            
            //Wrapping fW in bF
            BufferedWriter bW = new BufferedWriter(fW);
             bW.write("Name: " + fullName + "\n"); bW.newLine();
             bW.write("Age: " + age + "\n"); bW.newLine();
             bW.write("TUID: " + tuID + "\n"); bW.newLine();
             bW.write("Email: " + email + "\n"); bW.newLine();
             bW.write("Phone Number: " + phoneNumber + "\n"); bW.newLine();
             bW.write("Major: " + major + "\n"); bW.newLine();
             bW.write("Expected to graduate: " + gradDate + "\n"); bW.newLine();
             bW.write("Undergraduate: " + isUndergraduate); bW.newLine();
             bW.close();
        } catch (IOException ex){
            System.out.println("Error writing to file '" + fileName +"'");
        }
    }//End of createEntry()
    
    private static int calculateAge(int birthYear, int birthMonth, int birthDay){
        
        LocalDate dateOfBirth = LocalDate.of(birthYear, birthMonth, birthDay);
        LocalDate today = LocalDate.now();
        Period p = Period.between(dateOfBirth, today);
        int age = p.getYears();
        
        return age;
    }//End of calculateAge()
    
    private static boolean validatePhoneNumber(String phoneNumber) {
		//validate phone numbers of format "1234567890"
		if (phoneNumber.matches("\\d{10}")) return true;
		//validating -, . or spaces
		else if(phoneNumber.matches("\\d{3}[-\\.\\s]\\d{3}[-\\.\\s]\\d{4}")) return true;
		//validating length from 3 to 5
		else if(phoneNumber.matches("\\d{3}-\\d{3}-\\d{4}\\s(x|(ext))\\d{3,5}")) return true;
		//validating area code in braces ()
		else if(phoneNumber.matches("\\(\\d{3}\\)-\\d{3}-\\d{4}")) return true;
		//validating (xxx)xxxxxxx
                else if(phoneNumber.matches("\\(\\d{3}\\)\\d{7}")) return true;
                //return false if nothing matches the input`
		else 
                    return false;
		
    }//End of validatePhoneNumber
}


