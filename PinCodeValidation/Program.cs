using PinCodeValidation;
using System;
class Program
{
    static void Main(String[] args)
    {
        RegisterPinCode valid = new RegisterPinCode();
        // valid.CheckPin("400088");
        //valid.CheckPin("A400088");
        valid.CheckPin("400088B");
    }
}