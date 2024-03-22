namespace JogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "O";
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;

            disparador.IsEnabled = false;

            if (vez == "O")
            {
                disparador.Text = "O";
                vez = "X";
            }
            else
            {
                disparador.Text = "X";
                vez = "O";
            }

            //Verificando se o "X" ganhou na primeira linha

            if
                (btn10.Text == "X" &&
                 btn11.Text == "X" &&
                 btn12.Text == "X")

            {

                DisplayAlert("Parabéns! ", "O X ganhou", "Fechar");
            }
            else if
                (btn20.Text == "X" &&
                 btn21.Text == "X" &&
                 btn22.Text == "X")

            {

                DisplayAlert("Parabéns! ", "O X ganhou", "Fechar");
            }
            else if
                (btn30.Text == "X" &&
                 btn31.Text == "X" &&
                 btn32.Text == "X")

            {

                DisplayAlert("Parabéns! ", "O X ganhou", "Fechar");
            }
            else if
                (btn10.Text == "X" &&
                 btn20.Text == "X" &&
                 btn30.Text == "X")

            {

                DisplayAlert("Parabéns! ", "O X ganhou", "Fechar");
            }
            else if
                (btn11.Text == "X" &&
                 btn21.Text == "X" &&
                 btn31.Text == "X")

            {

                DisplayAlert("Parabéns! ", "O X ganhou", "Fechar");
            }
            else if
                (btn12.Text == "X" &&
                 btn22.Text == "X" &&
                 btn32.Text == "X")

            {

                DisplayAlert("Parabéns! ", "O X ganhou", "Fechar");
            }
            else if
                (btn10.Text == "X" &&
                 btn21.Text == "X" &&
                 btn32.Text == "X")

            {

                DisplayAlert("Parabéns! ", "O X ganhou", "Fechar");
            }
            else if
                (btn12.Text == "X" &&
                 btn21.Text == "X" &&
                 btn30.Text == "X")
            {

                DisplayAlert("Parabéns! ", "O X ganhou", "Fechar");
            }
            //Verificando se a O ganhou
            else if
                (btn10.Text == "O" &&
                 btn11.Text == "O" &&
                 btn12.Text == "O")

            {

                DisplayAlert("Parabéns! ", "A O ganhou", "Fechar");
            }
            else if
                (btn20.Text == "O" &&
                 btn21.Text == "O" &&
                 btn22.Text == "O")

            {

                DisplayAlert("Parabéns! ", "A O ganhou", "Fechar");
            }
            else if
                (btn30.Text == "O" &&
                 btn31.Text == "O" &&
                 btn32.Text == "O")

            {

                DisplayAlert("Parabéns! ", "A O ganhou", "Fechar");
            }
            else if
                (btn10.Text == "O" &&
                 btn20.Text == "O" &&
                 btn30.Text == "O")

            {

                DisplayAlert("Parabéns! ", "A O ganhou", "Fechar");
            }
            else if
                (btn11.Text == "O" &&
                 btn21.Text == "O" &&
                 btn31.Text == "O")

            {

                DisplayAlert("Parabéns! ", "A O ganhou", "Fechar");
            }
            else if
                (btn12.Text == "O" &&
                 btn22.Text == "O" &&
                 btn32.Text == "O")

            {

                DisplayAlert("Parabéns! ", "A O ganhou", "Fechar");
            }
            else if
                (btn10.Text == "O" &&
                 btn21.Text == "O" &&
                 btn32.Text == "O")

            {

                DisplayAlert("Parabéns! ", "A O ganhou", "Fechar");
            }
            else if
                (btn12.Text == "O" &&
                 btn21.Text == "O" &&
                 btn30.Text == "O")
            {

                DisplayAlert("Parabéns! ", "A O ganhou", "Fechar");
            }

            else if
               (btn10.IsEnabled == false &&
                btn11.IsEnabled == false &&
                btn12.IsEnabled == false &&
                btn21.IsEnabled == false &&
                btn22.IsEnabled == false &&
                btn20.IsEnabled == false &&
                btn30.IsEnabled == false &&
                btn31.IsEnabled == false &&
                btn32.IsEnabled == false)
            {
                DisplayAlert("Que pena!", "O jogo deu velha :(", "Fechar");
            }
        }

        private void limpar()
        {
            btn10.Text = "";
            btn10.IsEnabled = true;
            btn11.Text = "";
            btn11.IsEnabled = true;
            btn12.Text = "";
            btn12.IsEnabled = true;
            btn20.Text = "";
            btn20.IsEnabled = true;
            btn21.Text = "";
            btn21.IsEnabled = true;
            btn22.Text = "";
            btn22.IsEnabled = true;
            btn30.Text = "";
            btn30.IsEnabled = true;
            btn31.Text = "";
            btn31.IsEnabled = true;
            btn32.Text = "";
            btn32.IsEnabled = true;

        }

        private void restart_Clicked(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
