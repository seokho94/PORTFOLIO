package BaekJoon;

import java.util.Scanner;

public class Q1085 {
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int x = sc.nextInt();
		int y = sc.nextInt();
		int w = sc.nextInt();
		int h = sc.nextInt();
		int wd, hd;
		if((w-x)>=x) {
			wd = x;
		}
		else {
			wd = (w-x);
		}
		if((h-y)>=y) {
			hd = y;
		}
		else {
			hd = (h-y);
		}
		if(hd<=wd) {
			System.out.println(hd);
		}
		else {
			System.out.println(wd);
		}
	}
}
