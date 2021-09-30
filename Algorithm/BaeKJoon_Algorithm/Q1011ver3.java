package BaekJoon;

import java.util.Scanner;

public class Q1011ver3 {
	static int move(long distance) { //distance �̵��ؾ��� �Ÿ�
		int result = 0; //�ּ� �̵� Ƚ��
		long i=0, count=1;//i-�Ÿ�����, count-�ּ�Ƚ�� ����Ƚ��
		while(i<distance) {
			result++;
			i+=count;
			if(i==distance) break;
			if(result%2==0) {
					count++;
				}
		}
		return result;
	}
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int T = sc.nextInt();
		for(int i=0; i<T; i++) {
			int M = sc.nextInt();
			int N = sc.nextInt();
			long distance = (N-M);
			System.out.println(move(distance));
		}
	}
}
