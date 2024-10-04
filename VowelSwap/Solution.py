class Solution:
    # find first vowel from left in string
    def lFindVowel(self, s: str) -> int:
        vowels = "AaEeIiOoUu"
        index = len(s)
        for letter in vowels:
            newIndex = s.find(letter)
            if ((newIndex < index) and (newIndex != -1)):
                index = newIndex
        if (index == len(s)):
            return -1
        else:
            return index
    
    # find right-most vowel in string
    def rFindVowel(self, s: str) -> int:
        vowels = "AaEeIiOoUu"
        index = -1
        for letter in vowels:
            newIndex = s.rfind(letter)
            if (newIndex > index):
                index = newIndex
        return index

    def reverseVowels(self, s: str) -> str:
        first = self.lFindVowel(s)
        last = self.rFindVowel(s)
        if (first != last):
            left = s[:first] + s[last]
            if (last+1 <= len(s)):
                right = s[first] + s[last+1:]
            else:
                right = ""
            center = self.reverseVowels(s[first+1:last])
            return left + center + right
        else:
            return s