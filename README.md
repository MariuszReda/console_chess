#Console_chess
##Emulation chess piece

```cs
##namespace Chess_board
{
    // ===========================
    //
    //  Cell
    // ---------------------------
    //  Cell class uses for 
    //  class field initialization
    //  like table of contents
    //
    // ===========================
	}

    public class Cell
	 {
        // ===========================
        //
        //  Squares X i Y
        // ---------------------------
        //  Initialize and assign
        //  rowNumber and columnNumber
        //  to later use to determine
        //  position chess pawn
        //  
        //
        // ===========================
        public int rowNumber { get; set; } 
        public int columnNumber { get; set; }

        // ===========================
        //
        //  CurentlyBusy and legalMove
        // ---------------------------
        // Initialize and assign
        // curentlyBusy and legalMove
        // curentlyBussy check if the X / Y field is empty
        // to know if the player can
        // legalMove make a move, display if so
        //
        // ===========================
        public bool curentlyBusy { get; set; }
        public bool legalMove { get; set; }


        // ===========================
        //
        //  Cell
        // ---------------------------
        //  Update rowNumber and
        //  columnNumber of player
        //  every time when the player
        //  choose a square
        //
        // ===========================
        public Cell(int x, int y)
        {
            rowNumber = x;
            columnNumber = y;
        }
    }
}
```
##Main
```cs
namespace move_chess

class Program
{
    //================================
    //
    //static void Main(string[] args)
    //--------------------------------
    //generate chess board
    //if with values get result
    //if null wait for next step
    //
    // get the cords and check if the number typed from the keyboard
    // result if correct returns to the array
    //
    //================================
    private static void printBoard(ChessBoardModel2 myBoard)
    public static Cell SetCurentCell()

}
```

##namespace Chess_board
```cs
{
    //================================
    //
    //public ChessBoardModel2
    //--------------------------------
    //creat object new 2D array of typ Cell
    //
    //================================
    public class ChessBoardModel

    //================================
    //
    //mark the legal moves
    //and check that it does not exceed array
    //--------------------------------
    //clear all previous legal move
    //next check legal moves for selection
    //get coord theGrid
    //display moves not larger than the size of the array
    //==================================
    public void MarkNextLegalMove(Cell currentCell, string chessPiece)
    private bool isSafe(int x, int y)
}
```
<a href="https://ibb.co/1qpkTrh"><img src="https://i.ibb.co/MVjm7cW/ss1.png" alt="ss1" border="0"></a>
<a href="https://ibb.co/0XLLT5q"><img src="https://i.ibb.co/b3VVTt1/ss2.png" alt="ss2" border="0"></a>
<a href="https://ibb.co/zPzRhKJ"><img src="https://i.ibb.co/L93tz45/ss3.png" alt="ss3" border="0"></a>
<a href="https://ibb.co/gzprRbW"><img src="https://i.ibb.co/1850mYX/ss4.png" alt="ss4" border="0"></a>
