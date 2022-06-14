using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesktop.Model
{
    public class MathModel : INotifyPropertyChanged
    {
        string nameModel;
        int a;
        int b;        
        string[] c;
        int stepen; // Степень функции

        public string NameModeli
        {
            get { return nameModel; }
            set
            {
                nameModel = value;
                OnPropertyChanged("NameModel");
            }
        }

        public int A
        {
            get { return a; }
            set
            {
                a = value;
                OnPropertyChanged("A");
            }
        }

        public int B
        {
            get { return b; }
            set
            {
                b = value;
                OnPropertyChanged("B");
            }
        }

        public int Stepen
        {
            get { return stepen; }
            set
            {
                stepen = value;
                OnPropertyChanged("Stepen");
            }
        }       

        public string[] C
        {
            get { return c; }
            set
            {
                c = value;
                OnPropertyChanged("C");
            }
        }



        public static MathModel[] GetModels()
        {
            var result = new[]
            {
                new MathModel(){ nameModel = "Линейная", stepen = 1, c = new string[] {"1","2","3","4","5"}},
                new MathModel(){ nameModel = "Квадратичная", stepen = 2, c = new string[] {"10","20","30","40","50"}},
                new MathModel(){ nameModel = "Кубическая", stepen = 3, c = new string[] {"100","200","300","400","500"}},
                new MathModel(){ nameModel = "4-ой степени", stepen = 4, c = new string[] {"1000","2000","3000","4000","5000"}},
                new MathModel(){ nameModel = "5-ой степени", stepen = 5, c = new string[] { "10000", "20000", "30000", "40000", "50000" }},
            };
            return result;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
