#include <iostream>
using std::cout;
using std::endl;


void main()
{
	//We cannot switch on strings in C++ so for
	//this example we will use ints as before.
	int choice = 0;
	int caseValue = 1;
	switch (choice)
	{
	case 0:	     
		cout<< 0 <<endl;
		break;
	case /* causes error caseValue: // */1:	 
		cout<< 1 <<endl;
		break;
	case 2:	 
		cout<< 2 <<endl;
		break;

	default:
		cout<<"default"<<endl;
	}
}