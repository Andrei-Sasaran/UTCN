package isp.lab2.Exercise5EvenOddSearch;

public class Exercise5EvenOddSearch {
    
    public static int[] findEvenOdd(String input) {
        String[] B = input.split(",");
        int[] A = new int[B.length];
        int[] result = new int[4];
        int j=0;
        int LargestEvenNumber=0;
        int SmallestOddNumber=100;
        int LENpos=0;
        int SONpos=0;
        for(String i : B)
        {
            A[j] = Integer.parseInt(i);
            j++;
        }
        for(int i=0; i< A.length; i++)
        {
            if((A[i]%2 == 0)&&(A[i] > LargestEvenNumber))
            {
                LargestEvenNumber = A[i];
                LENpos = i+1;
            }
            if((A[i]%2 != 0)&&(A[i] < SmallestOddNumber))
            {
                SmallestOddNumber = A[i];
                SONpos = i+1;
            }
        }
        result[0] = SmallestOddNumber;
        result[1] = LargestEvenNumber;
        result[2] = SONpos;
        result[3] = LENpos;
        return result;
    }

    public static void main(String[] args) {
        String input = "1,2,3,4,5,6,7,8,9,10";
        int[] result = findEvenOdd(input);
        for (int i : result) {
            System.out.print(" "+i);
        }
    }
}
