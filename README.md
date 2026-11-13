# LeetCode Solutions

My LeetCode practice in C# and Python, with earlier Java solutions. Each entry links to the problem and my implementation, with a short hint for getting started.

[LeetCode profile](https://leetcode.com/u/AhmedSadek10/)

## Problem index

**85 problems** · Sorted by problem number.

| # | Problem | Solution | Hint |
| ---: | --- | --- | --- |
| 1 | [Two Sum](https://leetcode.com/problems/two-sum/) | [C#](Easy/1.%20Two%20Sum.cs) | Look up the complement before storing the current value. |
| 3 | [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | [C#](Medium/3.%20Longest%20Substring%20Without%20Repeating%20Characters.cs) | Move the left edge past the previous occurrence of a repeated character. |
| 7 | [Reverse Integer](https://leetcode.com/problems/reverse-integer/) | [C#](Medium/7.%20Reverse%20Integer.cs) | Pop digits one at a time and check for overflow before appending each digit. |
| 9 | [Palindrome Number](https://leetcode.com/problems/palindrome-number/) | [Python](Easy/9.%20Palindrome%20Number.py) | Reverse half the digits and compare the two halves. |
| 11 | [Container With Most Water](https://leetcode.com/problems/container-with-most-water/) | [C#](Medium/11.%20Container%20With%20Most%20Water.cs) | Move the pointer at the shorter wall after measuring the current area. |
| 13 | [Roman to Integer](https://leetcode.com/problems/roman-to-integer/) | [Python](Easy/13.%20Roman%20to%20Integer.py) | Subtract a symbol when the next symbol is larger. |
| 17 | [Letter Combinations of a Phone Number](https://leetcode.com/problems/letter-combinations-of-a-phone-number/) | [C#](Medium/17.%20Letter%20Combinations%20of%20a%20Phone%20Number.cs) | Build one letter at a time from the current digit’s keypad choices. |
| 20 | [Valid Parentheses](https://leetcode.com/problems/valid-parentheses/) | [C#](Easy/20.%20Valid%20Parentheses.cs) | Push opening brackets and match each closing bracket against the top. |
| 21 | [Merge Two Sorted Lists](https://leetcode.com/problems/merge-two-sorted-lists/) | [C#](Easy/21.%20Merge%20Two%20Sorted%20Lists.cs) | Use a dummy head and repeatedly attach the smaller current node. |
| 22 | [Generate Parentheses](https://leetcode.com/problems/generate-parentheses/) | [C#](Medium/22.%20Generate%20Parentheses.cs) | Add an opening bracket when available and close only unmatched opens. |
| 26 | [Remove Duplicates from Sorted Array](https://leetcode.com/problems/remove-duplicates-from-sorted-array/) | [Python](Easy/26.%20Remove%20Duplicates%20from%20Sorted%20Array.py) | Write each new value at the next unique index. |
| 35 | [Search Insert Position](https://leetcode.com/problems/search-insert-position/) | [C#](Easy/35.%20Search%20Insert%20Position.cs) | Binary-search for the first value greater than or equal to the target. |
| 46 | [Permutations](https://leetcode.com/problems/permutations/) | [C#](Medium/46.%20Permutations.cs) | Choose an unused element for each position and undo the choice on return. |
| 58 | [Length of Last Word](https://leetcode.com/problems/length-of-last-word/) | [C#](Easy/58.%20Length%20of%20Last%20Word.cs) | Skip trailing spaces, then count back to the previous space. |
| 67 | [Add Binary](https://leetcode.com/problems/add-binary/) | [C#](Easy/67.%20Add%20Binary.cs) | Walk both strings from right to left and keep a carry. |
| 70 | [Climbing Stairs](https://leetcode.com/problems/climbing-stairs/) | [C#](Easy/70.%20Climbing%20Stairs.cs) | The last move comes from either one or two steps below. |
| 75 | [Sort Colors](https://leetcode.com/problems/sort-colors/) | [C#](Medium/75.%20Sort%20Colors.cs) | Maintain regions for zeros and twos while scanning the unknown middle. |
| 77 | [Combinations](https://leetcode.com/problems/combinations/) | [C#](Medium/77.%20Combinations.cs) | Choose increasing numbers and stop when too few candidates remain. |
| 83 | [Remove Duplicates from Sorted List](https://leetcode.com/problems/remove-duplicates-from-sorted-list/) | [C#](Easy/83.%20Remove%20Duplicates%20from%20Sorted%20List.cs) | Skip the next node when it repeats the current value. |
| 94 | [Binary Tree Inorder Traversal](https://leetcode.com/problems/binary-tree-inorder-traversal/) | [C#](Easy/94.%20Binary%20Tree%20Inorder%20Traversal.cs) | Visit the left subtree, the node, then the right subtree. |
| 98 | [Validate Binary Search Tree](https://leetcode.com/problems/validate-binary-search-tree/) | [C#](Medium/98.%20Validate%20Binary%20Search%20Tree.cs) | Pass down strict lower and upper bounds from the ancestors. |
| 100 | [Same Tree](https://leetcode.com/problems/same-tree/) | [C#](Easy/100.%20Same%20Tree.cs) | Compare values and recurse into corresponding children. |
| 101 | [Symmetric Tree](https://leetcode.com/problems/symmetric-tree/) | [C#](Easy/101.%20Symmetric%20Tree.cs) | Compare each left child with the opposite right child. |
| 130 | [Surrounded Regions](https://leetcode.com/problems/surrounded-regions/) | [C#](Medium/130.%20Surrounded%20Regions.cs) | Mark every region that touches the boundary before flipping the rest. |
| 133 | [Clone Graph](https://leetcode.com/problems/clone-graph/) | [C#](Medium/133.%20Clone%20Graph.cs) | Map original nodes to clones before visiting their neighbors. |
| 141 | [Linked List Cycle](https://leetcode.com/problems/linked-list-cycle/) | [C#](Easy/141.%20Linked%20List%20Cycle.cs) | Move one pointer twice as fast as the other and look for a meeting. |
| 144 | [Binary Tree Preorder Traversal](https://leetcode.com/problems/binary-tree-preorder-traversal/) | [C#](Easy/144.%20Binary%20Tree%20Preorder%20Traversal.cs) | Visit the node before descending into its children. |
| 145 | [Binary Tree Postorder Traversal](https://leetcode.com/problems/binary-tree-postorder-traversal/) | [C#](Easy/145.%20Binary%20Tree%20Postorder%20Traversal.cs) | Visit both children before recording the node. |
| 150 | [Evaluate Reverse Polish Notation](https://leetcode.com/problems/evaluate-reverse-polish-notation/) | [C#](Medium/150.%20Evaluate%20Reverse%20Polish%20Notation.cs) | Use a stack and pop the right operand first for each operator. |
| 200 | [Number of Islands](https://leetcode.com/problems/number-of-islands/) | [C#](Medium/200.%20Number%20of%20Islands.cs) | Flood-fill each unvisited land cell and count the fills. |
| 202 | [Happy Number](https://leetcode.com/problems/happy-number/) | [C#](Easy/202.%20Happy%20Number.cs) | Track repeated digit-square sums to detect a loop. |
| 206 | [Reverse Linked List](https://leetcode.com/problems/reverse-linked-list/) | [C#](Easy/206.%20Reverse%20Linked%20List.cs) | Save the next node before redirecting the current node’s pointer. |
| 207 | [Course Schedule](https://leetcode.com/problems/course-schedule/) | [C#](Medium/Course%20Schedule.cs) | Track prerequisites and check whether every course can be processed. |
| 210 | [Course Schedule II](https://leetcode.com/problems/course-schedule-ii/) | [C#](Medium/Course%20Schedule%20II.cs) | Emit courses when their remaining prerequisite count reaches zero. |
| 215 | [Kth Largest Element in an Array](https://leetcode.com/problems/kth-largest-element-in-an-array/) | [C#](Medium/215.%20Kth%20Largest%20Element%20in%20an%20Array.cs) | Keep a min-heap of size k so its top is the kth largest value. |
| 219 | [Contains Duplicate II](https://leetcode.com/problems/contains-duplicate-ii/) | [C#](Easy/219.%20Contains%20Duplicate%20II.cs) | Track the most recent index of each value and compare the gap with k. |
| 234 | [Palindrome Linked List](https://leetcode.com/problems/palindrome-linked-list/) | [C#](Easy/234.%20Palindrome%20Linked%20List.cs) | Find the midpoint and compare the first half with the reversed second half. |
| 238 | [Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/) | [C#](Medium/238.%20Product%20of%20Array%20Except%20Self.cs) | Combine the products to the left and right of each index. |
| 257 | [Binary Tree Paths](https://leetcode.com/problems/binary-tree-paths/) | [C#](Easy/257.%20Binary%20Tree%20Paths.cs) | Carry the current path through DFS and save it only at leaves. |
| 297 | [Serialize and Deserialize Binary Tree](https://leetcode.com/problems/serialize-and-deserialize-binary-tree/) | [C#](Hard/297.%20Serialize%20and%20Deserialize%20Binary%20Tree.cs) | Write explicit null markers so decoding can recover the tree shape. |
| 374 | [Guess Number Higher or Lower](https://leetcode.com/problems/guess-number-higher-or-lower/) | [C#](Easy/374.%20Guess%20Number%20Higher%20or%20Lower.cs) | Use the guess API response to choose the next binary-search half. |
| 438 | [Find All Anagrams in a String](https://leetcode.com/problems/find-all-anagrams-in-a-string/) | [C#](Medium/438.%20Find%20All%20Anagrams%20in%20a%20String.cs) | Compare character counts in a window the length of the pattern. |
| 448 | [Find All Numbers Disappeared in an Array](https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/) | [C#](Easy/448.%20Find%20All%20Numbers%20Disappeared%20in%20an%20Array.cs) | Use each value’s corresponding index to mark which numbers appear. |
| 485 | [Max Consecutive Ones](https://leetcode.com/problems/max-consecutive-ones/) | [C#](Easy/485.%20Max%20Consecutive%20Ones.cs) | Reset the running count at every zero. |
| 567 | [Permutation in String](https://leetcode.com/problems/permutation-in-string/) | [C#](Medium/567.%20Permutation%20in%20String.cs) | Slide a fixed-length window and look for a matching frequency table. |
| 643 | [Maximum Average Subarray I](https://leetcode.com/problems/maximum-average-subarray-i/) | [Java](Easy/643.%20Maximum%20Average%20Subarray%20I.java) | Update the fixed-size window sum by adding one value and removing one. |
| 645 | [Set Mismatch](https://leetcode.com/problems/set-mismatch/) | [C#](Easy/645.%20Set%20Mismatch.cs) | Compare expected and observed counts to find the repeat and the gap. |
| 695 | [Max Area of Island](https://leetcode.com/problems/max-area-of-island/) | [C#](Medium/695.%20Max%20Area%20of%20Island.cs) | Count cells during each flood fill and retain the largest area. |
| 703 | [Kth Largest Element in a Stream](https://leetcode.com/problems/kth-largest-element-in-a-stream/) | [C#](Easy/703.%20Kth%20Largest%20Element%20in%20a%20Stream.cs) | Keep the k largest values in a min-heap as new values arrive. |
| 704 | [Binary Search](https://leetcode.com/problems/binary-search/) | [C#](Easy/704.%20Binary%20Search.cs) | Maintain a search interval and eliminate the half that cannot contain the target. |
| 709 | [To Lower Case](https://leetcode.com/problems/to-lower-case/) | [C#](Easy/709.%20To%20Lower%20Case.cs) | Convert uppercase letters using the offset between the two cases. |
| 743 | [Network Delay Time](https://leetcode.com/problems/network-delay-time/) | [C#](Medium/743.%20Network%20Delay%20Time.cs) | Run Dijkstra from the source and take the largest finalized distance. |
| 744 | [Find Smallest Letter Greater Than Target](https://leetcode.com/problems/find-smallest-letter-greater-than-target/) | [C#](Easy/744.%20Find%20Smallest%20Letter%20Greater%20Than%20Target.cs) | Find the first letter strictly greater than the target and wrap if needed. |
| 771 | [Jewels and Stones](https://leetcode.com/problems/jewels-and-stones/) | [Java](Easy/771.%20Jewels%20and%20Stones.java) | Put jewel types in a set and count stone types found in it. |
| 778 | [Swim in Rising Water](https://leetcode.com/problems/swim-in-rising-water/) | [C#](Hard/778.%20Swim%20in%20Rising%20Water.cs) | Prioritize the path whose highest elevation so far is smallest. |
| 787 | [Cheapest Flights Within K Stops](https://leetcode.com/problems/cheapest-flights-within-k-stops/) | [C#](Medium/787.%20Cheapest%20Flights%20Within%20K%20Stops.cs) | Track how many edges a route uses as well as its total cost. |
| 797 | [All Paths From Source to Target](https://leetcode.com/problems/all-paths-from-source-to-target/) | [C#](Medium/797.%20All%20Paths%20From%20Source%20to%20Target.cs) | Explore outgoing edges with DFS and save each path that reaches the target. |
| 860 | [Lemonade Change](https://leetcode.com/problems/lemonade-change/) | [C#](Easy/860.%20Lemonade%20Change.cs) | Give change with a ten and a five when possible to conserve fives. |
| 1002 | [Find Common Characters](https://leetcode.com/problems/find-common-characters/) | [C#](Easy/1002.%20Find%20Common%20Characters.cs) | Take the minimum frequency of each character across all words. |
| 1046 | [Last Stone Weight](https://leetcode.com/problems/last-stone-weight/) | [C#](Easy/1046.%20Last%20Stone%20Weight.cs) | Use a max-heap to repeatedly remove the two heaviest stones. |
| 1051 | [Height Checker](https://leetcode.com/problems/height-checker/) | [C#](Easy/1051.%20Height%20Checker%20UNOPTIMIZED%20SOLUTION.cs) | Compare the original heights with their sorted order. |
| 1221 | [Split a String in Balanced Strings](https://leetcode.com/problems/split-a-string-in-balanced-strings/) | [C#](Easy/1221.%20Split%20a%20String%20in%20Balanced%20Strings.cs) | Count a split whenever the running balance returns to zero. |
| 1365 | [How Many Numbers Are Smaller Than the Current Number](https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/) | [C#](Easy/1365.%20How%20Many%20Numbers%20Are%20Smaller%20Than%20the%20Current%20Number.cs) | Record the first sorted position of each value to count smaller elements. |
| 1441 | [Build an Array With Stack Operations](https://leetcode.com/problems/build-an-array-with-stack-operations/) | [C#](Medium/1441.%20Build%20an%20Array%20With%20Stack%20Operations.cs) | Read numbers in order and pop every pushed number absent from the target. |
| 1464 | [Maximum Product of Two Elements in an Array](https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/) | [C#](Easy/1464.%20Maximum%20Product%20of%20Two%20Elements%20in%20an%20Array.cs) | Only the two largest values can maximize the product after subtracting one. |
| 1470 | [Shuffle the Array](https://leetcode.com/problems/shuffle-the-array/) | [C#](Easy/1470.%20Shuffle%20the%20Array.cs) | Pair index i with index i + n. |
| 1514 | [Path with Maximum Probability](https://leetcode.com/problems/path-with-maximum-probability/) | [C#](Medium/1514.%20Path%20with%20Maximum%20Probability.cs) | Prioritize the highest probability so far and multiply by each edge probability. |
| 1557 | [Minimum Number of Vertices to Reach All Nodes](https://leetcode.com/problems/minimum-number-of-vertices-to-reach-all-nodes/) | [C#](Medium/1557.%20Minimum%20Number%20of%20Vertices%20to%20Reach%20All%20Nodes.cs) | Start from the vertices with zero incoming edges. |
| 1631 | [Path With Minimum Effort](https://leetcode.com/problems/path-with-minimum-effort/) | [C#](Medium/1631.%20Path%20With%20Minimum%20Effort.cs) | The effort of a path is its largest step, so relax with a maximum. |
| 1732 | [Find the Highest Altitude](https://leetcode.com/problems/find-the-highest-altitude/) | [C#](Easy/1732.%20Find%20the%20Highest%20Altitude.cs) | Add each gain to the running altitude, starting from zero. |
| 1876 | [Substrings of Size Three with Distinct Characters](https://leetcode.com/problems/substrings-of-size-three-with-distinct-characters/) | [Java](Easy/1876.%20Substrings%20of%20Size%20Three%20with%20Distinct%20Characters.java) | Check whether the three characters in each window are pairwise distinct. |
| 1929 | [Concatenation of Array](https://leetcode.com/problems/concatenation-of-array/) | [C#](Easy/1929.%20Concatenation%20of%20Array.cs) | Copy each value to its original index and to that index plus n. |
| 1971 | [Find if Path Exists in Graph](https://leetcode.com/problems/find-if-path-exists-in-graph/) | [C#](Easy/1971.%20Find%20if%20Path%20Exists%20in%20Graph.cs) | Traverse from the source and stop when the destination is reached. |
| 1979 | [Find Greatest Common Divisor of Array](https://leetcode.com/problems/find-greatest-common-divisor-of-array/) | [C#](Easy/1979.%20Find%20Greatest%20Common%20Divisor%20of%20Array.cs) | Apply Euclid’s algorithm to the minimum and maximum values. |
| 2095 | [Delete the Middle Node of a Linked List](https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/) | [C#](Medium/2095.%20Delete%20the%20Middle%20Node%20of%20a%20Linked%20List.cs) | Use a fast pointer to find the midpoint and keep its predecessor. |
| 2130 | [Maximum Twin Sum of a Linked List](https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/) | [C#](Medium/2130.%20Maximum%20Twin%20Sum%20of%20a%20Linked%20List.cs) | Reverse the second half, then pair nodes while walking both halves. |
| 2144 | [Minimum Cost of Buying Candies With Discount](https://leetcode.com/problems/minimum-cost-of-buying-candies-with-discount/) | [C#](Easy/2144.%20Minimum%20Cost%20of%20Buying%20Candies%20With%20Discount.cs) | Sort in descending order and skip every third candy. |
| 2161 | [Partition Array According to Given Pivot](https://leetcode.com/problems/partition-array-according-to-given-pivot/) | [C#](Medium/2161.%20Partition%20Array%20According%20to%20Given%20Pivot.cs) | Collect smaller, equal, and larger values in encounter order. |
| 2269 | [Find the K-Beauty of a Number](https://leetcode.com/problems/find-the-k-beauty-of-a-number/) | [Java](Easy/2269.%20Find%20the%20K-Beauty%20of%20a%20Number.java) | Slide over the digit string and test each nonzero window for divisibility. |
| 2778 | [Sum of Squares of Special Elements](https://leetcode.com/problems/sum-of-squares-of-special-elements/) | [C#](Easy/2778.%20Sum%20of%20Squares%20of%20Special%20Elements.cs) | Square only values whose one-based index divides the array length. |
| 3612 | [Process String with Special Operations I](https://leetcode.com/problems/process-string-with-special-operations-i/) | [C#](Medium/3612.%20Process%20String%20with%20Special%20Operations%20I.cs) | Apply each operation to a mutable result in one left-to-right pass. |
| 3689 | [Maximum Total Subarray Value I](https://leetcode.com/problems/maximum-total-subarray-value-i/) | [C#](Medium/3689.%20Maximum%20Total%20Subarray%20Value%20I.cs) | Any subarray’s range is bounded by the full array’s maximum minus minimum. |
| 3838 | [Weighted Word Mapping](https://leetcode.com/problems/weighted-word-mapping/) | [C#](Easy/3838.%20Weighted%20Word%20Mapping.cs) | Add the letter weights and use the remainder to select the output character. |
| 3959 | [Check Good Integer](https://leetcode.com/problems/check-good-integer/) | [C#](Easy/3959.%20Check%20Good%20Integer.cs) | Accumulate the sum of the digits and the sum of their squares in one pass. |
| 3963 | [Create Grid With Exactly One Path](https://leetcode.com/problems/create-grid-with-exactly-one-path/) | [C#](Easy/3963.%20Create%20Grid%20With%20Exactly%20One%20Path.cs) | Open the top row and the last column to form a single corridor. |
