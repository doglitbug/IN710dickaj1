##Methods

|Method        |Situation                             |Result     |
|:-------------|:-------------------------------------|:----------|
|Stack()       |Constructor||
||||
|void Push()   |Push an item onto a newly created stack then call Peek|Return item|
||||
|String Pop()  |Called on newly created stack|Should throw an exception with an appropriate error message|
|              |Push one item onto stack and then Pop|Return last item, check Count()|
|              |Push n items onto stack and then Pop|Return last item, check Count()|
||||
|String Peek() |Called on an empty stack|Should throw an exception with an appropriate error message|
|              |Push several items onto a stack, then call Peek|Should return last pushed item, but not delete it from stack. Check with Push(), Count(), Peek() then Count()|
||||
|int Count()   |Called on a newly created stack|Return 0|
|              |Called on a stack that used to have items, but from which all items been popped|Return 0|
|              |Push one item onto a stack, the call Count()|Return 1|
|              |Push n items onto a stack, then call Count()|Return n|
||||
|IsEmpty()     |Called on a newly created stack|Return true|
|              |Called on a stack that used to have items, but from which all items been popped|Return true|
|              |Called on a stack that has items on it|Return false|
|              |Called on a stack with 1 item on it|Return false|
