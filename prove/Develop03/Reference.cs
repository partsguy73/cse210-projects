using System;

class Reference
{
    public string _text;
    public string Text
    {
        get { return _text; }
        private set { _text = value; }
    }
    
    public Reference(string reference)
    {
        _text = reference;
    }

    public override string ToString()
    {
        return _text;

    }
}