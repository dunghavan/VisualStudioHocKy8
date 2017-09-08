#include <iostream>

using namespace std;
#include"stdio.h"

class Base
{
	int a;
	string b;
public:
	virtual void show()
	{
		cout << "Base class" << endl;
	}
};

class Sub : public Base
{
public:
	 void show() 
	{
		cout << "Sub class" << endl;
	}

};

void main()
{
	/*Base *base = new Sub();
	base->show();

	Sub *sub = new Sub();
	sub->show();*/
	char a[] = { 'a','b','c' };
	printf("%s", a);

	system("pause");
}