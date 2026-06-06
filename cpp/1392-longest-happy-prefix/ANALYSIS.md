# String Matching (KMP) – Longest Happy Prefix  

## Video Solution  

For more details about **Longest Happy Prefix**, watch the walkthrough at [resources](https://www.youtube.com/watch?v=0ZVtN2JxYkI).  

## Concept  

A *happy prefix* is a non‑empty string that appears both as a prefix and as a suffix of the given string `s` (the whole string itself is not allowed).  
The task is to find the longest such string.  

This is exactly the **prefix‑function** (also called the *LPS array*) used in the Knuth‑Morris‑Pratt (KMP) string‑matching algorithm: for each position `i` we store the length of the longest proper prefix of `s[0…i]` that is also a suffix of that substring. The answer for the whole string is `lps[n‑1]`.  

## When to Use It  

Use the prefix‑function / KMP idea when you see:  

- “longest prefix which is also a suffix”  
- “border” of a string  
- pattern matching where you need to reuse previously matched information  
- problems that ask for the longest happy prefix, longest prefix‑suffix, or similar string borders  

## Template  

```python
def compute_lps(pattern: str) -> list[int]:
    """
    Returns the LPS (longest proper prefix which is also suffix) array for `pattern`.
    lps[i] = length of the longest proper prefix of pattern[0..i] that is also a suffix.
    """
    n = len(pattern)
    lps = [0] * n
    length = 0               # length of the previous longest prefix suffix
    i = 1

    while i < n:
        if pattern[i] == pattern[length]:
            length += 1
            lps[i] = length
            i += 1
        else:
            if length != 0:
                # fall back to the previous longest border
                length = lps[length - 1]
                # note: we do NOT increment i here
            else:
                lps[i] = 0
                i += 1
    return lps
```

---

## LeetCode Problem Walkthrough  

### Problem: 1392. Longest Happy Prefix  

https://leetcode.com/problems/longest-happy-prefix/  

### Approach 1: Brute Force  

**Algorithm**  
1. For every possible prefix length `l` from `n‑1` down to `1`:  
   - Check if `s[0:l] == s[n-l:n]`.  
   - The first length that satisfies the condition is the answer (because we scan from longest to shortest).  
2. If none match, return `""`.  

**Implementation**  

```python
class Solution:
    def longestPrefix(self, s: str) -> str:
        n = len(s)
        # try lengths from longest to shortest
        for l in range(n - 1, 0, -1):
            if s[:l] == s[n - l:]:
                return s[:l]
        return ""
```

**Complexity Analysis**  

- Time complexity: O(n²) — each prefix comparison can take O(n) and we try O(n) lengths.  
- Space complexity: O(1) — only a few variables are used.  

---

### Approach 2: Rolling Hash (Rabin‑Karp)  

**Intuition**  
Comparing substrings character‑by‑character is expensive. If we can compute a hash for any prefix and any suffix in O(1) time, we can test equality in O(1) (with a very low collision probability). By scanning lengths from longest to shortest we stop at the first match.  

**Algorithm**  
1. Choose a base `b` and a large modulus `m`.  
2. Pre‑compute powers `b^i % m` for `i = 0 … n`.  
3. Compute prefix hashes `pref[i]` = hash of `s[0:i]`.  
4. Compute suffix hashes `suf[i]` = hash of `s[i:n]` (or compute using prefix hashes).  
5. For length `l` from `n‑1` down to `1`:  
   - If `pref[l] == suf[n‑l]` (hashes equal) → return `s[:l]`.  
6. Return `""` if none found.  

**Implementation**  

```python
class Solution:
    def longestPrefix(self, s: str) -> str:
        n = len(s)
        base, mod = 256, 10**9 + 7

        # pre‑compute powers of base
        pow_b = [1] * (n + 1)
        for i in range(1, n + 1):
            pow_b[i] = (pow_b[i - 1] * base) % mod

        # prefix hashes: pref[i] = hash of s[0:i]
        pref = [0] * (n + 1)
        for i, ch in enumerate(s):
            pref[i + 1] = (pref[i] * base + ord(ch)) % mod

        # helper to get hash of s[l:r] (0‑based, exclusive r)
        def get_hash(l: int, r: int) -> int:
            return (pref[r] - pref[l] * pow_b[r - l]) % mod

        # try lengths from longest to shortest
        for l in range(n - 1, 0, -1):
            # hash of prefix s[0:l]
            hash_pref = get_hash(0, l)
            # hash of suffix s[n-l:n]
            hash_suf = get_hash(n - l, n)
            if hash_pref == hash_suf:
                return s[:l]
        return ""
```

**Complexity Analysis**  

- Time complexity: O(n) — one pass to build powers & prefix hashes, then O(n) checks each O(1).  
- Space complexity: O(n) — arrays for powers and prefix hashes.  

---

### Approach 3: KMP Prefix Function (LPS) – Optimal  

**Intuition**  
The longest happy prefix of the whole string is exactly the longest proper prefix which is also a suffix of the entire string. The LPS array from KMP stores, for each prefix ending at position `i`, the length of its longest border. Therefore, `lps[n‑1]` directly gives the answer. No hashing, no collisions, pure O(n) time and O(n) space (or O(1) extra if we compute on the fly).  

**Algorithm**  
1. Build the LPS array for `s` using the classic KMP preprocessing loop.  
2. Return `s[0:lps[n‑1]]`.  

**Implementation**  

```python
class Solution:
    def longestPrefix(self, s: str) -> str:
        n = len(s)
        lps = [0] * n          # lps[i] = longest border length for s[0..i]
        length = 0             # length of the previous longest border
        i = 1

        while i < n:
            if s[i] == s[length]:
                length += 1
                lps[i] = length
                i += 1
            else:
                if length != 0:
                    # fall back to the next shorter border
                    length = lps[length - 1]
                else:
                    lps[i] = 0
                    i += 1

        return s[:lps[-1]]
```

**Complexity Analysis**  

- Time complexity: O(n) — each character is processed at most twice (once when `i` moves forward, once when we fall back).  
- Space complexity: O(n) — the LPS array (can be reduced to O(1) if we only keep the last value, but keeping the array is standard and clear).  

---

### Provide a Visual Demonstration  

**Impact: HIGH** | **Category: explanation** | **Tags:** dry-run, trace, example  

We dry‑run the LPS construction on the example `s = "ababab"` (n = 6).  

| i | s[i] | length before compare | s[i] == s[length]? | length after match | lps[i] | Comment |
|---|------|-----------------------|--------------------|--------------------|--------|---------|
| 1 | b    | 0                     | b vs a? **No**     | 0 (fallback)       | 0      | length=0 → lps[1]=0 |
| 2 | a    | 0                     | a vs a? **Yes**    | 1                  | 1      | extended border "a" |
| 3 | b    | 1                     | b vs b? **Yes**    | 2                  | 2      | border "ab" |
| 4 | a    | 2                     | a vs a? **Yes**    | 3                  | 3      | border "aba" |
| 5 | b    | 3                     | b vs b? **Yes**    | 4                  | 4      | border "abab" |

Final `lps[5] = 4`. The longest happy prefix is `s[0:4] = "abab"`.  

This matches the expected output.  

---  

*End of lecture.*