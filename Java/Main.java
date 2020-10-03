/*
lower = 0
upper = last index in array

while lower < upper:
  mid lower + upper / 2

  if target is equal to element at mid idx return mid idx

  if target is greater than mid look left
  else look right


if not found  return -1
*/

class Main {

  /**
  This function returns the index of a target element of an integer array.
  if not found the function will return -1
  @param arr Integer array to be searched.
  @param target The element to search for.
  */

  static int binarySearch(int [] arr, int target){
    int lower = 0;
    int upper = arr.length - 1;

    while(lower < upper){
      int mid = (lower + upper) / 2;

      if(arr[mid] == target) return mid;

      if(arr[mid] < target) {
        lower = mid + 1;
      }else{
        upper = mid - 1;
      }
    }

    return -1;
  }
  public static void main(String[] args) {
    int[] arr = {5 ,6, 7, 8, 23, 45, 99, 200};

    int result = binarySearch(arr, 99);
    // Should return 6
    System.out.println(result);

    result = binarySearch(arr, 6);
    // Should return 1
    System.out.println(result);
  }
}