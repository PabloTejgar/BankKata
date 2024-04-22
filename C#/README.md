## Instructions
Write a class named Account that implements the following public interface:

>public interface AccountService <br>
>{ <br>
>    void deposit(int amount) <br>
>    void withdraw(int amount) <br>
>    void printStatement() <br>
>} <br>

## Rules
1. You cannot change the public interface of this class.
2. Desired Behaviour
⋅⋅⋅Here's the specification for an acceptance test that expresses the desired behaviour for this

><p> Given a client makes a deposit of 1000 on 10-01-2012<br>
>And a deposit of 2000 on 13-01-2012<br>
>And a withdrawal of 500 on 14-01-2012<br>
>When they print their bank statement<br>
>Then they would see: <br></p>

>> <p> Date       || Amount || Balance <br>
>>  14/01/2012 || -500   || 2500 <br>
>>  13/01/2012 || 2000   || 3000 <br>
>>  10/01/2012 || 1000   || 1000 <br></p>
