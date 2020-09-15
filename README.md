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
