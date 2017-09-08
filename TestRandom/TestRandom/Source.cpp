#include <stdlib.h>
#include<time.h>
#include <iostream>
#include "B.h"
#include<conio.h>
using namespace std;
	/*int x;
	srand(time(NULL));
	for (int i = 0; i < 10; i++)
	{
		x = rand() % 2;
		cout << x;
	}
	cin.get();*/

	/*B b = B();
	b.print();

	cin.get();*/

	class coso
	{
	public:
		void display()
		{
			cout << "\n  Display lop co so:";
		}
		virtual void show()
		{
			cout << "\n  Show lop co so:";
		}
	};

	class kethua :public coso
	{
	public:
		void display()
		{
			cout << "\n  Display lop ke thua:";
		}
		void show()
		{
			cout << "\n  Show lop ke thua:";
		}
	};

	int main()
	{

		coso obj1;
		coso *p;
		cout << "\n\t P tro toi lop co so:\n";

		p = &obj1;
		p->display();
		p->show();

		cout << "\n\n\t P tro toi lop ke thua:\n";
		kethua obj2;
		p = &obj2;
		p->display();
		p->show();
		cin.get();
		return 0;
	}