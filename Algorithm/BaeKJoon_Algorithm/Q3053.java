package BaekJoon;

import java.text.DecimalFormat;
import java.util.Scanner;

public class Q3053 {
	static double Euclid(int r) {
		double area = Math.pow(r, 2)*Math.PI;
		return area;
	}
	static double Taxi(int r) {
		double area = Math.pow(r,2)+Math.pow(r, 2);
		return area;
	}
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int r = sc.nextInt();
		DecimalFormat dF = new DecimalFormat("####.######");
		System.out.println(dF.format(Euclid(r)));
		System.out.println(String.format("%.6f", Taxi(r)));
	}
}
