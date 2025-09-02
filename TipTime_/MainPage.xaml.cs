namespace TipTime_
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
        }
        private void DescQuinzeBtn(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
        }

        private void DescVinteBtn (object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
        }
        private void RDBtn (object sender, EventArgs e)
        {

        }
        private void RedBaixo_Clicked (object sender, EventArgs e)
        {

        }
        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }

}
