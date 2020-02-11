using System;
using System.Collections.Generic;
using System.Text;

namespace UEMS.BLL

{
    public class ProgressStatus
    {
        #region Member variables.
        private int _totalProcessses = 0;
        private string _mainProcessName = string.Empty;

        public delegate void ProgressStatusChangedEventHandler(object sender, ProgressStatusChangedEventArgs e);
        public event ProgressStatusChangedEventHandler ProgressStatusChange;
        #endregion

        #region Constructors & Finalizers.
        public ProgressStatus(string mainProcessName, int totalProcesses)
        {
            _totalProcessses = totalProcesses;
            _mainProcessName = mainProcessName;
        }
        #endregion

        #region Nested Enums, Structs, and Classes.
        #endregion

        #region Properties

        public int TotalProcessses
        {
            get { return _totalProcessses; }
            set { _totalProcessses = value; }
        }


        public string MainProcessName
        {
            get { return _mainProcessName; }
            set { _mainProcessName = value; }
        }

        #endregion

        #region Methods
        public void RaiseProgressStatusChangedEvent(int completedProcessNo, string nextSubProcessName)
        {
            if (ProgressStatusChange != null)
            {
                ProgressStatusChange(this, new ProgressStatusChangedEventArgs(TotalProcessses, completedProcessNo, MainProcessName, nextSubProcessName));
            }
        }
        #endregion
    }

    
    /// <summary>
    /// 
    /// </summary>
    public class ProgressStatusChangedEventArgs : EventArgs
    {
        #region "Private variables"
        private int _completedPercentage = 0;
        private string _mainProcessName = string.Empty;
        private string _subProcessName = string.Empty;
        private int _completedProcessNo = 0;
        private int _totalProcessses = 0;

        #endregion

        #region "Properties"
        public int CompletedPercentage
        {
            get { return _completedPercentage; }
            set { _completedPercentage = value; }
        }

        public string MainProcessName
        {
            get { return _mainProcessName; }
            set { _mainProcessName = value; }
        }


        public string SubProcessName
        {
            get { return _subProcessName; }
            set { _subProcessName = value; }
        }

        public int CompletedProcessNo
        {
            get { return _completedProcessNo; }
            set { _completedProcessNo = value; }
        }


        public int TotalProcessses
        {
            get { return _totalProcessses; }
            set { _totalProcessses = value; }
        }

        #endregion


        public ProgressStatusChangedEventArgs(int totalProcess, int completedProcessNo, string mainProcessName, string NextSubProcessName)
            : base()
        {
            _totalProcessses = totalProcess;
            _completedProcessNo = completedProcessNo;
            _completedPercentage = Convert.ToInt32(Math.Truncate(((double)completedProcessNo * 100) / (double)totalProcess));
            _mainProcessName = mainProcessName;
            _subProcessName = NextSubProcessName;
        }


    }


}
