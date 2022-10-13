namespace DefaultNamespace;

public class diaryValue
{
    private string _date;
    private string _description;

    public diaryValue(string date, string description)
    {
        _date = date;
        _description = description;
    }
    
    public string getDate(){return _date;}
    public string getDescription(){return _description;}

}