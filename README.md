# J1.S.P0001
  J1.S.P0001 code by C# (50 locs)
  
Title:
  	Bubble sort algorithm. 
Background Context:
Bubble sort is a simple and well-known sorting algorithm. It is used in practice once in a blue moon and its main application is to make an introduction to the sorting algorithms. Bubble sort belongs to O(n2) sorting algorithms, which makes it quite inefficient for sorting large data volumes. Bubble sort is stable and adaptive.
Program Specifications:

Design a program that allows users to input the number of array. Generate random integer in number range input. Display unsorted array and sorted array using bubble sort.

Function details: 
Display a screen to prompt users to input a size of an array (positive decimal number) and range.
Users run the program, display a screen to ask users to enter a positive decimal number. 
Users input a range and generate random integer in range (including positive and negative integer number). Then, perform Function 2.
Display & sort array. 
Generate random integer in number range for each array element.
Display array before and after sorting.



Guidelines:
Algorithm
Compare each pair of adjacent elements from the beginning of an array and, if they are in reversed order, swap them.
If at least one swap has been done, repeat step 1.
You can imagine that on every step big bubbles float to the surface and stay there. At the step, when no bubble moves, sorting stops. Let us see an example of sorting an array to make the idea of bubble sort clearer.
Example. Sort {5, 1, 12, -5, 16} using bubble sort.
