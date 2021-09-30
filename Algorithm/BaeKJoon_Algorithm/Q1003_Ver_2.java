package BaekJoon;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class Q1003_Ver_2 {
	public static BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
	public static BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
	public static void main(String args[]) throws IOException {
		String fibonacci[] = new String[41];
		for(int i=0; i<fibonacci.length; i++) {
			if(i<2) {
				if(i==0) fibonacci[0]="1 0";
				else if(i==1) fibonacci[1] = "0 1";
			}
			else {
				String arr1[] = fibonacci[i-1].split(" ");
				String arr2[] = fibonacci[i-2].split(" ");
				fibonacci[i] = String.valueOf(Integer.parseInt(arr1[0])+Integer.parseInt(arr2[0]))+" "+
								String.valueOf(Integer.parseInt(arr1[1])+Integer.parseInt(arr2[1]));
			}
		}
		int N = Integer.parseInt(br.readLine());
		for(int i=0; i<N; i++) {
			bw.write(fibonacci[Integer.parseInt(br.readLine())]+"\n");
		}
		bw.flush();
	}
}
