using System;
using System.Collections.Generic;
public class Prime{

    private int number;
    public Prime(int number){

        setNumber(number);
    }
    public void setNumber(int number){

        if(number<0){

            throw new ArgumentException("Number is invalid!");
        }
        this.number = number;
    }
    public int getNumber(){
        return this.number;
    }
    public bool checkPrime(int number){
        for( int idx=1; idx<number; idx++){
            if((6*idx+1)==number){
                return true;
            }
        }
        return false;
    }

    public  List<int> listNumbers(){
        List<int> ListPrimes = new List<int>();
        for (int idx=2; idx<=this.number; idx++){
            ListPrimes.Add(idx);
        }   
        return ListPrimes;

    }

    public List<int> getPrimes(){
        List<int> primeList = new List<int>();
        List<int> list = listNumbers();
        for(int idx=0; idx<list.Count; idx++){
            
            if(list[idx]>6){
                if(checkPrime(list[idx])){
                    primeList.Add(list[idx]);
                }
            }
            else{
                if(list[idx]==2 || list[idx]==3 || list[idx]==5){
                    primeList.Add(list[idx]);
                }
            }
        }
      
    return primeList;
    }
}
public class Program{
    public static void Main(){
        Console.WriteLine("Please enter positive number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Prime primes = new Prime(inputNumber);
        for(int idx=0; idx<primes.getPrimes().Count;idx++){
            Console.WriteLine(primes.getPrimes()[idx]);
        }
        // for( int idx=0; idx<primes.primeNumbers().Length; idx++){
        //     Console.WriteLine(primes.primeNumbers()[idx]);
        //     }
    }
}