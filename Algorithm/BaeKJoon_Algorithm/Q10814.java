package BaekJoon;

import java.util.Scanner;

public class Q10814 {
	private static void mergeSort(String[][] arr) {
		String[][] tmp = new String[arr.length][2];
		mergeSort(arr,tmp,0,arr.length-1);
	}
	private static void mergeSort(String arr[][], String tmp[][], int start, int end) {
		if(start<end) {
			int mid = (start + end) / 2;
			mergeSort(arr,tmp,start,mid);
			mergeSort(arr,tmp,mid+1,end);
			merge(arr, tmp, start, mid, end);
		}
	}
	private static void merge(String arr[][], String tmp[][], int start, 
			int mid, int end) {
		for (int i = start; i<=end; i++) {
			tmp[i][0] = arr[i][0];
			tmp[i][1] = arr[i][1];
		}
			int part1 = start;
			int part2 = mid+1;
			int index = start;
			while(part1 <=mid && part2<=end) {
				if(Integer.parseInt(tmp[part1][0])<Integer.parseInt(tmp[part2][0])) {
					arr[index][0] = tmp[part1][0];
					arr[index][1] = tmp[part1][1];
					part1++;
				}
				else if(Integer.parseInt(tmp[part1][0])>Integer.parseInt(tmp[part2][0])) {
					arr[index][0] = tmp[part2][0];
					arr[index][1] = tmp[part2][1];
					part2++;
				}
				else {
					if(part1<part2) {
						arr[index][0] = tmp[part1][0];
						arr[index][1] = tmp[part1][1];
						part1++;
					}
					else if(part1>part2) {
						arr[index][0] = tmp[part2][0];
						arr[index][1] = tmp[part2][1];
						part2++;
					}
				}
				index++;
				
			}
			for(int i=0; i<=mid-part1; i++) {
				arr[index + i][0] = tmp[part1 + i][0];
				arr[index + i][1] = tmp[part1 + i][1];
			}
		}
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int N = sc.nextInt();
		String arr[][] = new String[N][2];
		for(int i=0; i<N; i++) {
			arr[i][0] = sc.next();
			arr[i][1] = sc.next();
			System.out.println(arr[i][0]+" "+arr[i][1]);
		}
		System.out.println("���� ��");
		mergeSort(arr);
		for(int i=0; i<N; i++) {
			System.out.println(arr[i][0]+" "+arr[i][1]);
		}
		sc.close();
	}
}
