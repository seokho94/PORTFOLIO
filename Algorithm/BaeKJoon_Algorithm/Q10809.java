package BaekJoon;

import java.util.Scanner;

public class Q10809 {
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		char word[] = sc.next().toCharArray();
		int sequence[] = new int [26];
		for(int t=0; t<sequence.length; t++) {
			sequence[t] = -1;
		}
		for(int i=0; i<word.length; i++) {
			if(sequence[word[i]-97]==-1) {
			sequence[word[i]-97]=i;
			}
		}
		for(int i=0; i<sequence.length; i++) {
			System.out.print(sequence[i]+" ");
		}
	}
}
