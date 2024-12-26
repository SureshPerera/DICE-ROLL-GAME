// See https://aka.ms/new-console-template for more information








class AutoNumberGenerator
{
    Random rnd = new Random();
    public int randomNum;
   
    public void RandomNumber()
    {
        for (int i = 0; i < 1; i++)
        {
            //genarate random number 
             randomNum = rnd.Next(6);
           
        }
    }
}