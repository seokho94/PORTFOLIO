package BaekJoon;

import java.util.Scanner;

public class Q17362ver2 {
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int N = sc.nextInt();
		if(N%8==1) {
			System.out.println("1");
		}
		else if(N%8==2 || N%8==0) {
			System.out.println("2");
		}
		else if(N%8==3 || N%8==7) {
			System.out.println("3");
		}
		else if(N%8==4 || N%8==6) {
			System.out.println("4");
		}
		else if(N%8==5) {
			System.out.println("5");
		}
	}
}
