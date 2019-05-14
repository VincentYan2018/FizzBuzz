## Task2
   
1. Given 停车场车位20
   when  停车
   then  停车成功，生成停车票,可用车位19
   
2. Given 停车场车位20,剩余0,汽车停车
   when  停车
   then  停车失败，显示停车场满了
   
3. Given 停车场只停了一辆车，得到了停车票
   when  使用停车票取车
   then  成功取到对应的汽车
   
   3.1. Given：停车场有20个空位， 停车场已经有了一辆车， 又停了一辆车，得到了停车票
    When：使用停车票取车
    Then：取到了对应的车
    
    3.2. Given: 停车场有20个空位，停车场已经有了一辆车，
    得到了停车票，又停了一辆车
    when: 使用停车票取车
    Then: 取到了对应的车
   
4. Given 使用无效停车票取车
   when  取车
   then  取车失败，显示停车票无效
   
5. Given 停车场无车，使用有效停车票取车
   when  取车
   then  取车失败，显示查无此车
      
6. Given 当无停车票来取车
   when  取车
   then  取车失败，显示需要停车票
   
##Task3

1. 
Given: 有一个停车场，停车场有空余的停车位
when: 小弟去停车
then: 小弟在这个停车场停车成功，拿到停车票

2. 
Given: 有二个停车场，第一个停车场有空余的停车位， 第二个停车场有空余的停车位
when: 小弟去停车
then: 小弟在第一个停车场停车成功，拿到停车票

3. 
Given: 有二个停车场， 第一个停车场没有空余的停车位，第二个停车场有空余车位
when: 小弟去停车
then: 小弟在第二个停车场停车成功，拿到停车票

4.
Given: parkingLot停车成功,小弟有停车票
when: 小弟去取车
then: 小弟取车成功

5.
Given：有两个停车场，小弟在第一个停车场停车成功，parkingLot有停车票
when：parkingLot第二个停车场取车
Then：取车失败

6.
Given：有两个停车场，小弟在第一个停车场停车成功，parkingLot有停车票
when：parkingLot第一个停车场取车
Then：取车成功

7.
Given：有两个停车场，小弟在第一个停车场停车成功，小弟有停车票
when：小弟取车
Then：取车成功

8.
Given: 有一个停车场,小弟停车成功,parkingLot有停车票
when: parkingLot去取车
then: parkingLot取车成功

9、
given：所有停车场中，都没有空余车位
when：小弟来停车
then：停车失败，显示停车场满了

10、
given： 小弟有停车票，所有有的停车场中都没有停车票上对应的车
when：小弟取车
then： 小弟取车失败

