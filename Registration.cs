namespace knightmoves;
public class Registration
{
    // Add your code here
    public bool oldEnough;
    public string ValidateAge(bool oldEnough) {
        if (oldEnough == true) {
            return "old enough";
        }
        else {
            return "";
            }
    }
}

//should contain a method named ValidateAge that takes a parameter named oldEnough and returns "old enough" if oldEnough is true
//should return an empty string ("") from the ValidateAge method if oldEnough is false