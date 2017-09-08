#pragma once
#include "A.h"

class B: public A
{
public:
	B();
	~B();
	void print()
	{
		cout << "Class B";
	};
};

