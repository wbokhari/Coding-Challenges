# Coding-Challenges
Solving some coding challenges that test interesting concepts. The instructions on how to run solutions are in comments. 

# challenge 1
Publish a small service on the web that has two endpoints:
1. /messages takes a message (a string) as a POST and returns the SHA256 hash digest
of that message (in hexadecimal format)
2. /messages/<hash> is a GET request that returns the original message. A request to a
non-existent <hash> should return a 404 error

# challenge 2
You have been given a gift card that is about to expire and you want to buy gifts for 2 friends.
You want to spend the whole gift card, or if that’s not an option as close to the balance as
possible. You have a list of sorted prices for a popular store that you know they both like to
shop at. Your challenge is to find two distinct items in the list whose sum is minimally under (or
equal to) the gift card balance.
The file contains two columns:
1. A unique identifier of the item. You can assume there are no duplicates.
2. The value of that item in cents. It is always a positive integer that represents the price in
cents (1000 = $10.00).
Write a program to find the best two items. It takes two inputs:
1. A filename with a list of sorted prices
2. The balance of your gift card
If no two items have a sum that is less than or equal to the balance on the gift card, print “Not
possible”. You don’t have to return every possible pair that is under the balance, just one such
pair

# Challenge 3
You are given a string composed of only 1s, 0s, and Xs.
Write a program that will print out every possible combination where you replace the X with both 0 and 1.
