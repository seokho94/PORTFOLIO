package BaekJoon;

import java.util.Scanner;

public class Q2839 {
	static int delivery(int N, int count) {
		int sum = -1;
		while((N-3*count)>=0) {
			if((N-3*count)%5==0) {
				sum = count+(N-3*count)/5;
				break;
			}
			count++;
		}
		return sum;
	}
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int N = sc.nextInt();
		int Number = 0;
		int count = 0;
		if(N%5==0) {
			Number = N/5;
		}
		else {
			Number = delivery(N,count);
		}
		System.out.println(Number);
	}
}
