package BaekJoon;

import java.util.Scanner;

public class Q6376 {
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		System.out.println("n "+"e");
		System.out.println("- -----------");
		double e = 0;
		for(int i=0; i<10; i++) {
			int sum = 1;
			if(i==0) {
				e+=1;
			}
			else {
				e+=1/factorial(i,sum);
			}
			System.out.println(i+" "+e);
		}
	}
	public static double factorial(int num, int sum) {
		if(num==0) {
			return sum;
		}
		else {
			sum*=num;
			return factorial(num-1,sum);
		}
	}
}
