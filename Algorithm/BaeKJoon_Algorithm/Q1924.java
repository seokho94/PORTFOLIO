package BaekJoon;

import java.util.Scanner;

public class Q1924 {
	static String day(int count) {
		count = (count-1)%7;
		String Day[] = {"MON","TUE","WED","THU","FRI","SAT","SUN"};
		return Day[count];
	}
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int x = sc.nextInt();
		int y = sc.nextInt();
		int count = 0;
		boolean check = false;
		for(int i=1; i<=x; i++) {
			if(i==4||i==6||i==9||i==11) {
				for(int j=1; j<=30; j++) {
					count++;
					if(i==x && j==y) {
						check=true; break;
					}
				}
			}
			else if(i==2){
				for(int j=1; j<=28; j++) {
					count++;
					if(count==8) count=0;
					if(i==x && j==y) {
						check=true; break;
					}
				}
			}
			else {
				for(int j=1; j<=31; j++) {
					count++;
					if(i==x && j==y) {
						check=true; break;
					}
				}
			}
			if(check==true) break;
		}
		System.out.println(day(count));
	}
}
