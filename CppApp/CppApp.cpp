// CppApp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <math.h>
#include <typeinfo>


int k;
void variables_and_types()
{
    int i;
    i = 100;
    double j = cos(i);
    std::cout << "cos of " << i << " : " << j << "\n";
    std::cout << "default value of unitialized int: " << k << "\n"; // 0

    // Types:
    bool b = true;
    b = "a";
    std::cout << "type of variable b: " << typeid(b).name() << "\n";
    std::cout << "b: " << b << "\n"; // it prints 1, have no idea how it works, will dig into it later

    char c = 'c';
    signed char sc = 2;
    unsigned char usc = 5; // symbol that has this code in ascii
    wchar_t wct = '$'; // extended symbol, 2 bytes
    char16_t csixtt = 'u'; // 2 bytes in unicode
    char32_t cthirt = 'i'; // 4 bytes in unicode 
    short sh = 32767; // 2 bytes in int
    unsigned short ush = 65535; // 2 bytes from 0 
    int integ = 2147483647; // 2 or 4 bytes depending on processor architecture 
    unsigned int uinteg = 4294967295; // from 0
    long l = 0; // 4 bytes
    long long ll = 9223372036854775808; // 8 bytes 
    float f = 4.435345; // floating point, 4 bytes 
    double d = 0.1234234; // 8 bytes 
    long double ld = 0.24356234897562987435629834756; // more then 8

    std::wcout << usc << wct << '\n'; // this function for wchars
    // standart puts only minimal limitations on the size of memory for each type
    // depending on pc - bigger
    // sizeof() -> gives size of memory:
    long double n = 1;
    std::cout << "sizeof(n)=" << sizeof(n) << "\n";

    auto number = 5; // compiler desides type itself
    //auto numb; -> compiler error - can not deduce type
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

