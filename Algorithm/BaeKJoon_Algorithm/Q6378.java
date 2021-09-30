package BaekJoon;

import java.util.Scanner;

public class Q6378 {
	public static char num[] = new char[1005];
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		while(true) {
			char num[] = sc.nextLine().toCharArray();
			if(num.length<2) {
				String str = new String(num);
				if(str.equals("0")==true) break;
			}
			int sum = Digital_Route(num);
			if(sum>9) sum = conversion(sum);
			System.out.println(sum);
		}
	}
	public static int conversion(int sum) {
		char num[] = String.valueOf(sum).toCharArray();
		int result = Digital_Route(num);
		if(result>9) return conversion(result);
		else return result;
	}
	public static int Digital_Route(char num[]) {
		int Num[] = new int[10];
		for(int i=0; i<num.length; i++) {
			Num[num[i]-48]++;
		}
		int result=0;
		for(int i=0; i<Num.length; i++) {
			result += Num[i]*i;
		}
		return result;
	}
}
