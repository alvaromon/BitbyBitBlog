## Action and Func Delegates in C#<br/><font size="1"> ***Written by: Alvaro Montoya | Alvaro.montoya@knights.ucf.edu*** </font> 

`Action` and `Func` delegates are used in our .NET code more often than we might think. They are not meant to confuse us as much as the IntelliSense function signature preview window might lead us to believe. So let's learn more about how and when to use these built-in delegates in this article.
### Action and Func Delegates
`Action` and `Func` are built-in generic delegates in the .NET System namespace.These delegates are extremely flexible and will be useful in most situations where we might need to use delegates in our code. As a reminder, delegates are types that reference or encapsulate a method with a defined set of parameters and return type.Informally speaking delegates allow us to "variable-ize" functions and pass them as parameters.
#### Action Delegates
`Action<>` is a generic delegate that returns no value and can have a maximum of 16 parameters.The types in the<> are the types of the parameters of the function we can assign this `Action` to.
Let's take a look at how we can create a simple instance:
```C#
void ReportProfits(double grossSales, double totalExpenses)
{
    Console.WriteLine(grossSales - totalExpenses);
}

var reporter = new Action<double, double>(ReportProfits);

var aggregatedSales = 1000000.00;
var aggregatedExpenses = 12340.00;

reporter(aggregatedSales, aggregatedExpenses);
```
We can assign lambda expressions and anonymous functions to Actions. This is what makes Actions and Funcs such useful tools in a developer's toolbox. This affords a developer the ability to write syntactically expressive and readable code.

Let's take a look at how we can assign a lambda to an `Action` this way:
```C#
var aggregatedSales = 1000000.00;
var aggregatedExpenses = 12340.00;

Action<double, double> reporter = (grossSales, totalExpenses) => Console.WriteLine(grossSales - totalExpenses);

reporter(aggregatedSales, aggregatedExpenses);
```

Now let's do the same with an anonymous function:

```C#
var aggregatedSales = 1000000.00;
var aggregatedExpenses = 12340.00;

Action<double, double> reporter
    = delegate (double grossSales, double totalExpenses) { Console.WriteLine(grossSales - totalExpenses); };

reporter(aggregatedSales, aggregatedExpenses);
```
#### Function Delegates
`Func<>` is a generic delegate that must return a value and can have a maximum of 16 parameters.The types in the<> are the types of the parameters of the function we can assign this `Func` to. It's very important to note that the return value of the `Func` is the last type in the <> list.
Generically speaking we can view a Func's signature like this:
`Func<T1, T2, T3, ..., TResult> myFunc;`
Let 's take a look at how we can create a `Func`:
```C#
double CalculateProfits(double grossSales, double totalExpenses)
{
    return grossSales - totalExpenses;
}

var reporter = new Func<double, double, double>(CalculateProfits);

var aggregatedSales = 160540.43;
var aggregatedExpenses = 4342.99;

Console.WriteLine(reporter(aggregatedSales, aggregatedExpenses));
```

Similar to Actions, we can assign lambdas and anonymous functions to Funcs:
```C#
var carSales = 56489.02;
var truckSales = 1515868.44;

Func<double, double, double> salesAggregator = (a, b) => a + b;

salesAggregator(carSales, truckSales);

// Or

Func<double, double, double> salesAggregator = delegate (double a, double b) { return a + b; };

salesAggregator(carSales, truckSales);
```
### Alternate Syntax for Delegates
Delegates can be assigned functions to encapsulate by just passing the function name rather than using the new keyword. Let's consider a rewrite of a previous example:
```C#
// assigning delegate using method name
var reporter = ReportProfits;

// previously
//var reporter = new Action<double, double>(ReportProfits);
```
Secondly, the `Invoke()` function is an alternative for calling delegates. This is the same as just using () after the delegates name as we have already seen used. Using the Invoke() function may be preferable so that we may offer the reader of our code a sure signal that a delegate is being called. Invoke will take in the parameters the delegate requires:
```C#
salesAggregator.Invoke(deparmentASales, departmentBSales); // Same as salesAggregator(deparmentASales, departmentBSales)
```
### Why Use Action and Func?
We can creatively use these delegates to write clean expressive code. More importantly, we can achieve more advanced method calling. For example, passing a delegate to a function allows the user to customize the function's behavior. Consequently, this allows a method to run code that it does not know of yet while assuring the method's parameters and return type.

Let's consider a real-world example using LINQ. Using LINQ's `Where()` method we can selectively filter a Collection based on a `Func<TCollection, bool>` passed in. This effectively performs a SQL SELECT operation on our Collection for all items that return true when evaluated against the `Func<>`.

Let's break this down further in this example:
```C#
interface IFruit
{
    bool isCitrus { get; set; }
}
var fruits = new List<IFruit>() { new Apple(), new Banana(), new Orange() };
// in this case Where() signature is: Where(Func<IFruit, bool>)
var allCitrusFruits = fruits.Where(fruit => fruit.isCitrus); // allCitrusFruits should now only be a collection containing 'Orange'
```