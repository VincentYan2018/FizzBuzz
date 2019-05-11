# FizzBuzz
## Request
A programming challenge that prints the numbers from 1 to 100, where multiples of three print "Fizz," multiples of five print "Buzz," and multiples of both three and five print "FizzBuzz."
## Task1
1. Given number not in the scale from 1~100
   when system print
   then print "the number is invalid,  should be 1~100"
   
2. Given number is not integer
   when print
   then print "the number should be integer"
   
3. Given number either times of 3 or 5 
   when print
   then the system will print the number
   
2. Given number is times of 3
   when print
   then the system will print Fizz
   
3. Given number is times of 5
   when print
   then the system will print Buzz
   
4. Given number is times of 3 and 5
   when print
   then the system will print FizzBuzz
   
   
## Task2
   
1. Given 停车场车位20,剩余20
   when  停车
   then  停车成功，生成停车票'ticket',可用车位19
   
2. Given 停车场车位3,剩余0,汽车停车
   when  停车
   then  停车失败，提示"There are no available parking space!"
      
3. Given 停车场车位20,剩余19,使用停车票'ticket'取车
   when  取车
   then  成功取到汽车,可用车位20
   
4. Given 使用无效停车票'invalidTicket'取车
   when  取车
   then  取车失败，显示"Parking ticket invalid!"
   
5. Given 停车场无车，使用停车票'ticket'取车
   when  取车
   then  取车失败，显示"There is no such car!"
      
6. Given 当无停车票来取车
   when  取车
   then  取车失败，显示"Parking ticket is required!"