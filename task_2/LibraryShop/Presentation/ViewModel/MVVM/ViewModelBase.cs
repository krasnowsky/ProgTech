﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Presentation.ViewModel.MVVM
{
    public class ViewModelBase : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region API
        /// <summary>
        /// Raises the PropertyChanged event if needed.
        /// </summary>
        /// <param name="propertyName">(optional) The name of the property that changed.
        /// The <see cref="CallerMemberName"/> allows you to obtain the method or property name of the caller to the method.
        /// </param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
