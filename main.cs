using System;
using System.Linq;


class main{

    static bool Validate(Int64 cNum){
        if((Math.Floor(Math.Log10(cNum)+1))!=16){
            return false;
        }
        else{
            var digits = cNum.ToString().Select(t=>Int64.Parse(t.ToString())).ToArray();
            int pass=0;
            foreach (var i in digits)
            {
                if(pass%2==0){
                    if(i*2>9){
                        digits[pass]=getSum(i*2);
                    }
                    else{
                        digits[pass]=i*2;
                    }
                }
                pass++;
            }
            Int64 sum = getSum(digits);
            if (sum%10==0){
                return true;
            }
            else{
                return false;
            }
        }
        
    }
    static void print(Int64[] arr){
        foreach (var i in arr){
            Console.Write(i+" ");
        }
    }

    static Int64 getSum(Int64 n){
        Int64 sum = 0;
  
        while (n != 0) {
            sum = sum + n % 10;
            n = n / 10;
        }
  
        return sum;
    }

    static Int64 getSum(Int64[] arr){
        Int64 sum=0;
        foreach (var i in arr)
        {
            sum = sum+i;
        }
        return sum;
    }

    static void Main(){
        Int64 cardNumber = Int64.Parse(Console.ReadLine());
        if(Validate(cardNumber)){
            Console.WriteLine("Valid card");
        }
        else{
            Console.WriteLine("Invalid card");
        }
        Console.ReadKey();
    }
}