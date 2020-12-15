namespace Thuc_Hanh_He_Cac_So_Hoc
{
    public class Shape
    {
        private string color = "green";
        private bool filled = true;
        public Shape() { }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;

        }
        public string Getcolor()
        {
            return color;
        }
        public string SetColor(string color)
        {
            this.color = color;
        }
        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }
        public override string ToString()
        {
            return "A shap with color of"
            + Getcolor()
            + "and"
            + "filled" + "not filled" ;
        }
    }
}