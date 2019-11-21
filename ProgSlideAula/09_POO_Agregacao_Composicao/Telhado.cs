namespace ProgSlideAulas.Agregacao
{
    public class Telhado
    {
        //public double Area { get; set; }          
        //public Casa Casa { get; set; }

        private double _area;
        private Casa _casa;

        public void SetLargura(double area)
        {
            this._area = area;
        }

        public double GetLargura()
        {
            return this._area;
        }  

        public void SetCasa(Casa casa)
        {
            this._casa = casa;
        }

        public Casa GetCasa()
        {
            return this._casa;
        }
    }
}