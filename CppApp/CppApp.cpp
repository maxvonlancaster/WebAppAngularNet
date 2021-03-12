// CppApp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <math.h>


int k;
void variables_and_types()
{
    int i;
    i = 100;
    double j = cos(i);
    std::cout << "cos of " << i << " : " << j << "\n";
    std::cout << "default value of unitialized int: " << k << "\n"; // 0
}

int main()
{
    std::cout << "Hello World!\n";
    variables_and_types(); // This is called forward declaration: compiler needs to know function prototype 
    // when function call is compiled.
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file

/* 
    Multiline comment
*/

