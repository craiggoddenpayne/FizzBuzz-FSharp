module WhenTestingFizzBuzz

open NUnit.Framework

[<Test>]
let WhenCallingComputeWith1ItShouldReturn1() = Assert.That(FizzBuzz.Compute 1, Is.EqualTo 1)