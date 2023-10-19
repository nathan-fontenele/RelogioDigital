using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RelogioDigital.Dados
{
    class Data : INotifyPropertyChanged
    {
        private string _date;

        public string Dia
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        public Data()
        {
            DataAtual();
        }

        private void DataAtual()
        {
            DateTime data = DateTime.Now;
            string dataFormatada = data.ToString("dddd, dd MMMM yyyy");
            Dia = dataFormatada;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); //Dispara o evento PropertyChanged para notificar as mudanças
        }

    }
}
