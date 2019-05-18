using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AdvancedSudokuLibrary
{
    public class CellModel : INotifyPropertyChanged
    {

        private CellStateEnum _cellState;

        public CellStateEnum CellState
        {
            get { return _cellState; }
            set
            {
                _cellState = value;
                OnPropertyChanged();
            }
        }










        public event PropertyChangedEventHandler PropertyChanged; //Interface definition

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "") //TODO: What is CallerMemberName?
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        } 
    }
}
