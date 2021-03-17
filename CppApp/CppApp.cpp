// CppApp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <math.h>
#include <typeinfo>
#include "NewClass.h"


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

    // implicit type conversion:
    int code = 'g';
    char letter = 103;
    std::cout << letter << " is ancii code " << code << "\n";
    // how type conversions work: 
    // put anything into bool -> it will be true unless you put 0:
    bool ba = 1; // true
    bool bb = "gg"; // true
    bool bc = 0; // false
    // putting bool into string ot int:
    int ib = true; // 1
    // outside of range - overflow:
    unsigned char uco = -5; // 251
    // safe casting - no loss of info - from types with less info to more info
    float fd = 3.4;
    double df = fd;
    // unsafe casting - loss of info - from types with more info to less 
    char lettr = 300;
    std::cout << "unsafe casting: " + lettr;
}

void constants_and_operations() 
{
    // constants -> set one time and can not be changed:
    const int i = 1;
    //i = 22; -> expression must be a modifiable value
    // const must always be initialized:
    //const int x; -> requires intialization;
    int a = 1;
    const int c = a;

    // modulus operation:
    int n = 5;
    int m = 33;
    int d = m % n;
    std::cout << "33 mod 5: " << d << "\n";

    // prefix increment:
    int pia = 8;
    int pib = ++pia;
    std::cout << "prefix increment a: " << pia << "\n"; // 9
    std::cout << "prefix increment b: " << pib << "\n"; // 9

    // postfix increment:
    int poia = 8;
    int poib = poia++;
    std::cout << "postfix increment a: " << poia << "\n"; // 9
    std::cout << "postfix increment b: " << poib << "\n"; // 8

    // prefix decrement:
    int pda = 8;
    int pdb = --pda;
    std::cout << "prefix decrement a: " << pda << "\n"; // 7
    std::cout << "prefix decrement b: " << pdb << "\n"; // 7

    // postfix decrement:
    int poda = 8;
    int podb = poda--;
    std::cout << "postfix decrement a: " << poda << "\n"; // 7
    std::cout << "postfix decrement b: " << podb << "\n"; // 8

    // priority of operations (which are made first):
    // 1. increment decrement;
    // 2. *, / , %
    // 3. +, -
    // also can put operations in brackets to be done first 
}

void conditionals_and_bit_operations() 
{
    
}

void assignement_console_using() 
{

}





int main()
{
    std::cout << "Hello World!\n";
    // variables_and_types(); // This is called forward declaration: compiler needs to know function prototype 
    // when function call is compiled.
    constants_and_operations();
    NewClass newClass;
    newClass.main();
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

