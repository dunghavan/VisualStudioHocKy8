#pragma once
#include <iostream>
using namespace std;
class A
{
public:
	A();
	~A();
	virtual void print()
	{
		cout << "Class A";
	};
};

