# Longest Substring Without Repeating Characters
Given a string `s`, find the length of the **longest substring** without repeating characters.

### Example 1:

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Input:__ s = "abcabcbb"

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Output:__ 3

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Explanation:__ The answer is "abc", with the length of 3.

### Example 2:

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Input:__ s = "bbbbb"

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Output:__ 1

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Explanation:__ The answer is "b", with the length of 1.

### Example 3:

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Input:__ s = "pwwkew"

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Output:__ 3

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;__Explanation:__ The answer is "wke", with the length of 3. Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

### Constraints:

* `0 <= s.length <= 5 * 10^4`

* `s` consists of English letters, digits, symbols and spaces.