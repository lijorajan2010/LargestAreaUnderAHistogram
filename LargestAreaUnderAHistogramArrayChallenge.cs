using System;

class MainClass {

  public static int ArrayChallenge(int[] arr) {


    // code goes here 
    int size = arr.Length;
    int maxArea = 0;

    for(int current = 0;current < size; current++){
      int width =1;
      int moveRight = current +1;
      int moveLeft = current -1;


      while(moveRight < size && arr[moveRight] >= arr[current]){
        
        width ++;
        moveRight++;
      }

      while(moveLeft >=0 && arr[moveLeft] >= arr[current]){
        width++;
        moveLeft--;
      }

      if(width * arr[current] > maxArea)
      {
        maxArea = width * arr[current];
      }
    }
 
    return maxArea;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(ArrayChallenge(Console.ReadLine()));
  } 

}
