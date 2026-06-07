<div align="center">

<img src="./assets/banner.png" height="100" alt="DSA Mentor Banner" />

# Claude with LeetCode

[![Build README](https://github.com/Stewie-pixel/claude-with-leetcode/actions/workflows/build.yml/badge.svg)](https://github.com/Stewie-pixel/claude-with-leetcode/actions/workflows/build-readme.yml)
[![Problems Solved](https://img.shields.io/badge/dynamic/json?label=Solved&query=length&url=https://raw.githubusercontent.com/Stewie-pixel/claude-with-leetcode/main/.problemSiteData.json&color=brightgreen&logo=leetcode)](https://github.com/Stewie-pixel/claude-with-leetcode)
![C%2B%2B](https://img.shields.io/badge/C%2B%2B-00599c?logo=cplusplus&logoColor=ffffff)
![C%23](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=ffffff)
![Java](https://img.shields.io/badge/Java-ed8b00?logo=openjdk&logoColor=ffffff)
![Python](https://img.shields.io/badge/Python-3776ab?logo=python&logoColor=ffffff)
![Rust](https://img.shields.io/badge/Rust-000000?logo=rust&logoColor=ffffff)

A little assistant from Claude to help you learn daily LeetCode problems organised by DSA topic and difficulty.

</div>

## Table of Contents

- [Structure](#structure)
- [Problem List](#problem-list)

## Structure

```
claude-with-leetcode/
├── .github/
│   └── workflows/                      ← CI/CD pipelines
├── .vscode/                            ← editor settings
├── contest                             ← Weekly + Biweekly programming contests
├── cpp/                                ← C++ solutions
├── dcc/                                ← Daily Coding Challenge
├── java/
│   └── 2-add-two-numbers/              ← Java solutions
├── python/
│   └── 1-two-sum/                      ← Python solutions
├── rust/
│   └── 1-two-sum/                      ← Rust solutions
├── skills/                             ← Claude agent skill definitions
├── study_plan/
│   └── leetcode75/
│       └── cpp/                        ← LeetCode 75 study plan solutions
├── .gitattributes
├── .gitignore
├── .prettierrc
├── .problemSiteData.json               ← problem metadata store
├── CLAUDE.md                           ← Claude DSA mentor agent config
├── README.md                           ← auto-generated, do not edit
├── README_template.md                  ← README template
├── addProblem.js                       ← manually add a problem entry
├── detectNewProblems.js                ← detects newly committed files
├── dsaMentor.js                        ← triggers Claude DSA mentor agent
├── package.json
├── syncLeetcode.js                     ← fetches data from LeetCode
├── updateSiteData.js                   ← scans dirs and updates metadata
├── updateTable.js                      ← rebuilds README from template
└── verifySiteData.js                   ← verifies solution URLs
```

## Problem List

### Arrays & Hashing

<sub>Problem</sub> | <sub>Difficulty</sub> | <sub>C++</sub> | <sub>C#</sub> | <sub>Java</sub> | <sub>Python</sub> | <sub>Rust</sub>
---- | ---- | ---- | ---- | ---- | ---- | ----
<sub>[0001 - Two Sum](https://leetcode.com/problems/two-sum)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>[✔️](cpp%5C1-two-sum%5CREADME.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](python%5C1-two-sum%5CREADME.md)</div></sub> | <sub><div align='center'>[✔️](rust%5C1-two-sum%5CREADME.md)</div></sub>

### Linked List

<sub>Problem</sub> | <sub>Difficulty</sub> | <sub>C++</sub> | <sub>C#</sub> | <sub>Java</sub> | <sub>Python</sub> | <sub>Rust</sub>
---- | ---- | ---- | ---- | ---- | ---- | ----
<sub>[0002 - Add Two Numbers](https://leetcode.com/problems/add-two-numbers)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](java%5C2-add-two-numbers%5Cadd-two-numbers.java)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>

### String

<sub>Problem</sub> | <sub>Difficulty</sub> | <sub>C++</sub> | <sub>C#</sub> | <sub>Java</sub> | <sub>Python</sub> | <sub>Rust</sub>
---- | ---- | ---- | ---- | ---- | ---- | ----
<sub>[0020 - Valid Parentheses](https://leetcode.com/problems/valid-parentheses)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](csharp%5C20-valid-parentheses%5CREADME.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[0006 - Zigzag Conversion](https://leetcode.com/problems/zigzag-conversion)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C6-zigzag-conversion%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[1456 - Maximum Number of Vowels in a Substring of Given Length](https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C1456-maximum-number-of-vowels-in-a-substring-of-given-length%5Cmaximum-number-of-vowels-in-a-substring-of-given-length.cpp)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[2390 - Removing Stars From a String](https://leetcode.com/problems/removing-stars-from-a-string)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C2390-removing-stars-from-a-string%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[0214 - Shortest Palindrome](https://leetcode.com/problems/shortest-palindrome)</sub> | <sub>🔴 Hard</sub> | <sub><div align='center'>[✔️](cpp%5C214-shortest-palindrome%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[1392 - Longest Happy Prefix](https://leetcode.com/problems/longest-happy-prefix)</sub> | <sub>🔴 Hard</sub> | <sub><div align='center'>[✔️](cpp%5C1392-longest-happy-prefix%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[2223 - Sum of Scores of Built Strings](https://leetcode.com/problems/sum-of-scores-of-built-strings)</sub> | <sub>🔴 Hard</sub> | <sub><div align='center'>[✔️](cpp%5C2223-sum-of-scores-of-built-strings%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>

### Array

<sub>Problem</sub> | <sub>Difficulty</sub> | <sub>C++</sub> | <sub>C#</sub> | <sub>Java</sub> | <sub>Python</sub> | <sub>Rust</sub>
---- | ---- | ---- | ---- | ---- | ---- | ----
<sub>[0026 - Remove Duplicates from Sorted Array](https://leetcode.com/problems/remove-duplicates-from-sorted-array)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](csharp%5C26-remove-duplicates-from-sorted-array%5CREADME.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[0027 - Remove Element](https://leetcode.com/problems/remove-element)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](csharp%5C27-remove-element%5CREADME.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[0088 - Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](csharp%5C88-merge-sorted-array%5Cmerge-sorted-array.cs)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[0219 - Contains Duplicate II](https://leetcode.com/problems/contains-duplicate-ii)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>[✔️](cpp%5C219-contains-duplicate-ii%5Ccontains-duplicate-ii.cpp)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[0283 - Move Zeroes](https://leetcode.com/problems/move-zeroes)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](csharp%5C283-move-zeroes%5Cmove-zeroes.cs)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[0724 - Find Pivot Index](https://leetcode.com/problems/find-pivot-index)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>[✔️](cpp%5C724-find-pivot-index%5Cfind-pivot-index.cpp)</div></sub> | <sub><div align='center'>[✔️](csharp%5C724-find-pivot-index%5Cfind-pivot-index.cs)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[1732 - Find the Highest Altitude](https://leetcode.com/problems/find-the-highest-altitude)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](csharp%5C1732-find-the-highest-altitude%5Cfind-the-highest-altitude.cs)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[2248 - Intersection of Multiple Arrays](https://leetcode.com/problems/intersection-of-multiple-arrays)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>[✔️](cpp%5C2248-minimum-cost-of-buying-candies-with-discount%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[2574 - Left and Right Sum Differences](https://leetcode.com/problems/left-and-right-sum-differences)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>[✔️](cpp%5C2574-left-and-right-sum-differences%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[3633 - Earliest Finish Time for Land and Water Rides I](https://leetcode.com/problems/earliest-finish-time-for-land-and-water-rides-i)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>[✔️](cpp%5C3633-earliest-finish-time-for-land-and-water-rides-i%5Cearliest-finish-time-for-land-and-water-rides-i.cpp)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[0047 - Permutations II](https://leetcode.com/problems/permutations-ii)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C47-permutations-ii%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[1493 - Longest Subarray of 1's After Deleting One Element](https://leetcode.com/problems/longest-subarray-of-1s-after-deleting-one-element)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C1493-longest-subarray-of-1s-after-deleting-one-element%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[1567 - Maximum Length of Subarray With Positive Product](https://leetcode.com/problems/maximum-length-of-subarray-with-positive-product)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[2196 - Create Binary Tree From Descriptions](https://leetcode.com/problems/create-binary-tree-from-descriptions)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C2196-create-binary-tree-from-descriptions%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[2352 - Equal Row and Column Pairs](https://leetcode.com/problems/equal-row-and-column-pairs)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C2352-equal-row-and-column-pairs%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[3635 - Earliest Finish Time for Land and Water Rides II](https://leetcode.com/problems/earliest-finish-time-for-land-and-water-rides-ii)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C3635-earliest-finish-time-for-land-and-water-rides-ii%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>

### Two Pointers

<sub>Problem</sub> | <sub>Difficulty</sub> | <sub>C++</sub> | <sub>C#</sub> | <sub>Java</sub> | <sub>Python</sub> | <sub>Rust</sub>
---- | ---- | ---- | ---- | ---- | ---- | ----
<sub>[0028 - Find the Index of the First Occurrence in a String](https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](csharp%5C28-find-the-index-of-the-first-occurrence-in-a-string%5Cfind-the-index-of-the-first-occurrence-in-a-string.cs)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[0392 - Is Subsequence](https://leetcode.com/problems/is-subsequence)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](csharp%5C392-is-subsequence%5Cis-subsequence.cs)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[1768 - Merge Strings Alternately](https://leetcode.com/problems/merge-strings-alternately)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](csharp%5C1768-merge-strings-alternately%5Cmerge-strings-alternately.cs)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>

### Hash Table

<sub>Problem</sub> | <sub>Difficulty</sub> | <sub>C++</sub> | <sub>C#</sub> | <sub>Java</sub> | <sub>Python</sub> | <sub>Rust</sub>
---- | ---- | ---- | ---- | ---- | ---- | ----
<sub>[0202 - Happy Number](https://leetcode.com/problems/happy-number)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](csharp%5C202-happy-number%5Chappy-number.cs)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[0387 - First Unique Character in a String](https://leetcode.com/problems/first-unique-character-in-a-string)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](csharp%5C387-first-unique-character-in-a-string%5Cfirst-unique-character-in-a-string.cs)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[0424 - Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C424-longest-repeating-character-replacement%5Clongest-repeating-character-replacement.cpp)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[1358 - Number of Substrings Containing All Three Characters](https://leetcode.com/problems/number-of-substrings-containing-all-three-characters)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C1358-number-of-substrings-containing-all-three-characters%5Cnumber-of-substrings-containing-all-three-characters.cpp)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[1657 - Determine if Two Strings Are Close](https://leetcode.com/problems/determine-if-two-strings-are-close)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C1657-determine-if-two-strings-are-close%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>[✔️](python%5C1657-determine-if-two-strings-are-close%5CANALYSIS.md)</div></sub> | <sub><div align='center'>[✔️](rust%5C1657-determine-if-two-strings-are-close%5CANALYSIS.md)</div></sub>

### Math

<sub>Problem</sub> | <sub>Difficulty</sub> | <sub>C++</sub> | <sub>C#</sub> | <sub>Java</sub> | <sub>Python</sub> | <sub>Rust</sub>
---- | ---- | ---- | ---- | ---- | ---- | ----
<sub>[3751 - Total Waviness of Numbers in Range I](https://leetcode.com/problems/total-waviness-of-numbers-in-range-i)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C3751-total-waviness-of-numbers-in-range-i%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[3753 - Total Waviness of Numbers in Range II](https://leetcode.com/problems/total-waviness-of-numbers-in-range-ii)</sub> | <sub>🔴 Hard</sub> | <sub><div align='center'>[✔️](cpp%5C3753-total-waviness-of-numbers-in-range-ii%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>

### Contest

<sub>Problem</sub> | <sub>Difficulty</sub> | <sub>C++</sub> | <sub>C#</sub> | <sub>Java</sub> | <sub>Python</sub> | <sub>Rust</sub>
---- | ---- | ---- | ---- | ---- | ---- | ----
<sub>[3940 - Limit Occurrences in Sorted Array](https://leetcode.com/problems/limit-occurrences-in-sorted-array)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>[✔️](cpp%5C3940-limit-occurrences-in-sorted-array%5Climit-occurrences-in-sorted-array.cpp)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[3950 - Exactly One Consecutive Set Bits Pair](https://leetcode.com/problems/exactly-one-consecutive-set-bits-pair)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>[✔️](cpp%5C3950-exactly-one-consecutive-set-bits-pair%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[3954 - Sum of Compatible Numbers in Range I](https://leetcode.com/problems/sum-of-compatible-numbers-in-range-i)</sub> | <sub>🟢 Easy</sub> | <sub><div align='center'>[✔️](cpp%5C3954-sum-of-compatible-numbers-in-range-i%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[3951 - Minimum Energy to Maintain Brightness](https://leetcode.com/problems/minimum-energy-to-maintain-brightness)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C3951-minimum-energy-to-maintain-brightness%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[3952 - Maximum Total Value of Covered Indices](https://leetcode.com/problems/maximum-total-value-of-covered-indices)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C3952-maximum-total-value-of-covered-indices%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[3955 - Valid Binary Strings With Cost Limit](https://leetcode.com/problems/valid-binary-strings-with-cost-limit)</sub> | <sub>🟡 Medium</sub> | <sub><div align='center'>[✔️](cpp%5C3955-valid-binary-strings-with-cost-limit%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[3953 - Maximum Score with Co-Prime Element](https://leetcode.com/problems/maximum-score-with-co-prime-element)</sub> | <sub>🔴 Hard</sub> | <sub><div align='center'>[✔️](cpp%5C3953-maximum-score-with-co-prime-element%5Cmaximum-score-with-co-prime-element.cpp)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[3956 - Maximum Sum of M Non-Overlapping Subarrays I](https://leetcode.com/problems/maximum-sum-of-m-non-overlapping-subarrays-i)</sub> | <sub>🔴 Hard</sub> | <sub><div align='center'>[✔️](cpp%5C3956-maximum-sum-of-m-non-overlapping-subarrays-i%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>
<sub>[3957 - Maximum Sum of M Non-Overlapping Subarrays II](https://leetcode.com/problems/maximum-sum-of-m-non-overlapping-subarrays-ii)</sub> | <sub>🔴 Hard</sub> | <sub><div align='center'>[✔️](cpp%5C3957-maximum-sum-of-m-non-overlapping-subarrays-ii%5CANALYSIS.md)</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub> | <sub><div align='center'>❌</div></sub>


