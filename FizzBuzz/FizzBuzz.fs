module FizzBuzz

let Compute value =
    if (value % 3 = 0) && (value % 5 = 0) then "FizzBuzz"
    else if value % 3 = 0 then "Fizz"
    else if value % 5 = 0 then "Buzz"
    else value.ToString()