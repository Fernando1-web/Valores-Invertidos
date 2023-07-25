namespace Valores_Invertidos;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    ///<Summary>
    ///<Createddate>24/07/2023</Createddate>
    ///<company>INDEL</company>
    ///<lastmodificationdate>24/07/2023</lastmodificationdate>
    ///<lastmodificationdescription>
    ///Este metodo permite revertir el orden de los numeros al presionar un boton designado
    ///
    ///</lastmodificationdescription>
    //////<lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    ///</Summary>
    private void btnInvertir_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(Entry1.Text)
		 &&!string.IsNullOrEmpty(Entry2.Text)
         &&!string.IsNullOrEmpty(Entry3.Text)
         &&!string.IsNullOrEmpty(Entry4.Text)
		 &&!string.IsNullOrEmpty(Entry5.Text)
         &&!string.IsNullOrEmpty(Entry6.Text))
        {
			double Dato1,Dato2, Dato3, Dato4, Dato5, Dato6;

			Dato1 = Convert.ToDouble(Entry1.Text);
			Dato2 = Convert.ToDouble(Entry2.Text);
			Dato3 = Convert.ToDouble(Entry3.Text);
			Dato4 =	Convert.ToDouble(Entry4.Text);
			Dato5 = Convert.ToDouble(Entry5.Text);
			Dato6 = Convert.ToDouble(Entry6.Text);

			Entry1.Text = Convert.ToString(Dato6);
            Entry2.Text = Convert.ToString(Dato5);
            Entry3.Text = Convert.ToString(Dato4);
            Entry4.Text = Convert.ToString(Dato3);
            Entry5.Text = Convert.ToString(Dato2);
            Entry6.Text = Convert.ToString(Dato1);
        }
		else
		{
			DisplayAlert("Error", "Intrduce todos los numeros", "OK");
		}
    }
}

