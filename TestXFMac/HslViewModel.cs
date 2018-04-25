using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace TestXFMac
{
    public class HslViewModel: INotifyPropertyChanged
    {
        double _hue, _saturation, _luminosity;
        Color _color;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Hue
        {
            set{
                if( _hue != value){

                    _hue = value;
                    OnPropertyChanged("Hue");
                    SetNewColor();

                }
            }
            get
            {
                return _hue;
            }
        }

        public double Saturation
        {
            set
            {
                if (_saturation != value)
                {
                    _saturation = value;
                    OnPropertyChanged("Saturation");
                    SetNewColor();
                }
            }
            get
            {
                return _saturation;   
            }
        }

        public double Luminosity
        {
            set{
                if (_luminosity != value)
                {
                    _luminosity = value;
                    OnPropertyChanged("Luminosity");
                    SetNewColor();
                }
            }
            get{
                return _luminosity;
            }
        }

        public Color Color
        {
            set
            {
                if (_color != value)
                {
                    _color = value;
                    OnPropertyChanged("Color");

                    this.Hue = value.Hue;
                    this.Saturation = value.Saturation;
                    this.Luminosity = value.Luminosity;
                }
                
            }
            get
            {
                return _color;
            }
        }

        void SetNewColor()
        {
            this.Color = Color.FromHsla(this.Hue, this.Saturation, this.Luminosity);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
