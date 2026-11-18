public class Address
{
    private string _streetAddress;
    private string _stateProvince;
    private string _country;
    private string _city;

//construstor
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _city = city;
        _stateProvince = stateProvince;
        _streetAddress = streetAddress;
        _country = country;
    }
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa" ||
               _country.ToLower() == "united states";
    }
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}