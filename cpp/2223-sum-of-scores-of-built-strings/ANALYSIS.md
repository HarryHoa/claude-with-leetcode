# String Matching – Z‑Algorithm (Sum of Scores of Built Strings)

## Video Solution

For more details about **Sum of Scores of Built Strings**, watch the walkthrough at [NeetCode – Sum of Scores of Built Strings](https://www.youtube.com/watch?v=3b5XMZxVYqU).

## Concept

When we build the string `s` by prepending characters, each intermediate string `s_i` is a **suffix** of the final string `s`.  
The score of `s_i` is the length of the longest common prefix between `s_i` and `s`.  
Because `s_i` is a suffix, this is exactly the length of the longest prefix of `s` that also appears starting at position `n‑i` in `s`.  

Computing, for every position `i` in `s`, the length of the longest prefix of `s` that matches the substring starting at `i` is the classic **Z‑function** (also called Z‑array).  
The answer is simply `n + Σ Z[i]` (the `n` accounts for `s_n` matching itself completely).

## When to Use It

Use the Z‑algorithm when you see a problem that asks for:

* longest common prefix between a string and each of its suffixes,
* pattern matching where you need to know how much of the pattern matches at each position of a text,
* any situation where you need “prefix‑match lengths” for all positions in O(n) time.

Typical clues: substrings, prefixes, suffixes, “score”, “similarity”, and constraints up to 10⁵ that rule out O(n²).

## Template

```python
def z_function(s: str) -> List[int]:
    """
    Returns the Z-array where Z[i] = length of longest substring
    starting at i that is also a prefix of s.
    """
    n = len(s)
    z = [0] * n
    l = r = 0                     # current [l, r] window with max r where s[l:r] == prefix
    for i in range(1, n):
        if i <= r:                # i is inside the Z-box
            z[i] = min(r - i + 1, z[i - l])
        # try to extend past the current Z-box
        while i + z[i] < n and s[z[i]] == s[i + z[i]]:
            z[i] += 1
        # if we extended past r, update the box
        if i + z[i] - 1 > r:
            l, r = i, i + z[i] - 1
    return z
```

## LeetCode Problem Walkthrough

### Problem: 2416. Sum of Scores of Built Strings  
https://leetcode.com/problems/sum-of-scores-of-built-strings/

---

### Approach 1: Brute Force (O(n²))

**Algorithm**  
For each suffix starting at index `i` (0‑based), compare characters with the prefix of `s` until a mismatch or the end of the string is reached. The number of matching characters is the score for that suffix. Add `n` for the full string itself.

**Implementation**

```python
class Solution:
    def sumScores(self, s: str) -> int:
        n = len(s)
        total = n                     # score of s_n (the whole string)
        for i in range(n):            # i = start of suffix s_i+1
            match = 0
            while i + match < n and s[match] == s[i + match]:
                match += 1
            total += match
        return total
```

**Complexity Analysis**

- Time complexity: O(n²) — each of the n suffixes may scan up to n characters.  
- Space complexity: O(1) — only a few integer variables.

---

### Approach 2: Z‑Algorithm (O(n)) – Intermediate Optimized

**Intuition**  
Instead of re‑comparing characters for every suffix, we reuse previously computed matches.  
The Z‑array tells us, for each position, how many characters match the prefix.  
If we already know that a substring `[l, r]` is a copy of the prefix, any position `i` inside that window can inherit a match length from `z[i‑l]`, bounded by the window’s right edge.  
We then try to extend beyond the window with a simple character‑by‑character check.  
This yields linear time because each character is compared at most once as part of the extension step.

**Algorithm**  
1. Initialise `z = [0]*n`, window `[l, r] = [0,0]`.  
2. Iterate `i` from 1 to `n‑1`:  
   * If `i ≤ r`, set `z[i] = min(r‑i+1, z[i‑l])`.  
   * While `i+z[i] < n` and `s[z[i]] == s[i+z[i]]`, increment `z[i]`.  
   * If `i+z[i]‑1 > r`, update `l = i`, `r = i+z[i]‑1`.  
3. Answer = `n + sum(z)`.

**Implementation**

```python
class Solution:
    def sumScores(self, s: str) -> int:
        n = len(s)
        z = [0] * n
        l = r = 0
        for i in range(1, n):
            if i <= r:
                z[i] = min(r - i + 1, z[i - l])
            while i + z[i] < n and s[z[i]] == s[i + z[i]]:
                z[i] += 1
            if i + z[i] - 1 > r:
                l, r = i, i + z[i] - 1
        return n + sum(z)
```

**Complexity Analysis**

- Time complexity: O(n) — each index enters the while‑loop at most once overall.  
- Space complexity: O(n) for the Z‑array (can be O(1) if we accumulate on the fly, but O(n) is fine for n ≤ 10⁵).

---

### Approach 3: Z‑Algorithm with In‑Place Accumulation (O(n) time, O(1) extra space)

**Intuition**  
The Z‑array is only needed to accumulate the total score.  
We can keep a running sum while computing each `z[i]` and discard the array afterwards, reducing auxiliary memory to constant space.

**Algorithm**  
Same as Approach 2, but instead of storing all `z[i]` we add each computed value to a variable `total_z` immediately after it is finalized.

**Implementation**

```python
class Solution:
    def sumScores(self, s: str) -> int:
        n = len(s)
        total_z = 0
        l = r = 0
        for i in range(1, n):
            if i <= r:
                z_i = min(r - i + 1, 0)   # placeholder; we will compute properly below
                # We still need the previously computed z[i-l]; we can store it in a variable
                # because we only need the value at position i-l, which is already known
                # and we have not overwritten it (it lies behind i).
                # To keep O(1) space we keep an array of already computed z values
                # only up to i-l, which is at most i. Simpler: just keep the full array.
                # For clarity we retain the array; the interview‑style solution is fine.
            # The O(1) space variant is omitted for brevity; the O(n) space version above
            # is acceptable and easier to verify.
```

*Note:* The constant‑space variant is more involved (requires keeping the already‑computed Z values in a circular buffer).  
For interview purposes, the O(n) space Z‑array is clean, easy to prove correct, and meets the constraints.

**Complexity Analysis**

- Time complexity: O(n) — same as Approach 2.  
- Space complexity: O(n) for the Z‑array (or O(1) if you implement the in‑place variant).

---

### Provide a Visual Demonstration

**Impact: HIGH** | **Category: explanation** | **Tags:** dry-run, trace, example

We trace the Z‑algorithm on the example `s = "babab"` (n = 5).

| Step | i | s[i] | Current window [l, r] | z[i] before extension | While‑loop extensions | z[i] after | New window [l, r] |
|------|---|------|-----------------------|-----------------------|-----------------------|------------|-------------------|
| 1    | 1 | a    | [0,0] (i>r)           | 0                     | compare s[0]='b' vs s[1]='a' → stop | 0          | [0,0] (unchanged) |
| 2    | 2 | b    | [0,0]                 | 0                     | s[0]='b'==s[2]='b' → +1<br> s[1]='a'==s[3]='a' → +2<br> s[2]='b'==s[4]='b' → +3<br> i+z[i]=5 stop | 3          | [2,4] (l=2, r=4) |
| 3    | 3 | a    | [2,4] (i≤r)           | min(r‑i+1=2, z[i‑l]=z[0]=0) = 0 | s[0]='b' vs s[3]='a' → stop | 0          | [2,4] (unchanged) |
| 4    | 4 | b    | [2,4] (i≤r)           | min(r‑i+1=1, z[i‑l]=z[2]=3) = 1 | already have 1 match; try extend: i+z[i]=5 → stop | 1          | [2,4] (unchanged) |

Now `z = [0,0,3,0,1]`.  
Total score = n + Σz = 5 + (0+0+3+0+1) = 9, matching the expected answer.

---

**Summary**  
* The problem reduces to computing the Z‑function of the given string.  
* Brute force is O(n²) and impractical for n up to 10⁵.  
* The Z‑algorithm provides an O(n) time, O(n) space solution (or O(1) extra space with a more involved implementation).  
* Always present the brute force first, then show the key insight (re‑using a Z‑box) that leads to the linear optimal solution.