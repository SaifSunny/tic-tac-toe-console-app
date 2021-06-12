using System;

class MainClass {

  static char[] box={'0','1','2','3','4','5','6','7','8','9'};
  static int checkwin(){
    if (box[1] == box[2] && box[2] == box[3])
        return 1;
    else if (box[4] == box[5] && box[5] == box[6])
        return 1;
    else if (box[7] == box[8] && box[8] == box[9])
        return 1;
    else if (box[1] == box[4] && box[4] == box[7])
        return 1;
    else if (box[2] == box[5] && box[5] == box[8])
        return 1;
    else if (box[3] == box[6] && box[6] == box[9])
        return 1;
    else if (box[1] == box[5] && box[5] == box[9])
        return 1;
    else if (box[3] == box[5] && box[5] == box[7])
        return 1;
    else if (box[1] != '1' && box[2] != '2' && box[3] != '3' && box[4] != '4' && box[5] != '5' && box[6] != '6'&& box[7] != '7' && box[8] != '8' && box[9] != '9')
        return 0;
    else
        return -1;
  }

  static void board(){
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ",box[1],box[2],box[3]);
    Console.WriteLine("_____|_____|_____" );
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ",box[4],box[5],box[6]);
    Console.WriteLine("_____|_____|_____" );
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ",box[7],box[8],box[9]);
    Console.WriteLine("     |     |     ");
  }
  public static void Main (string[] args) {
    int player =1;
    int win;
    do{
      Console.Clear();
      Console.WriteLine("Player 1 : X and Player 2 : O");
      Console.WriteLine();
      board();
      Console.WriteLine();
      Console.WriteLine("Please Enter a Position Number");
      Console.WriteLine();
      if(player % 2 == 0){
        Console.WriteLine("Player 2's Turn");
        player=2;
      }
      else{
        Console.WriteLine("Player 1's Turn");
        player=1;
      }
      int choice = Convert.ToInt32(Console.ReadLine());
      char mark = (player==1) ? 'X':'O';

      if (choice == 1 && box[1] == '1')
      box[1] = mark;
      else if (choice == 2 && box[2] == '2')
      box[2] = mark;
      else if (choice == 3 && box[3] == '3')
      box[3] = mark;
      else if (choice == 4 && box[4] == '4')        box[4] = mark;
      else if (choice == 5 && box[5] == '5')
      box[5] = mark;
      else if (choice == 6 && box[6] == '6')
      box[6] = mark;
      else if (choice == 7 && box[7] == '7')
      box[7] = mark;
      else if (choice == 8 && box[8] == '8')
      box[8] = mark;
      else if (choice == 9 && box[9] == '9')
      box[9] = mark;
      else
      {
        Console.WriteLine("Invalid Move.Try Again");
        player--;
      }
        player++;
        win = checkwin();
    }while(win == -1);
      board();
      if(win==1)
      Console.WriteLine("Player "+--player+" "+"Won");
      else
      Console.WriteLine("Its a Tie");
  }
}