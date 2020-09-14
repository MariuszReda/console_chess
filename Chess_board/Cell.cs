using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_board
{
    public class Cell
    {
        
        public int rowNumber { get; set; } //numeber of row
        public int columnNumber { get; set; } // number of column

        public bool curentlyBusy { get; set; }  // field occupied
        public bool legalMove { get; set; } // check if move is legal


        public Cell(int x, int y)
        {

            rowNumber = x;
            columnNumber = y;

        }


    }
}

