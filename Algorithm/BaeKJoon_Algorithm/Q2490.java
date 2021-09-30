package BaekJoon;

import java.util.Scanner;

public class Q2490 {
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int N = 3;
		for(int i=0; i<N; i++) {
			String str = sc.nextLine();
			str = str.replaceAll(" ","");
			char pattern[] = str.toCharArray();
			int Num[] = new int[2];
			for(int j=0; j<4; j++) {
				Num[pattern[j]-48]++;
			}
			switch(Num[0]) {
			case 1: 
				System.out.println("A");
				break;
			case 2: 
				System.out.println("B");
				break;
			case 3: 
				System.out.println("C");
				break;
			case 4: 
				System.out.println("D");
				break;
			case 0: 
				System.out.println("E");
				break;
			}
		}
	}
}
