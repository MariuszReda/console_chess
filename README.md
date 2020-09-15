using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_board
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

using Chess_board;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

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

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Chess_board

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
