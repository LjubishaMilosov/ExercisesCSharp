//Solve the following problem. On one tree there are 12 branches with applesPerBranch on them.
//One basket can hold "applesInBasket". If a user enters number of trees find out
//how many baskets does it take to collect all the apples from the trees?

//applesPerBranch = 8
//applesInBasket = 5
//numberOfBranchesPerTree = 12;
// numberOfTrees = user input
// totalNumberOfApples = ?
//totalNumberOfBasketsNeeded = ?

int applesPerBranch = 8;
int applesInBasket = 5;
int numberOfBranchesPerTree = 12;

Console.WriteLine("Please enter the number of trees: ");
bool numberOfTreesSuccess = int.TryParse(Console.ReadLine(), out int numberOfTrees);

if (numberOfTreesSuccess && numberOfTrees > 0)
{
    int totalNumberOfApples = numberOfTrees * numberOfBranchesPerTree * applesPerBranch;
    Console.WriteLine($"Total number of apples: {totalNumberOfApples}");

    if(totalNumberOfApples % applesInBasket == 0)
    {
        Console.WriteLine($"Total number of baskets needed: {totalNumberOfApples / applesInBasket}");
    }
    else
    {
        Console.WriteLine($"Total number of baskets needed: {totalNumberOfApples / applesInBasket + 1}");
    }

}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number of trees.");
}
