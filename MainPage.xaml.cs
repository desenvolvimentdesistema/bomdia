namespace BomDiaGrupo;

public partial class MainPage : ContentPage
{
	string[] frases = new string[10];

	public MainPage()
	{
		InitializeComponent();

		frases[0] = "Bom dia! Que hoje seja o início de uma jornada cheia de conquistas e alegrias";
		frases[1] = "A luz do Sol é um lembrete de que cada dia é uma nova oportunidade para brilhar. Bom dia!";
		frases[2] = "Que este dia traga sorriso, abraços e muita positividade. Bom dia!";
		frases[3] = "A cada amanhecer, renovam-se as esperanças. Bom dia, que seu dia seja repleto de realizações!";
		frases[4] = "Comece o dia com gratidão no coração e tudo se transformará em bênçãos. Bom dia!";
		frases[5] = "Que  cada raio de Sol leve consigo uma mensagem de esperança e felicidade. Bom dia!";
		frases[6] = "Que a paz acompanhe seu dia e a alegria preencha seu coração. Bom dia!";
		frases[7] = "Levante-se e brilhe, o mundo espera pela sua luz. Bom dia!";
		frases[8] = "Cada novo amanhecer é uma página em branco, pronta para ser escrita com boas histórias. Bom dia!";
		frases[9] = "Que seu dia seja tão incrível quanto a primeira vista do Sol pela manhã. Bom dia!";
	}


 void Button_Clicked(object sender, EventArgs args)
 {
	int indice = Random.Shared.Next(0, 9);
	labelMsg.Text = frases[indice];
 }

 async void Button_Clicked_1(System.Object sender, System.EventArgs e)
 {
	await Share.RequestAsync(new ShareTextRequest{
		Text= "Essa é uma mensagem teste",
		Title = "Share Text"
	});
}
}

