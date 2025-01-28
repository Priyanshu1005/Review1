using System;

class RemoveDuplicates {
    static void Main() {
        int[] arr={1,2,1,3,2,3,1};
        int n=arr.Length;
        for(int i=0;i<n-1;i++){
            for(int j=i+1;j<n;j++){
                if(arr[i]==arr[j]){
                    arr[j]=-1;
                }
            }
        }
        Console.WriteLine("Array after removing duplicates: ");
        for(int i=0;i<n;i++){
            if(arr[i]!=-1){
                Console.Write(arr[i]+" ");
            }
        }
    }
}