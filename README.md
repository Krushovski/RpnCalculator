Usage
The Program class contains the entry point Main method. Upon execution, an instance of the RpnCalculator is created, and various operators (such as addition, subtraction, etc.) are registered with the calculator. The user is then prompted to input expressions in RPN format. The calculator continuously evaluates the expressions and displays the results until an empty input is provided.

Token Hierarchy
The application defines a hierarchy of tokens, which are the building blocks of RPN expressions. The Token class is an abstract base class, and there are two concrete implementations: Operator and Operand. Operator represents arithmetic and factorial operations, while Operand represents numeric values.

RpnCalculator Class
The RpnCalculator class manages the evaluation of RPN expressions. It utilizes a stack to process tokens and calculate results. The calculator supports the registration of custom operators, making it extensible.

Operator Classes
The application includes specific operator classes like Addition, Subtraction, Multiplication, Division, and Factorial. Each operator class inherits from the abstract Operator class, implementing the ProcessWith method to perform the specific operation.

Operand Class
The Operand class represents numeric values in the RPN expressions. It inherits from the Token class and implements the ProcessWith method, which simply pushes the operand onto the stack.

Factorial Operation
The Factorial operator is a unique feature of this calculator, allowing users to compute factorials of non-negative integers. It checks for non-integer and negative inputs and throws an exception in such cases.

Error Handling
The code includes error handling to deal with unsupported operators and invalid factorial inputs, enhancing the robustness of the calculator.

This RPN calculator provides a flexible and extensible platform for evaluating mathematical expressions in postfix notation, offering users the ability to perform a variety of arithmetic operations.
