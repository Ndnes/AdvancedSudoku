using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedSudokuLibrary
{
    public enum CellStateEnum
    {
        Blank,
        Answer,
        Hint,
        UserInputCorrect,
        UserInputWrong,
        Notes
    }
}
