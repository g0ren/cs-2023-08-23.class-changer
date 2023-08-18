namespace CW;

class ClassWithManyAttributes
{
    private int _myInt = 888;
    public int MyInt => _myInt;
        
    [ModifyField]
    private string _myString = "777";
    public string MyString => _myString;
        
    private bool _myBool = true;
    public bool MyBool => _myBool;
        
    [ModifyField]
    private int _myInt2 = 404;
    public int MyInt2 => _myInt2;
        
    private string _myString2 = "000";
    public string MyString2 => _myString2;
        
    [ModifyField]
    private bool _myBool2 = false;
    public bool MyBool2 => _myBool2;
}