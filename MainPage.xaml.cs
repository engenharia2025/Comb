namespace Comb
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                if(etanol <= (gasolina * 0.7))
                {
                    DisplayAlert("Resultado", "Abasteça com Etanol", "OK");
                }
                else
                {
                    DisplayAlert("Resultado", "Abasteça com Gasolina", "OK");
                };

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }

}
