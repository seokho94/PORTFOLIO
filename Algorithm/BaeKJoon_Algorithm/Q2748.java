package BaekJoon;

import java.util.Scanner;

public class Q2748 {
	static long Fibonachi(long A, long B, long C) {
		C = A+B;
		return C;
	}
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int N = sc.nextInt();
		long First = 0;
		long Second = 1;
		long Number = 0;
			for(int i=0; i<=N; i++) {
				if(i==0) Number = First;
				else if(i==1) Number = Second;
				else {
				Number = Fibonachi(First,Second,Number);
				First = Second;
				Second = Number;
				}
				System.out.println(i+"��° "+Number);
			}
	}
}
