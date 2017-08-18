// ManagedCppConsoleApp.cpp : main project file.

#include "stdafx.h"

using namespace System;
using namespace MyLibrary;

int main(array<System::String ^> ^args)
{
	Int32 x = 42;
	String^ s = L"Hello";

	MyConsole::Print(x, s);

    Console::WriteLine(L"Hello World");
    return 0;
}
