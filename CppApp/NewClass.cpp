#include "NewClass.h"

NewClass::NewClass() 
{

}

void some_method()
{
	std::cout << "Hello from some method";
}

void NewClass::main() 
{
	someProperty = 0;
	some_method();
}


