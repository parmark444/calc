class Calc 
{
    public static double DoOperationLocal(double x, double y, string operation) 
    {
        double result = double.NaN;
        switch (operation) 
        {
            case "add":
                result = x + y;
                break;
            case "sub":
                result = x - y;
                break;
            case "mult":
                result = x * y;
                break;
            case "div":
                if (y != 0) 
                {
                    result = x / y;
                }
                break;
            default:
                break;
        }
        return result;
    }
}