using System;
// Inplace selection sort
   /*

    arr: array of items
    n: size of list


    for i = 0 ti n - 1:
      lowest = i

      for j = idx + 1 to n
        if arr[j] < arr[min]:
          min = j
      

    if  min != i then swap arr[min] arr[i]
    */
class MainClass {

  /// <summary>This method prints an integer array.</summary>
  /// <param name="arr">The integer array to be printed. </param>
  static void PrintArray(int [] arr){
    foreach(int i in arr){
      Console.Write(i + " ");
    }
  }


  /// <summary>This method sort an integer array.</summary>
  /// <param name="arr">The integer array to be printed. </param>
  static void SelectionSort(int[] arr){
    
    for(int i = 0; i < arr.Length-1; i++){

      int idxMin = i;

      for(int j = i+1; j < arr.Length; j++){
        if(arr[j] < arr[idxMin]){
          idxMin = j;
        }
      }
      

      if(idxMin != i){
        int temp = arr[i];
        arr[i] = arr[idxMin];
        arr[idxMin] = temp;
      }

    }
  }

  public static void Main (string[] args) {
 

    int[] arr = {5,6,2,3,4,100,85,66};

    PrintArray(arr);
    SelectionSort(arr);
    Console.WriteLine("");
    PrintArray(arr);
    int arr_length = arr.Length;
    
  }
}