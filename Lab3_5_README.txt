LAB 3.5 - Spam Checker

Scenario:
You work for a company that runs a web site. One of the features of the site is that users are able to post comments online and engage with each other in a discussion on the site.
Lately, the message boards have been flooded with spam and other inappropriate postings. There is so much spam coming in the human moderators of the site can’t keep up.
You’ve been asked by your boss to implement a spam checker for the web site. You work as part of a large team, so you’ve only been tasked with writing the code for the spam checking itself, and you don’t have to worry about how it hooks up to the web pages. Using C#, write a small program that will check messages for spam.

Step 1. Solving the problem.
Let’s begin by braining about what we need to solve this. We’ll bold out important words that are going to help us figure out the problem-solving approach.

First, we’ll need a blacklist of words that spammers use. We’ll be using the words in the blacklist to determine if the message contains spam.

Secondly, what kind of data will be our input? Well, we know we are going to be getting messages, which are going to be long strings of text.

Ok, what does are code need to do? It needs to check each message, and see if the message contains a word from the blacklist. It sounds like we will need to use string functions to solve this task.

Finally, what should happen after the message is checked? The code should either flag the message as spam, or flag it as ok. We’ll probably just use a true/false value to say if the message was good or bad.

Step 2. Write some pseudocode
	1. Blacklist = a word to check
	2. message = get content of message.
	3. test if the message contains the word.
	4. If it contains the word, spam is true,
	5. If not, the message is ok to post to the web site.

Step 3 - Writing some code.

Step 4: Test the code

Write the code shown above and test it, by writing your own messages and changing the blackListWord to a different word.
How well does this version of the code work?

We’ll come back to this spam checker and keep improving it in the next lesson.

