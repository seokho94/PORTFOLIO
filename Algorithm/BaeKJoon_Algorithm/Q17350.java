package BaekJoon;

import java.util.Scanner;

public class Q17350 {
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int N = sc.nextInt();
		String result = "����?";
		for(int i=0; i<N; i++) {
			String Name = sc.next();
			if(Name.equals("anj")) {
				result = "����;";
			}
		}
		System.out.println(result);
	}
}
