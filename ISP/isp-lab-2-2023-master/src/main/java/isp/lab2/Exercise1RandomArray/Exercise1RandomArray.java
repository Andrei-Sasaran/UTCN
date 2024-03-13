package isp.lab2.Exercise1RandomArray;

import java.util.Random;

public class Exercise1RandomArray {

    public static int[] getArrayOfRandomNumbers(int n) {
        int[] array = new int[n];
        //TODO: implement the logic to fill the array with random numbers
        Random x = new Random();
        for(int i=0; i<n; i++)
        {
            array[i]=x.nextInt(91)+10;
        }
        return array;
    }

    public static int[] findMaxAndMin(int[] array) {
        int max=0, min=100; int[] arr = new int[2];
        for(int i=0; i<array.length; i++)
        {
            if (array[i]>max) max = array[i];
            if (array[i]<min) min = array[i];
        }
        arr[0]=min; arr[1]=max;
        return arr;
    }

    public static void main(String[] args) {

        Random random = new Random();
        //genereaza numar random intre 10 si 100
        int size = random.nextInt(91) + 10;
        int[] a = getArrayOfRandomNumbers(size);
        int[] mm = findMaxAndMin(a);
        System.out.println("Min is:"+mm[0]+" Max is:"+mm[1] );
    }
}
