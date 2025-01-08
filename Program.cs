using System.Numerics;

class Program{
    public static bool[] Erastotenes(int n){
        bool[] criba = new bool[n];

        for(int i=0;i<n;i++){
            if(IsPrime(i)){
                criba[i]=true;
            }
        }
        return criba;
    }

    public static bool IsPrime(int number){
        if (number <= 1){
            return false;
        }  
        if (number == 2){
            return true;
        }  

        if (number % 2 == 0){
            return false;
        }
    
        int boundary = (int)Math.Floor(Math.Sqrt(number));
    
        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    } 
}