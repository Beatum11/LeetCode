string s = "1.1.1.1";

string res = DefangIPaddr(s);
Console.WriteLine(res);


string DefangIPaddr(string address)
{
    string s = address.Replace(".", "[.]");
    return s;
}
