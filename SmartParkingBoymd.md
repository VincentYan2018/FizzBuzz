## Task3
1. 
Given: 有两个停车场，第一个停车场有10个空位，第二个停车场有9个空位

when: smartParkingBoy去停车

then: smartParkingBoy在第一个停车场停车成功，拿到停车票

2. 
Given: 有两个停车场， 第一个停车场有10个空位，第二个停车场10个空位

when: smartParkingBoy去停车

then: smartParkingBoy在第一个停车场停车成功，拿到停车票

3.
Given: 有两个停车场， 第一个停车场有9个空位，第二个停车场10个空位

when: smartParkingBoy去停车

then: smartParkingBoy在第二个停车场停车成功，拿到停车票

4.
Given：有两个停车场， 两个停车场空位都为0

when：smartParkingBoy去停车

Then：停车失败

5.
Given: smartParkingBoy停车成功,smartParkingBoy拿有效停车票

when: smartParkingBoy取车

then: smartParkingBoy取车成功

6.
Given：车主停车成功，停车票给smartParkingBoy

when：smartParkingBoy取车

Then：smartParkingBoy取车成功

7.
Given：graduateParkingBoy停车成功，停车票给smartParkingBoy

when：smartParkingBoy取车

Then：smartParkingBoy取车成功

8.
Given：smartParkingBoy停车成功,smartParkingBoy将有效停车票给车主

when：车主取车

Then：取车成功

9.
Given：smartParkingBoy停车成功,smartParkingBoy将有效停车票给GraduateParkingBoy

when：GraduateParkingBoy取车

Then：取车成功

10.
Given: smartParkingBoy持有无效停车票

when: smartParkingBoy去取车

then: smartParkingBoy取车失败

