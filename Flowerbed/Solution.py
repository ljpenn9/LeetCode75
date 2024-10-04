class Solution:
    def canPlaceFlowers(self, flowerbed: List[int], n: int) -> bool:
        placed = 0

        for i in range(len(flowerbed)):
            right = 0
            left = 0
            ## if current spot empty
            if (flowerbed[i] == 0):
                ## if not the end
                if (i != (len(flowerbed)-1)):
                    ## check right
                    right = flowerbed[i+1]
                ## if not the beginning
                if (i != 0):
                    ## check left
                    left = flowerbed[i-1]
                ## if both are 0
                if (right + left == 0):
                    placed += 1
                    i += 2
                else:
                    i += 1
            else:
                i += 2

        if placed >= n:
            return True
        else:
            return False