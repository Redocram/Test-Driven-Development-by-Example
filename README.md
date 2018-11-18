# Test Driven Development by Example

This repo contains my excercises done following the book [Test Driven Development: By Example](https://www.oreilly.com/library/view/test-driven-development/0321146530/)  by Kent Beck

## Test Driven Development tasks:
* Make a list, maybe from the requirements, of the tests/task the code should be able to pass/accomplish 
* Red - write a little test (taken from the list) that doesn't work, perhaps even compile at first
* Green - make the test 
  * compile 
  * work 
  
  quickly, _committing whatever sins necessary in the process_. There's to ways to get there:

  * Fake it: return a constant and gradually replace constants with variables until you have the real code
  * Obvious Implementation: type in the real implementation
  * Triangulation: generalyze the code only if you have more examples
* Refactor - eliminate all the duplication created in just getting the test to work

## Notes
I'm trying to commit every little change in the code following the book's "narrative evolution".
In this way, should be possible to understand the changes I've been done to code.