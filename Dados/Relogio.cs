using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace RelogioDigital.Dados
{
    class Relogio : INotifyPropertyChanged //Chama a interface
    {
        private int _hora;
        private int _minuto;
        private string _segundo;

        public int Hora
        {
            get { return _hora; }
            set
            {
                _hora = value;
                OnPropertyChanged(); // Notifica sobre a mudança na propriedade Hora
            }
        }

        public int Minuto
        {
            get { return _minuto; }
            set
            {
                _minuto = value;
                OnPropertyChanged(); // Notifica sobre a mudança na propriedade Minuto
            }
        }

        public string Segundo
        {
            get { return _segundo; }
            set
            {
                _segundo = value;
                OnPropertyChanged(); // Notifica sobre a mudança na propriedade Segundo
            }
        }

        private DispatcherTimer _timer;
        public Relogio()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += HorarioAtual;
            _timer.Start();
        }

        private void HorarioAtual(object sender, EventArgs e)
        {
            Hora = DateTime.Now.Hour;
            Minuto = DateTime.Now.Minute;
            Segundo = DateTime.Now.ToString("ss");
        }

        //implementa a interface
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); //Dispara o evento PropertyChanged para notificar as mudanças
        }
    }
}
