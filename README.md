# PathToKnightHood

Journaling my personal leetcode journey to knighthood

## June 21, 2024

### Grumpy Owner Problem

I solved the grumpy boss question on leetcode. The problemset presents the issue where a bookstore owner is grumpy at different points throughout the day. During the periods of time where he is grumpy, the number of customers in the store will be left unsatisfied. However, the owner knows how to control himself for a set amount of time where he can hold in his grumpiness and ensure the customer is satisfied. The goal is to maximize the number of satisfied customers by choosing the right window such that the most amount of customers are left satisfied if the owner controls his emotions.

### Solution

To solve the problem, a the key technique used will be the sliding window. First, we determine the minimum number of customers that can possibly be satisfied. We pass through the array and add to a minimum value if the boss is not grumpy. Next, we'll initialize a rolling sum to be equal to this minimum value, since we're guaranteed to have at least that many satisfied customers. We then build out the window, adding any number of customers where they would originially be unsatisfied if the boss was not controlling his emotions. Once the window is built out, we "slide" the window forward by incrementing the right pointer and decrementing the left pointer. As we do so, we are subtracting customers if the left pointer previously pointed to a value of 1 and adding customers if the right pointer is at an index where the grumpy boss has a value of 1. We then record the max between the current max value and the rolling sum and eventually return the greater of the two.

## June 22, 2024

### LC 1438. Longest Continuous Subarray With Absolute Diff Less Than or Equal to Limit

Given an array of integers nums and an integer limit, return the size
of the longest non-empty subarray such that the absolute difference
between any two elements of this subarray is less than or equal to limit.

### Solution

For this problem we'll need to use a sliding window, a min heap, and a hax heap. So long as the difference between the largest value in the window and the smallest value is less than or equal to the limit, then all other numbers should be within the limit as well. The tricky part is keeping track of the min and max window the window. Simply finidng it everytime we expand the array would be too costly time-wise. Instead, we keep track of the min and max using heaps, adding to each heap as we expand the window, and popping when we shrink the window. As we do so, we record the length of the window with the max length and return that value at the end.

## July 24, 2024

Took a bit of a break due to feeling a little stressed at work, but I'm ready to refocus and continue my journey to knighthood :)

### LC 2128. Merge Nodes Between Zero

You are given a linked list that starts with and ends with a node with the value of zero. Throughout the linked list, there are more zeroes with other values in between. The goal of this problem is to merge these nodes in between by adding their values together. Afterwards, we return the linked list without the zeroes and with the merged nodes

### Solution

To solve this problem, a two pointer solution is needed. The left pointer stays on the node that will have it's value added to, while the right pointer will traverse the linked list node by node. When the right pointer hits a zero, we skip over that node and assign the left pointer's next node to that node. We then set the left node to the new node. However, this only works if the node after the zero is not null, so we must introduce this restriction when attempting this operation. In the cases where the zero node is the last node, we simply just set left pointer's next node to the last node's next (which would be null). We then allow the right pointer to increment and break out of the while loop, returning the head of the node.
