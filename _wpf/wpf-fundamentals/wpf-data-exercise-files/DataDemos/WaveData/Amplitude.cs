using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WaveData
{
    class Amplitude : INotifyPropertyChanged
    {
        private double amplitudePropertyValue;

        public double Value
        {
            get { return amplitudePropertyValue; }
            set
            {
                if (amplitudePropertyValue != value)
                {
                    amplitudePropertyValue = value;
                    OnPropertyChanged("Amplitude");
                }
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }
	
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Private methods

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
