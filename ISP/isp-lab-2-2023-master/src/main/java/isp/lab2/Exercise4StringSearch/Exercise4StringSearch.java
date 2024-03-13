package isp.lab2.Exercise4StringSearch;

import java.util.Scanner;

public class Exercise4StringSearch {
    public static int Count(String input, String substring)
    {
        String[] A = input.split(",");
        int j=0;
        for(String i : A)
        {
            if(i.contains(substring)) j++;
        }
        return j;
    }
    /**
     * This method should return an array of strings that contain the substring.
     * @param input
     * @param substring what to search for
     * @return
     */
    public static String[] searchSubstrings(String input, String substring)
    {
        String[] A = input.split(",");
        String[] B = new String[Count(input,substring)];
        int j=0;
        for(String i : A)
        {
            if(i.contains(substring)) {B[j]=i;j++;}
        }
        return B;
    }

    public static String readFromConsoleInt() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter line: ");
        return scanner.nextLine();
    }

    public static void main(String[] args) {
        String input = "apples,computer,bread,tea,car";
        String substring = "te";
        String[] result = searchSubstrings(input, substring);
        for (String string : result) {
            System.out.println(string);
        }
    }
}
