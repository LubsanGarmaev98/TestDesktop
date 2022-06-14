using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDesktop.Model;

namespace TestDesktop.ViewModel
{
    public class MainWindowViewModel: INotifyPropertyChanged
    {
        MathModel[] models;
        MathModel selectedModel;
        public MathModel[] Models { get; private set; }
        
        public MathModel SelectedModel
        {
            get
            {
                return selectedModel;
            }
            set{
                selectedModel = value;                
                OnPropertyChanged("SelectedModel");                
            }
        }
        /*
        public MathModel SelectedCArray
        {
            get
            {
                return selectedModel;
            }
            set
            {
                SelectedCArray = value;
                OnPropertyChanged("SelectedCArray");
            }
        }
        */
        public MainWindowViewModel()
        {
            Models = MathModel.GetModels();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

        public void calculation ()
        {
            //return a * Math.Pow(x, t) + b * Math.Pow(x, t - 1) + c;
        }


    }

    

    }
