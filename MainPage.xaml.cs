namespace W5B_GradeBookApp;

public partial class MainPage : ContentPage
{
    GradeBook _gradeBook = new GradeBook();


	public MainPage()
	{
		InitializeComponent();
	}

    void AddGradeBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            double grade = double.Parse(GradeEntry.Text);
            _gradeBook.AddGrade(grade);
            DisplayAlert("Info", "Grade added to the book", "Ok");
            GradeEntry.Text = "";
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "Ok");
        }


    }

    void ShowHigestGradeBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        double higestGrade = _gradeBook.GetStats().Highest;
        DisplayAlert("Info", $"Hihest Grade is {higestGrade}", "Ok");
    }

    void ShowLowestGradeBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        double lowestGrade = _gradeBook.GetStats().Lowest;
        DisplayAlert("Info", $"Lowest grade is {lowestGrade}", "Ok");
    }

    void ShowAverageGradeBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        double averagegrade = _gradeBook.GetStats().Average;
        DisplayAlert("Info", $"average grade is {averagegrade}", "Ok");

    }

    void IsOpenCheckBox_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        _gradeBook.IsOpen = IsOpenCheckBox.IsChecked;
    }
}


