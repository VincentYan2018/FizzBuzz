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
   when  o取车
   then  取车失败，显示"Parking ticket invalid!"
   
5. Given 停车场无车，使用有效停车票取车
   when  取车
   then  取车失败，显示"There is no such car!"
      
6. Given 当无停车票来取车
   when  取车
   then  取车失败，显示"Parking ticket is required!"