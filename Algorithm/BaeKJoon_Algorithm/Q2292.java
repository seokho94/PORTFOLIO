package BaekJoon;

import java.util.Scanner;

public class Q2292 {
   public static void main(String[] args) {
	   Scanner sc = new Scanner(System.in);
	   int N = sc.nextInt();
	   int result=2;
	   int i = 1;
	   if(N==1) result=1;
	   else {
		   while(true) {
			   i+=6*(result-1);
			   if(i>=N) break;
			   result++;
		   }
	   }
	   System.out.println(result);
   }
}