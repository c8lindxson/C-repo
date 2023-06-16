using System.Globalization;

Console.Title = "WhileLoop";

//GENERAL NOTE *write* vs *writeLine*. one creates a new line, one does not.
//!!!! be careful not to just tab through programming and cuase issues you need to fix later


int[] num = new int[10];
int i = 0;


//while is best when the nuber of loops is not set(?). there is no built in iteration to the code
//num.length is counting the number of charcacters.
//num has been preset to 10 which has 2 characters. once i becomes a two digit number, the loop ends
while (i < num.Length)
{
    num[i] = i;
    Console.Write(" | " +num[i]);
    i++;

}

Console.Write("\n\n");

//putting do at the start instead of while means the expressions are tested first then checked for teh While condition
do
{
    i--;
    if (i == 8) { Console.Write(" | skipped "); continue; }
    //break causes the loop to stop all together. no further iterations
    if (i == 3) { Console.Write(" | done"); break; }
    Console.Write(" | "+ num[i]);
}
while(i>0);
Console.ReadKey();