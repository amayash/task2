import java.util.Random;
import java.util.Scanner;

public class lab2_7 {

    public static void main(String[] args) {

        System.out.println("С каким массивом будем работать?\n1. Одномерный\n2. Двумерный");
        Scanner sc = new Scanner(System.in);
        Random r = new Random();
        int num = sc.nextInt();
        if(num==1){
            System.out.println("Введите размер массива");
            int size=sc.nextInt();
            int[] arr=new int[size];
            System.out.println("Как будет задавать массив?\n1. Вручную\n2. Случайно");
            int how=sc.nextInt();
            if (how==1){
                System.out.println("Начните вводить элементы");
                for(int i=0;i<size;i++)
                    arr[i]=sc.nextInt();
                System.out.println("Ваш массив:");
                for(int i=0;i<size;i++)
                    System.out.print(arr[i]+" ");
            }
            if (how==2){
                System.out.println("Ваш массив:");
                for(int i=0;i<size;i++) {
                    arr[i]=r.nextInt(10);
                    System.out.print(arr[i]+" "); }
                
            }
			int mini=0;
                int maxi=0;
                int min = 101;
                int max = 0;
                for(int i = 0; i < arr.length; i++) {
                    if (arr[i]< min) {
                        min = arr[i];
                        mini=i;
                    }
                    if (arr[i]> max) {
                        max = arr[i];
                        maxi=i;
                    }
                }
                System.out.println("maxi-"+maxi+" mini-"+mini);
                if (mini<maxi)
                {
                    int left=mini+1;
                    int right=maxi-1;
                    while(left<right)
                    {
                        int tmp=arr[left];
                        arr[left]=arr[right];
                        arr[right]=tmp;
                        left++;
                        right--;
                    }
                }
                if (mini>maxi)
                {
                    int left=maxi+1;
                    int right=mini-1;
                    while(left<right)
                    {
                        int tmp=arr[left];
                        arr[left]=arr[right];
                        arr[right]=tmp;
                        left++;
                        right--;
                    }
                }
                System.out.println("\nВаш измененный массив:");
                for(int i=0;i<size;i++)
                    System.out.print(arr[i]+" ");
        }
        if(num==2){
            System.out.println("Введите размер массива. Кол-во строк и столбцов");
            int n=sc.nextInt();
            int m=sc.nextInt();
            int[][] arr2=new int[n][m];
            System.out.println("Как будет задавать массив?\n1. Вручную\n2. Случайно");
            int how2=sc.nextInt();
            if(how2==1){
                System.out.println("Начните вводить элементы");
                for(int i=0;i<n;i++) {
                    for(int j=0;j<m;j++) {
                        arr2[i][j]=sc.nextInt();
                    }
                }
                System.out.println("Ваш массив:");
                for(int i=0;i<n;i++) {
                    for(int j=0;j<m;j++) {
                        System.out.print(arr2[i][j]+"\t");
                        System.out.print("|");
                    }
                    System.out.println();
                }
                int max=0;
                int maxst=0;
                int st = 0;
                for (int i=0;i<n;i++) {
                    for(int j=0;j<m;j++){
                        if (arr2[i][j]>max){
							max=arr2[i][j]; maxst=i;
						}
                        if(arr2[i][j]<0){
							if (arr2[i][j]%2==-1) {
								st=i;
							}
                        }
                    }
                }
                System.out.println("Строка с отрицательным - "+st+"\nСтрока с макс. - "+maxst);
                int[][] dubl=new int[1][m];
                for (int i=0;i<1;i++){
                    for (int j=0;j<m;j++){
                        dubl[i][j]=arr2[maxst][j];}}
                for(int i=0;i<=st;i++) {
                    for(int j=0;j<m;j++) {
                        System.out.print(arr2[i][j]+"\t");
                        System.out.print("|");
                    }
                    System.out.println();
                }
                for (int j=0;j<m;j++) {
                    System.out.print(dubl[0][j]+"\t");
                    System.out.print("|");
                }
                System.out.println();
                for (int i=st+1;i<n;i++){
                    for(int j=0;j<m;j++){
                        System.out.print(arr2[i][j]+"\t");
                        System.out.print("|");
                    }
                    System.out.println();
                }

            }
            if(how2==2){
                for(int i=0;i<n;i++) {
                    for(int j=0;j<m;j++) {
                        arr2[i][j]=r.nextInt(100);
                        System.out.print(arr2[i][j]+"\t");
                        System.out.print("|");
                    }
                    System.out.println();
                }
            }
        }
    }
}
