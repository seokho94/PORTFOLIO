package BaekJoon;

import java.util.Arrays;
import java.util.Scanner;

public class Q4948 {
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int Number[] = new int[246913];
		Arrays.fill(Number, 1);
		for(int i=0; i<=246912; i++) {
			if(i==0 || i==1) Number[i]=0;
			if(Number[i]==1) {
				int count=2;
				int remove = 0;
				while(remove<=246912) {
					Number[remove]=0;
					remove = i*count;
					count++;
				}
			}
		}
		while(true) {
			int n = sc.nextInt();
			if(n==0) {
				sc.close();
				break;
			}
			int result=0;
			for(int i=2*n; i>n; i--) {
				if(Number[i]==1) {
					result++; 
				}
			}
			System.out.println(result);
		}
	}
}
