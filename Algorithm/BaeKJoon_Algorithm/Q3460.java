package BaekJoon;

import java.util.Scanner;

public class Q3460 {
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int T = sc.nextInt();
		for(int i=0; i<T; i++) {
			StringBuilder sb = new StringBuilder("");
			String check = binary(sc.nextInt(),sb);
			tracking(check);
			System.out.println();
		}
		sc.close();
	}
	public static String binary(int num, StringBuilder sb) {
		while(num>0) {
			sb.append(num%2);
			num/=2;
		}
		return sb.toString();
	}
	public static void tracking(String str) {
		char find[] = str.toCharArray();
		for(int i=0; i<str.length(); i++) {
			if(find[i]=='1') {
				System.out.print(i+" ");
			}
		}
	}
}
