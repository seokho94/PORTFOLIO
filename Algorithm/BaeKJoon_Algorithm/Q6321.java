package BaekJoon;

import java.util.Scanner;

public class Q6321 {
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int T = sc.nextInt();
		sc.nextLine();
		for(int i=0; i<T; i++) {
			char Name[] = sc.nextLine().toCharArray();
			Change_Name(Name);
			String str = new String(Name);
			System.out.println("String #"+(i+1));
			System.out.println(str);
			System.out.println();
		}
		sc.close();
	}
	public static char[] Change_Name(char Name[]) {
		for(int i=0; i<Name.length; i++) {
			if(Name[i]!='Z') Name[i]++;
			else Name[i]=65;
 		}
		return Name;
	}
}
