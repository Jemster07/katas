# Two Sum
Given an array of integers `nums` and an integer `target`, _return indices of the two numbers such that they add up to_ `target`.

You may assume that each input would have **_exactly_ one solution,** and you may not use the same _element_ twice.

You can return the answer in any order.


### Example 1:

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Input:__ nums = [2,7,11,15], target = 9

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Output:__ [0,1]

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Explanation:__ Because nums[0] + nums[1] == 9, we return [0, 1].

### Example 2:

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Input:__ nums = [3,2,4], target = 6

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Output:__ [1,2]

### Example 3:

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Input:__ nums = [3,3], target = 6

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Output:__ [0,1]
 

### Constraints:

* `2 <= nums.length <= 10^4`

* `-10^9 <= nums[i] <= 10^9`

* `-10^9 <= target <= 10^9`

* __Only one valid answer exists.__