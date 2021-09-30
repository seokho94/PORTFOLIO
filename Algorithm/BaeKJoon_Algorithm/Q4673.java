package BaekJoon;

import java.util.HashSet;
import java.util.Iterator;

public class Q4673 {
	public static void main(String args[]) {
		HashSet<Integer> hs = new HashSet<>();
		for(int i=1; i<=10000; i++) {
			hs.add(i);
		}
		int i=1;
		int constructor;
		while(i!=10000) {
			constructor = Num(i);
			hs.remove(constructor);
			i++;
		}
		Iterator it = hs.iterator();
		while(it.hasNext()) {
			System.out.println(it.next());
		}
	}
	static int Num(int N) {
		int result = 0;
		if(N<10) {
			result = N+N;
		}
		else if(N<100) {
			result = N+(N/10)+(N%10);
		}
		else if(N<1000) {
			result = N+(N/100)+((N%100)/10)+((N%100)%10);
		}
		else if(N<10000) {
			result = N+(N/1000)+((N%1000)/100)+(((N%1000)%100)/10)+(((N%1000)%100)%10);
		}
		return result;
	}
}