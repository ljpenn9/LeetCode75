class Solution:
    def reverseWords(self, s: str) -> str:
        trimmed = s.strip()
        x = trimmed.split(sep=" ")
        while(x.count("") > 0):
            x.remove("")
        # for item in x:
        #     print(item,end="|\n")
        num = len(x)
        ans = ""
        for i in range(1, num+1):
            ans += x[num-i]
            if (i != num):
                ans += " "
        return ans

x = Solution()
print(x.reverseWords("a good   example"))
