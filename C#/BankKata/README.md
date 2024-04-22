## Instructions
Write a class named Account that implements the following public interface:

>public interface AccountService
>{
>    void deposit(int amount) 
>    void withdraw(int amount) 
>    void printStatement()
>}

## Rules
1. You cannot change the public interface of this class.
2. Desired Behaviour
⋅⋅⋅Here's the specification for an acceptance test that expresses the desired behaviour for this

>Given a client makes a deposit of 1000 on 10-01-2012
>And a deposit of 2000 on 13-01-2012
>And a withdrawal of 500 on 14-01-2012
>When they print their bank statement
>Then they would see:

>>Date       || Amount || Balance
>>14/01/2012 || -500   || 2500
>>13/01/2012 || 2000   || 3000
>>10/01/2012 || 1000   || 1000
