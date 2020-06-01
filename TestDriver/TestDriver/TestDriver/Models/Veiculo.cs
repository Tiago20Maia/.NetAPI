namespace TestDriver.Models
{
    public class Veiculo
    {
        public const int FREIO_ABS = 800;
        public const int AR_CONDICIONADO = 1000;
        public const int MP3_PLAYER = 500;

        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {   
            get { return string.Format("R$ {0}", Preco); }
        }

        public bool TemFreioABS { get; set; }
        public bool TemArcondicionado { get; set; }
        public bool TemMP3 { get; set; }

        public string ValorTotalFormatado
        {
            get
            {
                return string.Format("Valor total: R$ {0}", Preco
                    + (TemFreioABS ? FREIO_ABS : 0)
                    + (TemArcondicionado ? AR_CONDICIONADO : 0)
                    + (TemMP3 ? MP3_PLAYER : 0));
            }

        }
    }
}

