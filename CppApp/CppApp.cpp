// CppApp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <math.h>
#include <typeinfo>
#include "NewClass.h"
#include <string>


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
    bool b = 10 > 5 && 7 < 11; // and, true
    bool b1 = b || false; // or, true
    bool b2 = !b1; // not, false
    std::cout << "bool: " << b2 << "\n";

    // bit operations performed on separate bits, in integer numbers;
    int a = 2 << 2; // 10 two bits to left = 1000 - 8
    int c = 16 >> 3; // 1000 three bits to right = 10 - 2
    // operations on every digit:
    int i = 5 | 2;          // 101 | 010 = 111  - 7
    int j = 6 & 2;          // 110 & 010 = 10  - 2
    int k = 5 ^ 2;          // 101 ^ 010 = 111 - 7
    int m = ~9;             // -10
}

void assignement_console_using() 
{
    int a, b, c;
    a = b = c = 34; // multiple assignement 
    // assignement goes from right to left; has the least priority - done after all else
    int i = 10;
    i += 5; // 15
    i -= 3; // 12
    i *= 2; // 24
    i /= 6; // 4
    i <<= 4; // 64
    i >>= 2; // 16
    i %= 6; // 3 (modulus 16 by 6)

    // library iostream gives console usage, istrem - input in console, ostream - output
    std::cout << "hello!"; // operand that returns ostream, 
    std::cout << "hello!" << std::endl;// end the buffer and new line
    std::cout << "your age: ";
    int age;
    std::cin >> age;// left side is iostream, right- object that receives data, we can also chain it:
    std::cin >> a >> b >> c;

    // cout and cin are defined is the namespace std, :: is scope operator
    // using help use without scope operator:
    //using std::cout;
    // ...
    //cout << "helo!";
}

void if_else_switch() 
{
    int i = 60;
    if (i < 50) 
    {
    
    }
    else if (50 <= i < 60) 
    {
    
    }
    else 
    {
    
    }

    i = 2;
    switch (i) 
    {
    case 1:
        std::cout << "1\n";
        break;
    case 2:
        std::cout << "2\n";
        break;
    default:
        std::cout << "???\n";
    }
    int j = i == 2 ? 1 : 0; // ternary operator;
}

void cycles() 
{
    int i = 0;
    while (i < 10) 
    {
        std::cout << i << "\n";
    }

    for (int j = 0; j < 10; j++) 
    {
        std::cout << j << "\n";
    }

    do 
    {
        std::cout << "this will be executed at least once always \n";
    } while (1 < 0);

    int k = 0;
    for (;;) 
    {
        k++;
        if (k % 2 == 0)
            std::cout << k << "\n";
        else
            continue; // to get to another iteration of the cycle
        if (k > 10) break; // to stop cycle alltogether
    }
}

void pointers() 
{
    // pointers - point to object;
    int n = 1;
    int &m = n; // the same type
    std::cout << m << "\n"; // 1
    n = 2;
    std::cout << m << "\n"; // 2

    const int i = 5;
    //int &j = i; -> error since it is const

    int a = 10;
    const int &b = a;
    a = 5;
    std::cout << b << "\n"; // 5; 
}

void arrays() 
{
    int numbers[4] = {1,2,3,4};
    //int numbers[4] = { 1,2,3,4,5 }; -> error - too many intializor values;
    int numbersBig[] = { 1,2,3,4,5 }; // array size can be taken from the amount of initializors
    char letters[] = { 'a', 'b' };
    char word[] = "hello";
    //int num1[] = numbers; -> error - can not assign one array to another;
    const int c = 4;
    int num2[c] = {}; // via constant
    std::cout << numbers[2] << "\n"; // 3
    for (int i : numbers)
        std::cout << i << "\n"; // going through array;
    for(auto i : numbers)
        std::cout << i << "\n"; // can use auto if type of elem in array is unknown;
    int matrix[3][3] = { {1,2,3},{},{0,1} };
    std::cout << matrix[0][1] << "\n";
}

void strings() 
{
    std::string s = "string";
    // include <string> at top to import 
    std::string s2("welcome");      // welcome
    std::string s3(5, 'h');     // hhhhh
    std::string s4 = s3;            // hello
    std::string s5 = s + s2; //stringwelcome -> tsring concatenation;
    // string comparison:
    bool b = s5 == s;
    b = s5 < s; // comparison depending on register;
    int size = s.size(); // 6
    char c = s[1];
    s[1] = 'p';
    std::cout << s << "\n"; // spring

    char letters[] = { 'h', 'e', 'l', 'l', 'o', '\0' }; // ending in "\0" can be used as a string
    std::cout << letters << std::endl;

    std::string name;
    std::cout << "Input your name: ";
    getline(std::cin, name);
    std::cout << "Your name: " << name << std::endl;
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

