package BaekJoon;

import java.util.Scanner;

public class Q2231 {
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int N = sc.nextInt();
		int min = 1000000;
		int i=N;
		int temp =i;
		int constructor = N;
		while(i>0) {
			int remainder = temp%10;
			constructor = constructor + remainder;
			temp = temp/10;
			if(temp==0) {
				if(constructor<N/10) {
					break;
				}
				if(constructor==N) {
					if(i<min) {
						min = i;
					}
				}
				i--;
				temp = i;
				constructor = i;
			}
		}
		if(min==1000000) {
			System.out.println("0");
			sc.close();
		}
		else {
		System.out.println(min);
		sc.close();
		}
	}
}
