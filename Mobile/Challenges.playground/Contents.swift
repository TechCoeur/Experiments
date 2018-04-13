//: Playground - noun: a place where people can play

/* FIBONACCI NUMBERS
 0,1,1,2,3,5,8....)
 */

import UIKit

func fibo(maxnum: Int) -> Int
{
    var ctr: Int = 0
    var fibonacci: Int
    
    while ctr <= maxnum
    {
        if (ctr == 0)
        {
            ctr += 1
            fibonacci = ctr
        }
        else
        {
            fibonacci = fibonacci + fibonacci
            ctr += 1
        }
    }
    return fibonacci
    
}
